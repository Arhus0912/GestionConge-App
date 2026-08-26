using GestionConge.Data;
using GestionConge.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Data;

namespace GestionConge.Repository
{
    public class CongeRepository
    {
        private DBConnection db = new DBConnection();

        // Ajout de conge
        public bool AjouterConge(Conge conge)
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = @"INSERT INTO conge
                                (EmployeID, DateDebut, DateFin, Motif, Statut, DateDemande)
                                VALUES
                                (@EmployeID, @DateDebut, @DateFin, @Motif, @Statut, @DateDemande)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@EmployeID", conge.EmployeId);

                cmd.Parameters.AddWithValue("@DateDebut", conge.DateDebut);

                cmd.Parameters.AddWithValue("@DateFin", conge.DateFin);

                cmd.Parameters.AddWithValue("@Motif", conge.Motif);

                cmd.Parameters.AddWithValue("@Statut", conge.Statut);

                cmd.Parameters.AddWithValue("@DateDemande", conge.DateDemande);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //Modifier conge
        public bool ModifierConge(Conge conge)
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = @"UPDATE conge
                                 SET
         DateDebut=@DateDebut,
         DateFin=@DateFin,
         Motif=@Motif,
         Statut=@Statut,
         DateDemande=@DateDemande
                                 WHERE
         IdConge=@IdConge";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@IdConge", conge.IdConge);

                cmd.Parameters.AddWithValue("@DateDebut", conge.DateDebut);

                cmd.Parameters.AddWithValue("@DateFin", conge.DateFin);

                cmd.Parameters.AddWithValue("@Motif", conge.Motif);

                cmd.Parameters.AddWithValue("@Statut", conge.Statut);

                cmd.Parameters.AddWithValue("@DateDemande", conge.DateDemande);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //Modifier statut conge
        public bool ModifierStatutConge(int idConge, string statut)
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = "UPDATE conge SET Statut=@Statut WHERE IdConge= @IdConge";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@IdConge", idConge);
                cmd.Parameters.AddWithValue("@Statut", statut);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            }
        //Suppression Conge
        public bool SupprimerConge(int idConge)
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = "DELETE FROM conge WHERE IdConge=@IdConge";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@IdConge", idConge);

                con.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //Liste demande
        public DataTable ListeConge()
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = @"
    SELECT
        c.IdConge,
        c.EmployeID,
        e.Nom AS Employe,
        d.NomDepartement AS Departement,
        c.DateDebut,
        c.DateFin,
        c.Motif,
        c.Statut,
        c.DateDemande
    FROM conge c
    INNER JOIN employe e ON c.EmployeID = e.IdEmploye
    INNER JOIN departement d ON e.DepartementID = d.IdDepartement";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }
        //Recherche
        public DataTable RechercherConge(int idConge)
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = "SELECT * FROM conge WHERE IdConge=@IdConge";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@IdConge", idConge);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

        public int CalculerJoursCongesAcceptes(int employeId)
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = @"
            SELECT COALESCE(SUM(DATEDIFF(DateFin, DateDebut) + 1), 0)
            FROM conge
            WHERE EmployeID = @EmployeID
            AND Statut = 'Accepté'";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@EmployeID", employeId);

                con.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public DataTable ListeEmployes()
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = "SELECT IdEmploye, Nom, Prenom FROM employe";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt;
            }
        }

        public string
            ObtenirDepartementEmploye(int employeId)
        {
            using (MySqlConnection con = db.GetConnection())
            {
                string query = @"
                       SELECT d.NomDepartement
                       FROM employe e INNER JOIN departement d ON e.DepartementID = d.IdDepartement
                       WHERE e.IdEmploye = @IdEmploye";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@IdEmploye", employeId);

                con.Open();

                object resultat = cmd.ExecuteScalar();

                if (resultat != null)
                {
                    return
                        resultat.ToString();
                }

                return "";
            }
        }

        public string ObtenirEmailEmploye(int employeId)
        {
            string query = "SELECT Email FROM employe WHERE IdEmploye = @IdEmploye";
            using (MySqlConnection con =db.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdEmploye", employeId);
                con.Open();
                object result= cmd.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }

    }
}
        