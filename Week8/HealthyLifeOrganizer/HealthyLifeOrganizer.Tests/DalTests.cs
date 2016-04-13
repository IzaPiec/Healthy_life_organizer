using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthyLifeOrganizer.Models;
using System.Collections.Generic;

namespace HealthyLifeOrganizer.Tests
{
    [TestClass]
    public class DalTests
    {
        [TestMethod]
        public void AddMeasurement_WithANewMeasurement_GetAllMeasurementReturnsTheMeasurement()
        {
            using (IDal dal = new Dal())
            {
                DateTime localDate = DateTime.Now;
                dal.AddMeasurement(localDate, 62, 70, 75, 100.5, 58.5, 38, 81, 25);
                List<Measurement> measures = dal.GetAllMeasurements();

                Assert.IsNotNull(measures);
                Assert.AreEqual(1, measures.Count);
                Assert.AreEqual(62, measures[0].Weight);
                Assert.AreEqual(70, measures[0].Waist);
                Assert.AreEqual(75, measures[0].Tummy);
                Assert.AreEqual(100.5, measures[0].Hips);
                Assert.AreEqual(58.5, measures[0].Thigh);
                Assert.AreEqual(38, measures[0].Calf);
                Assert.AreEqual(81, measures[0].Breast);
                Assert.AreEqual(25, measures[0].Biceps);

            }

        }

    }
}
