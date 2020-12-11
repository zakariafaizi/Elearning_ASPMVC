using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Elearning.Models
{
    public class Cour
    {

        [Key]
        public int idCours { get; set; }
        public string Nom { get; set; }
        public string Laboratoire { get; set; }
        public string Exercice { get; set; }
        public string Quiz { get; set; }
        public string Video { get; set; }
        public string Niveau { get; set; }
        public string NotesDeCours { get; set; }

        public int idEnseignant { get; set; }
        public Enseignant Enseignant { get; set; }

        public virtual List<Etudiant> Etudiants { get; set; }
    }
}