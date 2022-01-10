using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    public class Racer
    {
        public int RaceNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Points { get; set; }

        public Racer()
        {

        }
        public Racer(int racenumber, string firstname, string lastname)
        {
            this.RaceNumber = racenumber;
            this.FirstName = firstname;
            this.LastName = lastname;
        }
    }
}
