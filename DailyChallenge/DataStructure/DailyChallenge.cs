using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyChallenge.DataStructure
{
    class DailyChallenge
    {
        private Exercises challenge; //which challenge user got (data from ExercisesEnum)
        private uint howManyRepeatsNeeded; //number of repeats needed to complete challenge
        private uint repeatsDone; //number of repeats done by user

        public DailyChallenge()
        { }
        public DailyChallenge(Exercises challenge,uint howManyRepeatsNeeded,uint repeatsDone)
        {
            this.challenge = challenge;
            this.howManyRepeatsNeeded = howManyRepeatsNeeded;
            this.repeatsDone = repeatsDone;
        }
        public Boolean newChallenge()
        {
            //TODO: Do new challenge
            return false;
        }
    }
}
