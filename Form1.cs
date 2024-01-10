namespace homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //Ÿ�̸� ���� 100ms
            timer1.Start();  //Ÿ�̸� ����   
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
           
            IBLDATA.Text = DateTime.Now.ToString("F"); // label1�� ���糯¥�ð� ǥ��, F:�ڼ��� ��ü ��¥/��
        }

        private void IBLDATA_Click(object sender, EventArgs e)
        {

        }
    }
}
