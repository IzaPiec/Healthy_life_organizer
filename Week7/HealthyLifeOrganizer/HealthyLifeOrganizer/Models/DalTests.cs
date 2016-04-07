using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HealthyLifeOrganizer.Models
{
    public class DalTests

    {

        //TestMethod
        public void AddMeasurement_WithANewMeasurement_GetAllMeasurementReturnsTheMeasurement()
        {

            using (IDal dal = new Dal())

            {

                dal.AddMeasurement(62, 70, 75, 100.5, 58.5, 38, 81, 25);

                List<Measurement> measures = dal.GetAllMeasurements();



                Assert.IsNotNull(measures);

                Assert.AreEqual(1, measures.Count);

                Assert.AreEqual("La bonne fourchette", measures[0].Weight);
                Assert.AreEqual("La bonne fourchette", measures[0].Waist);
                Assert.AreEqual("La bonne fourchette", measures[0].Tummy);
                Assert.AreEqual("La bonne fourchette", measures[0].Hips);
                Assert.AreEqual("La bonne fourchette", measures[0].Thigh);
                Assert.AreEqual("La bonne fourchette", measures[0].Calf);
                Assert.AreEqual("La bonne fourchette", measures[0].Breast);
                Assert.AreEqual("01 02 03 04 05", measures[0].Biceps);

            }

        }

    }
}