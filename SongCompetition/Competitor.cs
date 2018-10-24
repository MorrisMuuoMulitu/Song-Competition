using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongCompetition
{
    class Competitor
    {
        //fields
        private int idNumber;
        private string name;
        private string department;

        private int score;

        //defining a unique number
        private static int itemsNumber;

        //constructor
        public Competitor(string name,string department)
        {
            this.name = name;
            this.department = department;

            //unique number 
            itemsNumber++;
            idNumber = itemsNumber;
        }
        //methods
        public void Scoring(int point)
        {
            score += point;
        }
        public override string ToString()
        {
            return idNumber + "\t" + name + "\t" + department + "\t" + score + "points";
        }
        //properties
        public int IdNumber
        {
            get { return idNumber; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Department
        {
            get { return department; }
        }
        public int Score
        {
            get { return score; }
        }
    }
}
