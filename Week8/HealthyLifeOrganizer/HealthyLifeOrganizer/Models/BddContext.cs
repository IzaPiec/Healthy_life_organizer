using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HealthyLifeOrganizer.Models
{
    public class BddContext:DbContext
    {
        public DbSet<Measurement> Measurements { get; set; }
               
    }
}