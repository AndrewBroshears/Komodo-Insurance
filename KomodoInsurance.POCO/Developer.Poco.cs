using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCO
{
    public class DeveloperPoco
    {
        public DeveloperPoco() { }
        public DeveloperPoco(string developerFirstName, string developerLastName, int developerId, bool pluralsight)
        {
            DeveloperFirstName = developerFirstName;
            DeveloperLastName = developerLastName;
            DeveloperId = developerId;
            Pluralsight = pluralsight;
        }
        public string DeveloperFirstName { get; set; }
        public string DeveloperLastName { get; set; }
        public int DeveloperId { get; set; }
        public bool Pluralsight { get; set; }
    }
}
