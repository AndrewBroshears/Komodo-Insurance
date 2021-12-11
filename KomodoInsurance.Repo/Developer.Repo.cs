using KomodoInsurance.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Repo
{
    public class DeveloperRepo
    {
        private readonly List<DeveloperPoco> _developerPoco = new List<DeveloperPoco>();
        private int _count = 0;

        //C
        public bool CreateDeveloper(DeveloperPoco developerPoco)
        {
            if (developerPoco is null)
            {
                return false;
            }
            _count++;
            developerPoco.DeveloperId = _count;
            _developerPoco.Add(developerPoco);
            return true;
        }
        //R
        public List<DeveloperPoco> GetDevelopers()
        {
            return _developerPoco;
        }
        public DeveloperPoco GetDeveloperById(int DeveloperId)
        {
            foreach (DeveloperPoco developerPoco in _developerPoco)
                if (DeveloperId == developerPoco.DeveloperId)
                {
                    return developerPoco;
                }
            return null;
        }
        //u
        public bool UpdateDeveloper(int DeveloperId, DeveloperPoco newDeveloper)
        {
            DeveloperPoco oldDeveloper = GetDeveloperById(DeveloperId);
            if (oldDeveloper != null)
            {
                oldDeveloper.DeveloperId = newDeveloper.DeveloperId;
                oldDeveloper.DeveloperFirstName = newDeveloper.DeveloperFirstName;
                oldDeveloper.DeveloperLastName = newDeveloper.DeveloperLastName;
                oldDeveloper.Pluralsight = newDeveloper.Pluralsight;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteDeveloper(int DevloperId)
        {
            DeveloperPoco developerToBeDeleted = GetDeveloperById(DevloperId);
            if (developerToBeDeleted == null)
            {
                return false;
            }
            else
            {
                _developerPoco.Remove(developerToBeDeleted);
                return true;
            }
        }
    }

}
