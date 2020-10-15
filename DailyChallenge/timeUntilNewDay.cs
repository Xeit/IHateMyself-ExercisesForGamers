using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DailyChallenge
{
    class TimeUntilNewDay
    {
        private static Int64 timeUntilDay;
        private static System.Timers.Timer timer;
        public static void NewDayTimer()
        {
            //TODO: Timer for new day
            timeUntilDay = 86400000 - ((DateTime.Now.Hour * 60 * 60 * 1000) +
                (DateTime.Now.Minute * 60 * 1000) +
                (DateTime.Now.Second * 1000) +
                DateTime.Now.Millisecond);

            timer = new System.Timers.Timer(timeUntilDay);

            Console.WriteLine("Time until new day: {0} min", timeUntilDay / 1000 / 60);

            timer.Elapsed += Event;
            timer.AutoReset = true;
            timer.Enabled = true;
            //To prevent killing timer.
            GC.KeepAlive(timer);
        }
        private static void Event(Object source, ElapsedEventArgs eventArgs)
        {
            Console.WriteLine("New day!");
            Program.data.newDay();
            timeUntilDay = 86400000 - ((DateTime.Now.Hour * 60 * 60 * 1000) +
                (DateTime.Now.Minute * 60 * 1000) +
                (DateTime.Now.Second * 1000) +
                DateTime.Now.Millisecond);
            timer = new System.Timers.Timer(timeUntilDay);
            //DataStructure.DataHistorical.ChallengeForNewDay();
            //StaticValues.currentDailyTask.newDay();
            //TODO: Make event for new day (update file, update hisotry)
        }
    }
}
