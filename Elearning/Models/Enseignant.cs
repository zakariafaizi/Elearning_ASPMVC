using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Elearning.Models
{
    public class Enseignant
    {

        [Key]
        public int idEnseignant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int idCours { get; set; }
        public  Cour Cour { get; set; }

        public virtual List<Etudiant> Etudiants { get; set; }
        public virtual List<Cour> Cours { get; set; }
    }
}