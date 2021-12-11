using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.POCO
{
    public class DevTeamPoco
    {
        public DevTeamPoco() { }
        public DevTeamPoco(string devMembers, string devTeamName, int devTeamId)
        {
            DevMembers = devMembers;
            DevTeamName = devTeamName;
            DevTeamId = devTeamId;
        }
        public string DevMembers { get; set; }
        public string DevTeamName { get; set; }
        public int DevTeamId { get; set; }
    }
}
