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
        private IDal dal;

        public GestionController() : this(new Dal())
        {

        }

        public GestionController(Dal dal)
        {
            this.dal = dal;
        }


        // GET: Gestion
        public ActionResult Gestion()
        {

            var viewModel = new GestionViewModel();
            viewModel.emplacements = dal.obtenirListeEmplacements();
            viewModel.reservations = dal.obtenirListeReservations();
            viewModel.utilisateurs = dal.obtenirListeUtilisateurs();


            return View(viewModel);
            
        }

        
    }
}