using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    [Serializable]
    public class DailyTask
    {
        // How many repeats of each exercise user did. (resets everyday)
        public int PushupsDone { get; set; }
        public int SquatsDone { get; set; }
        public int PlankDone { get; set; }
        public int SitupsDone { get; set; }
        public int BurpeesDone { get; set; }
        public int MountainClimbersDone { get; set; }
        public int SprawlDone { get; set; }
        public int RussianTwistsDone { get; set; }
        public int HeelTouchesDone { get; set; }

        // How many user should do we can get from difficulty setting.
        public int DifficultyForThatDay { get; set; }

        public DailyTask()
        {
            newDay();
        }

        public void newDay()
        {
            DifficultyForThatDay = Properties.Settings.Default.UserDifficulty;

            PushupsDone = 0;
            SquatsDone = 0;
            PlankDone = 0;
            SitupsDone = 0;
            BurpeesDone = 0;
            MountainClimbersDone = 0;
            SprawlDone = 0;
            RussianTwistsDone = 0;
            HeelTouchesDone = 0;

            //TODO: delete this
            /*pushups = 5 * Properties.Settings.Default.UserDifficulty;
            squats = 10 * Properties.Settings.Default.UserDifficulty;
            plank = 15 * Properties.Settings.Default.UserDifficulty;
            situps = 7 * Properties.Settings.Default.UserDifficulty;*/
        }

        public void somethingDone(
            int howMuch, 
            short whatExercise /* 0 - pushup ; 1 - squat ; 2 - plank ; 3 - situp ; 4 - burpee
                                5 - mountain climber ; 6 - sprawl ; 7 - russian twist; 
                                8 - heel touch*/)
        {
            switch(whatExercise)
            {
                case 0:
                    PushupsDone += howMuch;
                    break;
                case 1:
                    SquatsDone += howMuch;
                    break;
                case 2:
                    PlankDone += howMuch;
                    break;
                case 3:
                    SitupsDone += howMuch;
                    break;
                case 4:
                    BurpeesDone += howMuch;
                    break;
                case 5:
                    MountainClimbersDone += howMuch;
                    break;
                case 6:
                    SprawlDone += howMuch;
                    break;
                case 7:
                    RussianTwistsDone += howMuch;
                    break;
                case 8:
                    HeelTouchesDone += howMuch;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "Error in adding progress to daily tasks, please contact developer :(");
                    break;
            }
        }

    }
}
