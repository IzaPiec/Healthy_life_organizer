using HealthyLifeOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLifeOrganizer.Controllers
{
    public class MeasurementsController : Controller
    {
        // GET: Measurements
        public ActionResult Index()
        {
            return View("Measurements");
        }
        public string AddMeasurement()
        {

            string date = Request.QueryString["measurementsDate"];
            string weight = Request.QueryString["weight"];
            string waist = Request.QueryString["waist"];
            string tummy = Request.QueryString["tummy"];
            string hips = Request.QueryString["hips"];
            string thigh = Request.QueryString["thigh"];
            string calf = Request.QueryString["calf"];
            string breast = Request.QueryString["breast"];
            string biceps = Request.QueryString["biceps"];

            double wgt;
            double newWeight;
            double wst;
            double newWaist;
            double t;
            double newTummy;
            double h;
            double newHips;
            double tgh;
            double newThigh;
            double c;
            double newCalf;
            double br;
            double newBreast;
            double bi;
            double newBiceps;

            if (double.TryParse(weight, out wgt))
                newWeight = wgt;
            else
                newWeight = 0;

            if (double.TryParse(waist, out wst))
                newWaist = wst;
            else
                newWaist = 0;

            if (double.TryParse(tummy, out t))
                newTummy = t;
            else
                newTummy = 0;

            if (double.TryParse(tummy, out h))
                newHips = h;
            else
                newHips = 0;

            if (double.TryParse(tummy, out tgh))
                newThigh = tgh;
            else
                newThigh = 0;

            if (double.TryParse(tummy, out c))
                newCalf = c;
            else
                newCalf = 0;

            if (double.TryParse(tummy, out br))
                newBreast = br;
            else
                newBreast = 0;

            if (double.TryParse(tummy, out bi))
                newBiceps = bi;
            else
                newBiceps = 0;

            DateTime convertedDate;
            try
            {
                convertedDate = Convert.ToDateTime(date);
                Console.WriteLine("'{0}' converts to {1} {2} time.",
                                  date, convertedDate,
                                  convertedDate.Kind.ToString());
                if (newWeight != 0 && newWaist != 0 && newBiceps != 0 && newBreast != 0 && newCalf != 0 && newHips != 0 && newThigh != 0 & newTummy != 0)
                {
                    using (IDal dal = new Dal())
                    {
                        dal.AddMeasurement(convertedDate, newWeight, newWaist, newTummy, newHips, newThigh, newCalf, newBreast, newBiceps);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' is not in the proper format.", date);
            }



            //Console.WriteLine("Added Measurments: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}",             
            //    date, 
            //weight, 
            //waist, 
            //tummy, 
            //hips, 
            //thigh, 
            //calf, 
            //breast, 
            //biceps);

            return "Done!";
        }
    }
}