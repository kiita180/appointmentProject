using MySql.Data.MySqlClient;
namespace homework
{
    public partial class Form1 : Form
    {

        MySqlConnection cn = new MySqlConnection(db.cn);
        MySqlCommand cm;
        MySqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            Loadpatient();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Width = width;
            this.Height = height;
            Top = 0;
            Left = 0;


        }
        public void Loadpatient()
        {

            cn.Open();
            int i = 0;
            cm = new MySqlCommand("select * from patient", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
            }

            dr.Close();
            cn.Close();
            LbIPatient.Text = i.ToString();
            //LbIPatient.Text=cm.ExecuteScalar().ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();  //타이머 시작   
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Patient p = new Patient(this);
            p.TopLevel = false;
            panmain.Controls.Add(p);
            p.BringToFront();
            p.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient p = new Patient(this);
            p.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            IBLDATA.Text = DateTime.Now.ToString("F"); // label1에 현재날짜시간 표시, F:자세한 전체 날짜/시
            Loadpatient();
        }

        private void IBLDATA_Click(object sender, EventArgs e)
        {

        }
    }
}
