namespace homework
{
    partial class Appointment
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
            Dgvappointment = new DataGridView();
            autoID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Patient_idnum = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ColEdit = new DataGridViewButtonColumn();
            panel2 = new Panel();
            Btnadd = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgvappointment).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Dgvappointment
            // 
            Dgvappointment.AllowUserToAddRows = false;
            Dgvappointment.AllowUserToDeleteRows = false;
            Dgvappointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 128, 222);
            dataGridViewCellStyle1.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Dgvappointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Dgvappointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgvappointment.Columns.AddRange(new DataGridViewColumn[] { autoID, Column2, Column3, Patient_idnum, address, Column6, ColEdit });
            Dgvappointment.Dock = DockStyle.Fill;
            Dgvappointment.EnableHeadersVisualStyles = false;
            Dgvappointment.Location = new Point(0, 70);
            Dgvappointment.Margin = new Padding(4, 5, 4, 5);
            Dgvappointment.Name = "Dgvappointment";
            Dgvappointment.ReadOnly = true;
            Dgvappointment.RowHeadersVisible = false;
            Dgvappointment.RowHeadersWidth = 62;
            Dgvappointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgvappointment.Size = new Size(1634, 1128);
            Dgvappointment.TabIndex = 4;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 128, 222);
            panel2.Controls.Add(Btnadd);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1634, 70);
            panel2.TabIndex = 3;
            // 
            // Btnadd
            // 
            Btnadd.BackColor = Color.FromArgb(12, 128, 222);
            Btnadd.FlatStyle = FlatStyle.Flat;
            Btnadd.ForeColor = Color.White;
            Btnadd.Location = new Point(642, 7);
            Btnadd.Margin = new Padding(4, 5, 4, 5);
            Btnadd.Name = "Btnadd";
            Btnadd.Size = new Size(380, 58);
            Btnadd.TabIndex = 21;
            Btnadd.Text = "Create New Patient";
            Btnadd.UseVisualStyleBackColor = false;
            Btnadd.Click += Btnadd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 58);
            label1.TabIndex = 7;
            label1.Text = "Patient";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(1581, 0);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(53, 70);
            button2.TabIndex = 2;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 1198);
            Controls.Add(Dgvappointment);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Appointment";
            Text = "Appointment";
            WindowState = FormWindowState.Maximized;
            Load += Appointment_Load;
            ((System.ComponentModel.ISupportInitialize)Dgvappointment).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Dgvappointment;
        private DataGridViewTextBoxColumn autoID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Patient_idnum;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn ColEdit;
        private Panel panel2;
        private Button Btnadd;
        private Label label1;
        private Button button2;
    }
}