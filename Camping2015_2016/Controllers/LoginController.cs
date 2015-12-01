using Camping2015_2016.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Camping2015_2016.Controllers
{
    public class LoginController : Controller
    {
        private IDal dal;

        public LoginController() : this(new Dal())
        {

        }

        private LoginController(IDal dalIoc)
        {
            dal = dalIoc;
        }

        public ActionResult LoginIndex()
        {

            UtilisateurViewModel viewModel = new UtilisateurViewModel { authentifie = HttpContext.User.Identity.IsAuthenticated };
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                
                viewModel.utilisateur = dal.getUtilisateur(HttpContext.User.Identity.Name);


            }
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult LoginIndex(UtilisateurViewModel viewModel, string returnUrl)
        {
           
            //test si le formulaire est complet
            if (!string.IsNullOrWhiteSpace(viewModel.utilisateur.email) && !string.IsNullOrWhiteSpace(viewModel.utilisateur.password))
            {
                //on verifie si l'utilisateur existe bien
                Utilisateur utilisateur = dal.authentifier(viewModel.utilisateur.email, viewModel.utilisateur.password);
                if (utilisateur != null)
                {
                    FormsAuthentication.SetAuthCookie(utilisateur.id.ToString(), false);
                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    return Redirect("/");
                }
                ModelState.AddModelError("Utilisateur.Prenom", "Prénom et/ou mot de passe incorrect(s)");
            }
            return View(viewModel);
        }

        public ActionResult Deconnexion()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }



    }
}