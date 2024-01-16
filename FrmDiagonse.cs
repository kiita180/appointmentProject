using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace homework
{
    public partial class FrmDiagonse : Form
    {
        static String SqlConn = "Server=localhost;Port=3306; Database=appointment;Uid=root;Pwd=1234";
        MySqlConnection cn = new MySqlConnection(SqlConn);
        MySqlCommand cm;
        MySqlDataReader dr;
        public FrmDiagonse()
        {
            InitializeComponent();
        }

        private void DgvPatient_Resize(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Width = width;
            this.Height = height;
            Top = 0;
            Left = 0;
        }
        public void LoadPatient()
        {
           
            //DgvDiagonse.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from Patient where patient_appointment='appointment'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                DgvDiagonse.Rows.Add(dr["Patient_name"], dr["Patient_id"], dr["Patient_Idnum"], "Edit", "Edit", "Edit", "Edit");
            }
            cn.Close();
        }

        private void DgvDiagonse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvDiagonse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
