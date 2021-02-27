using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    //TODO: Think about deleting / rewritting whole thing
    class DataHistoricalObsolete
    {
        /// <summary>
        /// Initialize databases.
        /// </summary>
        public static void InitializeHistorical()
        {
            StaticValues.historical = new DataTable("Hisotrical");
            StaticValues.historical.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            StaticValues.historical.Columns.Add(new DataColumn("Challenge", typeof(Challenge)));
            StaticValues.historical.Columns.Add(new DataColumn("DailyTasks", typeof(DailyTaskObsolete)));
            StaticValues.historical.Columns.Add(new DataColumn("Done", typeof(int)));
            StaticValues.historical.Columns.Add(new DataColumn("Total", typeof(int)));

            //SerializeTest();
            if (File.Exists("Data.json"))
            {
                LoadHistoricalData();
                ReadToConsole();
                CheckForCurrentDay();
            }else
            {
                StaticValues.currentDailyTask = new DailyTaskObsolete();
                ChallengeForNewDay();
            }
        }

        /// <summary>
        /// Does nothing, it was test if this works.
        /// </summary>
        private static void SerializeTest()
        {
            DataRow dataRow = StaticValues.historical.NewRow();
            dataRow[0] = DateTime.Now;
            dataRow[1] = Challenge.Plank;
            dataRow[2] = StaticValues.currentDailyTask;
            dataRow[3] = 3;
            dataRow[4] = 30;
            StaticValues.historical.Rows.Add(dataRow);

            dataRow = StaticValues.historical.NewRow();
            dataRow[0] = DateTime.Now;
            dataRow[1] = Challenge.Pushups;
            dataRow[2] = StaticValues.currentDailyTask;
            dataRow[3] = 6;
            dataRow[4] = 48;
            StaticValues.historical.Rows.Add(dataRow);

            String serializedText = JsonConvert.SerializeObject(StaticValues.historical,
                Formatting.Indented);
            File.WriteAllText("AAA.json",serializedText);
        }

        private static void LoadHistoricalData()
        {
            String rawJson = File.ReadAllText("Data.json");
            Console.WriteLine(rawJson);
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(rawJson);
            StaticValues.historical = JsonConvert.DeserializeObject<DataTable>(rawJson);
        }

        private static void ReadToConsole()
        {
            foreach(DataRow dataRow in StaticValues.historical.Rows)
            {
                foreach(var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void CheckForCurrentDay()
        {
            int rows = StaticValues.historical.Rows.Count;
            rows--;
            DateTime lastDay = (DateTime)StaticValues.historical.Rows[rows][0];

            if(lastDay.Date != DateTime.Today)
            {
                ChallengeForNewDay();
                StaticValues.currentDailyTask.newDay();
            }
        }

        public static void ChallengeForNewDay()
        {
            //TODO: This segment of historical
            int randomChallenge = new Random().Next(5);
            Challenge challenge = Challenge.Plank;
            switch (randomChallenge)
            {
                case 0:
                    challenge = Challenge.Pushups;
                    break;
                case 1:
                    challenge = Challenge.Squats;
                    break;
                case 2:
                    challenge = Challenge.Burpees;
                    break;
                case 3:
                    challenge = Challenge.Plank;
                    break;
                case 4:
                    challenge = Challenge.Situp;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "Error in sellecting challenge, please contact Developer :(");
                    break;
            }
            int repeats = 1;
            switch (randomChallenge)
            {
                case 0: // Pushup
                    repeats = 5 * Properties.Settings.Default.UserDifficulty;
                    break;
                case 1: // Squat
                    repeats = 10 * Properties.Settings.Default.UserDifficulty;
                    break;
                case 2: // Burpee
                    repeats = 5 * Properties.Settings.Default.UserDifficulty;
                    break;
                case 3: // Plank
                    repeats = 15 * Properties.Settings.Default.UserDifficulty;
                    break;
                case 4: // Situp
                    repeats = 7 * Properties.Settings.Default.UserDifficulty;
                    break;
                default:
                    //For deafault (if something goes wrong) there is Plank (bcs I hate it).
                    repeats = 15 * Properties.Settings.Default.UserDifficulty;
                    break;
            }
            // Make new row for database
            DataRow dataRow = StaticValues.historical.NewRow();
            dataRow[0] = DateTime.Today;
            dataRow[1] = challenge;
            dataRow[2] = StaticValues.currentDailyTask;
            dataRow[3] = 0;
            dataRow[4] = repeats;
            StaticValues.historical.Rows.Add(dataRow);

            // Save file with new, updated database
            String serializedText = JsonConvert.SerializeObject(StaticValues.historical, 
                Formatting.Indented);
            File.WriteAllText("data.json", serializedText);

            // Save data for current use (like timer to next day)
            
            
            
            //StaticValues.currentDay = new Data(DateTime.Now, challenge, 0, repeats);
        }
    }
}
