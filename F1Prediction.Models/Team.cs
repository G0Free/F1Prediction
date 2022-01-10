using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    public class Team
    {
        public string Name { get; set; }
        public Racer[] Pilots { get; set; }
        public int ConstructorPoints { get; set; }

        public Team(string name)
        {
            this.Name = name;
            this.Pilots = new Racer[2];
        }
    }
}
