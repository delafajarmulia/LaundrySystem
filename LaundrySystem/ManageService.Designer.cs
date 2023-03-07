namespace LaundrySystem
{
    partial class ManageService
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
            nameCategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idServiceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idCategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameServiceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceUnitServiceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimationDurationServiceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            viewManageServiceBindingSource = new BindingSource(components);
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtServiceName = new TextBox();
            cmbCategory = new ComboBox();
            cmbUnit = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            NUDPrice = new NumericUpDown();
            NUDDuration = new NumericUpDown();
            label7 = new Label();
            cmbSerach = new ComboBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewManageServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDuration).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(331, 58);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 1;
            label1.Text = "Manage Service";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(22, 18);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 20);
            lblTime.TabIndex = 2;
            lblTime.Text = "time";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(793, 9);
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
            lblHay.Location = new Point(627, 18);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameCategoryDataGridViewTextBoxColumn, idServiceDataGridViewTextBoxColumn, idCategoryDataGridViewTextBoxColumn, idUnitDataGridViewTextBoxColumn, nameServiceDataGridViewTextBoxColumn, priceUnitServiceDataGridViewTextBoxColumn, estimationDurationServiceDataGridViewTextBoxColumn, nameUnitDataGridViewTextBoxColumn });
            dataGridView1.DataSource = viewManageServiceBindingSource;
            dataGridView1.Location = new Point(22, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(865, 188);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // nameCategoryDataGridViewTextBoxColumn
            // 
            nameCategoryDataGridViewTextBoxColumn.DataPropertyName = "NameCategory";
            nameCategoryDataGridViewTextBoxColumn.HeaderText = "NameCategory";
            nameCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCategoryDataGridViewTextBoxColumn.Name = "nameCategoryDataGridViewTextBoxColumn";
            nameCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // idServiceDataGridViewTextBoxColumn
            // 
            idServiceDataGridViewTextBoxColumn.DataPropertyName = "IdService";
            idServiceDataGridViewTextBoxColumn.HeaderText = "IdService";
            idServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            idServiceDataGridViewTextBoxColumn.Name = "idServiceDataGridViewTextBoxColumn";
            idServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // idCategoryDataGridViewTextBoxColumn
            // 
            idCategoryDataGridViewTextBoxColumn.DataPropertyName = "IdCategory";
            idCategoryDataGridViewTextBoxColumn.HeaderText = "IdCategory";
            idCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCategoryDataGridViewTextBoxColumn.Name = "idCategoryDataGridViewTextBoxColumn";
            idCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // idUnitDataGridViewTextBoxColumn
            // 
            idUnitDataGridViewTextBoxColumn.DataPropertyName = "IdUnit";
            idUnitDataGridViewTextBoxColumn.HeaderText = "IdUnit";
            idUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            idUnitDataGridViewTextBoxColumn.Name = "idUnitDataGridViewTextBoxColumn";
            idUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameServiceDataGridViewTextBoxColumn
            // 
            nameServiceDataGridViewTextBoxColumn.DataPropertyName = "NameService";
            nameServiceDataGridViewTextBoxColumn.HeaderText = "NameService";
            nameServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameServiceDataGridViewTextBoxColumn.Name = "nameServiceDataGridViewTextBoxColumn";
            nameServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceUnitServiceDataGridViewTextBoxColumn
            // 
            priceUnitServiceDataGridViewTextBoxColumn.DataPropertyName = "PriceUnitService";
            priceUnitServiceDataGridViewTextBoxColumn.HeaderText = "PriceUnitService";
            priceUnitServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceUnitServiceDataGridViewTextBoxColumn.Name = "priceUnitServiceDataGridViewTextBoxColumn";
            priceUnitServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimationDurationServiceDataGridViewTextBoxColumn
            // 
            estimationDurationServiceDataGridViewTextBoxColumn.DataPropertyName = "EstimationDurationService";
            estimationDurationServiceDataGridViewTextBoxColumn.HeaderText = "EstimationDurationService";
            estimationDurationServiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            estimationDurationServiceDataGridViewTextBoxColumn.Name = "estimationDurationServiceDataGridViewTextBoxColumn";
            estimationDurationServiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameUnitDataGridViewTextBoxColumn
            // 
            nameUnitDataGridViewTextBoxColumn.DataPropertyName = "NameUnit";
            nameUnitDataGridViewTextBoxColumn.HeaderText = "NameUnit";
            nameUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameUnitDataGridViewTextBoxColumn.Name = "nameUnitDataGridViewTextBoxColumn";
            nameUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // viewManageServiceBindingSource
            // 
            viewManageServiceBindingSource.DataSource = typeof(Model.ViewManageService);
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(22, 90);
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
            btnUpdate.Location = new Point(745, 337);
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
            btnDelete.Location = new Point(745, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Data";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(745, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Location = new Point(745, 448);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 337);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 12;
            label2.Text = "Service Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 376);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 13;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 413);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 14;
            label4.Text = "Unit";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(143, 330);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(187, 27);
            txtServiceName.TabIndex = 15;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(143, 372);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(187, 28);
            cmbCategory.TabIndex = 16;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(143, 410);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(187, 28);
            cmbUnit.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 337);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 18;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 375);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 19;
            label6.Text = "Est Duration";
            // 
            // NUDPrice
            // 
            NUDPrice.Location = new Point(484, 335);
            NUDPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            NUDPrice.Name = "NUDPrice";
            NUDPrice.Size = new Size(150, 27);
            NUDPrice.TabIndex = 20;
            // 
            // NUDDuration
            // 
            NUDDuration.Location = new Point(484, 373);
            NUDDuration.Name = "NUDDuration";
            NUDDuration.Size = new Size(150, 27);
            NUDDuration.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(650, 375);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 22;
            label7.Text = "Hour[s]";
            // 
            // cmbSerach
            // 
            cmbSerach.FormattingEnabled = true;
            cmbSerach.Location = new Point(592, 92);
            cmbSerach.Name = "cmbSerach";
            cmbSerach.Size = new Size(125, 28);
            cmbSerach.TabIndex = 23;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(723, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 27);
            txtSearch.TabIndex = 24;
            txtSearch.Click += Search;
            txtSearch.Leave += txtSearch_LeaveFocus;
            // 
            // ManageService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 496);
            Controls.Add(txtSearch);
            Controls.Add(cmbSerach);
            Controls.Add(label7);
            Controls.Add(NUDDuration);
            Controls.Add(NUDPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbUnit);
            Controls.Add(cmbCategory);
            Controls.Add(txtServiceName);
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
            Name = "ManageService";
            Text = "ManageService";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewManageServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTime;
        private Button btnLogOut;
        private Label lblHay;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceUnitServiceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimationDurationServiceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameUnitDataGridViewTextBoxColumn;
        private BindingSource viewManageServiceBindingSource;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServiceName;
        private ComboBox cmbCategory;
        private ComboBox cmbUnit;
        private Label label5;
        private Label label6;
        private NumericUpDown NUDPrice;
        private NumericUpDown NUDDuration;
        private Label label7;
        private ComboBox cmbSerach;
        private TextBox txtSearch;
    }
}