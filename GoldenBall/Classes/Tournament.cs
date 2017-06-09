using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenBall.Classes
{

    public delegate void Log(string text);

    class Tournament
    {
        private int teamCount;
        private int playerInTeamCount;

        List<Team> tList;

        double previousTeamsMark = 0D;
        double previousCaptainsMark = 0D;
        double previousBestSolution = 0D;

        int final = 100;

        public Log Output;

        bool isFinished = false;

        public Tournament(int teamCount, int playersCount, double[,] dist)
        {
            this.teamCount = teamCount;
            this.playerInTeamCount = playersCount;

            Manager.Instance.SetDistance(dist);
            Manager.Instance.CitiesCount = dist.GetLength(0);
        }

        public void Initialise()
        {
            try
            {
                var manager = Manager.Instance;

                List<Player> pList = new List<Player>();

                tList = new List<Team>();

                var capacity = Manager.Instance.CitiesCount;

                for (int i = 0; i < teamCount * playerInTeamCount; i++)
                {
                    var success = false;
                    Player p;

                    do
                    {
                        p = new Player(capacity, 1);

                        success = !pList.Any(obj => obj.Route.SequenceEqual(p.Route));

                    } while (!success);

                    pList.Add(p);
                }

                for (int i = 0; i < teamCount; i++)
                {
                    var players = pList.GetRange(i * playerInTeamCount, playerInTeamCount);

                    Team t = new Team(players);

                    tList.Add(t);
                }

                manager.AllPlayers = pList;

                string txtLog = string.Empty;

                tList.ForEach(t =>
                {
                    txtLog += "Team #" + t.Id + Environment.NewLine;

                    t.Players.ForEach(p =>
                    {
                        p.Route.ForEach(i => { txtLog += i + " "; });
                        txtLog += Environment.NewLine;
                    });

                });

                //Output(txtLog);
            }
            catch (Exception ex)
            {
                Output(ex.ToString());
            }
        }


        public void Run(int steps = -1)
        {
            try
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                
                Season season;

                while (true && !isFinished)
                {
                    if (steps == 0)
                        break;

                    final--;

                    season = new Season(tList);
                    season.Output = Output;
                    season.Start();
                    if (final <= 0 || previousBestSolution == season.GetBestSolution() && previousTeamsMark == season.GetTeamsMark() && previousCaptainsMark == season.GetCaptainsMark())
                    {
                        watch.Stop();
                        var elapsedMs = watch.ElapsedMilliseconds;

                        string txtLog = string.Empty;

                        txtLog = "Answer: " + season.GetBestSolution() + Environment.NewLine;

                        txtLog += "Route: ";
                        var best = Manager.Instance.AllPlayers.FindAll(i => i.Mark == season.GetBestSolution());

                        best.ForEach(b => { b.Route.ForEach(i => { txtLog += i + " "; }); txtLog += Environment.NewLine; });

                        txtLog += "Time: " + elapsedMs + " ms" + Environment.NewLine;

                        File.AppendAllText("test.txt", elapsedMs + Environment.NewLine); 

                        Output(txtLog);

                        isFinished = true;

                        break;
                    }
                    else
                    {
                        previousBestSolution = season.GetBestSolution();
                        previousTeamsMark = season.GetTeamsMark();
                        previousCaptainsMark = season.GetCaptainsMark();
                    }
                    if (steps > 0)
                        steps--;
                }
            }
            catch (Exception ex)
            {
                Output(ex.ToString());
            }
        }
    }
}
