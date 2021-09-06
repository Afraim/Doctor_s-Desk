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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(softwaresettings.connection());

        private void exit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to EXIT?";
            string title = "EXIT";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
            else
            {
                // Do something  
            }
           
        }
        private void loginchk()
        {
            try
            {

                string SQL = "Select admin_name , password FROM admin where admin_name = '" + user.Text + "' AND password = '" + pass.Text + "'";
                MySqlCommand command = new MySqlCommand(SQL, con);
                MySqlDataReader reader;

                try
                {
                    con.Open();
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        
                        options obj = new options();
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("!User Unauthorized!","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                    con.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (user.Text != "" && pass.Text != "")
                {
                    if (user.Text == "admin" && pass.Text == "admin")
                    {
                        AdminLog obj = new AdminLog();
                        this.Hide();
                        obj.ShowDialog();
                    }
                    else
                    {
                        loginchk();
                    }
                }
                else
                {
                    MessageBox.Show("Cannot leave User name or Password box empty!!!");
                }
            }
        }


        private void login_button(object sender, EventArgs e)
        {
            if (user.Text != "" && pass.Text != "")
            {
                if(user.Text=="admin" && pass.Text == "admin")
                {
                    AdminLog obj = new AdminLog();
                    this.Hide();
                    obj.ShowDialog();
                }
                else
                {
                    loginchk();
                }
            }
            else
            {
                MessageBox.Show("Cannot leave User name or Password box empty!!!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
