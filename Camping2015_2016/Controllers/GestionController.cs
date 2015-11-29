using Camping2015_2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camping2015_2016.Controllers
{
    public class GestionController : Controller
    {
        // GET: Gestion
        public ActionResult Gestion()
        {
            using (IDal dal = new Dal())
            {
                List<Emplacement> listeDesEmplacements = dal.obtenirListeEmplacements();
                return View(listeDesEmplacements);
            }
        }

        // GET: GestionReservation
        public ActionResult GestionReservation()
        {

            using (IDal dal = new Dal())
            {
                List<Reservation> listeDesReservations = dal.obtenirListeReservations();
                return View(listeDesReservations);
            }
        }

        public ActionResult GestionUtilisateur()
        {
            using (IDal dal = new Dal())
            {
                List<Utilisateur> listeDesUtilisateurs = dal.obtenirListeUtilisateurs();
                return View(listeDesUtilisateurs);
            }
        }
    }
}