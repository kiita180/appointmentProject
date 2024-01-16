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
namespace homework
{
    public partial class addPatient : Form
    {
        static String SqlConn = "Server=localhost;Port=3306; Database=appointment;Uid=root;Pwd=1234;allow user variables=true;";
        MySqlConnection conn = new MySqlConnection(SqlConn);
        MySqlCommand cm;
        //Patient f = new Patient();
        public addPatient(Patient f)
        {
            InitializeComponent();
            //this.f = f;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            cm = new MySqlCommand("insert into patient (Patient_name,Patient_id,Patient_idnum,Patient_address) value (@Patient_name,@Patient_id,@Patient_idnum,@Patient_address)", conn);
            MemoryStream ms = new MemoryStream();
            byte[] img = ms.ToArray();
            cm.Parameters.AddWithValue("@Patient_name", TxtPatinetName.Text);
            cm.Parameters.AddWithValue("@Patient_id", TxtPatientID.Text);
            cm.Parameters.AddWithValue("@Patient_idnum", TxtPatientPhone.Text);
            cm.Parameters.AddWithValue("@Patient_address", Txtaddress.Text);
            cm.ExecuteNonQuery();
            conn.Close();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            //f.LoadPatient();
            MessageBox.Show("Record has been saved successfully");
            Form1 f = new Form1();
            f.Loadpatient();
        }

        private void addPatiend_Load(object sender, EventArgs e)
        {

        }

        private void TxtPatinetName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
