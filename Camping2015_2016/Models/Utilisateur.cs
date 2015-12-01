using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Camping2015_2016.Models
{
    [Table("Utilisateurs")]
    public class Utilisateur
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Nom obligatoire")]
        public string nom { get; set; }

        [Required(ErrorMessage = "Prenom obligatoire")]
        public string prenom { get; set; }

        [Required(ErrorMessage = "Email obligatoire")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email invalide")]
        public string email { get; set; }

        [Required(ErrorMessage = "Mot de passe obligatoire")]
        public string password { get; set; }

        [Required(ErrorMessage = "Rue obligatoire")]
        public string rue { get; set; }

        [Required(ErrorMessage = "Numéro obligatoire")]
        public int numRue { get; set; }

        [Required(ErrorMessage = "Code Postal obligatoire")]
        public int codePostal { get; set; }

        [Required(ErrorMessage = "Ville obligatoire")]
        public string ville { get; set; }

        [Required(ErrorMessage = "Pays obligatoire")]
        public string pays { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")]
        [RegularExpression(@"^\d{1,2}\/\d{1,2}\/\d{4}$", ErrorMessage = "Date invalide mm/dd/yyyy")]
        public string naissance { get; set; }

        [Required(ErrorMessage = "Champ obligatoire")] //[RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Numero invalide")] Ne fonctionne pas 
        public int telephone { get; set; }





        public Utilisateur()
        {

        }

        public Utilisateur (string nom, string prenom, string email, string password, string rue, int numRue, int codePostal,string ville, string pays, string naissance, int telephone) : this(nom, prenom, email, password, rue, numRue, codePostal,ville, pays, naissance)
        {
            this.telephone = telephone;

        }

        public Utilisateur(string nom, string prenom, string email, string password, string rue, int numRue, int codePostal, string ville, string pays, string naissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.password = password;
            this.rue = rue;
            this.numRue = numRue;
            this.codePostal = codePostal;
            this.ville = ville;
            this.pays = pays;
            this.naissance = naissance;

        }



       
    }
}