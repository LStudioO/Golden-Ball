using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBall.Classes
{
    public sealed class Distances
    {
        private static readonly Distances instance = new Distances();

        private Dictionary<int, Dictionary<int, double>> dist;

        public Dictionary<int, Dictionary<int, double>> Dist
        {
            get
            {
                return dist;
            }
        }

        public void Load()
        {
            dist = new Dictionary<int, Dictionary<int, double>>();

            // TODO
        }

        static Distances()
        {
        }

        private Distances()
        {
        }

        public static Distances Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
