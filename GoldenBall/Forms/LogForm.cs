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

        private void btnStart_Click(object sender, EventArgs e)
        {

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

                var teamCount = 4;

                var playerInTeamCount = 3;

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

                tList.ForEach(t =>
                {

                    txtLog.Text += "Team #" + t.Id + Environment.NewLine;

                    t.Players.ForEach(p =>
                    {
                        p.Route.ForEach(i => { txtLog.Text += i + " "; });
                        txtLog.Text += Environment.NewLine;
                    });

                });

                var season = new Season(tList);

                season.Start();

            } catch (Exception ex)
            {
                txtLog.Text += ex.ToString();
            }
        }
    }
}
