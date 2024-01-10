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
            c = new Button();
            label3 = new Label();
            button1 = new Button();
            DgvPatient = new DataGridView();
            autoID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ColEdit = new DataGridViewButtonColumn();
            ColDelete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvPatient).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 128, 222);
            panel1.Controls.Add(c);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2485, 70);
            panel1.TabIndex = 1;
            // 
            // c
            // 
            c.BackColor = Color.FromArgb(12, 128, 222);
            c.FlatStyle = FlatStyle.Flat;
            c.ForeColor = Color.White;
            c.Location = new Point(639, 2);
            c.Margin = new Padding(4, 5, 4, 5);
            c.Name = "c";
            c.Size = new Size(380, 58);
            c.TabIndex = 21;
            c.Text = "Create New Patient";
            c.UseVisualStyleBackColor = false;
            c.Click += c_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 58);
            label3.TabIndex = 7;
            label3.Text = "Patient";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 128, 222);
            dataGridViewCellStyle1.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPatient.Columns.AddRange(new DataGridViewColumn[] { autoID, Column2, Column3, Column4, Column6, ColEdit, ColDelete });
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
            autoID.Width = 150;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Patient Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Patient ID";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Patiend IdNum";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Patient appointment";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            Column6.Width = 150;
            // 
            // ColEdit
            // 
            ColEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColEdit.HeaderText = "Edit";
            ColEdit.MinimumWidth = 8;
            ColEdit.Name = "ColEdit";
            ColEdit.ReadOnly = true;
            ColEdit.Width = 48;
            // 
            // ColDelete
            // 
            ColDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColDelete.HeaderText = "Delete";
            ColDelete.MinimumWidth = 8;
            ColDelete.Name = "ColDelete";
            ColDelete.ReadOnly = true;
            ColDelete.Width = 71;
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
        private Button c;
        private DataGridView DgvPatient;
        private DataGridViewTextBoxColumn autoID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn ColEdit;
        private DataGridViewButtonColumn ColDelete;
    }
}