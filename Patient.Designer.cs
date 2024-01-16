namespace homework
{
    partial class Patient
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Btnadd = new Button();
            label3 = new Label();
            button1 = new Button();
            DgvPatient = new DataGridView();
            autoID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Patient_idnum = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPatient).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 128, 222);
            panel1.Controls.Add(Btnadd);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2485, 70);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // Btnadd
            // 
            Btnadd.BackColor = Color.FromArgb(12, 128, 222);
            Btnadd.FlatStyle = FlatStyle.Flat;
            Btnadd.ForeColor = Color.White;
            Btnadd.Location = new Point(639, 2);
            Btnadd.Margin = new Padding(4, 5, 4, 5);
            Btnadd.Name = "Btnadd";
            Btnadd.Size = new Size(380, 58);
            Btnadd.TabIndex = 21;
            Btnadd.Text = "새 환자 예약";
            Btnadd.UseVisualStyleBackColor = false;
            Btnadd.Click += c_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(51, 7);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 58);
            label3.TabIndex = 7;
            label3.Text = "환자";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(2432, 0);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(53, 70);
            button1.TabIndex = 2;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DgvPatient
            // 
            DgvPatient.AllowUserToAddRows = false;
            DgvPatient.AllowUserToDeleteRows = false;
            DgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 128, 222);
            dataGridViewCellStyle1.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPatient.Columns.AddRange(new DataGridViewColumn[] { autoID, Column2, Column3, Patient_idnum, address, Column6 });
            DgvPatient.Dock = DockStyle.Fill;
            DgvPatient.EnableHeadersVisualStyles = false;
            DgvPatient.Location = new Point(0, 70);
            DgvPatient.Margin = new Padding(4, 5, 4, 5);
            DgvPatient.Name = "DgvPatient";
            DgvPatient.ReadOnly = true;
            DgvPatient.RowHeadersVisible = false;
            DgvPatient.RowHeadersWidth = 62;
            DgvPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPatient.Size = new Size(2485, 1370);
            DgvPatient.TabIndex = 2;
            DgvPatient.CellClick += DgvPatient_CellClick;
            DgvPatient.CellContentClick += DgvPatient_CellContentClick_1;
            // 
            // autoID
            // 
            autoID.HeaderText = "";
            autoID.MinimumWidth = 8;
            autoID.Name = "autoID";
            autoID.ReadOnly = true;
            autoID.Visible = false;
            autoID.Width = 8;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "환자 이름";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "환자 ID";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 108;
            // 
            // Patient_idnum
            // 
            Patient_idnum.HeaderText = "환자 주민번호";
            Patient_idnum.MinimumWidth = 8;
            Patient_idnum.Name = "Patient_idnum";
            Patient_idnum.ReadOnly = true;
            Patient_idnum.Width = 162;
            // 
            // address
            // 
            address.HeaderText = "환자 주소";
            address.MinimumWidth = 8;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 126;
            // 
            // Column6
            // 
            Column6.HeaderText = "Patient appointment";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            Column6.Width = 213;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2485, 1440);
            Controls.Add(DgvPatient);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "v";
            WindowState = FormWindowState.Maximized;
            Load += Patient_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPatient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button button1;
        private Button Btnadd;
        private DataGridView DgvPatient;
        private DataGridViewTextBoxColumn autoID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Patient_idnum;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn Column6;
    }
}