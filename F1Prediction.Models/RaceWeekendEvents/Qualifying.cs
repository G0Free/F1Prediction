﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    public class Qualifying
    {
        public DateTime Date { get; set; }
        public Racer[] Result { get; set; }

        public Qualifying()
        {
            this.Result = new Racer[20];
        }
    }
}
