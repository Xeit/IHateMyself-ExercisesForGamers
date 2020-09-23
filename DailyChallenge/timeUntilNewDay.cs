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
        public static void NewDayTimer()
        {
            Int64 timeUntilDay = 86400000 - ((DateTime.Now.Hour * 60 * 60 * 1000) +
                (DateTime.Now.Minute * 60 * 1000) +
                (DateTime.Now.Second * 1000) +
                DateTime.Now.Millisecond);

            System.Timers.Timer timer = new System.Timers.Timer(timeUntilDay);

            Console.WriteLine("Czas do konca: {0} min", timeUntilDay / 1000 / 60);

            timer.Elapsed += Event;
            timer.AutoReset = true;
            timer.Enabled = true;
            //To prevent killing timer.
            GC.KeepAlive(timer);
        }
        private static void Event(Object source, ElapsedEventArgs eventArgs)
        {
            Console.WriteLine("New day!");
            DataStructure.DataHistorical.ChallengeForNewDay();
            //TODO: Make event for new day (update file, update hisotry)
        }
    }
}
