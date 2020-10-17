using DailyChallenge.DataStructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    //TODO: Make functions to handle all this data. (nothing to do for now unelss nececary)
    [Serializable]
    class Data
    {
        //TODO: Throw dailyExercises to list or something similiar
        public List<DailyExercises> dailyExerciesList { get; set; }
        public User user { get; set; }

        public Data() { dailyExerciesList = new List<DailyExercises>(); }
        public Data(float Weight, float Height, string Name, int Age, UInt64 BellyXp, UInt64 LegsXp, UInt64 ArmsXp)
        {
            dailyExerciesList = new List<DailyExercises>();
            dailyExerciesList.Add(new DailyExercises());
            user = new User(Weight, Height, Name, Age, BellyXp, LegsXp, ArmsXp);
        }
        public void NewDay()
        {
            dailyExerciesList.Add(new DailyExercises());
            FileHandler.saveFile();
        }
    }
}
