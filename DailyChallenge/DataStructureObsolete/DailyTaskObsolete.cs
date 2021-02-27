using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    [Serializable]
    public class DailyTaskObsolete
    {
        // How many repeats of each exercise user did. (resets everyday)
        public int pushupsDone { get; set; }
        public int squatsDone { get; set; }
        public int plankDone { get; set; }
        public int situpsDone { get; set; }
        public int burpeesDone { get; set; }
        public int mountainClimbersDone { get; set; }
        public int sprawlDone { get; set; }
        public int russianTwistsDone { get; set; }
        public int heelTouchesDone { get; set; }

        // How many user should do we can get from difficulty setting.
        public int DifficultyForThatDay { get; set; }

        public DailyTaskObsolete()
        {
            newDay();
        }

        public void newDay()
        {
            DifficultyForThatDay = Properties.Settings.Default.UserDifficulty;

            pushupsDone = 0;
            squatsDone = 0;
            plankDone = 0;
            situpsDone = 0;
            burpeesDone = 0;
            mountainClimbersDone = 0;
            sprawlDone = 0;
            russianTwistsDone = 0;
            heelTouchesDone = 0;

            //TODO: delete this
            /*pushups = 5 * Properties.Settings.Default.UserDifficulty;
            squats = 10 * Properties.Settings.Default.UserDifficulty;
            plank = 15 * Properties.Settings.Default.UserDifficulty;
            situps = 7 * Properties.Settings.Default.UserDifficulty;*/
        }

        public void exerciseDone(
            int howMuch, 
            short whatExercise /* 0 - pushup ; 1 - squat ; 2 - plank ; 3 - situp ; 4 - burpee
                                5 - mountain climber ; 6 - sprawl ; 7 - russian twist; 
                                8 - heel touch*/)
        {
            switch(whatExercise)
            {
                case 0:
                    pushupsDone += howMuch;
                    break;
                case 1:
                    squatsDone += howMuch;
                    break;
                case 2:
                    plankDone += howMuch;
                    break;
                case 3:
                    situpsDone += howMuch;
                    break;
                case 4:
                    burpeesDone += howMuch;
                    break;
                case 5:
                    mountainClimbersDone += howMuch;
                    break;
                case 6:
                    sprawlDone += howMuch;
                    break;
                case 7:
                    russianTwistsDone += howMuch;
                    break;
                case 8:
                    heelTouchesDone += howMuch;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "Error in adding progress to daily tasks, please contact developer :(");
                    break;
            }
        }

    }
}
