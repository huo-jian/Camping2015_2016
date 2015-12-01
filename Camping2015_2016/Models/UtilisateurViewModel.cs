using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Camping2015_2016.Models
{
    //[Table("UtilisateurView")]
    public class UtilisateurViewModel
    {

        public Utilisateur utilisateur { get; set; }
        public bool authentifie { get; set; }
    }
}