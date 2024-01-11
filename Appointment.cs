using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace homework
{
    public partial class Appointment : Form
    {
        static String SqlConn = "Server=localhost;Port=3306; Database=appointment;Uid=root;Pwd=1234";
        MySqlConnection cn = new MySqlConnection(SqlConn);
        MySqlCommand cm;
        MySqlDataReader dr;

        Form1 f = new Form1();
        public Appointment(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            LoadPatient();
        }
        public void LoadPatient()
        {
            int i = 1;
            Dgvappointment.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from Patient", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Dgvappointment.Rows.Add(i, dr["Patient_name"], dr["Patient_id"], dr["Patient_Idnum"], "Edit", "Edit", "Edit", "Edit");
            }
            cn.Close();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new MySqlCommand("update patient set Patient_appointment='appointment'where idnum=@idnum", cn);
            cm.Parameters.AddWithValue("@idnum", Dgvappointment.CurrentRow.Cells[0].Value);
            cn.Close();
            MessageBox.Show("appointment has been successfully");
        }
    }
}
