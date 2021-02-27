using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    [Serializable]
    class DailyExercisesObsolete
    {
        public DailyTaskObsolete dailyTask { get; set; }
        public DailyChallengeObsolete dailyChallenge { get; set; }
        public DateTime dateTime { get; set; }

        public DailyExercisesObsolete()
        {
            dailyTask = new DailyTaskObsolete();
            dailyChallenge = new DailyChallengeObsolete();
            dateTime = DateTime.Today;
        }
    }
}
