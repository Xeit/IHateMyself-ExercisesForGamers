using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DailyChallenge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data data = new Data(DateTime.Now, Challenge.Plank, 0, 25);
            StaticValues.currentDay = data;

            

            string jsonString = JsonConvert.SerializeObject(data);
            File.WriteAllText("serializacja.json", jsonString);



            //TODO: Posibility for user to change difficulty of training
            Properties.Settings.Default.UserDifficulty = 1;

            //TODO: Progress to complete challenge



            // Initialize data and get historic data from files.
            DataStructure.DataHistorical.InitializeHistorical();

            //Timer for new day
            TimeUntilNewDay.NewDayTimer();

            //TODO: Whole UI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
