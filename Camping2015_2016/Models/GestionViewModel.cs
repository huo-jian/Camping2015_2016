using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camping2015_2016.Models
{
    public class GestionViewModel
    {
        public IEnumerable<Emplacement> emplacements { get; set; }
        public IEnumerable<Reservation> reservations { get; set; }
        public IEnumerable<Utilisateur> utilisateurs { get; set; }

    }
}