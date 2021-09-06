using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_s_Desk
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            patient obj = new patient();
            this.Hide();
            obj.ShowDialog();
        }

        private void all_Click(object sender, EventArgs e)
        {
            view obj = new view();
            this.Hide();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solutions obj = new solutions();
            this.Hide();
            obj.ShowDialog();
        }

        Timer time = new Timer();
        private void TIME(object sender, EventArgs e)
        {
            int H = DateTime.Now.Hour;
            int M = DateTime.Now.Minute;

            string T = "";
            string tag = "AM";

            if (H == 0)
            {
                H = 12;
                T += H;
            }
            else if (H < 10)
            {
                T += "0" + H;

            }
            if (H>9 && H < 12)
            {
                T += H;
            }
            else
            {


                if (H > 11)
                {
                    if (H == 12)
                    {
                        T += H;
                    }
                    else
                    {
                        H = H % 12;

                        T += H;
                    }

                    tag = "PM";
                }

            }
            T += " : ";
            if (M < 10)
            {
                T += "0" + M;
            }
            else
            {
                T += M;
            }

            time_lab.Text = T + " " + tag;
        }
        private void options_Load(object sender, EventArgs e)
        {
            time.Interval = 1000;

            time.Tick += new EventHandler(this.TIME);

            time.Start();
        }

        private void testbtn_Click(object sender, EventArgs e)
        {
            testreport obj = new testreport();
            this.Hide();
            obj.ShowDialog();
        }

        private void discharge_Click(object sender, EventArgs e)
        {
            dischargform obj = new dischargform();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
