using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Close();
            frm1.Show();
        }
        
        private void play_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Close();
            frm2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 frm2 = Application.OpenForms["Form2"] as Form2;
            if (Settings1.Default.Score > Convert.ToInt32(frm2.Road0.Text.Substring(0, frm2.Road0.Text.Length - 1)))
            {
                RoadEd.Text = "Road :" + frm2.Road0.Text;
                ScoreEd.Text = "Score : " + Settings1.Default.Score.ToString() + " m";
            }
            else
            {
                RoadEd.Text = "Road :" + frm2.Road0.Text;
                ScoreEd.Text = "Score : " + Settings1.Default.Score.ToString() + " m";
                ScoreEd.BackgroundImage = RedLine.Image;
                ScoreEd.ForeColor = Color.White;
            }
            

        }
    }
}
