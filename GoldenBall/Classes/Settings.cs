using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBall.Classes
{

    public class Settings
    {
        private static readonly Settings instance = new Settings();

        public int TeamsCount { get; set; }

        public int PlayersCount { get; set; }

        public bool NeedUniquePlayers { get; set; }

        public bool NeedIntermResult { get; set; }

        private Settings()
        {
            TeamsCount = 2;
            PlayersCount = 1;
            NeedUniquePlayers = true;
            NeedIntermResult = true;
        }

        public static Settings Instance()
        {
            return instance;
        }
    }
}
