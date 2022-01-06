using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    class Season
    {
        public List<RaceWeekend> RaceWeekends{ get; set; }
        public List<Racer> Racers { get; set; }
        public List<Team> Teams { get; set; }

        public Season()
        {
            this.RaceWeekends = new List<RaceWeekend>();
            this.Racers = new List<Racer>();
            this.Teams = new List<Team>();
        }
    }
}
