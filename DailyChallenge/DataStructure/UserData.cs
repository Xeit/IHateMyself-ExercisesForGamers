using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyChallenge.DataStructure
{
    class UserData
    {
        private String firstName;
        private String secondName;
        private Double weight; //kg
        private Double height; //cm
        private DateTime bornDate; //To calculate age

        //Basic XP system for body
        private ulong legXP;
        private ulong bellyXP;
        private ulong chestXP;
        private ulong armsXP;

        public UserData()
        {
        }
        public UserData(String firstName, String secondName, Double weight, int height, DateTime bornDate, 
            ulong legXP, ulong bellyXP, ulong chestXP, ulong armsXP)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.weight = weight;
            this.height = height;
            this.bornDate = bornDate;
            this.legXP = legXP;
            this.bellyXP = bellyXP;
            this.chestXP = chestXP;
            this.armsXP = armsXP;
        }
        public String getFirstName() { return firstName; }
        public String getSecondName() { return secondName; }
        public Double getWeight() { return weight; }
        public Double getHeight() { return height; }
        public DateTime getBornDate() { return bornDate; }
        public ulong getLegXP() { return legXP; }
        public ulong getBellyXP() { return bellyXP; }
        public ulong getChestXP() { return chestXP; }
        public ulong getArmsXP() { return armsXP; }
        public Boolean updateFirstName(String firstName)
        {
            this.firstName = firstName;
            if (this.firstName.Equals(firstName))
                return true;
            else
            {
                MessageBox.Show("Something went wrong. Error code: 100");
                return false;
            }
        }
        public Boolean updateSecondName(String secondName)
        {
            this.secondName = secondName;
            if (this.secondName.Equals(secondName))
                return true;
            else
            {
                MessageBox.Show("Something went wrong. Error code: 101");
                return false;
            }
        }
        public Boolean updateWeight(Double weight)
        {
            this.weight = weight;
            if(this.weight.Equals(weight))
                return true;
            else
            {
                MessageBox.Show("Somehing went wrong. Error code: 102");
                return false;
            }
        }
        public Boolean updateHeight(Double height)
        {
            this.height = height;
            if (this.height.Equals(height))
                return true;
            else
            {
                MessageBox.Show("Something went wrong. Error code: 103");
                return false;
            }
        }
        public Boolean updateBornDate(DateTime bornDate)
        {
            this.bornDate = bornDate;
            if (this.bornDate.Equals(bornDate))
                return true;
            else
            {
                MessageBox.Show("Something went wrong. Error code: 104");
                return false;
            }
        }
        public Boolean addLegXP(uint XP)
        {
            if((ulong.MaxValue - XP) < this.legXP) //If user would get more XP than is possible to store
            {
                string message = "Well... (this shouldn't happen) Please contact developer for fix. You absolute LEGEND :) Error code: 105";
                string title = "Well... you have too much XP";
                MessageBox.Show(message, title);
                return false;
            }else
            {
                ulong temp = this.legXP;
                this.legXP += XP;
                if((temp + XP) != this.legXP)
                {
                    MessageBox.Show("Something went wrong. Error code: 106");
                    return false;
                }
                return true;
            }
        }
        public Boolean addBellyXP(uint XP)
        {
            if ((ulong.MaxValue - XP) < this.bellyXP) //If user would get more XP than is possible to store
            {
                string message = "Well... (this shouldn't happen) Please contact developer for fix. You absolute LEGEND :) Error code: 107";
                string title = "Well... you have too much XP";
                MessageBox.Show(message, title);
                return false;
            }
            else
            {
                ulong temp = this.bellyXP;
                this.bellyXP += XP;
                if((temp + XP) != this.bellyXP)
                {
                    MessageBox.Show("Something went wrong. Error code: 108");
                    return false;
                }
                return true;
            }
        }
        public Boolean addChestXP(uint XP)
        {
            if ((ulong.MaxValue - XP) < this.chestXP) //If user would get more XP than is possible to store
            {
                string message = "Well... (this shouldn't happen) Please contact developer for fix. You absolute LEGEND :) Error code: 109";
                string title = "Well... you have too much XP";
                MessageBox.Show(message, title);
                return false;
            }
            else
            {
                ulong temp = this.chestXP;
                this.chestXP += XP;
                if((temp + XP) != this.chestXP)
                {
                    MessageBox.Show("Something went wrong. Error code: 110");
                    return false;
                }
                return true;
            }
        }
        public Boolean addArmsXP(uint XP)
        {
            if ((ulong.MaxValue - XP) < this.armsXP) //If user would get more XP than is possible to store
            {
                string message = "Well... (this shouldn't happen) Please contact developer for fix. You absolute LEGEND :) Error code: 111";
                string title = "Well... you have too much XP";
                MessageBox.Show(message, title);
                return false;
            }
            else
            {
                ulong temp = this.armsXP;
                this.armsXP += XP;
                if((temp + XP) != this.armsXP)
                {
                    MessageBox.Show("Something went wrong. Error code: 112");
                    return false;
                }
                return true;
            }
        }
    }
}
