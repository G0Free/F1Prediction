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
        public virtual DbSet<Racer> Racers { get; set; }
        public virtual DbSet<Player> Players { get; set; }

        public PredictionContext()
        {
            this.Database.EnsureCreated();
        }
        public PredictionContext(DbContextOptions<PredictionContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PredictionDatabase.mdf;Integrated Security=True";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SEASONS
            Season season = new Season();
            #endregion

            #region RACEWEEKENDS
            RaceWeekend raceWeekend1 = new RaceWeekend("Bahrain", "Sakhir", new DateTime(2022, 03, 18));
            RaceWeekend raceWeekend2 = new RaceWeekend("Saudi Arabia", "Jeddah", new DateTime(2022, 03, 25));
            RaceWeekend raceWeekend3 = new RaceWeekend("Australia", "Melbourne", new DateTime(2022, 04, 08));
            RaceWeekend raceWeekend4 = new RaceWeekend("Italy", "Imola", new DateTime(2022, 04, 22));
            RaceWeekend raceWeekend5 = new RaceWeekend("USA", "Miami", new DateTime(2022, 05, 06));
            RaceWeekend raceWeekend6 = new RaceWeekend("Spain", "Barcelona", new DateTime(2022, 05, 20));
            RaceWeekend raceWeekend7 = new RaceWeekend("Monaco", "Monaco", new DateTime(2022, 05, 27));
            RaceWeekend raceWeekend8 = new RaceWeekend("Azerbaijan", "Baku", new DateTime(2022, 06, 10));
            RaceWeekend raceWeekend9 = new RaceWeekend("Canada", "Montreal", new DateTime(2022, 06, 17));
            RaceWeekend raceWeekend10 = new RaceWeekend("United Kingdom", "Silverstone", new DateTime(2022, 07, 01));
            RaceWeekend raceWeekend11 = new RaceWeekend("Austria", "Spielberg", new DateTime(2022, 07, 08));
            RaceWeekend raceWeekend12 = new RaceWeekend("France", "France", new DateTime(2022, 07, 22));
            RaceWeekend raceWeekend13 = new RaceWeekend("Hungary", "Hungaroring", new DateTime(2022, 07, 29));
            RaceWeekend raceWeekend14 = new RaceWeekend("Belgium", "Spa", new DateTime(2022, 08, 26));
            RaceWeekend raceWeekend15 = new RaceWeekend("Netherlands", "Zandvoort", new DateTime(2022, 09, 02));
            RaceWeekend raceWeekend16 = new RaceWeekend("Italy", "Monza", new DateTime(2022, 09, 09));
            RaceWeekend raceWeekend17 = new RaceWeekend("Russia", "Sochi", new DateTime(2022, 09, 23));
            RaceWeekend raceWeekend18 = new RaceWeekend("Singapore", "Singapore", new DateTime(2022, 09, 30));
            RaceWeekend raceWeekend19 = new RaceWeekend("Japan", "Suzuka", new DateTime(2022, 10, 07));
            RaceWeekend raceWeekend20 = new RaceWeekend("USA", "Austin", new DateTime(2022, 10, 21));
            RaceWeekend raceWeekend21 = new RaceWeekend("Mexico", "Mexico", new DateTime(2022, 10, 28));
            RaceWeekend raceWeekend22 = new RaceWeekend("Brazil", "Sao Paolo", new DateTime(2022, 11, 11));
            RaceWeekend raceWeekend23 = new RaceWeekend("Abu Dhabi", "Abu Dhabi", new DateTime(2022, 11, 18));
            #endregion



            #region RACERS
            Racer verstappen = new Racer(1, "Max", "Verstappen");
            Racer perez = new Racer(11, "Sergio", "Perez");
            Racer hamilton = new Racer(44, "Lewis", "Hamilton");
            Racer russell = new Racer(63, "George", "Russell");
            Racer sainz = new Racer(55, "Carlos", "Sainz");
            Racer leclerc = new Racer(16, "Charles", "Leclerc");
            Racer norris = new Racer(4, "Lando", "Norris");
            Racer ricciardo = new Racer(3, "Daniel", "Ricciardo");
            Racer gasly = new Racer(10, "Pierre", "Gasly");
            Racer tsunoda = new Racer(22, "Yuki", "Tsunoda");
            Racer alonso = new Racer(14, "Fernando", "Alonso");
            Racer ocon = new Racer(31, "Esteban", "Ocon");
            Racer vettel = new Racer(5, "Sebastian", "Vettel");
            Racer stroll = new Racer(18, "Lance", "Stroll");
            Racer bottas = new Racer(77, "Valteri", "Bottas");
            Racer zhou = new Racer(24, "Guanyu", "Zhou");
            Racer albon = new Racer(23, "Alex", "Albon");
            Racer latifi = new Racer(6, "Nicholas", "Latifi");
            Racer schumacher = new Racer(47, "Mick", "Schumacher");
            Racer mazepin = new Racer(9, "Nikita", "Mazepin");
            #endregion

            #region TEAMS
            Team mercedes = new Team("Mercedes");
            Team redbull = new Team("Red Bull Racing");
            Team ferrari = new Team("Ferrari");
            Team mclaren = new Team("McLaren");
            Team alpine = new Team("Alpine");
            Team alphatauri = new Team("AlphaTauri");
            Team astonmartin = new Team("Aston Matrin");
            Team williams = new Team("Williams");
            Team alfaromeo = new Team("Alfa Romeo Racing");
            Team haas = new Team("Haas F1 Team");
            #endregion

            #region CONNECTION_SET

            #region TEAMS-PILOTS
            mercedes.Pilots[0] = hamilton;
            mercedes.Pilots[1] = russell;

            redbull.Pilots[0] = verstappen;
            redbull.Pilots[1] = perez;

            ferrari.Pilots[0] = leclerc;
            ferrari.Pilots[1] = sainz;

            mclaren.Pilots[0] = ricciardo;
            mclaren.Pilots[1] = norris;

            alpine.Pilots[0] = alonso;
            alpine.Pilots[1] = ocon;

            alphatauri.Pilots[0] = gasly;
            alphatauri.Pilots[1] = tsunoda;

            astonmartin.Pilots[0] = vettel;
            astonmartin.Pilots[1] = stroll;

            williams.Pilots[0] = latifi;
            williams.Pilots[1] = albon;

            alfaromeo.Pilots[0] = zhou;
            alfaromeo.Pilots[1] = bottas;

            haas.Pilots[0] = mazepin;
            haas.Pilots[1] = schumacher;
            #endregion

            #region RACEWEEKENDS
            raceWeekend1.Practice1.Date = new DateTime(2022, 03, 18, 11, 00, 00);
            raceWeekend1.Practice2.Date = new DateTime(2022, 03, 18, 14, 00, 00);
            raceWeekend1.Practice3.Date = new DateTime(2022, 03, 19, 11, 00, 00);
            raceWeekend1.Qualifying.Date = new DateTime(2022, 03, 19, 14, 00, 00);
            raceWeekend1.Race.Date = new DateTime(2022, 03, 20, 14, 00, 00);
            
            #endregion


            #endregion

            #region PLAYERS

            #endregion

        }

    }
}
