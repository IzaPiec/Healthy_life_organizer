using HelloWorldASPNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldASPNet.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public string Index()
        //{
        //    return "Hello World MVC";
        //}

        //public ActionResult Index(string id)
        //{
        //    if (string.IsNullOrWhiteSpace(id))
        //        return View("Error");
        //    else
        //    {
        //        ViewData["Name"] = id;
        //        return View();

        //    }

        //}

        public ActionResult ListClients()

        {
            Clients clients = new Clients();

            ViewData["Clients"] = clients.GetClientsList();

            return View();

        }

        public ActionResult SearchClient(string id)

        {

            ViewData["Name"] = id;

            Clients clients = new Clients();

            Client client = clients.GetClientsList().FirstOrDefault(c => c.Name == id);

            if (client != null)

            {

                ViewData["Age"] = client.Age;

                return View("Found");

            }

            return View("NotFound");

        }
    }
}