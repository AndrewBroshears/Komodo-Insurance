using KomodoInsurance.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance.Repo
{
    public class DevTeamRepo
    {
        private readonly List<DevTeamPoco> _devTeamPoco = new List<DevTeamPoco>();
        private int _devTeamId = 0;

        //C
        public bool AddDevTeam(DevTeamPoco devTeamPoco)
        {
            if (devTeamPoco is null)
            {
                return false;
            }
            else
            {
            _devTeamId++;
            devTeamPoco.DevTeamId = _devTeamId;
            _devTeamPoco.Add(devTeamPoco);
            return true;
            }
        }
        //R
        public List<DevTeamPoco> GetDevteam()
        {
            return _devTeamPoco;
        }
        public DevTeamPoco GetDevTeamById(int DevTeamId)
        {
           foreach(DevTeamPoco devTeamPoco in _devTeamPoco)
                if (DevTeamId == devTeamPoco.DevTeamId)
                {
                    return devTeamPoco;
                }
                return null;
        }
        //u
        public bool UpdateDevTeam(int DevTeamId, DevTeamPoco newDevTeam)
        {
            DevTeamPoco oldDevTeam = GetDevTeamById(DevTeamId);
            if (oldDevTeam != null)
            {
                oldDevTeam.DevTeamId = newDevTeam.DevTeamId;
                oldDevTeam.DevTeamName = newDevTeam.DevTeamName;
                oldDevTeam.DevMembers = newDevTeam.DevMembers;
                return true;
            }
            else
            {
                return false;
            }
        }
        //D
        public bool DeleteDevTeam(int DevTeamId)
        {
            DevTeamPoco devTeamToBeDeleted = GetDevTeamById(DevTeamId);
            if (devTeamToBeDeleted == null)
            {
                return false;
            }
            else
            {
                _devTeamPoco.Remove(devTeamToBeDeleted);
                return true;
            }
        }
    }
}
