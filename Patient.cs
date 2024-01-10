using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.Common;
namespace homework
{

    public partial class Patient : Form
    {
        static String SqlConn = "Server=localhost;Port=3306; Database=appointment;Uid=root;Pwd=1234";
        MySqlConnection cn = new MySqlConnection(SqlConn);
        MySqlCommand cm;
        MySqlDataReader dr;
        Form1 f = new Form1();
        public Patient(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            LoadPatient();
        }
        public void LoadPatient()
        {
            int i = 1;
            DgvPatient.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from Patient", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                DgvPatient.Rows.Add(i, dr["Patient_name"], dr["Patient_id"], dr["Patient_Idnum"], "Edit", "Edit", "Delete", "Delete");
            }
            cn.Close();
        }
        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Dispose();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void c_Click(object sender, EventArgs e)
        {

        }

        private void c_Click_1(object sender, EventArgs e)
        {
            addPatient f = new addPatient(this);
            f.ShowDialog();
        }

        private void DgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvPatient_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = DgvPatient.Columns[e.ColumnIndex].Name;
            if (ColName == "ColEdit")
            {
                db._id = (int)DgvPatient.CurrentRow.Cells[0].Value;
                addPatient f = new addPatient(this);
                f.TxtPatinetName.Text = DgvPatient.CurrentRow.Cells[2].Value.ToString();
                f.TxtPatientID.Text = DgvPatient.CurrentRow.Cells[3].Value.ToString();
                f.TxtPatientPhone.Text = DgvPatient.CurrentRow.Cells[4].Value.ToString();
                f.BtnAdd.Enabled = false;
                f.BtnUpdate.Enabled = true;
                //f.IbI
                f.ShowDialog();
            }
            if(ColName == "ColDelete" )
            {
                cm = new MySqlCommand("select * from Patient", cn);
                cm.Parameters.AddWithValue("@Patient_idnum", db._id);
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been Delete successfully");
                LoadPatient();
            }
        }



        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
