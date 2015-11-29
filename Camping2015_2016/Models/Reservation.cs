using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Camping2015_2016.Models
{
    [Table("Reservations")]
    public class Reservation
    {
        public int id { get; set; }
        public int idClient { get; set; }  //en fonction de la connection

        
        public virtual Emplacement emplacement{ get; set; } 
        [Required]
        public DateTime arrivee { get; set; }
        [Required]
        public DateTime depart { get; set; }
        [Required]
        public int nbrAdultes { get; set; }
        [Required]
        public int nbrEnfants { get; set; }
        [Required]
        public bool supParking { get; set; }
        [Required]
        public bool supElectricite{ get; set; }
      
        public bool validation { get; set; }
        
        [Required]
        public bool tente { get; set; }

        public Reservation()
        {

        }

        public Reservation(int idClient, bool tente, DateTime arrivee, DateTime depart, int nbrAdultes, int nbrEnfants, bool supParking, bool supElectricite, Emplacement emplacement,bool validation)
        {
            this.idClient = idClient;
            this.tente = tente;
            this.arrivee = arrivee;
            this.depart = depart;
            this.nbrAdultes = nbrAdultes;
            this.nbrEnfants = nbrEnfants;
            this.supParking = supParking;
            this.supElectricite = supElectricite;
            this.validation = validation;
            this.emplacement = emplacement;


        }
    }
}