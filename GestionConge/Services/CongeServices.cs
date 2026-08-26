using GestionConge.Models;
using GestionConge.Repository;
using System.Data;

namespace GestionConge.Services
{
    public class CongeService
    {
        private CongeRepository repository = new CongeRepository();

        //verification Date
        public bool VerifierDates(Conge conge)
        {
            return conge.DateFin >= conge.DateDebut;
        }
        //calcul jour
        public int CalculerNombreJours(Conge conge)
        {
            return (conge.DateFin - conge.DateDebut).Days + 1;
        }
        //
        public int CalculerSolde(int employeId)
        {
            int joursPris = repository.CalculerJoursCongesAcceptes(employeId);

            return 30 - joursPris;
        }

        //Demande conge
        public bool DemanderConge(Conge conge)
        {
            //verifier les dates
            if (!VerifierDates(conge))
            {
                return false;
            }
            //Definier les informations automatiquement
            conge.Statut = "En Attente";
            conge.DateDemande = DateTime.Today;

            //Enregistrer dans la base de donnees
            return
                repository.AjouterConge(conge);
        }
        //Valider
        public bool ValiderConge(int idConge)
        {
            return
                repository.ModifierStatutConge(idConge, "Accepté");
        }
        //Refus
        public bool RefuserConge(int idConge)
        {
            return
                repository.ModifierStatutConge(idConge, "Refusé");
        }
        public bool ModifierConge(Conge conge)
        {
            if (!VerifierDates(conge))
            { return false; }

            return
                repository.ModifierConge(conge);
        }
        public bool SupprimerConge(int idConge)
        {
            return
                repository.SupprimerConge(idConge);
        }

        public DataTable ListeEmployes()
        {
            return
                repository.ListeEmployes();
        }

        public string ObtenirDepartementEmploye(int employeId)
        {
            return
                repository.ObtenirDepartementEmploye(employeId);
        }

    public string ObtenirEmailEmploye(int employeId)
        {
            return
                repository.ObtenirEmailEmploye(employeId);
        }

    }
}