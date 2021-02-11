using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public class Band
    {
        public int BandRanking { get; set; }
        public string BandName { get; set; }
        public float BandPoints { get; set; }

        public static Band[] GetBands()
        {
            Band b1 = new Band
            {
                BandRanking = 1,
                BandName = "Led Zeppelin",
                BandPoints = 528
            };

            Band b2 = new Band
            {
                BandRanking = 2,
                BandName = "The Beatles",
                BandPoints = 514
            };

            return new Band[] { b1, b2 };
        }
    }
}
