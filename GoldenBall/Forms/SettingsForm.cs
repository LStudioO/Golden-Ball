using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldenBall.Classes;

namespace GoldenBall.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        Settings setting;

        private void GenerationParams_Load(object sender, EventArgs e)
        {
            setting = Settings.Instance();
            nudPlayersCount.Value = setting.PlayersCount;
            nudTeamsCount.Value = setting.TeamsCount;
            chkInterim.Checked = setting.NeedIntermResult;
            chkUnique.Checked = setting.NeedUniquePlayers;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            setting.PlayersCount = Convert.ToInt32(nudPlayersCount.Value);
            setting.TeamsCount = Convert.ToInt32(nudTeamsCount.Value);
            setting.NeedIntermResult = chkInterim.Checked;
            setting.NeedUniquePlayers = chkUnique.Checked;
            this.Close();
        }
    }
}
