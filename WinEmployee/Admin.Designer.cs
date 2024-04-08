namespace WinEmployee
{
    partial class Admin
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtBIrthday = new TextBox();
            txtexperience = new TextBox();
            txtPosition = new TextBox();
            txtDepartment = new TextBox();
            txtStatus = new TextBox();
            txtSalary = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSearch = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(235, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1160, 463);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAdd.Location = new Point(796, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(181, 40);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Get Employee";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDelete.Location = new Point(1005, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 40);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.Location = new Point(1227, 108);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(159, 32);
            txtSearch.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtName.Location = new Point(35, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 30);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSurname.Location = new Point(35, 157);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(152, 30);
            txtSurname.TabIndex = 1;
            // 
            // txtBIrthday
            // 
            txtBIrthday.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtBIrthday.Location = new Point(35, 226);
            txtBIrthday.Name = "txtBIrthday";
            txtBIrthday.Size = new Size(152, 30);
            txtBIrthday.TabIndex = 2;
            // 
            // txtexperience
            // 
            txtexperience.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtexperience.Location = new Point(35, 295);
            txtexperience.Name = "txtexperience";
            txtexperience.Size = new Size(152, 30);
            txtexperience.TabIndex = 3;
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtPosition.Location = new Point(3, 359);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(226, 30);
            txtPosition.TabIndex = 4;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtDepartment.Location = new Point(3, 430);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(226, 30);
            txtDepartment.TabIndex = 5;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtStatus.Location = new Point(35, 491);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(152, 30);
            txtStatus.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtSalary.Location = new Point(35, 557);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(152, 30);
            txtSalary.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Fuchsia;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdate.Location = new Point(24, 599);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 42);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(63, 126);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 11;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(63, 195);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 11;
            label3.Text = "Birthday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(47, 264);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 11;
            label4.Text = "Experience";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(63, 328);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 11;
            label5.Text = "Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(47, 399);
            label6.Name = "label6";
            label6.Size = new Size(125, 28);
            label6.TabIndex = 11;
            label6.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(75, 460);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 11;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(75, 526);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 11;
            label8.Text = "Salary";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Cyan;
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearch.Location = new Point(1218, 158);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(177, 40);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(1273, 77);
            label9.Name = "label9";
            label9.Size = new Size(68, 28);
            label9.TabIndex = 11;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(559, 9);
            label10.Name = "label10";
            label10.Size = new Size(253, 54);
            label10.TabIndex = 13;
            label10.Text = "Admin Page";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1398, 667);
            Controls.Add(label10);
            Controls.Add(btnSearch);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(txtSalary);
            Controls.Add(txtStatus);
            Controls.Add(txtDepartment);
            Controls.Add(txtPosition);
            Controls.Add(txtexperience);
            Controls.Add(txtBIrthday);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtSearch;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtBIrthday;
        private TextBox txtexperience;
        private TextBox txtPosition;
        private TextBox txtDepartment;
        private TextBox txtStatus;
        private TextBox txtSalary;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSearch;
        private Label label9;
        private Label label10;
    }
}