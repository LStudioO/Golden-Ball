using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using GoldenBall.Classes;

namespace GoldenBall.Forms
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        List<Team> TeamL;

        private void btnStart_Click(object sender, EventArgs e)
        {
           var m = Manager.Instance.AllPlayers.Where(p => p.Mark == Convert.ToInt32(textBox1.Text)).ToList();
            int j = 5;

            j++;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                var manager = Manager.Instance;

                manager.Load();

                List<Player> pList = new List<Player>();

                List<Team> tList = new List<Team>();

                var capacity = Manager.Instance.CitiesCount;

                var teamCount = 10;

                var playerInTeamCount = 5;

                for (int i = 0; i < teamCount * playerInTeamCount; i++)
                {
                    var success = false;
                    Player p;

                    do
                    {
                        p = new Player(capacity, 4);

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

                tList.ForEach(t =>
                {

                    txtLog.Text += "Team #" + t.Id + Environment.NewLine;

                    t.Players.ForEach(p =>
                    {
                        p.Route.ForEach(i => { txtLog.Text += i + " "; });
                        txtLog.Text += Environment.NewLine;
                    });

                });

                Season season;

                double previousTeamsMark = 0D;
                double previousCaptainsMark = 0D;
                double previousBestSolution = 0D;

                while (true)
                {
                    season = new Season(tList);
                    season.T = txtLog;
                    season.Start();
                    if (previousBestSolution == season.GetBestSolution() && previousTeamsMark == season.GetTeamsMark() && previousCaptainsMark == season.GetCaptainsMark())
                    {
                        break;
                    } else
                    {
                        previousBestSolution = season.GetBestSolution();
                        previousTeamsMark = season.GetTeamsMark();
                        previousCaptainsMark = season.GetCaptainsMark();
                    }
                }

                TeamL = tList;
                txtLog.Text += "Answer: " + season.GetBestSolution() + Environment.NewLine;

                txtLog.Text += "Route: ";
                var best = Manager.Instance.AllPlayers.FindAll(i => i.Mark == season.GetBestSolution());
                best.ForEach(b => { b.Route.ForEach(i => { txtLog.Text += i + " "; }); txtLog.Text += Environment.NewLine;    }); 
            }
            catch (Exception ex)
            {
                txtLog.Text += ex.ToString();
            }
        }
    }
}
