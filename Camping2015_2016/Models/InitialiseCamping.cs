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


            base.Seed(context);
        }
    }
}

