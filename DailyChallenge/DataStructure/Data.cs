using DailyChallenge.DataStructure;
using System;
using System.Collections.Generic;
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
        public DailyExercises dailyExercises { get; set; }
        public User user { get; set; }

        public Data() { }
        public Data(float Weight, float Height, string Name, int Age, UInt64 BellyXp, UInt64 LegsXp, UInt64 ArmsXp)
        {
            dailyExercises = new DailyExercises();
            user = new User(Weight, Height, Name, Age, BellyXp, LegsXp, ArmsXp);
        }
    }



    /*public enum Challenge
    {
        Pushups, //Pompki
        Squats, //Przysiady
        Burpees, // Z dolu do wyskoku (o uj chodzi xD)
        Plank, // Zaginanie czasu
        Situps, // Brzuszki

        // Dumbellsy trzeba zalatwic, wtedy mozna dodac wiecej cwiczen

    }
    [Serializable]
    public class Data
    {
        public DateTime date { get; set; }
        public Challenge challenge { get; set; }
        public int done { get; set; }
        public int total { get; set; }
        public DailyTask dailyTask { get; set; }

        public Data(DateTime date, Challenge challenge, int done, int total)
        {
            this.date = date;
            this.challenge = challenge;
            this.done = done;
            this.total = total;
        }

        public void progressValue(int repeats)
        {
            this.done += repeats;
        }

        public DateTime GetDate()
        {
            return date;
        }

        public Challenge GetChallenge()
        {
            return challenge;
        }

        public int getDone()
        {
            return done;
        }

        public int getTotal()
        {
            return total;
        }
    }*/
}
