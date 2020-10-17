using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    [Serializable]
    class DailyExercises
    {
        public DailyTask dailyTask { get; set; }
        public DailyChallenge dailyChallenge { get; set; }
        public DateTime dateTime { get; set; }

        public DailyExercises()
        {
            dailyTask = new DailyTask();
            dailyChallenge = new DailyChallenge();
            dateTime = DateTime.Today;
        }
    }
}
