using Camping2015_2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Camping2015_2016.Controllers
{

    public class UtilisateurController : Controller
    {
        public ActionResult Inscription()
        {
           
            return View();
        }


        [HttpPost]
        public ActionResult Inscription(Utilisateur u)
        {
            

            using (IDal dal = new Dal())
            {

                if (!ModelState.IsValid)
                { 
                    System.Diagnostics.Debug.WriteLine("controleur u");
                    return View(u);
                
                }

                dal.creerUtilisateur(u.nom, u.prenom, u.email, u.password, u.rue, u.numRue, u.codePostal, u.ville, u.pays, u.naissance,u.telephone);
                return RedirectToAction("Index");
            }

           

        }
    }
}