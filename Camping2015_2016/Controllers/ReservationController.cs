using Camping2015_2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camping2015_2016.Controllers
{
    public class ReservationController : Controller
    {
        public ActionResult Reservation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reservation(int? id)
        {
            
            using (IDal dal = new Dal())
            {
                int nbrEnfants;
                int.TryParse(Request.Form["nbrEnfants"], out nbrEnfants);

                int nbrAdultes;
                int.TryParse(Request.Form["nbrAdultes"], out nbrAdultes);

                bool supParking = (Request.Form["supParking"] == "false" ? false : true);
                bool supElec = (Request.Form["supElectricite"] == "false" ? false : true);
                bool tente = (Request.Form["tente"] == "tente");

                
                DateTime arrivee = DateTime.Parse(Request.Form["Check-in"]);
                DateTime depart = DateTime.Parse(Request.Form["Check-out"]);

               
                
                //test s'il reste un emplacement libre
                Emplacement e = dal.obtenirEmplacementLibre(tente);


                if (e != null)
                {
                    dal.creerReservation(02, tente, arrivee, depart, nbrAdultes, nbrEnfants, supParking, supElec, e, false);
                    dal.reserverEmplacement(e);
                   
                }

                //TODO page d'erreur pour plus d'emplacements disponibles et gérer l'id client ici
              
                return RedirectToAction("Index");

            }
        }
       


    }
}