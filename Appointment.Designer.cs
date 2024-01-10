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
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 46);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(208, 39);
            label3.TabIndex = 7;
            label3.Text = "Appointment";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(1107, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 46);
            button1.TabIndex = 2;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 719);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Appointment";
            Text = "Appointment";
            WindowState = FormWindowState.Maximized;
            Load += Appointment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private Label label3;
        private Button button1;
    }
}