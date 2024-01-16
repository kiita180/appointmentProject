namespace homework
{
    partial class addPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            TxtPatientID = new TextBox();
            TxtPatientPhone = new TextBox();
            TxtPatinetName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnAdd = new Button();
            Txtaddress = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 128, 222);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 70);
            panel1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 58);
            label3.TabIndex = 7;
            label3.Text = "새 환자";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(831, 0);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(53, 70);
            button1.TabIndex = 2;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtPatientID
            // 
            TxtPatientID.Location = new Point(270, 350);
            TxtPatientID.Margin = new Padding(4, 5, 4, 5);
            TxtPatientID.Name = "TxtPatientID";
            TxtPatientID.Size = new Size(543, 31);
            TxtPatientID.TabIndex = 18;
            // 
            // TxtPatientPhone
            // 
            TxtPatientPhone.Location = new Point(270, 420);
            TxtPatientPhone.Margin = new Padding(4, 5, 4, 5);
            TxtPatientPhone.Name = "TxtPatientPhone";
            TxtPatientPhone.Size = new Size(543, 31);
            TxtPatientPhone.TabIndex = 17;
            // 
            // TxtPatinetName
            // 
            TxtPatinetName.Location = new Point(270, 292);
            TxtPatinetName.Margin = new Padding(4, 5, 4, 5);
            TxtPatinetName.Name = "TxtPatinetName";
            TxtPatinetName.Size = new Size(543, 31);
            TxtPatinetName.TabIndex = 16;
            TxtPatinetName.TextChanged += TxtPatinetName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 420);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 14;
            label4.Text = "환자 주민번호:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 353);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 13;
            label2.Text = "환자 id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 298);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 12;
            label1.Text = "새 환자 이름:";
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(12, 128, 222);
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.ForeColor = Color.White;
            BtnAdd.Location = new Point(68, 611);
            BtnAdd.Margin = new Padding(4, 5, 4, 5);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(745, 58);
            BtnAdd.TabIndex = 21;
            BtnAdd.Text = "추가";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // Txtaddress
            // 
            Txtaddress.Location = new Point(270, 484);
            Txtaddress.Margin = new Padding(4, 5, 4, 5);
            Txtaddress.Name = "Txtaddress";
            Txtaddress.Size = new Size(543, 31);
            Txtaddress.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 484);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 23;
            label5.Text = "환자 집주소:";
            // 
            // addPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 915);
            Controls.Add(Txtaddress);
            Controls.Add(label5);
            Controls.Add(BtnAdd);
            Controls.Add(panel1);
            Controls.Add(TxtPatientID);
            Controls.Add(TxtPatientPhone);
            Controls.Add(TxtPatinetName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "addPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addPatient";
            Load += addPatiend_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label2;
        private Label label1;
        public Button BtnAdd;
        public TextBox TxtPatientID;
        public TextBox TxtPatientPhone;
        public TextBox TxtPatinetName;
        public TextBox Txtaddress;
        private Label label5;
    }
}