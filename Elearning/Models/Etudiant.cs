using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Elearning.Models
{
    public class Etudiant
    {
        [Key]
        public int idEtudiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Niveau { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int changedpw { get; set; }

        public virtual List<Cour> Cours { get; set; }


    }
}