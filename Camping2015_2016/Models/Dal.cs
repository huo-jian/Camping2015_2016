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

   

        public List<Utilisateur> obtenirListeUtilisateurs()
        {
            return maBaseDD.listeUtilisateurs.ToList();
        }

        public List<Reservation> obtenirListeReservations()
        {
            return maBaseDD.listeReservations.ToList();
        }


        public void creerReservation(int idEmplacement, int idUtilisateur, bool tente, DateTime arrivee, DateTime depart, int nbrAdultes, int nbrEnfants, bool supParking, bool supElectricite, bool validation)
        {
            //la creer dans la base et l'ajouter dans la liste des reservations d'un utilisateur
            Reservation r = new Reservation(tente, arrivee, depart, nbrAdultes, nbrEnfants, supParking, supElectricite, validation);
            r.utilisateur = getUtilisateur(idUtilisateur);
            r.emplacement = getEmplacement(idEmplacement);

            maBaseDD.listeReservations.Add(r);
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

        public Emplacement getEmplacement(int id)
        {
            List<Emplacement> liste = obtenirListeEmplacements();

            foreach (Emplacement e in liste)
            {
                if (e.Id == id)
                    return e;

            }

            return null;

        }


        public void reserverEmplacement(Emplacement e)
        {
            e.disponible = false;
            maBaseDD.SaveChanges();
        }

        public Utilisateur authentifier(string email, string password)
        {
            List<Utilisateur> liste = obtenirListeUtilisateurs();

            foreach(Utilisateur u in liste)
            {
                if(u.email == email && u.password == password)
                {
                    // l'utilisateur existe bien
                    return u;
                }
            }
            return null;
        }

        public Utilisateur getUtilisateur(string email)
        {
            List<Utilisateur> liste = obtenirListeUtilisateurs();
            foreach (Utilisateur u in liste)
            {
                if (u.email == email)
                {
                    return u;
                }
            }
            return null;

        }

        public Utilisateur getUtilisateur(int id)
        {
            List<Utilisateur> liste = obtenirListeUtilisateurs();
            foreach (Utilisateur u in liste)
            {
                if (u.id == id)
                {
                    return u;
                }
            }
            return null;

        }

       

    }
}