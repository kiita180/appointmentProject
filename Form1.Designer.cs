namespace homework
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button6 = new Button();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            c = new Button();
            panel10 = new Panel();
            IBLDATA = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panmain = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            label5 = new Label();
            panel11 = new Panel();
            LbIPatient = new Label();
            label4 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panmain.SuspendLayout();
            panel5.SuspendLayout();
            panel11.SuspendLayout();
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
            panel1.Size = new Size(1881, 57);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 58);
            label3.TabIndex = 7;
            label3.Text = "A.S";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(1828, 0);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(53, 57);
            button1.TabIndex = 2;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 67, 115);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 57);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 1133);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(129, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 58);
            label2.TabIndex = 6;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 58);
            label1.TabIndex = 5;
            label1.Text = "Appointment";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(7, 67, 115);
            button6.Dock = DockStyle.Bottom;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 1048);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(323, 85);
            button6.TabIndex = 4;
            button6.Text = "ABOUT US";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(c);
            panel3.Location = new Point(26, 190);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 577);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(12, 128, 222);
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 255);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(297, 85);
            button5.TabIndex = 3;
            button5.Text = "USER";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(12, 128, 222);
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 170);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(297, 85);
            button4.TabIndex = 2;
            button4.Text = "APPOINTMENT";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(12, 128, 222);
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 85);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(297, 85);
            button3.TabIndex = 1;
            button3.Text = "NEW PATIENT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // c
            // 
            c.BackColor = Color.FromArgb(12, 128, 222);
            c.Dock = DockStyle.Top;
            c.FlatStyle = FlatStyle.Flat;
            c.ForeColor = Color.White;
            c.Location = new Point(0, 0);
            c.Margin = new Padding(4, 5, 4, 5);
            c.Name = "c";
            c.Size = new Size(297, 85);
            c.TabIndex = 0;
            c.Text = "DashBoard";
            c.UseVisualStyleBackColor = false;
            c.Click += button2_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(12, 128, 222);
            panel10.Controls.Add(IBLDATA);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(323, 1105);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(1558, 85);
            panel10.TabIndex = 5;
            // 
            // IBLDATA
            // 
            IBLDATA.AutoSize = true;
            IBLDATA.Font = new Font("Microsoft Sans Serif", 25F);
            IBLDATA.ForeColor = Color.Yellow;
            IBLDATA.Location = new Point(31, 20);
            IBLDATA.Margin = new Padding(4, 0, 4, 0);
            IBLDATA.Name = "IBLDATA";
            IBLDATA.Size = new Size(307, 58);
            IBLDATA.TabIndex = 6;
            IBLDATA.Text = "Appointment";
            IBLDATA.Click += IBLDATA_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panmain
            // 
            panmain.BackgroundImageLayout = ImageLayout.Center;
            panmain.BorderStyle = BorderStyle.FixedSingle;
            panmain.Controls.Add(panel7);
            panmain.Controls.Add(panel8);
            panmain.Controls.Add(panel9);
            panmain.Controls.Add(panel6);
            panmain.Controls.Add(panel5);
            panmain.Controls.Add(panel11);
            panmain.Location = new Point(354, 87);
            panmain.Margin = new Padding(4, 5, 4, 5);
            panmain.Name = "panmain";
            panmain.Size = new Size(1421, 967);
            panmain.TabIndex = 6;
            panmain.Paint += panel4_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(50, 50, 50);
            panel7.Location = new Point(783, 450);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(310, 212);
            panel7.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(12, 128, 222);
            panel8.Location = new Point(401, 202);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(310, 212);
            panel8.TabIndex = 13;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(212, 47, 43);
            panel9.Location = new Point(783, 202);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(310, 212);
            panel9.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(12, 128, 222);
            panel6.Location = new Point(401, 450);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(310, 212);
            panel6.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(212, 47, 43);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(27, 450);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(310, 212);
            panel5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15F);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(197, 145);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 36);
            label7.TabIndex = 9;
            label7.Text = "00";
            label7.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(4, 17);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(244, 36);
            label5.TabIndex = 8;
            label5.Text = "TOTAL DOCTOC";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(202, 81, 0);
            panel11.Controls.Add(LbIPatient);
            panel11.Controls.Add(label4);
            panel11.Location = new Point(27, 202);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(310, 212);
            panel11.TabIndex = 11;
            // 
            // LbIPatient
            // 
            LbIPatient.AutoSize = true;
            LbIPatient.Font = new Font("Microsoft Sans Serif", 15F);
            LbIPatient.ForeColor = Color.Yellow;
            LbIPatient.Location = new Point(203, 153);
            LbIPatient.Margin = new Padding(4, 0, 4, 0);
            LbIPatient.Name = "LbIPatient";
            LbIPatient.Size = new Size(49, 36);
            LbIPatient.TabIndex = 8;
            LbIPatient.Text = "00";
            LbIPatient.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(4, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(246, 36);
            label4.TabIndex = 7;
            label4.Text = "TOTAL PATIENT";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1881, 1190);
            Controls.Add(panmain);
            Controls.Add(panel10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panmain.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button c;
        private Button button6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel10;
        private Label IBLDATA;
        private System.Windows.Forms.Timer timer1;
        private Panel panmain;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel6;
        private Panel panel5;
        private Label label7;
        private Label label5;
        private Panel panel11;
        private Label LbIPatient;
        private Label label4;
        public Panel panel1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
