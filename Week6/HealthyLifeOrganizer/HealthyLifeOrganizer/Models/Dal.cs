using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLifeOrganizer.Models
{
    public class Dal:IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public List<Measurement> GetAllMeasurements()
        {
            return bdd.Measurements.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}