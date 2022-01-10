using F1Prediction.Models;
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
        public virtual DbSet<Season> Seasons { get; set; } //maybe is not necessary
        public virtual DbSet<RaceWeekend> RaceWeekends { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Racer> Racers{ get; set; }
        public virtual DbSet<Player> Players { get; set; }

        public PredictionContext()
        {
            this.Database.EnsureCreated();
        }
        public PredictionContext(DbContextOptions<PredictionContext> options) : base(options) { }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer();
            }
        }

    }
}
