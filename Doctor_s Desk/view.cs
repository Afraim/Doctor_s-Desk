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
    public partial class view : Form
    {
        MySqlConnection con = new MySqlConnection(softwaresettings.connection());
        public view()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            options obj = new options();
            this.Hide();
            obj.ShowDialog();
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
        private void view_Load(object sender, EventArgs e)
            {
                populate();
            }

        private void patientlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            id.Text = patientlst.SelectedValue.ToString();
            nm.Text = patientlst.Text;
            addrs.MaximumSize = new Size(100, 0);
            addrs.AutoSize = true;
            string SQLL = "Select * from patient where pname='"+nm.Text+"'";

            DataTable pt = new DataTable();
            try
            {
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(pt);

                try
                {
                    phn.Text = pt.Rows[0][2].ToString();
                    ag.Text= pt.Rows[0][3].ToString();
                    sx.Text= pt.Rows[0][4].ToString();
                    addrs.Text= pt.Rows[0][5].ToString();
                    bp.Text= pt.Rows[0][6].ToString();
                    pb.Text= pt.Rows[0][7].ToString();
                   
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

        private void num_press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void search_special(string word,string name)
        {
            string SQLL = "Select * from patient where "+name+" like '%"+word+"%'";

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

        private void nmbut_Click(object sender, EventArgs e)
        {
            search_special(name_txbx.Text, "pname");
        }

        private void phbut_Click(object sender, EventArgs e)
        {
            search_special(phone_txbx.Text, "phone");
        }
    }
}

