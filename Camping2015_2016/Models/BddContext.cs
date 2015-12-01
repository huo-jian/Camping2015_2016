using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Camping2015_2016.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Emplacement> listeEmplacements { get; set; }
        public DbSet<Utilisateur> listeUtilisateurs { get; set; }
        public DbSet<Reservation> listeReservations { get; set; }

    }
}