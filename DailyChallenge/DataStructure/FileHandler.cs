using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    class FileHandler
    {

        /// <summary>
        /// Function used to load data from file.
        /// If file is not present, it creates new file.
        /// </summary>
        public static void InitializeData()
        {
            if (File.Exists("Data.json"))
            {
                String rawJson = File.ReadAllText("Data.json");
                Console.WriteLine(rawJson);
                Program.data = JsonConvert.DeserializeObject<Data>(rawJson);


                DailyExercises dataToCheckDate = Program.data.dailyExerciesList.Last();
                if (dataToCheckDate.dateTime != DateTime.Today)
                {
                    Program.data.NewDay();
                }
            }
            else
            {
                Program.data = new Data(90, 180, "User", 20, 0, 0, 0);
                String serializedText = JsonConvert.SerializeObject(Program.data, Formatting.Indented);
                File.WriteAllText("data.json", serializedText);
                //TODO: make form for new user.
                //make new set of data and save to file
            }
        }
        public static void saveFile()
        {
            String serializedText = JsonConvert.SerializeObject(Program.data, Formatting.Indented);
            File.WriteAllText("data.json", serializedText);
        }
    }
}
