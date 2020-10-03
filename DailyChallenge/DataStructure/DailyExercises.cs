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
        //TODO: rename it (to DailyExercises) to store only tasks and challenge, use as a list in Data structure
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
