using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Camping2015_2016.Models;
using System.Collections.Generic;

namespace Camping2015_2016.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreerRestaurant_AvecUnNouveauRestaurant_ObtientTousLesRestaurantsRenvoitBienLeRestaurant()
        {
            using (IDal dal = new Dal())
            {
                dal.creerReservation(01, false, DateTime.Now, DateTime.Now, 2, 3, true, true, null,true);

                List<Reservation> restos = dal.obtenirListeReservations();

               
                Assert.IsNotNull(restos);
                Assert.AreEqual(1, restos.Count);
                Assert.AreEqual(01, restos[0].idClient);
                
            }
        }
    }
}
