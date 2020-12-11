using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Elearning.Models
{
    public class ElearningContext:DbContext
    {
        public DbSet<Enseignant> Enseignants { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Cour> Cours { get; set; }
       

    

    }
}