using System;
using System.Collections.Generic;
using System.Text;

namespace GestionConge.Models
{
    public class Conge
    {
        public int IdConge {  get; set;}
        public int EmployeId { get; set;}
        public DateTime DateDebut { get; set;}
        public DateTime DateFin {  get; set;}
        public string Motif {  get; set;}
        public string Statut { get; set;}
        public DateTime DateDemande { get; set;}
    }
}
