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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();


            Cont();
        

            //case 3:
            //        sayac++;
            //if (sayac == 5)
            //{
            //    pb.Image = Properties.Resources.car3;
            //    sayac = 0;
            //}
            //break;
        }
        Random rnd = new Random();
        int speed = 25,speed1=70,Road1=0,move=14;
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        Form1 frm1 = Application.OpenForms["Form1"] as Form1;
        bool Mouse = true;

        void Cont()
        {
            if (frm1 != null && frm1.Keyboard.Checked)
            {
                Mouse = false;
            }
        }



        class CarChoos
        {
            public bool ObstacleCar = false;
            public PictureBox Cars;
            public bool time = false;
        }
        
        
        CarChoos[] RndCars = new CarChoos[2];
        void CarsShow(PictureBox pb)
        {
            int r = rnd.Next(0,4);
            switch (r)
            {
                case 0:
                    pb.Image = Properties.Resources.car0;
                    break;
                case 1:
                    pb.Image = Properties.Resources.car1;
                    break;
                case 2:
                    pb.Image = Properties.Resources.car2;
                    break;
                case 3:
                    pb.Image = Properties.Resources.car3;
                    break;



            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        bool Movement = true;
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (Mouse == false)
            {
                if (Movement == true)
                {
                    if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                    {
                        RedCar.Left -= move;
                    }
                    if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                    {
                        RedCar.Left += move;
                    }
                    if (e.KeyCode == Keys.W && RedCar.Top > 3 || e.KeyCode == Keys.Up)
                    {
                        RedCar.Top -= move;
                    }
                    if (e.KeyCode == Keys.S && RedCar.Bottom < 700 || e.KeyCode == Keys.Down)
                    {
                        RedCar.Top += move;
                    }
                }
            }
            int x = RedCar.Location.X;
            int y = RedCar.Location.Y;
            if (x < 152)
            {
               x = 153;
            }
            if (x>629)
            {
                x = 628;
            }
            if (y<0)
            {
                y = 1;
            }
            if (y>554)
            {
                y = 553;
            }
            RedCar.Location = new Point(x, y);
        }

        private void ChoseTimer_Tick(object sender, EventArgs e)
        {

            if (Mouse == true)
            {
                RedCar.Location = Control.MousePosition;
                RedCar.Top -= 135;
                RedCar.Left -= 415;
                int x = RedCar.Location.X;
                int y = RedCar.Location.Y;
                if (x < 152)
                {
                    x = 153;
                }
                if (x > 629)
                {
                    x = 628;
                }
                if (y < 0)
                {
                    y = 1;
                }
                if (y > 554)
                {
                    y = 553;
                }
                RedCar.Location = new Point(x, y);
                
            }
            for (int i = 0; i < RndCars.Length ; i++)
            {
                if (!RndCars[i].ObstacleCar&&RndCars[i].time)
                {
                    RndCars[i].Cars = new PictureBox();
                    CarsShow(RndCars[i].Cars);
                    RndCars[i].Cars.Size = new Size(80,150);
                    RndCars[i].Cars.Top = -RndCars[i].Cars.Height;
                    RndCars[i].Cars.Left = rnd.Next(147, 629);
                    RndCars[i].Cars.BackColor = Color.Transparent;
                    this.Controls.Add(RndCars[i].Cars);
                    RndCars[i].ObstacleCar = true;
                    RndCars[i].Cars.BringToFront();
                }
                else
                {
                    if (RndCars[i].time)
                    {
                        RndCars[i].Cars.Top += 2*speed;
                        if (RndCars[i].Cars.Top>100)
                        {
                            for (int m = 0; m < RndCars.Length; m++)
                            {
                                if (!RndCars[m].time)
                                {
                                    RndCars[m].time = true;
                                    break;
                                }
                            }
                        }
                        if (RndCars[i].Cars.Top >= this.Height - 20)
                        {
                            RndCars[i].Cars.Dispose();
                            RndCars[i].ObstacleCar = false;
                        }
                    }
                }


                if (RndCars[i].time)
                {
                    float AbsoluteX = Math.Abs((RedCar.Left + (RedCar.Width / 2)) - (RndCars[i].Cars.Left+(RndCars[i].Cars.Width / 2)));
                    float AbsoluteY = Math.Abs((RedCar.Top + (RedCar.Height / 2)) - (RndCars[i].Cars.Top + (RndCars[i].Cars.Height / 2)));
                    float DifWidth = (RedCar.Width / 2) + (RndCars[i].Cars.Width / 2);
                    float DifHeight = (RedCar.Height / 2) + (RndCars[i].Cars.Height / 2);
                    if (DifWidth > AbsoluteX && DifHeight > AbsoluteY)
                    {
                        Movement = false;
                        axWindowsMediaPlayer1.URL = @"music/crash.mp3";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        LinesTimer.Enabled = false;
                        ChoseTimer.Enabled = false;
                        if (Road1 > Settings1.Default.Score)
                        {
                            Settings1.Default.Score = Road1;
                            Settings1.Default.Save();
                            Score0.Text = Settings1.Default.Score.ToString();
                        }
                        Form3 frm3 = new Form3();
                        frm3.ShowDialog();
                        this.Close();
                    }

                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"music/start.M4A";
            axWindowsMediaPlayer1.Ctlcontrols.play();

            if (frm1 != null && frm1.RaceType.Checked)
            {
                RedCar.Image = LeadCar1.Image;
            }
            Score0.Text = Settings1.Default.Score.ToString();

            for (int i = 0; i < RndCars.Length; i++)
            {
                RndCars[i] = new CarChoos();
            }
            RndCars[0].time = true;
        }
        
        void Lavel()
        {

            //2. lavel
            if (Road1>125&&Road1<350)
            {
                LavelNum.Text = "2";
                if (speed1 < 100)
                    speed1++;
                LinesTimer.Interval = 125;
                ChoseTimer.Interval = 100;
                move = 16;
                if (frm1 != null && frm1.RaceType.Checked)
                {
                    RedCar.Image = BlueCar2.Image;
                }
                else
                {
                    RedCar.Image = BlackCar2.Image;
                }
            }
            //3. lavel
            else if (Road1 > 350 && Road1 < 600)
            {
                LavelNum.Text = "3";
                if (speed1 < 125)
                    speed1++;
                LinesTimer.Interval = 100;
                ChoseTimer.Interval = 75;
                move = 18;
                if (frm1 != null && frm1.RaceType.Checked)
                {
                    RedCar.Image = WhiteCar3.Image;
                }
                else
                {
                    RedCar.Image = BlackCar3.Image;
                }
            }
            //4. lavel
            else if (Road1 > 600 && Road1 < 800)
            {
                LavelNum.Text = "4";
                if (speed1 < 150)
                    speed1++;
                LinesTimer.Interval = 80;
                ChoseTimer.Interval = 50;
                move = 20;
                if (frm1 != null && frm1.RaceType.Checked)
                {
                    RedCar.Image = RedCar4.Image;
                }
                else
                {
                    RedCar.Image = Green4.Image;
                }
            }
            //5. lavel
            else if (Road1 > 800 )
            {
                LavelNum.Text = "5";
                if (speed1 < 180)
                    speed1++;
                LinesTimer.Interval = 75;
                ChoseTimer.Interval = 25;
                move = 22;
                
            }
        }

        private void Mouseoperation_Tick(object sender, EventArgs e)
        {
            
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        bool LineMove = false;
        private void LinesTimer_Tick(object sender, EventArgs e)
        {

            Road1++;
            Lavel();
            if (Road1 == 40 )
            {
                axWindowsMediaPlayer1.URL = @"music/street.mp3";
                axWindowsMediaPlayer1.Ctlcontrols.fastForward();
            }
            if (LineMove == false)
            {
                for (int i = 1; i <= 7; i++)
                {
                    this.Controls.Find("Right" + i.ToString(), true)[0].Top -= speed;
                    this.Controls.Find("Left" + i.ToString(), true)[0].Top -= speed;
                    LineMove = true;
                }
            }
            else
            {
                for (int i = 1; i <= 7; i++)
                {
                    this.Controls.Find("Right" + i.ToString(), true)[0].Top += speed;
                    this.Controls.Find("Left" + i.ToString(), true)[0].Top += speed;
                    LineMove = false;
                }
            }

            Road0.Text = Road1.ToString() + " m";
            Speed0.Text = speed1.ToString() + " km/h";
            
            

        }

        private void RedCar_Click(object sender, EventArgs e)
        {

        }
    }
}
