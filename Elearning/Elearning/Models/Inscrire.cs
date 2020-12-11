using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Elearning.Models
{
    public class Inscrire
    {

        
        public string id { get ; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string age { get; set; }
        public string email{ get; set; }
        public string niveau { get; set; }


    }
}