using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    class User
    {
        public Stats stats;
        public UserData userData;

        public User(){}
        public User(float Weight, float Height, string Name, int Age, UInt64 BellyXp, UInt64 LegsXp, UInt64 ArmsXp)
        {
            stats = new Stats(BellyXp, LegsXp, ArmsXp);
            userData = new UserData(Weight, Height, Name, Age);
        }
    }
}
