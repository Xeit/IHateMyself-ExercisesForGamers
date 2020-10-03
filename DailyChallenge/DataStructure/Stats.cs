using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    [Serializable]
    class Stats
    {
        //This all total xp user earned in this categories.
        public UInt64 bellyXp { get; set; }
        public UInt64 legsXp { get; set; }
        public UInt64 armsXp { get; set; }

        public Stats()
        {

        }
        public Stats(UInt64 BellyXp, UInt64 LegsXp, UInt64 ArmsXp)
        {
            this.bellyXp = BellyXp;
            this.legsXp = LegsXp;
            this.armsXp = ArmsXp;
        }
    }
}
