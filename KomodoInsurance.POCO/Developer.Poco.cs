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
        public DeveloperPoco(string developerName, int developerId, bool pluralsight)
        {
            DeveloperName = developerName;
            DeveloperId = developerId;
            Pluralsight = pluralsight;
        }
        public string DeveloperFirstName { get; set; }
        public string DeveloperLastName { get; set; }
        public int DeveloperId { get; set; }
        public bool Pluralsight { get; set; }
    }
}
