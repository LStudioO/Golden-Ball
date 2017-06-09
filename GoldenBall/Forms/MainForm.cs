using System;
using System.Windows.Forms;
using System.IO;
using GoldenBall.Forms;
using GoldenBall.Classes;
using System.Collections.Generic;

namespace GoldenBall
{
    public partial class MainForm : Form
    {

        public int cityCount;

        const int DEFAULT_COLUMN_WIDTH = 40;

        private Tournament tour;

        static Random rnd = new Random();

        public void UpdateLog(string s)
        {
            txtResult.Text += s;
        }

        public MainForm()
        {
            InitializeComponent();
            tabFrame.TabPages[1].Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
        }

        private void recreateTable(DataGridView dgv)
        {
            int count = Convert.ToInt32(nudCities.Value);

            cityCount = count;

            dgv.Columns.Clear();

            for (int i = 0; i < count; i++)
            {
                dgv.Columns.Add("City" + i.ToString(), "City " + (i + 1).ToString());
            }

            dgv.Rows.Add(count);

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i == j)
                        dgv.Rows[i].Cells[j].Value = "-";
                    else
                        dgv.Rows[i].Cells[j].Value = 0;
                }
            }

            for (int i = 0; i < count; i++)
            {
                DataGridViewColumn column = dgv.Columns[i];
                column.Width = DEFAULT_COLUMN_WIDTH;
            }
        }

        private void addCities(DataGridView dgv, int count)
        {
            for (int i = 0; i < count; i++)
            {
                dgv.Columns.Add("City" + (dgv.Columns.Count + 1).ToString(), "City " + (dgv.Columns.Count + 1).ToString());
                DataGridViewColumn column = dgv.Columns[dgv.Columns.Count - 1];
                column.Width = DEFAULT_COLUMN_WIDTH;
                dgv.Rows.Add();
                DataGridViewRow row = dgv.Rows[dgv.Rows.Count - 1];
                var name = "City " + (row.Index + 1).ToString();
                row.HeaderCell.Value = name;
                dgv.RowHeadersWidth = (12 * name.Length);

                var c = dgv.Columns.Count;
                for (int j = 0; j < c - 1; j++)
                {
                    dgv[c - 1, j].Value = 0;
                    dgv[j, c - 1].Value = 0;
                }
                dgv[c - 1, c - 1].Value = "-";
            }
        }

        private void removeCities(DataGridView dgv, int count)
        {

            if (count >= dgv.Columns.Count)
            {
                dgv.Columns.Clear();
                dgv.Rows.Clear();
                return;
            }

            for (int i = 0; i < count; i++)
            {
                dgv.Columns.RemoveAt(dgv.Columns.Count - 1);
                dgv.Rows.RemoveAt(dgv.Rows.Count - 1);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvMain.AllowUserToAddRows = false;
            dgvMain.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            recreateTable(dgvMain);
            setRowNumber(dgvMain);
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var name = "City " + (row.Index + 1).ToString();
                row.HeaderCell.Value = name;
                dgv.RowHeadersWidth = 12 * name.Length;
            }
        }


        private void nudCities_ValueChanged(object sender, EventArgs e)
        {
            var diff = Convert.ToInt32(nudCities.Value) - cityCount;
            if (diff > 0)
            {
                addCities(dgvMain, diff);
            }
            else if (diff < 0)
            {
                removeCities(dgvMain, -diff);
            }
            cityCount = Convert.ToInt32(nudCities.Value);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvMain.Columns.Count; i++)
            {
                for (int j = 0; j < dgvMain.Rows.Count; j++)
                {
                    if (i != j)
                        dgvMain[i, j].Value = rnd.Next(100);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = new SaveFileDialog();
            s.FileName = "default.txt";
            s.Filter = "Text File | *.txt";
            if (s.ShowDialog() == DialogResult.OK)
            {
                var str = String.Empty;
                for (int i = 0; i < dgvMain.Columns.Count; i++)
                {
                    for (int j = 0; j < dgvMain.Columns.Count; j++)
                    {
                        str += dgvMain[i, j].Value.ToString() + " ";
                    }
                    str = str.Remove(str.Length - 1);
                    if (i != dgvMain.Columns.Count - 1)
                        str += Environment.NewLine;
                }
                File.WriteAllText(s.FileName, str);
                MessageBox.Show("File was successfully saved!", "Saving");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Text File | *.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var str = File.ReadAllText(open.FileName);
                string[] rows = str.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                var count = rows.Length;
                cityCount = count;
                nudCities.Value = count;

                dgvMain.Columns.Clear();
                dgvMain.Rows.Clear();
                addCities(dgvMain, count);

                for (int i = 0; i < count; i++)
                {
                    string[] items = rows[i].Split(new string[] { " " }, StringSplitOptions.None);
                    for (int j = 0; j < count; j++)
                    {
                        dgvMain[i, j].Value = items[j];
                    }
                }
                MessageBox.Show("File was successfully loaded!", "Loading");
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            tabFrame.TabPages[1].Enabled = true;
            tabFrame.SelectedIndex = 1;

            txtResult.Clear();

            runner.RunWorkerAsync();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabFrame.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tour.Run(1);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            tour.Run(-1);
        }

        private void runner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            Team.dropCounter();
            Season.dropSeason();

            var tCount = Settings.Instance().TeamsCount;
            var pCount = Settings.Instance().PlayersCount;

            var distances = new double[cityCount, cityCount];

            for (int i = 0; i < cityCount; i++)
            {
                for (int j = 0; j < cityCount; j++)
                {
                    if (i != j)
                        distances[i, j] = Convert.ToDouble(dgvMain[i, j].Value);
                }
            }

            tour = new Tournament(tCount, pCount, distances);

            tour.Output += UpdateLog;

            tour.Initialise();


            //try
            //{
            //    Team.dropCounter();

            //    var tCount = Settings.Instance().TeamsCount;
            //    var pCount = Settings.Instance().PlayersCount;


            //    for (int l = 5; l < 16; l++)
            //    {
            //        cityCount = l;
            //        for (int k = 0; k < 1; k++)
            //        {
            //            var distances = new double[cityCount, cityCount];

            //            for (int i = 0; i < cityCount; i++)
            //            {
            //                for (int j = 0; j < cityCount; j++)
            //                {
            //                    if (i != j)
            //                        distances[i, j] = rnd.Next(99);
            //                }
            //            }


            //            for (int j = 2; j < 5; j += 2)
            //                for (int i = 1; i < 6; i++)
            //                {
            //                    //if (j == 4 && i == 3)
            //                    //    continue;
            //                    Team.dropCounter();
            //                    tour = new Tournament(j, i, distances);

            //                    tour.Output += UpdateLog;

            //                    tour.Initialise();

            //                    File.AppendAllText("test.txt", cityCount.ToString() + " " + j.ToString() + " " + i.ToString() + " ");
            //                    tour.Run();
            //                }
            //            File.AppendAllText("test.txt", Environment.NewLine + Environment.NewLine);
            //        }
            //        File.AppendAllText("test.txt", Environment.NewLine + "=============================" + Environment.NewLine);
            //    }
            //}
            //catch (Exception) { 

            //}
        }
    }
}
