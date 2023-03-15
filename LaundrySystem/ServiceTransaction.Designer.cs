namespace LaundrySystem
{
    partial class ServiceTransaction
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
            cmbSerach = new ComboBox();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            cmbService = new ComboBox();
            NUDTotalUnit = new NumericUpDown();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            linkAdd = new LinkLabel();
            RTAddress = new RichTextBox();
            txtName = new TextBox();
            txtPhoneNum = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnRemove = new Button();
            label7 = new Label();
            lblPay = new Label();
            label8 = new Label();
            lblHour = new Label();
            btnSubmit = new Button();
            serviceTransactionModelBindingSource = new BindingSource(components);
            idServiceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            servicePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimationTimePerServiceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDTotalUnit).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceTransactionModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(369, 40);
            label1.Name = "label1";
            label1.Size = new Size(252, 28);
            label1.TabIndex = 3;
            label1.Text = "Input Service Transaction";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(12, 19);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 20);
            lblTime.TabIndex = 4;
            lblTime.Text = "time";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(961, 10);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 39);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblHay
            // 
            lblHay.AutoSize = true;
            lblHay.Location = new Point(821, 19);
            lblHay.Name = "lblHay";
            lblHay.Size = new Size(45, 20);
            lblHay.TabIndex = 7;
            lblHay.Text = "Hello";
            // 
            // cmbSerach
            // 
            cmbSerach.FormattingEnabled = true;
            cmbSerach.Location = new Point(760, 71);
            cmbSerach.Name = "cmbSerach";
            cmbSerach.Size = new Size(125, 28);
            cmbSerach.TabIndex = 39;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(891, 72);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 27);
            txtSearch.TabIndex = 40;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idServiceDataGridViewTextBoxColumn, serviceNameDataGridViewTextBoxColumn, servicePriceDataGridViewTextBoxColumn, totalUnitDataGridViewTextBoxColumn, estimationTimePerServiceDataGridViewTextBoxColumn, subTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = serviceTransactionModelBindingSource;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1043, 188);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 357);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 42;
            label2.Text = "Service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 398);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 43;
            label3.Text = "Total Unit";
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(112, 354);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(151, 28);
            cmbService.TabIndex = 44;
            // 
            // NUDTotalUnit
            // 
            NUDTotalUnit.Location = new Point(113, 396);
            NUDTotalUnit.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NUDTotalUnit.Name = "NUDTotalUnit";
            NUDTotalUnit.Size = new Size(150, 27);
            NUDTotalUnit.TabIndex = 45;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(134, 438);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 38);
            btnAdd.TabIndex = 46;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            groupBox1.Location = new Point(279, 351);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 198);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // linkAdd
            // 
            linkAdd.AutoSize = true;
            linkAdd.Location = new Point(281, 36);
            linkAdd.Name = "linkAdd";
            linkAdd.Size = new Size(160, 20);
            linkAdd.TabIndex = 6;
            linkAdd.TabStop = true;
            linkAdd.Text = "Not Found? add New+";
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
            txtPhoneNum.Leave += txtPhone_LeaveFocus;
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
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.ActiveCaption;
            btnRemove.Location = new Point(926, 299);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(129, 38);
            btnRemove.TabIndex = 48;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(779, 383);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 49;
            label7.Text = "Total Pay";
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.Location = new Point(903, 403);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(0, 20);
            lblPay.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(779, 456);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 51;
            label8.Text = "Estimation Time";
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.Location = new Point(903, 494);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(0, 20);
            lblHour.TabIndex = 52;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Location = new Point(779, 523);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(276, 38);
            btnSubmit.TabIndex = 54;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // serviceTransactionModelBindingSource
            // 
            serviceTransactionModelBindingSource.DataSource = typeof(Model.ServiceTransactionModel);
            // 
            // idServiceDataGridViewTextBoxColumn
            // 
            idServiceDataGridViewTextBoxColumn.DataPropertyName = "IdService";
            idServiceDataGridViewTextBoxColumn.HeaderText = "IdService";
            idServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            idServiceDataGridViewTextBoxColumn.Name = "idServiceDataGridViewTextBoxColumn";
            idServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            serviceNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicePriceDataGridViewTextBoxColumn
            // 
            servicePriceDataGridViewTextBoxColumn.DataPropertyName = "ServicePrice";
            servicePriceDataGridViewTextBoxColumn.HeaderText = "ServicePrice";
            servicePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            servicePriceDataGridViewTextBoxColumn.Name = "servicePriceDataGridViewTextBoxColumn";
            servicePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalUnitDataGridViewTextBoxColumn
            // 
            totalUnitDataGridViewTextBoxColumn.DataPropertyName = "TotalUnit";
            totalUnitDataGridViewTextBoxColumn.HeaderText = "TotalUnit";
            totalUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalUnitDataGridViewTextBoxColumn.Name = "totalUnitDataGridViewTextBoxColumn";
            totalUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimationTimePerServiceDataGridViewTextBoxColumn
            // 
            estimationTimePerServiceDataGridViewTextBoxColumn.DataPropertyName = "EstimationTimePerService";
            estimationTimePerServiceDataGridViewTextBoxColumn.HeaderText = "EstimationTimePerService";
            estimationTimePerServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            estimationTimePerServiceDataGridViewTextBoxColumn.Name = "estimationTimePerServiceDataGridViewTextBoxColumn";
            estimationTimePerServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            subTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            subTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // ServiceTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 573);
            Controls.Add(btnSubmit);
            Controls.Add(lblHour);
            Controls.Add(label8);
            Controls.Add(lblPay);
            Controls.Add(label7);
            Controls.Add(btnRemove);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(NUDTotalUnit);
            Controls.Add(cmbService);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(cmbSerach);
            Controls.Add(lblHay);
            Controls.Add(btnLogOut);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Name = "ServiceTransaction";
            Text = "ServiceTransaction";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDTotalUnit).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceTransactionModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTime;
        private Button btnLogOut;
        private Label lblHay;
        private ComboBox cmbSerach;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private ComboBox cmbService;
        private NumericUpDown NUDTotalUnit;
        private Button btnAdd;
        private GroupBox groupBox1;
        private RichTextBox RTAddress;
        private TextBox txtName;
        private TextBox txtPhoneNum;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnRemove;
        private Label label7;
        private Label lblPay;
        private Label label8;
        private Label lblHour;
        private Button btnSubmit;
        private LinkLabel linkAdd;
        private DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn servicePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimationTimePerServiceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private BindingSource serviceTransactionModelBindingSource;
    }
}