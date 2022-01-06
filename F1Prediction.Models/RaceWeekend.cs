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
        public Practice1 Practice1 { get; set; }
        public Practice2 Practice2 { get; set; }
        public Practice3 Practice3 { get; set; }
        public Qualifying Qualifying { get; set; }
        public Race Race { get; set; }

    }
}
