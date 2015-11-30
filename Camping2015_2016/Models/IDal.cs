using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping2015_2016.Models
{
    public interface IDal : IDisposable
    {
        List<Emplacement> obtenirListeEmplacements();
        List<Reservation> obtenirListeReservations();
        List<Utilisateur> obtenirListeUtilisateurs();
        void creerReservation(int idClient, bool tente, DateTime arrivee, DateTime depart, int nbrAdultes, int nbrEnfants, bool supParking, bool supElectricite,Emplacement e, bool validation);
        void creerUtilisateur(string nom, string prenom, string email, string password, string rue, int numRue, int codePostal, string ville, string pays, string naissance, int telephone);
        void creerUtilisateur(string nom, string prenom, string email, string password, string rue, int numRue, int codePostal, string ville, string pays, string naissance);
        Emplacement obtenirEmplacementLibre(bool tente);
        void reserverEmplacement(Emplacement e);
        Utilisateur authentifier(string email, string password);
        Utilisateur getUtilisateur(string email);

        

    }
}
