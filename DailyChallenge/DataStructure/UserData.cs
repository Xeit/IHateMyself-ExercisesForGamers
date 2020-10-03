using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    [Serializable]
    class UserData
    {
        public float weight { get; set; }
        public float height { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public UserData()
        {

        }
        public UserData(float Weight, float Height, string Name, int Age)
        {
            this.weight = Weight;
            this.height = Height;
            this.name = Name;
            this.age = Age;
        }
    }
}
