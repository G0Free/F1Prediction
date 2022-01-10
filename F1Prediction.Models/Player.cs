using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Racer[] Prediction { get; set; }
        public int Points { get; set; }

    }
}
