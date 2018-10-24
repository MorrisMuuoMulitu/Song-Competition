using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SongCompetition
{
    class Controller
    {
        private List<Competitor> Competitors = new List<Competitor>();
        private int juryMember = 5;
        private int scoreLimit = 10;
            
       public void Start()
        {
            InputData();
            DisplayData("\nParticipants: \n);
            Competition();
            DisplayData("\nResults: \n");
            Results();
            Search();
        }

        private void InputData()
        {
            String name, department;
            Competitor competitor;

            //read the data
            StreamReader streamreader = new StreamReader("competitor.txt");
            while (!streamreader.EndOfStream)
            {
                name = streamreader.ReadLine();
                department = streamreader.ReadLine();
                competitor = new Competitor(name, department);
                //add the new object to the list
                competitors.Add(competitor);
            }
        }

        private object Competition()
        {
            throw new NotImplementedException();
        }

        private void DisplayData(string v)
        {
            throw new NotImplementedException();
        }

        private void Search()
        {
            throw new NotImplementedException();
        }
    }
}