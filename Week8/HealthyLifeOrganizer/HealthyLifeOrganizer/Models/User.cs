using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLifeOrganizer.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirnstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}