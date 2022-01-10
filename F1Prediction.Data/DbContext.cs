using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Data
{
    //Entityframework Core
        //.Proxies
        //.SqlServer
        //.Tools
    public class PredictionContext : DbContext
    {
        public virtual DbSet<RaceWeekend> RaceWeekends { get; set; }
    }
}
