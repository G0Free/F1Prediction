using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    class Race
    {
        public DateTime Date { get; set; }

        public Racer FastestLapDriver { get; set; }
        public Racer[] Result { get; set; }
        public Race()
        {
            this.Result = new Racer[20];
        }
        
    }
}
