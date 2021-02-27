using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    class UserObsolete
    {
        public StatsObsolete stats;
        public UserDataObsolete userData;

        public UserObsolete(){}
        public UserObsolete(float Weight, float Height, string Name, int Age, UInt64 BellyXp, UInt64 LegsXp, UInt64 ArmsXp)
        {
            stats = new StatsObsolete(BellyXp, LegsXp, ArmsXp);
            userData = new UserDataObsolete(Weight, Height, Name, Age);
        }
    }
}
