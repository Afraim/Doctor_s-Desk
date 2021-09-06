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
    public partial class dischargform : Form
    {
        MySqlConnection con = new MySqlConnection(softwaresettings.connection());
        public dischargform()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            options obj = new options();
            this.Hide();
            obj.ShowDialog();
        }

        private void search_special(string word, string name)
        {
            string SQLL = "Select * from patient where " + name + " like '%" + word + "%'";

            DataTable pt = new DataTable();
            try
            {
                con.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(pt);

                try
                {
                    patientlst.ValueMember = "pID";
                    patientlst.DisplayMember = "pname";
                    patientlst.DataSource = pt;

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
            con.Close();
        }

        

        private void populate()
        {
            string SQLL = "Select * from patient ";

            DataTable pt = new DataTable();
            try
            {
                con.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(pt);

                try
                {
                    patientlst.ValueMember = "pID";
                    patientlst.DisplayMember = "pname";
                    patientlst.DataSource = pt;

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
       
        private void dischargform_Load(object sender, EventArgs e)
        {
            populate();
        }
        
        private void patientlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                report();
            }
            catch
            {

            }
            try { con.Close(); }catch{ }
        }

        private void name_txbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            search_special(name_txbx.Text, "pname");
        }
        private void deletepatient()
        {
            string sql = "DELETE FROM `patient` WHERE `pID`='"+patientlst.SelectedValue+"'";
            try
            {
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Patient deleted");
                populate();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void report()
        {
            string SQLL = "Select `pname`,`phone`,`problem`,`solNAME` from patient inner join solution on `patient`.`pID`=`solution`.`pID` where `patient`.`pID`='" + patientlst.SelectedValue + "'";

            DataTable pt = new DataTable();
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(pt);

                try
                {
                    string name = pt.Rows[0][0].ToString();
                    string phone = pt.Rows[0][1].ToString();
                    string problem = pt.Rows[0][2].ToString();
                    string solution = pt.Rows[0][3].ToString();

                    reportbox.Clear();
                    reportbox.AppendText("\n\t\t\t Final Report\n");
                    reportbox.AppendText("=======================================================");
                    reportbox.AppendText("\nPatient's Name        :\t\t\t" + name);
                    reportbox.AppendText("\nPatient's Phone       :\t\t\t" + phone);
                    reportbox.AppendText("\nPatient's Problem    :\t\t\t" + problem);
                    reportbox.AppendText("\nPatient's Solution    :\t\t\t" + solution);
                    reportbox.AppendText("\n\n\n For the test report please contact the lab\n");
                    reportbox.AppendText("\n\n\n\t\t\t This report was conducted by \"Doctor's Dest\" \n");





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
            con.Close();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Discharge \""+patientlst.Text+"\" ?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                deletepatient();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                string message = "Do you want to Print this report?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    DocumentDialog.ShowDialog();

                }

            } 
            catch(Exception x) { MessageBox.Show(x.Message); }
            
        }

        private void printing(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(reportbox.Text, new Font("Arial", 12), Brushes.Black, new Point(0, 0));
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
