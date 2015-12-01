using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Camping2015_2016.Models
{
    public class InitialiseCamping : DropCreateDatabaseAlways<BddContext>
    {
        // Notre camping possède 30emplacements avec parking, 20emplacements sans parking pour les deux types
        protected override void Seed(BddContext context)
        {
            for(int i=0;i<3;i++)
                context.listeEmplacements.Add(new Emplacement(true, false)); //tente sans parking

            for (int i = 0; i < 3; i++)
                context.listeEmplacements.Add(new Emplacement(true, true)); //tente avec parking

            for (int i = 0; i < 3; i++)
                context.listeEmplacements.Add(new Emplacement(false, false)); // mobileHome sans parking

            for (int i = 0; i < 3; i++)
                context.listeEmplacements.Add(new Emplacement(false, true)); //mobileHome avec parking


            //creer un utilisateur et lui ajouter une reservation


            Utilisateur a = new Utilisateur("Verhelle", "Romain", "the_bresilien@hotmail.fr", "dd", "rue", 5, 6, "Mons", "Belgique", "09/09/2000");
         
            
            
            //on la rajoute a l'utilisateur
            

            // on rajoute l'utilisateur à la base
            context.listeUtilisateurs.Add(a);

            System.Diagnostics.Debug.WriteLine("Ici" + "\n\n\n" + context.listeUtilisateurs.Local.Count + "\n\n\n");

            

            base.Seed(context);
        }
    }
}

