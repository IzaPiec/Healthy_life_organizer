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

        public void AddMeasurement(DateTime measurementsDate, double weight, double waist, double tummy, double hips, double thigh, double calf, double breast, double biceps)
        {

            bdd.Measurements.Add(new Measurement
            {
                MeasurementsDate= measurementsDate,
                Weight = weight,
                Waist = waist,
                Tummy= tummy,
                Hips= hips,
                Thigh= thigh,
                Calf= calf,
                Breast= breast,
                Biceps= biceps
            });

            bdd.SaveChanges();

        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}