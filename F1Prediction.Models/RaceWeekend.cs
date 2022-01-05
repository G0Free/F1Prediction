using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    class RaceWeekend
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime Practice1 { get; set; }
        public DateTime Practice2 { get; set; }
        public DateTime Practice3 { get; set; }
        public DateTime Qualifying { get; set; }
        public DateTime Race { get; set; }

    }
}
