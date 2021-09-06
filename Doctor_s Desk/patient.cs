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
    public partial class patient : Form
    {
       
        MySqlConnection con = new MySqlConnection(softwaresettings.connection());
        public patient()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            options obj = new options();
            this.Hide();
            obj.ShowDialog();
        }
        private string idgenerator(string name,string phone)
        {
            string n = name.Length <= 3 ? name : name.Substring(0, 3);
            string m = phone.Length <= 3 ? phone : phone.Substring(0, 3);
            string id = m+n;
            return id;
        }
        private void insertdata()
        {
            string name, phone, age, sex, address, BP, Problem;
                
            name = pName.Text;
            phone = Pphone.Text;
            age = agetext.Value.ToString();
            sex = sextxt.Text;
            address = adrstxt.Text;
            BP = bp1.Value.ToString() + "/" + bp2.Value.ToString();
            Problem = prob.Text;

            try
            {

                string sql = "INSERT INTO patient (`pID` ,`pname` ,`phone`,`age`,`sex`,`address`,`BP`,`problem`)" +
                    "VALUES(@pID ,@pname ,@phone,@age,@sex,@address,@BP,@problem);";
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@pID", idgenerator(name, phone));
                cmd.Parameters.AddWithValue("@pname", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@BP", BP);
                cmd.Parameters.AddWithValue("@problem", Problem);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Patient Added Successfull");
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }

            searchlist();


        }

        private void num_only(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void searchlist()
        {
            string SQLL = "Select pID, pname from patient where pname like '%"+textBox1.Text+"%'";
            
            DataTable pt = new DataTable();
            try
            {
                con.Open();
                MySqlDataAdapter ad = new MySqlDataAdapter(SQLL, con);
                ad.Fill(pt);

                try
                {
                    patientlist.ValueMember = "pID";
                    patientlist.DisplayMember = "pname";
                    patientlist.DataSource = pt;
                    con.Close();
                }catch(Exception x)
                {
                    MessageBox.Show(x.Message);                    
                }

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchlist();

            textBox1.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            string message = "Do you want to add "+pName.Text+" as a new patient?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                insertdata();
                button1_Click_1(sender,e);
                searchlist();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pName.Text = "";
            Pphone.Text = "";
            agetext.Value = 1;
            sextxt.Text = "Other";
            adrstxt.Text = "";
            bp1.Value = 1;
            bp2.Value = 1;
            prob.Text = "";
        }

        private void key_p(object sender, KeyPressEventArgs e)
        {
            searchlist();
        }

        private void patient_Load(object sender, EventArgs e)
        {
            searchlist();
        }
    }
}
