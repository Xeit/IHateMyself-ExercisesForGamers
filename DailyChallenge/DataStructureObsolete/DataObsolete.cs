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
    class DataObsolete
    {
        //TODO: Throw dailyExercises to list or something similiar
        public List<DailyExercisesObsolete> dailyExerciesList { get; set; }
        public UserObsolete user { get; set; }

        public DataObsolete() { dailyExerciesList = new List<DailyExercisesObsolete>(); }
        public DataObsolete(float Weight, float Height, string Name, int Age, UInt64 BellyXp, UInt64 LegsXp, UInt64 ArmsXp)
        {
            dailyExerciesList = new List<DailyExercisesObsolete>();
            dailyExerciesList.Add(new DailyExercisesObsolete());
            user = new UserObsolete(Weight, Height, Name, Age, BellyXp, LegsXp, ArmsXp);
        }
        public void NewDay()
        {
            dailyExerciesList.Add(new DailyExercisesObsolete());
            FileHandlerObsolete.saveFile();
        }
    }
}
