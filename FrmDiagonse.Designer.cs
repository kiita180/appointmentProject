namespace homework
{
    partial class FrmDiagonse
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
            DgvDiagonse = new DataGridView();
            autoID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Patient_idnum = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ColEdit = new DataGridViewButtonColumn();
            panel1 = new Panel();
            Btnadd = new Button();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvDiagonse).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvDiagonse
            // 
            DgvDiagonse.AllowUserToAddRows = false;
            DgvDiagonse.AllowUserToDeleteRows = false;
            DgvDiagonse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 128, 222);
            dataGridViewCellStyle1.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvDiagonse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvDiagonse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDiagonse.Columns.AddRange(new DataGridViewColumn[] { autoID, Column2, Column3, Patient_idnum, address, Column6, ColEdit });
            DgvDiagonse.Dock = DockStyle.Fill;
            DgvDiagonse.EnableHeadersVisualStyles = false;
            DgvDiagonse.Location = new Point(0, 70);
            DgvDiagonse.Margin = new Padding(4, 5, 4, 5);
            DgvDiagonse.Name = "DgvDiagonse";
            DgvDiagonse.ReadOnly = true;
            DgvDiagonse.RowHeadersVisible = false;
            DgvDiagonse.RowHeadersWidth = 62;
            DgvDiagonse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDiagonse.Size = new Size(1468, 701);
            DgvDiagonse.TabIndex = 4;
            DgvDiagonse.CellClick += DgvDiagonse_CellClick;
            DgvDiagonse.CellContentClick += DgvDiagonse_CellContentClick;
            DgvDiagonse.Resize += DgvPatient_Resize;
            // 
            // autoID
            // 
            autoID.HeaderText = "";
            autoID.MinimumWidth = 8;
            autoID.Name = "autoID";
            autoID.ReadOnly = true;
            autoID.Visible = false;
            autoID.Width = 1000;
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
            Column3.Width = 127;
            // 
            // Patient_idnum
            // 
            Patient_idnum.HeaderText = "Patiend IdNum";
            Patient_idnum.MinimumWidth = 8;
            Patient_idnum.Name = "Patient_idnum";
            Patient_idnum.ReadOnly = true;
            Patient_idnum.Width = 170;
            // 
            // address
            // 
            address.HeaderText = "Patient_address";
            address.MinimumWidth = 8;
            address.Name = "address";
            address.ReadOnly = true;
            address.Width = 174;
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
            panel1.Size = new Size(1468, 70);
            panel1.TabIndex = 3;
            panel1.Resize += DgvPatient_Resize;
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
            Btnadd.Text = "Create New Diagnse";
            Btnadd.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 58);
            label3.TabIndex = 7;
            label3.Text = "Diagonse";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(1415, 0);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(53, 70);
            button1.TabIndex = 2;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmDiagonse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 771);
            Controls.Add(DgvDiagonse);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDiagonse";
            Text = "FrmDiagonse";
            ((System.ComponentModel.ISupportInitialize)DgvDiagonse).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvDiagonse;
        private DataGridViewTextBoxColumn autoID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Patient_idnum;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn ColEdit;
        private Panel panel1;
        private Button Btnadd;
        private Label label3;
        private Button button1;
    }
}