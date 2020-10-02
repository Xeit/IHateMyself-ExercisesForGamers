using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    public enum Challenge
    {
        //Translation to polish (easier for me)
        Pushups, // pompki
        Squats, // przysiady
        Plank, // plank
        Situp, // Brzuszki
        Burpees, //nwm
        MountainClimbers, // nwm
        Sprawl, // nwm
        RussianTwist, // siedzisz i obracasz się w lewo i w prawo brzuchem
        HeelTouch // dotykasz kostek

        //We can add something if this person will have dumbells
    }
    class DailyChallenge
    {
        public Challenge challenge { get; set; }
        public int HowManyDone { get; set; }
        public int HowManyRequired { get; set; }

        public DailyChallenge()
        {
            //TODO: new day for this class
            challenge = Challenge.Burpees;
            HowManyDone = 0;
            HowManyRequired = 10;
        }
    }
}
