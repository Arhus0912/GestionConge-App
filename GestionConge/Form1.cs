using GestionConge.Models;
using GestionConge.Services;
using GestionConge.Repository;
using System.Data;

namespace GestionConge
{
    public partial class Form1 : Form
    {
        private CongeService service = new CongeService();
        private CongeRepository repository = new CongeRepository();

        private int idCongeSelectionne = 0;
        private void AfficherSolde(int employeId)
        {
            {
                int solde = service.CalculerSolde(employeId);
                lblSolde.Text = "Solde disponible : " + solde + " jours";
            }
        }
        public Form1()
        {
            InitializeComponent();
            ChargerConges();

            dgvConges.AllowUserToAddRows = false;
        }

        private void ChargerConges()
        {
            dgvConges.AutoGenerateColumns = true;
            dgvConges.DataSource = repository.ListeConge();

            if (dgvConges.Columns["EmployeID"] != null)
                dgvConges.Columns["EmployeID"].Visible = false;
        }

        private void lblEmploye_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblDateDebut_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvConges.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un congé.");
                return;
            }

            DataGridViewRow ligne = dgvConges.SelectedRows[0];

            int idConge = Convert.ToInt32(ligne.Cells["IdConge"].Value);
            int employeId = Convert.ToInt32(ligne.Cells["EmployeID"].Value);

            if (service.RefuserConge(idConge))
            {
                MessageBox.Show("Congé refusé avec succès.");

                ChargerConges();

                AfficherSolde(employeId);
            }
            else
            {
                MessageBox.Show("Erreur lors du refus du congé.");
            }

