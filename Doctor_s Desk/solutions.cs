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
    public partial class solutions : Form
    {

        MySqlConnection con = new MySqlConnection(softwaresettings.connection());
        public solutions()
        {
            InitializeComponent();
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

        private void back_Click(object sender, EventArgs e)
        {
            options obj = new options();
            this.Hide();
            obj.ShowDialog();
        }

        private void solutions_Load(object sender, EventArgs e)
        {
            populate();
            Solpopulate();
            testpopulate();
        }

        private void nmbut_Click(object sender, EventArgs e)
        {
            search_special(name_txbx.Text, "pname");
        }

        private void phbut_Click(object sender, EventArgs e)
        {
            search_special(name_txbx.Text, "phone");
        }
        private void prob()
        {
            string SQLL = "Select * from patient where pname='" + patientlst.Text + "'";

            DataTable pt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
            ad.Fill(pt);

                try
                {
                problemsts.MaximumSize = new Size(200, 0);
                problemsts.AutoSize = true;
                problemsts.Text = pt.Rows[0][7].ToString();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            
            con.Close();
        }

        private void patientlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnametxt.Text = patientlst.Text;
            Solpopulate();
            prob();
            testpopulate();
        }
        private string idgenerator(string m,string n)
        {
            string N = n.Length <= 3 ? n : n.Substring(0, 3);
            string M = m.Length <= 3 ? m : m.Substring(0, 3);
            return (N + " " + M);
        }
        private void add_sol()
        {
            string patientID = patientlst.SelectedValue.ToString();
            string solNAME = sol.Text;
            try
            {

                string sql = "INSERT INTO solution (`solID` ,`pID` ,`solNAME`)" +
                    "VALUES(@solID ,@pID ,@solNAME);";
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@solID", idgenerator(solNAME, patientID));
                cmd.Parameters.AddWithValue("@pID", patientID);
                cmd.Parameters.AddWithValue("@solNAME", solNAME);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Solution Added Successfull");
                Solpopulate();
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
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
        private void Solpopulate()
        {
            string SQLL = "Select * from solution where pID ='" + patientlst.SelectedValue + "'";

            DataTable st = new DataTable();
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(st);

                try
                {
                    Solutionlist.ValueMember = "solID";
                    Solutionlist.DisplayMember = "solNAME";
                    Solutionlist.DataSource = st;

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
            string message = "Do you want to add this solution ?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                add_sol();

                sol.Text = "";
            }
        }

        private void update()
        {
            string SQL = "UPDATE solution SET `solNAME` = '"+sol.Text+"' WHERE `pID` = '"+patientlst.SelectedValue+"'";
            try
            {
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = SQL;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Solution Updated Successfull");
                Solpopulate();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to update this solution ?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                update();

                sol.Text = "";
            }
        }
        private void adding_test()
        {

            string patientID = patientlst.SelectedValue.ToString();
            string report = testbox.Text;
            try
            {

                string sql = "INSERT INTO test (`pID` ,`report`)" +
                    "VALUES(@pID ,@report);";
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@pID", patientID);
                cmd.Parameters.AddWithValue("@report", report);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Test Added Successfull");
                Solpopulate();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                con.Close();
            }
        }

        private void updating_test()
        {

            string SQL = "UPDATE test SET `report` = '" + testbox.Text + "' WHERE `pID` = '" + patientlst.SelectedValue + "'";
            try
            {
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = SQL;

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Test Updated Successfull");
                Solpopulate();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                con.Close();
            }
        }

        private void add_test_Click(object sender, EventArgs e)
        {
            if (testbox.Text != "")
            {
                string message = "Do you want to add this test ?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    adding_test();

                    testbox.Text = "";
                    testpopulate();
                }
            }
            else
            {
                MessageBox.Show("Can not enter blank value");
            }
        }

        private void update_test_Click(object sender, EventArgs e)
        {
            if (testbox.Text != "")
            {
                string message = "Do you want to update this test ?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    updating_test();

                    testbox.Text = "";
                    testpopulate();
                }
            }
            else
            {
                MessageBox.Show("Can not update blank value");
            }
        }

        private void testlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SQLL = "Select * from test where pID ='" + testlst.SelectedValue + "'";

            DataTable tt = new DataTable();
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(tt);

                try
                {
                    res.Text = tt.Rows[0][2].ToString();

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
    }
}
