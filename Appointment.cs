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
        Form1 f = new Form1();
        public Appointment(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}