            if (service.RefuserConge(idConge))
            {
                MessageBox.Show("Demande refusée.");
                ChargerConges();

                // --- NOUVEAU : Envoi de la notification ---
                string emailDestinataire = txtEmail.Text;
                string sujet = "Décision concernant votre demande de congé";
                string message = $"Bonjour,\n\nNous vous informons que votre demande de congé a été REFUSÉE par l'administration.\n\nCordialement,\nLes Ressources Humaines.";

                EnvoyerEmailSimulation(emailDestinataire, sujet, message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChargerConges();
            ChargerEmployes();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Conge conge = new Conge();

            conge.EmployeId = Convert.ToInt32(cmbEmploye.SelectedValue);
            conge.DateDebut = dtpDateDebut.Value;
            conge.DateFin = dtpDateFin.Value;
            conge.Motif = txtMotif.Text;

            // Calcul de la durée demandée
            int joursDemandes = service.CalculerNombreJours(conge);

            // Calcul du solde disponible
            int solde = service.CalculerSolde(conge.EmployeId);

            // Vérification du solde
            if (joursDemandes > solde)
            {
                MessageBox.Show(
                    "Solde insuffisant.\n\n" +
                    "Solde disponible : " + solde + " jours\n" +
                    "Jours demandés : " + joursDemandes + " jours",
                    "Solde insuffisant",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Enregistrement de la demande
            if (service.DemanderConge(conge))
            {
                MessageBox.Show("Demande enregistrée avec succès!");

                ChargerConges();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'enregistrement");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvConges.CurrentRow != null)
            {
                string statutActuel = dgvConges.CurrentRow.Cells["Statut"].Value.ToString();

                if (statutActuel == "Accepté" || statutActuel == "Refusé")
                {
                    MessageBox.Show("Vous ne pouvez pas modifier une demande déjà traitée.", "Action bloquée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            Conge conge = new Conge();

            conge.IdConge = idCongeSelectionne;
            conge.EmployeId = Convert.ToInt32(cmbEmploye.SelectedValue);
            conge.DateDebut = dtpDateDebut.Value;
            conge.DateFin = dtpDateFin.Value;
            conge.Motif = txtMotif.Text;
            conge.Statut = "En Attente";
            conge.DateDemande = DateTime.Today;

            if (service.ModifierConge(conge))
            {
                MessageBox.Show("Demande modifiée avec succès !");
                ChargerConges();
            }
            else
            {
                MessageBox.Show("Erreur lors de la Modification.");
            }
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier qu'on a bien cliqué sur une ligne
            if (e.RowIndex < 0)
                return;

            DataGridViewRow ligne = dgvConges.Rows[e.RowIndex];

            // Récupérer l'ID du congé
            idCongeSelectionne = Convert.ToInt32(ligne.Cells["IdConge"].Value);

            // Récupérer l'employé
            cmbEmploye.SelectedValue = Convert.ToInt32(ligne.Cells["EmployeID"].Value); ;

            // Récupérer les dates
            dtpDateDebut.Value = Convert.ToDateTime(ligne.Cells["DateDebut"].Value);
            dtpDateFin.Value = Convert.ToDateTime(ligne.Cells["DateFin"].Value);

            // Récupérer le motif
            txtMotif.Text = ligne.Cells["Motif"].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvConges.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un congé à supprimer.");
                return;
            }

            int idConge = Convert.ToInt32(

                dgvConges.SelectedRows[0].Cells["IdConge"].Value);

            DialogResult confirmation = MessageBox.Show("Voulez-vous vraiment supprimer ce congé?", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation == DialogResult.Yes)
            {
                bool resultat = service.SupprimerConge(idConge);

                if (resultat)
                {
                    MessageBox.Show("Congé supprimer avec succès.");
                    ChargerConges();
                }
                else
                {
                    MessageBox.Show("La suppression a échoué.");
                }
            }
        }

        private void btnAccepter_Click_1(object sender, EventArgs e)
        {
            if (dgvConges.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un congé.");
                return;
            }

            DataGridViewRow ligne = dgvConges.SelectedRows[0];

            int idConge = Convert.ToInt32(ligne.Cells["IdConge"].Value);
            int employeId = Convert.ToInt32(ligne.Cells["EmployeID"].Value);

            if (service.ValiderConge(idConge))
            {
                MessageBox.Show("Congé accepté avec succès.");

                ChargerConges();
                AfficherSolde(employeId);
            }
            else
            {
                MessageBox.Show("Erreur lors de l'acceptation du congé.");
            }

            if (service.ValiderConge(idConge)) // (C'est un exemple, adapte au nom de ta méthode)
            {
                MessageBox.Show("Demande acceptée.");
                ChargerConges(); // Actualise le tableau

                // --- NOUVEAU : Envoi de la notification ---
                string emailDestinataire = txtEmail.Text;
                string sujet = "Décision concernant votre demande de congé";
                string message = $"Bonjour,\n\nNous vous informons que votre demande de congé a été ACCEPTÉE par l'administration.\n\nCordialement,\nLes Ressources Humaines.";

                EnvoyerEmailSimulation(emailDestinataire, sujet, message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ChargerEmployes()
        {
            DataTable dt = service.ListeEmployes();

            cmbEmploye.DataSource = dt;
            cmbEmploye.DisplayMember = "Nom";
            cmbEmploye.ValueMember = "IdEmploye";
        }

        private void cmbEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // On vérifie que la valeur sélectionnée est bien un ID valide pour éviter les crashs
                if (cmbEmploye.SelectedValue != null && cmbEmploye.SelectedValue is int)
                {
                    int idEmploye = Convert.ToInt32(cmbEmploye.SelectedValue);

                    // 1. On garde l'affichage du département (que tu avais déjà)
                    txtDepartement.Text = service.ObtenirDepartementEmploye(idEmploye);

                    // 2. On garde le calcul du solde (si tu l'avais déjà mis ici pour mettre à jour lblSolde)
                    lblSolde.Text = service.CalculerSolde(idEmploye).ToString();

                    // 3. LA NOUVEAUTÉ : On affiche l'e-mail dans le nouveau TextBox
                    txtEmail.Text = service.ObtenirEmailEmploye(idEmploye);
                    lblSolde.Text = $"Solde disponible : {service.CalculerSolde(idEmploye)} jours";
                }
            }
        }
        public void AfficherDepartement(int employeId)
        {
            txtDepartement.Text = service.ObtenirDepartementEmploye(employeId);
        }
        private void txtMotif_TextChanged(object sender, EventArgs e)
        {

        }
        private void EnvoyerEmailSimulation(string adresseEmail, string sujet, string contenu)
        {
            string emailVirtuel = $"----- E-MAIL ENVOYÉ -----\n\n" +
                                  $"À : {adresseEmail}\n" +
                                  $"Sujet : {sujet}\n" +
                                  $"-------------------------\n\n" +
                                  $"{contenu}";

            // On affiche l'e-mail sous forme de message avec une icône d'information
            MessageBox.Show(emailVirtuel, "Simulation d'envoi d'e-mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblSolde_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = null;

                // Récupère la DataTable, qu'elle soit directe ou via un BindingSource
                if (dgvConges.DataSource is DataTable) 
                {
                    dt = (DataTable)dgvConges.DataSource;
                }
                else if (dgvConges.DataSource is BindingSource bs && bs.DataSource is DataTable)
                {
                    dt = (DataTable)bs.DataSource;
                }

                // Si on a bien trouvé la table, on applique le filtre
                if (dt != null)
                {
                    string filtre = txtRecherche.Text.Replace("'", "''");

                    dt.DefaultView.RowFilter = string.Format(
                        "Employe LIKE '%{0}%' OR Motif LIKE '%{0}%' OR Statut LIKE '%{0}%'",
                        filtre
                    );
                }
            }
            catch (Exception)
            {
                // Empêche l'application de crasher si une colonne n'est pas trouvée
            }
        }
    }
}
