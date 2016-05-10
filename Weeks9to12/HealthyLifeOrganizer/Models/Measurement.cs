using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLifeOrganizer.Models
{
    public class Measurement
    {
        public int MeasurementID { get; set; }
        public DateTime MeasurementsDate { get; set; }
        public double Weight { get; set; }
        public double Waist { get; set; }
        public double Tummy { get; set; }
        public double Hips { get; set; }
        public double Thigh { get; set; }
        public double Calf { get; set; }
        public double Breast { get; set; }
        public double Biceps { get; set; }
        //public virtual User User { get; set; }
    }
}