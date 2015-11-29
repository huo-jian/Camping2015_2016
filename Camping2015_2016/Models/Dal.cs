using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Camping2015_2016.Models
{
    

    public class Dal : IDal
    {

        private BddContext maBaseDD;

        public Dal()
        {
            maBaseDD = new BddContext();
        }

        public List<Emplacement> obtenirListeEmplacements()
        {
            return maBaseDD.listeEmplacements.ToList();
        }

        public List<Reservation> obtenirListeReservations()
        {
            return maBaseDD.listeReservations.ToList();
        }

        public List<Utilisateur> obtenirListeUtilisateurs()
        {
            return maBaseDD.listeUtilisateurs.ToList();
        }


        public void creerReservation(int idClient, bool tente, DateTime arrivee, DateTime depart, int nbrAdultes, int nbrEnfants, bool supParking, bool supElectricite, Emplacement e, bool validation)
        {
            maBaseDD.listeReservations.Add(new Reservation(idClient, tente, arrivee, depart, nbrAdultes, nbrEnfants, supParking, supElectricite, e,validation));
            maBaseDD.SaveChanges();
        }

        public void creerUtilisateur(string nom, string prenom, string email, string password, string rue, int numRue, int codePostal, string ville, string pays, string naissance, int telephone)
        {
            maBaseDD.listeUtilisateurs.Add(new Utilisateur(nom, prenom, email, password, rue, numRue, codePostal, ville, pays, naissance, telephone));
            maBaseDD.SaveChanges();

        }


        public void creerUtilisateur(string nom, string prenom, string email, string password, string rue, int numRue, int codePostal, string ville, string pays, string naissance)
        {
            maBaseDD.listeUtilisateurs.Add(new Utilisateur(nom, prenom, email, password, rue, numRue, codePostal, ville, pays, naissance));
            maBaseDD.SaveChanges();
        }

        public void Dispose()
        {
            maBaseDD.Dispose();
        }

        public Emplacement obtenirEmplacementLibre(bool tente)
        {
            List<Emplacement> liste = obtenirListeEmplacements();

            foreach(Emplacement e in liste)
            {
                if (e.disponible == true && e.tente == tente)
                    return e;

            }

            return null;
        }

        public void reserverEmplacement(Emplacement e)
        {
            e.disponible = false;
            maBaseDD.SaveChanges();
        }

        
    }
}