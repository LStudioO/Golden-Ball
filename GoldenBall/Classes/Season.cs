using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBall.Classes
{
    class Season
    {
        List<Team> tList;

        Dictionary<Team, int> rating;

        public Season(List<Team> teams)
        {
            tList = teams;

            dropRating();
        }

        private void dropRating()
        {
            if (rating == null)
            {
                rating = new Dictionary<Team, int>();
                tList.ForEach(i => rating.Add(i, 0));
            } else
            {
                foreach (var itm in tList)
                    rating[itm] = 0;
            }
        }

    }
}
