namespace LaundrySystem
{
    partial class ManageCustomer
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
            btnLogOut = new Button();
            lblHay = new Label();
            dataGridView1 = new DataGridView();
            idCustomerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameCostumerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberCustomerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressCostumerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtPhoneNumber = new TextBox();
            RTAddress = new RichTextBox();
            cmbSerach = new ComboBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(228, 35);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 1;
            label1.Text = "Manage Customer";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(22, 22);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 20);
            lblTime.TabIndex = 2;
            lblTime.Text = "time";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(586, 22);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 39);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblHay
            // 
            lblHay.AutoSize = true;
            lblHay.Location = new Point(456, 22);
            lblHay.Name = "lblHay";
            lblHay.Size = new Size(45, 20);
            lblHay.TabIndex = 5;
            lblHay.Text = "Hello";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCustomerDataGridViewTextBoxColumn, nameCostumerDataGridViewTextBoxColumn, phoneNumberCustomerDataGridViewTextBoxColumn, addressCostumerDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(22, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(658, 188);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idCustomerDataGridViewTextBoxColumn
            // 
            idCustomerDataGridViewTextBoxColumn.DataPropertyName = "IdCustomer";
            idCustomerDataGridViewTextBoxColumn.HeaderText = "IdCustomer";
            idCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCustomerDataGridViewTextBoxColumn.Name = "idCustomerDataGridViewTextBoxColumn";
            idCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCostumerDataGridViewTextBoxColumn
            // 
            nameCostumerDataGridViewTextBoxColumn.DataPropertyName = "NameCostumer";
            nameCostumerDataGridViewTextBoxColumn.HeaderText = "NameCostumer";
            nameCostumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCostumerDataGridViewTextBoxColumn.Name = "nameCostumerDataGridViewTextBoxColumn";
            nameCostumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberCustomerDataGridViewTextBoxColumn
            // 
            phoneNumberCustomerDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumberCustomer";
            phoneNumberCustomerDataGridViewTextBoxColumn.HeaderText = "PhoneNumberCustomer";
            phoneNumberCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberCustomerDataGridViewTextBoxColumn.Name = "phoneNumberCustomerDataGridViewTextBoxColumn";
            phoneNumberCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressCostumerDataGridViewTextBoxColumn
            // 
            addressCostumerDataGridViewTextBoxColumn.DataPropertyName = "AddressCostumer";
            addressCostumerDataGridViewTextBoxColumn.HeaderText = "AddressCostumer";
            addressCostumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressCostumerDataGridViewTextBoxColumn.Name = "addressCostumerDataGridViewTextBoxColumn";
            addressCostumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(22, 63);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(142, 29);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert Data";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(538, 316);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 30);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update Data";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(538, 360);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete Data";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(538, 422);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 29);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save Data";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Location = new Point(538, 457);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 29);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 320);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 31;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 369);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 32;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 412);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 33;
            label4.Text = "Address";
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 317);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 27);
            txtName.TabIndex = 34;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(148, 366);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(361, 27);
            txtPhoneNumber.TabIndex = 35;
            // 
            // RTAddress
            // 
            RTAddress.Location = new Point(148, 409);
            RTAddress.Name = "RTAddress";
            RTAddress.Size = new Size(353, 77);
            RTAddress.TabIndex = 36;
            RTAddress.Text = "";
            // 
            // cmbSerach
            // 
            cmbSerach.FormattingEnabled = true;
            cmbSerach.Location = new Point(384, 74);
            cmbSerach.Name = "cmbSerach";
            cmbSerach.Size = new Size(125, 28);
            cmbSerach.TabIndex = 37;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(516, 74);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 27);
            txtSearch.TabIndex = 38;
            txtSearch.Click += Search;
            txtSearch.Leave += txtSearch_LeaveFocus;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 498);
            Controls.Add(txtSearch);
            Controls.Add(cmbSerach);
            Controls.Add(RTAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(lblHay);
            Controls.Add(btnLogOut);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Name = "ManageCustomer";
            Text = "ManageCustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTime;
        private Button btnLogOut;
        private Label lblHay;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idCustomerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCostumerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberCustomerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressCostumerDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtPhoneNumber;
        private RichTextBox RTAddress;
        private ComboBox cmbSerach;
        private TextBox txtSearch;
    }
}