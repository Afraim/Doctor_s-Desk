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
    public partial class testreport : Form
    {
        MySqlConnection con = new MySqlConnection(softwaresettings.connection());
        public testreport()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            options obj = new options();
            this.Hide();
            obj.ShowDialog();
        }

        private void nmbut_Click(object sender, EventArgs e)
        {
            string SQLL = "Select * from patient where pname = '" + name_txbx.Text + "'";

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

        private void patientpopulate()
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
        private void testreport_Load(object sender, EventArgs e)
        {
            patientpopulate();
            testpopulate();
            resultpopulate();
        }

        private void testpopulate()
        {
            string SQLL = "Select * from test where pID ='" + patientlst.SelectedValue + "'";

            DataTable tt = new DataTable();
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(tt);

                try
                {
                    testlst.ValueMember = "pID";
                    testlst.DisplayMember = "report";
                    testlst.DataSource = tt;

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
        private void resultpopulate()
        {

            string SQLL = "Select * from test where pID ='" + patientlst.SelectedValue + "'";

            DataTable tt = new DataTable();
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(tt);

                try
                {
                    testresultlst.ValueMember = "pID";
                    testresultlst.DisplayMember = "result";
                    testresultlst.DataSource = tt;

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
        private void patientlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            testpopulate();
            resultpopulate();
            name_lbl.Text = patientlst.Text;
        }

       


        private void update_result()
        {
            string SQL = "UPDATE test SET `result` = '" + resultbxb.Text + "' WHERE `pID` = '" + patientlst.SelectedValue + "'";
            try
            {
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = SQL;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Result Updated Successfull");
                resultpopulate();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to add this result ?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                update_result();
                resultbxb.Text = "";
            }
        }
    }
}
