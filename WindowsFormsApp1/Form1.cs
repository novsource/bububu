using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Space> spaceObjects = new List<Space>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.spaceObjects.Clear();

            var rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                switch (rand.Next() % 3)
                {
                    case 0:
                        this.spaceObjects.Add(Planet.Generation());
                        break;
                    case 1:
                        this.spaceObjects.Add(Star.Generation());
                        break;
                    case 2:
                        this.spaceObjects.Add(Comet.Generation());
                        break;
                }
            }
            ShowInfo();
            ShowTurn();
        }

        private void ShowInfo()
        {
            txtCountPlanets.Text = "";
            txtCountStars.Text = "";
            txtCountComets.Text = "";

            int PlanetsCount = 0;
            int StarsCount = 0;
            int CometsCount = 0;

            foreach (var objects in this.spaceObjects)
            {
                if (objects is Planet)
                {
                    PlanetsCount += 1;
                }
                else if (objects is Star)
                {
                    StarsCount += 1;
                }
                else if (objects is Comet)
                {
                    CometsCount += 1;
                }
            }
            txtCountPlanets.Text += String.Format("{0}", PlanetsCount);
            txtCountStars.Text += String.Format("{0}", StarsCount);
            txtCountComets.Text += String.Format("{0}", CometsCount);
        }

        public void ShowTurn()
        {
            CheckTurn();
            Button button = new Button();
            if (spaceObjects.Count == 2)
            {
                button5.Text = "Пустая ячейка";
                button5.Image = null;
                return;
            }
            if (spaceObjects.Count == 1)
            {
                button4.Text = "Пустая ячейка";
                button4.Image = null;
                return;
            }
            if (spaceObjects.Count == 0)
            {
                button3.Text = "Пустая ячейка";
                button3.Image = null;
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                if (spaceObjects[i] is Planet)
                {
                    button.Text = "Планета";
                    button.Image = Properties.Resources.Planet;
                }
                else if (spaceObjects[i] is Star)
                {
                    button.Text = "Звезда";
                    button.Image = Properties.Resources.Star;
                }
                else if (spaceObjects[i] is Comet)
                {
                    button.Text = "Комета";
                    button.Image = Properties.Resources.Comet;
                }
                button3.Text = button4.Text;
                button3.Image = button4.Image;
                button4.Text = button5.Text;
                button4.Image = button5.Image;
                button5.Text = button.Text;
                button5.Image = button.Image;
            }
        }

        public void CheckTurn()
        {
            Button button = new Button();
            if (button3.Text == "Пустая ячейка" && button4.Text == button3.Text && spaceObjects.Count != 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (spaceObjects[i] is Planet)
                    {
                        button.Text = "Планета";
                        button.Image = Properties.Resources.Planet;
                    }
                    else if (spaceObjects[i] is Star)
                    {
                        button.Text = "Звезда";
                        button.Image = Properties.Resources.Star;
                    }
                    else if (spaceObjects[i] is Comet)
                    {
                        button.Text = "Комета";
                        button.Image = Properties.Resources.Comet;
                    }
                    if (i == 0)
                    {
                        button3.Text = button.Text;
                        button3.Image = button.Image;
                    }
                    else if (i == 1)
                    {
                        button4.Text = button.Text;
                        button4.Image = button.Image;
                    }
                    else if (i == 2)
                    {
                        button5.Text = button.Text;
                        button5.Image = button.Image;
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormInTrayButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private int x = 0; private int y = 0;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (spaceObjects.Count == 0)
            {
                txtAboutObject.Text = "No Object";
                pictureBox4.Image = null;
                return;
            }

            var spaceObject = this.spaceObjects[0];

            PictureObjectNow();

            this.spaceObjects.RemoveAt(0);
          
            txtAboutObject.Text = spaceObject.GetInfo();
         
            ShowInfo();
            ShowTurn();
        }

        private void PictureObjectNow()
        {
            var spaceObject = this.spaceObjects[0];

            if (spaceObject is Planet)
            {
                pictureBox4.Image = Properties.Resources.Planet;
            }
            else if (spaceObject is Star)
            {
                pictureBox4.Image = Properties.Resources.Star;
            }
            else if (spaceObject is Comet)
            {
                pictureBox4.Image = Properties.Resources.Comet;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Paint(object sender, EventArgs e)
        {
        }


    }
}

