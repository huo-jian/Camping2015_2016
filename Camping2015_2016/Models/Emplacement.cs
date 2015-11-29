using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Camping2015_2016.Models
{
    [Table("Emplacements")]
    public class Emplacement
    {
        public int Id { get; set; }
        public bool disponible { get; set; }
        public bool parking { get; set; }
        public bool tente { get; set; }

        public Emplacement()
        {

        }


        public Emplacement(bool tente, bool parking)
        {
            this.disponible = true;
            this.tente = tente;
            this.parking = parking;
        }

    }
}