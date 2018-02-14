using MvvmLightDemo.Core.Models;
using System.Collections.Generic;

namespace MvvmLightDemo.Core.Helpers
{
    public class Teams
    {
        public static List<Card> GenerateCards
        {
            get
            {
                return new List<Card>{  new Card {TeamName="Liverpool", Capacity=45276, StadiumName="Anfield", Latitude=53.430833, Longitude=2.960833 },
                 new Card {TeamName="West Ham United", Capacity=35345, StadiumName="Upton Park",Latitude=51.531944, Longitude=0.039444 },
                 new Card {TeamName="Aston Villa", Capacity=42682, StadiumName="Villa Park", Latitude=52.509167, Longitude=1.884722 },
                 new Card {TeamName="Tottenham Hotspurs", Capacity=36284, StadiumName="White Hart Lane", Latitude=51.603333, Longitude=0.065833 }};
            }
        }
    }
}
