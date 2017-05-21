using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            }
            else
            {
                foreach (var itm in tList)
                    rating[itm] = 0;
            }
        }

        public void Start()
        {
            for (int j = 0; j < 2; j++)
            {

                // generate table 

                var tCount = tList.Count - 1;

                int[,] table = new int[tCount, tCount + 1];

                var curTeamIndex = 0;

                for (int i = 0; i < tCount; i++)
                {
                    int p;

                    if (i % 2 == 0)
                    {
                        p = 1;
                        table[i, 0] = tList[curTeamIndex++].Id;
                    }
                    else
                    {
                        p = 0;
                        table[i, 1] = tList[curTeamIndex++].Id;
                    }

                    table[i, p] = tList.Last().Id;

                    if (curTeamIndex >= tList.Count - 1)
                        curTeamIndex = 0;

                    for (int k = 2; k < tCount + 1; k += 2)
                    {
                        if (table[i, k] == 0)
                        {
                            table[i, k] = tList[curTeamIndex++].Id;
                            if (curTeamIndex >= tList.Count - 1)
                                curTeamIndex = 0;
                        }
                    }

                }

                if (tCount > 2)
                {
                    curTeamIndex = tList.Count - 2;
                    for (int i = 0; i < tCount; i++)
                    {
                        for (int k = 3; k < tCount + 1; k += 2)
                        {
                            table[i, k] = tList[curTeamIndex--].Id;
                            if (curTeamIndex < 0)
                                curTeamIndex = tList.Count - 2;
                        }
                    }
                }
            }
        }

    }
}
