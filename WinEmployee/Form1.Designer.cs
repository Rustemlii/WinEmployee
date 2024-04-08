namespace WinEmployee
{
    partial class Form1
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMaaw = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cmbSahe = new ComboBox();
            cmbWobe = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            LabelSoyad = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbStatus = new ComboBox();
            label7 = new Label();
            btnElaveEt = new Button();
            label8 = new Label();
            btnAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(380, 142);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(194, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(380, 187);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(194, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtMaaw
            // 
            txtMaaw.Location = new Point(380, 457);
            txtMaaw.Name = "txtMaaw";
            txtMaaw.Size = new Size(194, 27);
            txtMaaw.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(380, 236);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // cmbSahe
            // 
            cmbSahe.FormattingEnabled = true;
            cmbSahe.Items.AddRange(new object[] { "Backend Developer", "Frontend Developer", "Fullstack Developer", "Cyber Security", "Electric", "Security", "Human Resources", "Avtomatic" });
            cmbSahe.Location = new Point(380, 362);
            cmbSahe.Name = "cmbSahe";
            cmbSahe.Size = new Size(194, 28);
            cmbSahe.TabIndex = 4;
            // 
            // cmbWobe
            // 
            cmbWobe.FormattingEnabled = true;
            cmbWobe.Items.AddRange(new object[] { "Information and Texnology", "Energetic", "Human Resources", "Security" });
            cmbWobe.Location = new Point(380, 321);
            cmbWobe.Name = "cmbWobe";
            cmbWobe.Size = new Size(194, 28);
            cmbWobe.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(380, 279);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(194, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // LabelSoyad
            // 
            LabelSoyad.AutoSize = true;
            LabelSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LabelSoyad.Location = new Point(279, 187);
            LabelSoyad.Name = "LabelSoyad";
            LabelSoyad.Size = new Size(95, 28);
            LabelSoyad.TabIndex = 4;
            LabelSoyad.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(306, 142);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(275, 234);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 4;
            label2.Text = "Birthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(297, 453);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 4;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(263, 274);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 4;
            label4.Text = "Experience";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(279, 362);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 4;
            label5.Text = "Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(249, 321);
            label6.Name = "label6";
            label6.Size = new Size(125, 28);
            label6.TabIndex = 4;
            label6.Text = "Department";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Junior", "Middle", "Senior" });
            cmbStatus.Location = new Point(380, 409);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(194, 28);
            cmbStatus.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(297, 409);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 4;
            label7.Text = "Status";
            // 
            // btnElaveEt
            // 
            btnElaveEt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnElaveEt.Location = new Point(403, 503);
            btnElaveEt.Name = "btnElaveEt";
            btnElaveEt.Size = new Size(151, 41);
            btnElaveEt.TabIndex = 8;
            btnElaveEt.Text = "Add";
            btnElaveEt.UseVisualStyleBackColor = true;
            btnElaveEt.Click += btnElaveEt_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(297, 47);
            label8.Name = "label8";
            label8.Size = new Size(321, 46);
            label8.TabIndex = 4;
            label8.Text = "Add new Employee";
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAdmin.Location = new Point(813, 545);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(144, 44);
            btnAdmin.TabIndex = 9;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(994, 614);
            Controls.Add(btnAdmin);
            Controls.Add(btnElaveEt);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LabelSoyad);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbStatus);
            Controls.Add(cmbWobe);
            Controls.Add(cmbSahe);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtMaaw);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMaaw;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbSahe;
        private ComboBox cmbWobe;
        private NumericUpDown numericUpDown1;
        private Label LabelSoyad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbStatus;
        private Label label7;
        private Button btnElaveEt;
        private Label label8;
        private Button btnAdmin;
    }
}