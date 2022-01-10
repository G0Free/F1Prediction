using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    //maybe this class is not necessary
    public class Season
    {
        public ICollection<RaceWeekend> RaceWeekends{ get; set; }
        public ICollection<Racer> Racers { get; set; }
        public ICollection<Team> Teams { get; set; }

        public Season()
        {
            this.RaceWeekends = new List<RaceWeekend>();
            this.Racers = new List<Racer>();
            this.Teams = new List<Team>();
        }        
    }
}
