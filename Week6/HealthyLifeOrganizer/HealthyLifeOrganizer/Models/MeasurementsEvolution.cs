using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLifeOrganizer.Models
{
    public class MeasurementsEvolution
    {
        public int Id { get; set; }
        public DateTime MeasurementDate { get; set; }             
        public virtual Measurement Measurement { get; set; }
        public virtual List<Measurement> Measurements { get; set; }
    }
}