using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Doctor_s_Desk
{
    public partial class AdminLog : Form
    {
        MySqlConnection con = new MySqlConnection(softwaresettings.connection());
        public AdminLog()
        {
            InitializeComponent();
        }
        private void gotomain()
        {

            Main obj = new Main();
            this.Hide();
            obj.ShowDialog();
        }
        private void back_Click(object sender, EventArgs e)
        {
            gotomain();
        }
        private void add()
        {
            string NAME = admin.Text;
            string password = pass.Text;


            string sql = "INSERT INTO admin (`admin_name` ,`password`)" +
                "VALUES(@admin ,@password);";
            try
            {
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@admin", NAME);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Successfull");
                gotomain();
                
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            admin.Text = "";
            pass.Text = "";
            confirmpass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(admin.Text!="" && pass.Text == confirmpass.Text)
            {
                string message = "Do you want to add " + admin.Text + " as a new user?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    add();
                }
            }
            else
            {
                MessageBox.Show("Registration Unsuccessful please retry");
                button2_Click(sender, e);

            }
        }

        private void confirmpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (admin.Text != "" && pass.Text == confirmpass.Text)
                {
                    string message = "Do you want to add " + admin.Text + " as a new user?";
                    string title = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        add();
                    }
                }
                else
                {
                    MessageBox.Show("Registration Unsuccessful please retry");
                    button2_Click(sender, e);

                }
            }
            
        }
        private void deleteadmin()
        {
            string sql = "DELETE FROM `admin` WHERE `admin_name`='" + admin.Text+ "'";
            try
            {
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User deleted");
                admin.Text = "";
                pass.Text = "";
                confirmpass.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string message = "Do you want to delete " + admin.Text + " from user?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                deleteadmin();
            }
        }
    }
}
