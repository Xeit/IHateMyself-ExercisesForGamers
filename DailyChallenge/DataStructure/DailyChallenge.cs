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
        MountainClimbers, // podparcie rękami i skakanie z nogi na nogę zmieniając, która jest prosta
        Sprawl, // nwm
        RussianTwist, // siedzisz i obracasz się w lewo i w prawo brzuchem
        HeelTouch // dotykasz kostek

        //We can add something if this person will have dumbells
    }
    [Serializable]
    class DailyChallenge
    {
        public Challenge challenge { get; set; }
        public int howManyDone { get; set; }
        public int howManyRequired { get; set; }

        public DailyChallenge()
        {
            ChallengeForNewDay();

            howManyDone = 0;
            //TODO: requirement based on difficulty
            howManyRequired = 10;
        }

        public void ChallengeForNewDay()
        {
            int randomChallenge = new Random().Next(9);
            switch (randomChallenge)
            {
                case 0:
                    challenge = Challenge.Pushups;
                    break;
                case 1:
                    challenge = Challenge.Squats;
                    break;
                case 2:
                    challenge = Challenge.Plank;
                    break;
                case 3:
                    challenge = Challenge.Situp;
                    break;
                case 4:
                    challenge = Challenge.Burpees;
                    break;
                case 5:
                    challenge = Challenge.MountainClimbers;
                    break;
                case 6:
                    challenge = Challenge.Sprawl;
                    break;
                case 7:
                    challenge = Challenge.RussianTwist;
                    break;
                case 8:
                    challenge = Challenge.HeelTouch;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "Error in sellecting challenge, please contact Developer :(");
                    break;
            }
        }
    }
}
