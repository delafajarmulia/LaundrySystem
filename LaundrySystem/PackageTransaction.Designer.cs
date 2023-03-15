namespace LaundrySystem
{
    partial class PackageTransaction
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
            lblTime = new Label();
            lblHay = new Label();
            btnLogOut = new Button();
            txtSearch = new TextBox();
            cmbSerach = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idPackageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packageNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packagePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimationTimePerPackageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packageTransactionModelBindingSource = new BindingSource(components);
            btnRemove = new Button();
            btnAdd = new Button();
            NUDQuantity = new NumericUpDown();
            cmbPackage = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            linkAdd = new LinkLabel();
            RTAddress = new RichTextBox();
            txtName = new TextBox();
            txtPhoneNum = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSubmit = new Button();
            lblPay = new Label();
            lblHour = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)packageTransactionModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDQuantity).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(22, 21);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 20);
            lblTime.TabIndex = 5;
            lblTime.Text = "time";
            // 
            // lblHay
            // 
            lblHay.AutoSize = true;
            lblHay.Location = new Point(809, 21);
            lblHay.Name = "lblHay";
            lblHay.Size = new Size(45, 20);
            lblHay.TabIndex = 8;
            lblHay.Text = "Hello";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(960, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 39);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(890, 94);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 27);
            txtSearch.TabIndex = 42;
            // 
            // cmbSerach
            // 
            cmbSerach.FormattingEnabled = true;
            cmbSerach.Location = new Point(759, 94);
            cmbSerach.Name = "cmbSerach";
            cmbSerach.Size = new Size(125, 28);
            cmbSerach.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(390, 50);
            label1.Name = "label1";
            label1.Size = new Size(261, 28);
            label1.TabIndex = 43;
            label1.Text = "Input Package Transaction";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idPackageDataGridViewTextBoxColumn, packageNameDataGridViewTextBoxColumn, packagePriceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, estimationTimePerPackageDataGridViewTextBoxColumn, subTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = packageTransactionModelBindingSource;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1043, 188);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idPackageDataGridViewTextBoxColumn
            // 
            idPackageDataGridViewTextBoxColumn.DataPropertyName = "IdPackage";
            idPackageDataGridViewTextBoxColumn.HeaderText = "IdPackage";
            idPackageDataGridViewTextBoxColumn.MinimumWidth = 6;
            idPackageDataGridViewTextBoxColumn.Name = "idPackageDataGridViewTextBoxColumn";
            idPackageDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageNameDataGridViewTextBoxColumn
            // 
            packageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName";
            packageNameDataGridViewTextBoxColumn.HeaderText = "PackageName";
            packageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            packageNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // packagePriceDataGridViewTextBoxColumn
            // 
            packagePriceDataGridViewTextBoxColumn.DataPropertyName = "PackagePrice";
            packagePriceDataGridViewTextBoxColumn.HeaderText = "PackagePrice";
            packagePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            packagePriceDataGridViewTextBoxColumn.Name = "packagePriceDataGridViewTextBoxColumn";
            packagePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimationTimePerPackageDataGridViewTextBoxColumn
            // 
            estimationTimePerPackageDataGridViewTextBoxColumn.DataPropertyName = "EstimationTimePerPackage";
            estimationTimePerPackageDataGridViewTextBoxColumn.HeaderText = "EstimationTimePerPackage";
            estimationTimePerPackageDataGridViewTextBoxColumn.MinimumWidth = 6;
            estimationTimePerPackageDataGridViewTextBoxColumn.Name = "estimationTimePerPackageDataGridViewTextBoxColumn";
            estimationTimePerPackageDataGridViewTextBoxColumn.Width = 125;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            subTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            subTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageTransactionModelBindingSource
            // 
            packageTransactionModelBindingSource.DataSource = typeof(Model.PackageTransactionModel);
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.ActiveCaption;
            btnRemove.Location = new Point(925, 339);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(129, 38);
            btnRemove.TabIndex = 49;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(133, 471);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 38);
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // NUDQuantity
            // 
            NUDQuantity.Location = new Point(112, 429);
            NUDQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NUDQuantity.Name = "NUDQuantity";
            NUDQuantity.Size = new Size(150, 27);
            NUDQuantity.TabIndex = 53;
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(111, 387);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(151, 28);
            cmbPackage.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 431);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 51;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 390);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 50;
            label2.Text = "Package";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkAdd);
            groupBox1.Controls.Add(RTAddress);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtPhoneNum);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(288, 387);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 198);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // linkAdd
            // 
            linkAdd.AutoSize = true;
            linkAdd.Location = new Point(287, 35);
            linkAdd.Name = "linkAdd";
            linkAdd.Size = new Size(166, 20);
            linkAdd.TabIndex = 6;
            linkAdd.TabStop = true;
            linkAdd.Text = "Not Found? Add New +";
            linkAdd.LinkClicked += linkAdd_LinkClicked;
            // 
            // RTAddress
            // 
            RTAddress.Enabled = false;
            RTAddress.Location = new Point(135, 101);
            RTAddress.Name = "RTAddress";
            RTAddress.Size = new Size(308, 79);
            RTAddress.TabIndex = 5;
            RTAddress.Text = "";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(135, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 27);
            txtName.TabIndex = 4;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(135, 32);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(140, 27);
            txtPhoneNum.TabIndex = 3;
            txtPhoneNum.Click += autoCompleteInPhone;
            txtPhoneNum.Leave += txtPhoneNum_LeaveFocus;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 105);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 2;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 68);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 1;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 36);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 0;
            label4.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(786, 419);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 56;
            label7.Text = "Total Pay";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(786, 492);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 57;
            label8.Text = "Estimation Time";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Location = new Point(778, 555);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(276, 38);
            btnSubmit.TabIndex = 58;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.Location = new Point(890, 455);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(31, 20);
            lblPay.TabIndex = 59;
            lblPay.Text = "Pay";
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.Location = new Point(899, 523);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(39, 20);
            lblHour.TabIndex = 60;
            lblHour.Text = "hour";
            // 
            // PackageTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 605);
            Controls.Add(lblHour);
            Controls.Add(lblPay);
            Controls.Add(btnSubmit);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(NUDQuantity);
            Controls.Add(cmbPackage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRemove);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(cmbSerach);
            Controls.Add(btnLogOut);
            Controls.Add(lblHay);
            Controls.Add(lblTime);
            Name = "PackageTransaction";
            Text = "PackageTransaction";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)packageTransactionModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDQuantity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblHay;
        private Button btnLogOut;
        private TextBox txtSearch;
        private ComboBox cmbSerach;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnRemove;
        private Button btnAdd;
        private NumericUpDown NUDQuantity;
        private ComboBox cmbPackage;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private RichTextBox RTAddress;
        private TextBox txtName;
        private TextBox txtPhoneNum;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label8;
        private Button btnSubmit;
        private Label lblPay;
        private Label lblHour;
        private LinkLabel linkAdd;
        private DataGridViewTextBoxColumn idPackageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packagePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimationTimePerPackageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private BindingSource packageTransactionModelBindingSource;
    }
}