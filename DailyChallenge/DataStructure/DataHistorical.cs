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
    class DataHistorical
    {
        public static void InitializeHistorical()
        {
            StaticValues.historical = new DataTable("Hisotrical");
            StaticValues.historical.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            StaticValues.historical.Columns.Add(new DataColumn("Challenge", typeof(Challenge)));
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
                ChallengeForNewDay();
            }
        }

        private static void SerializeTest()
        {
            DataRow dataRow = StaticValues.historical.NewRow();
            dataRow[0] = DateTime.Now;
            dataRow[1] = Challenge.Plank;
            dataRow[2] = 3;
            dataRow[3] = 30;
            StaticValues.historical.Rows.Add(dataRow);

            dataRow = StaticValues.historical.NewRow();
            dataRow[0] = DateTime.Now;
            dataRow[1] = Challenge.Pushups;
            dataRow[2] = 6;
            dataRow[3] = 48;
            StaticValues.historical.Rows.Add(dataRow);

            String serializedText = JsonConvert.SerializeObject(StaticValues.historical);
            File.WriteAllText("AAA.json",serializedText);
        }

        private static void LoadHistoricalData()
        {
            String rawJson = File.ReadAllText("Data.json");
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
            }
        }

        public static void ChallengeForNewDay()
        {
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
                    challenge = Challenge.Situps;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Error in sellecting challenge, please contact Developer :(");
                    break;
            }
            int repeats = 1;
            switch (randomChallenge)
            {
                case 0:
                    repeats = 5 * Properties.Settings.Default.UserDifficulty;
                    break;
                case 1:
                    repeats = 10 * Properties.Settings.Default.UserDifficulty;
                    break;
                case 2:
                    repeats = 5 * Properties.Settings.Default.UserDifficulty;
                    break;
                case 3:
                    repeats = 15 * Properties.Settings.Default.UserDifficulty;
                    break;
                case 4:
                    repeats = 7 * Properties.Settings.Default.UserDifficulty;
                    break;
                default:
                    //For deafault (if something goes wrong) there is Plank.
                    repeats = 15 * Properties.Settings.Default.UserDifficulty;
                    break;
            }
            // Make new row for database
            DataRow dataRow = StaticValues.historical.NewRow();
            dataRow[0] = DateTime.Today;
            dataRow[1] = challenge;
            dataRow[2] = 0;
            dataRow[3] = repeats;
            StaticValues.historical.Rows.Add(dataRow);

            // Save file with new, updated database
            String serializedText = JsonConvert.SerializeObject(StaticValues.historical);
            File.WriteAllText("data.json", serializedText);

            // Save data for current use (like timer to next day)
            StaticValues.currentDay = new Data(DateTime.Now, challenge, 0, repeats);
        }
    }
}
