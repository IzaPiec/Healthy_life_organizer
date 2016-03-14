using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldASPNet.Models
{
    public class Clients
    {
        public List<Client> GetClientsList()
        {
            return new List<Client>
            {
                new Client {Age=33, Name="Nicholas" },
                new Client {Age = 30, Name = "Diane"},
                new Client {Age = 33, Name = "Jeremy"},
                new Client {Age = 1, Name = "Timmy"}
            };
        }
    }
}