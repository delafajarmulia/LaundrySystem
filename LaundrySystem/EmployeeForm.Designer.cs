namespace LaundrySystem
{
    partial class EmployeeForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblTime = new Label();
            lblHay = new Label();
            btnLogOut = new Button();
            dataGridView1 = new DataGridView();
            idEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idJobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameJobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailEmployeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PasswordEmployee = new DataGridViewTextBoxColumn();
            viewManageEmployeeBindingSource = new BindingSource(components);
            btnInsert = new Button();
            cmbSerach = new ComboBox();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPw = new TextBox();
            txtConfPw = new TextBox();
            label7 = new Label();
            RTAddress = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            cmbJob = new ComboBox();
            dateBirth = new DateTimePicker();
            label10 = new Label();
            NUDSalary = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewManageEmployeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDSalary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(371, 46);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 0;
            label1.Text = "Manage Employee";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(26, 21);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 20);
            lblTime.TabIndex = 1;
            lblTime.Text = "time";
            // 
            // lblHay
            // 
            lblHay.AutoSize = true;
            lblHay.Location = new Point(587, 18);
            lblHay.Name = "lblHay";
            lblHay.Size = new Size(50, 20);
            lblHay.TabIndex = 2;
            lblHay.Text = "label2";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(790, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 39);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idEmployeeDataGridViewTextBoxColumn, idJobDataGridViewTextBoxColumn, nameJobDataGridViewTextBoxColumn, nameEmployeeDataGridViewTextBoxColumn, emailEmployeDataGridViewTextBoxColumn, addressEmployeeDataGridViewTextBoxColumn, phoneNumberEmployeeDataGridViewTextBoxColumn, dateOfBirthEmployeeDataGridViewTextBoxColumn, salaryEmployeeDataGridViewTextBoxColumn, PasswordEmployee });
            dataGridView1.DataSource = viewManageEmployeeBindingSource;
            dataGridView1.Location = new Point(26, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(858, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idEmployeeDataGridViewTextBoxColumn
            // 
            idEmployeeDataGridViewTextBoxColumn.DataPropertyName = "IdEmployee";
            idEmployeeDataGridViewTextBoxColumn.HeaderText = "IdEmployee";
            idEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            idEmployeeDataGridViewTextBoxColumn.Name = "idEmployeeDataGridViewTextBoxColumn";
            idEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // idJobDataGridViewTextBoxColumn
            // 
            idJobDataGridViewTextBoxColumn.DataPropertyName = "IdJob";
            idJobDataGridViewTextBoxColumn.HeaderText = "IdJob";
            idJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            idJobDataGridViewTextBoxColumn.Name = "idJobDataGridViewTextBoxColumn";
            idJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameJobDataGridViewTextBoxColumn
            // 
            nameJobDataGridViewTextBoxColumn.DataPropertyName = "NameJob";
            nameJobDataGridViewTextBoxColumn.HeaderText = "NameJob";
            nameJobDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameJobDataGridViewTextBoxColumn.Name = "nameJobDataGridViewTextBoxColumn";
            nameJobDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameEmployeeDataGridViewTextBoxColumn
            // 
            nameEmployeeDataGridViewTextBoxColumn.DataPropertyName = "NameEmployee";
            nameEmployeeDataGridViewTextBoxColumn.HeaderText = "NameEmployee";
            nameEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameEmployeeDataGridViewTextBoxColumn.Name = "nameEmployeeDataGridViewTextBoxColumn";
            nameEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailEmployeDataGridViewTextBoxColumn
            // 
            emailEmployeDataGridViewTextBoxColumn.DataPropertyName = "EmailEmploye";
            emailEmployeDataGridViewTextBoxColumn.HeaderText = "EmailEmploye";
            emailEmployeDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailEmployeDataGridViewTextBoxColumn.Name = "emailEmployeDataGridViewTextBoxColumn";
            emailEmployeDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressEmployeeDataGridViewTextBoxColumn
            // 
            addressEmployeeDataGridViewTextBoxColumn.DataPropertyName = "AddressEmployee";
            addressEmployeeDataGridViewTextBoxColumn.HeaderText = "AddressEmployee";
            addressEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressEmployeeDataGridViewTextBoxColumn.Name = "addressEmployeeDataGridViewTextBoxColumn";
            addressEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberEmployeeDataGridViewTextBoxColumn
            // 
            phoneNumberEmployeeDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumberEmployee";
            phoneNumberEmployeeDataGridViewTextBoxColumn.HeaderText = "PhoneNumberEmployee";
            phoneNumberEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberEmployeeDataGridViewTextBoxColumn.Name = "phoneNumberEmployeeDataGridViewTextBoxColumn";
            phoneNumberEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthEmployeeDataGridViewTextBoxColumn
            // 
            dateOfBirthEmployeeDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirthEmployee";
            dateOfBirthEmployeeDataGridViewTextBoxColumn.HeaderText = "DateOfBirthEmployee";
            dateOfBirthEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateOfBirthEmployeeDataGridViewTextBoxColumn.Name = "dateOfBirthEmployeeDataGridViewTextBoxColumn";
            dateOfBirthEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryEmployeeDataGridViewTextBoxColumn
            // 
            salaryEmployeeDataGridViewTextBoxColumn.DataPropertyName = "SalaryEmployee";
            salaryEmployeeDataGridViewTextBoxColumn.HeaderText = "SalaryEmployee";
            salaryEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            salaryEmployeeDataGridViewTextBoxColumn.Name = "salaryEmployeeDataGridViewTextBoxColumn";
            salaryEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // PasswordEmployee
            // 
            PasswordEmployee.DataPropertyName = "PasswordEmployee";
            PasswordEmployee.HeaderText = "PasswordEmployee";
            PasswordEmployee.MinimumWidth = 6;
            PasswordEmployee.Name = "PasswordEmployee";
            PasswordEmployee.Width = 125;
            // 
            // viewManageEmployeeBindingSource
            // 
            viewManageEmployeeBindingSource.DataSource = typeof(Model.ViewManageEmployee);
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(26, 89);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(142, 29);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert Data";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // cmbSerach
            // 
            cmbSerach.FormattingEnabled = true;
            cmbSerach.Location = new Point(587, 92);
            cmbSerach.Name = "cmbSerach";
            cmbSerach.Size = new Size(125, 28);
            cmbSerach.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(720, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 27);
            txtSearch.TabIndex = 7;
            txtSearch.Click += Search;
            txtSearch.Leave += Search_LeaveFocus;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(742, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Data";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(742, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Data";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 340);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 375);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 404);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 12;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 436);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 13;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 469);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 14;
            label6.Text = "Confirm Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 337);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 27);
            txtName.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 368);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 16;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(170, 404);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(137, 27);
            txtPhone.TabIndex = 17;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(170, 436);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(137, 27);
            txtPw.TabIndex = 18;
            // 
            // txtConfPw
            // 
            txtConfPw.Location = new Point(170, 466);
            txtConfPw.Name = "txtConfPw";
            txtConfPw.Size = new Size(137, 27);
            txtConfPw.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 344);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 20;
            label7.Text = "Address";
            // 
            // RTAddress
            // 
            RTAddress.Location = new Point(455, 336);
            RTAddress.Name = "RTAddress";
            RTAddress.Size = new Size(281, 76);
            RTAddress.TabIndex = 21;
            RTAddress.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 423);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 22;
            label8.Text = "Job Title";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(346, 466);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 23;
            label9.Text = "Date Of Birth";
            // 
            // cmbJob
            // 
            cmbJob.FormattingEnabled = true;
            cmbJob.Location = new Point(455, 418);
            cmbJob.Name = "cmbJob";
            cmbJob.Size = new Size(281, 28);
            cmbJob.TabIndex = 24;
            // 
            // dateBirth
            // 
            dateBirth.Location = new Point(455, 461);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(281, 27);
            dateBirth.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(170, 513);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 26;
            label10.Text = "Salary";
            // 
            // NUDSalary
            // 
            NUDSalary.Location = new Point(258, 511);
            NUDSalary.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NUDSalary.Name = "NUDSalary";
            NUDSalary.Size = new Size(200, 27);
            NUDSalary.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(742, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 29);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save Data";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Location = new Point(742, 510);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 29);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 551);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(NUDSalary);
            Controls.Add(label10);
            Controls.Add(dateBirth);
            Controls.Add(cmbJob);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(RTAddress);
            Controls.Add(label7);
            Controls.Add(txtConfPw);
            Controls.Add(txtPw);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtSearch);
            Controls.Add(cmbSerach);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogOut);
            Controls.Add(lblHay);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewManageEmployeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTime;
        private Label lblHay;
        private Button btnLogOut;
        private DataGridView dataGridView1;
        private BindingSource viewManageEmployeeBindingSource;
        private Button btnInsert;
        private ComboBox cmbSerach;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtPw;
        private TextBox txtConfPw;
        private Label label7;
        private RichTextBox RTAddress;
        private Label label8;
        private Label label9;
        private ComboBox cmbJob;
        private DateTimePicker dateBirth;
        private Label label10;
        private NumericUpDown NUDSalary;
        private Button btnSave;
        private Button btnCancel;
        private DataGridViewTextBoxColumn idEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idJobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameJobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailEmployeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PasswordEmployee;
    }
}