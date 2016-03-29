using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLifeOrganizer.Models
{
    public interface IDal:IDisposable
    {
        List<Measurement> GetAllMeasurements();
    }
}
