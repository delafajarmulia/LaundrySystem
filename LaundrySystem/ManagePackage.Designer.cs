namespace LaundrySystem
{
    partial class ManagePackage
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
            idPackageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namePackageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pricePackageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionPackageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            durationPackageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packageBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            idPackageDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            totalUnitServiceDetailPackageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IdService = new DataGridViewTextBoxColumn();
            EstimationDurationService = new DataGridViewTextBoxColumn();
            PriceUnitService = new DataGridViewTextBoxColumn();
            NameService = new DataGridViewTextBoxColumn();
            viewManagePackageBindingSource1 = new BindingSource(components);
            viewManagePackageBindingSource = new BindingSource(components);
            cmbSerach = new ComboBox();
            txtSearch = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            label3 = new Label();
            label4 = new Label();
            txtPackName = new TextBox();
            RTDescription = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            cmbService = new ComboBox();
            NUDTotalUnit = new NumericUpDown();
            btnAdd = new Button();
            label2 = new Label();
            NUDPrice = new NumericUpDown();
            lblAction = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)packageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewManagePackageBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewManagePackageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDTotalUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(368, 47);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 2;
            label1.Text = "Manage Package";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(22, 12);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 20);
            lblTime.TabIndex = 3;
            lblTime.Text = "time";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(823, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 39);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblHay
            // 
            lblHay.AutoSize = true;
            lblHay.Location = new Point(710, 12);
            lblHay.Name = "lblHay";
            lblHay.Size = new Size(45, 20);
            lblHay.TabIndex = 6;
            lblHay.Text = "Hello";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idPackageDataGridViewTextBoxColumn, namePackageDataGridViewTextBoxColumn, pricePackageDataGridViewTextBoxColumn, descriptionPackageDataGridViewTextBoxColumn, durationPackageDataGridViewTextBoxColumn });
            dataGridView1.DataSource = packageBindingSource;
            dataGridView1.Location = new Point(22, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(895, 188);
            dataGridView1.TabIndex = 7;
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
            // namePackageDataGridViewTextBoxColumn
            // 
            namePackageDataGridViewTextBoxColumn.DataPropertyName = "NamePackage";
            namePackageDataGridViewTextBoxColumn.HeaderText = "NamePackage";
            namePackageDataGridViewTextBoxColumn.MinimumWidth = 6;
            namePackageDataGridViewTextBoxColumn.Name = "namePackageDataGridViewTextBoxColumn";
            namePackageDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePackageDataGridViewTextBoxColumn
            // 
            pricePackageDataGridViewTextBoxColumn.DataPropertyName = "PricePackage";
            pricePackageDataGridViewTextBoxColumn.HeaderText = "PricePackage";
            pricePackageDataGridViewTextBoxColumn.MinimumWidth = 6;
            pricePackageDataGridViewTextBoxColumn.Name = "pricePackageDataGridViewTextBoxColumn";
            pricePackageDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionPackageDataGridViewTextBoxColumn
            // 
            descriptionPackageDataGridViewTextBoxColumn.DataPropertyName = "DescriptionPackage";
            descriptionPackageDataGridViewTextBoxColumn.HeaderText = "DescriptionPackage";
            descriptionPackageDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionPackageDataGridViewTextBoxColumn.Name = "descriptionPackageDataGridViewTextBoxColumn";
            descriptionPackageDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationPackageDataGridViewTextBoxColumn
            // 
            durationPackageDataGridViewTextBoxColumn.DataPropertyName = "DurationPackage";
            durationPackageDataGridViewTextBoxColumn.HeaderText = "DurationPackage";
            durationPackageDataGridViewTextBoxColumn.MinimumWidth = 6;
            durationPackageDataGridViewTextBoxColumn.Name = "durationPackageDataGridViewTextBoxColumn";
            durationPackageDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageBindingSource
            // 
            packageBindingSource.DataSource = typeof(Model.Package);
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idPackageDataGridViewTextBoxColumn1, totalUnitServiceDetailPackageDataGridViewTextBoxColumn, IdService, EstimationDurationService, PriceUnitService, NameService });
            dataGridView2.DataSource = viewManagePackageBindingSource1;
            dataGridView2.Location = new Point(22, 318);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(895, 188);
            dataGridView2.TabIndex = 8;
            // 
            // idPackageDataGridViewTextBoxColumn1
            // 
            idPackageDataGridViewTextBoxColumn1.DataPropertyName = "IdPackage";
            idPackageDataGridViewTextBoxColumn1.HeaderText = "IdPackage";
            idPackageDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idPackageDataGridViewTextBoxColumn1.Name = "idPackageDataGridViewTextBoxColumn1";
            idPackageDataGridViewTextBoxColumn1.Width = 125;
            // 
            // totalUnitServiceDetailPackageDataGridViewTextBoxColumn
            // 
            totalUnitServiceDetailPackageDataGridViewTextBoxColumn.DataPropertyName = "TotalUnitServiceDetailPackage";
            totalUnitServiceDetailPackageDataGridViewTextBoxColumn.HeaderText = "TotalUnitServiceDetailPackage";
            totalUnitServiceDetailPackageDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalUnitServiceDetailPackageDataGridViewTextBoxColumn.Name = "totalUnitServiceDetailPackageDataGridViewTextBoxColumn";
            totalUnitServiceDetailPackageDataGridViewTextBoxColumn.Width = 125;
            // 
            // IdService
            // 
            IdService.DataPropertyName = "IdService";
            IdService.HeaderText = "IdService";
            IdService.MinimumWidth = 6;
            IdService.Name = "IdService";
            IdService.Width = 125;
            // 
            // EstimationDurationService
            // 
            EstimationDurationService.DataPropertyName = "EstimationDurationService";
            EstimationDurationService.HeaderText = "EstimationDurationService";
            EstimationDurationService.MinimumWidth = 6;
            EstimationDurationService.Name = "EstimationDurationService";
            EstimationDurationService.Width = 125;
            // 
            // PriceUnitService
            // 
            PriceUnitService.DataPropertyName = "PriceUnitService";
            PriceUnitService.HeaderText = "PriceUnitService";
            PriceUnitService.MinimumWidth = 6;
            PriceUnitService.Name = "PriceUnitService";
            PriceUnitService.Width = 125;
            // 
            // NameService
            // 
            NameService.DataPropertyName = "NameService";
            NameService.HeaderText = "NameService";
            NameService.MinimumWidth = 6;
            NameService.Name = "NameService";
            NameService.Width = 125;
            // 
            // viewManagePackageBindingSource1
            // 
            viewManagePackageBindingSource1.DataSource = typeof(Model.ViewManagePackage);
            // 
            // viewManagePackageBindingSource
            // 
            viewManagePackageBindingSource.DataSource = typeof(Model.ViewManagePackage);
            // 
            // cmbSerach
            // 
            cmbSerach.FormattingEnabled = true;
            cmbSerach.Location = new Point(622, 74);
            cmbSerach.Name = "cmbSerach";
            cmbSerach.Size = new Size(125, 28);
            cmbSerach.TabIndex = 38;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(753, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 27);
            txtSearch.TabIndex = 39;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ActiveCaption;
            btnInsert.Location = new Point(22, 73);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(142, 29);
            btnInsert.TabIndex = 40;
            btnInsert.Text = "Insert Data";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(775, 512);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 30);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update Data";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(775, 548);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 29);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Delete Data";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(775, 605);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 29);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save Data";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Location = new Point(775, 640);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 29);
            btnCancel.TabIndex = 44;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 522);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 46;
            label3.Text = "Package Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 568);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 47;
            label4.Text = "Description";
            // 
            // txtPackName
            // 
            txtPackName.Location = new Point(162, 519);
            txtPackName.Name = "txtPackName";
            txtPackName.Size = new Size(216, 27);
            txtPackName.TabIndex = 48;
            // 
            // RTDescription
            // 
            RTDescription.Location = new Point(162, 565);
            RTDescription.Name = "RTDescription";
            RTDescription.Size = new Size(216, 104);
            RTDescription.TabIndex = 49;
            RTDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 522);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 50;
            label5.Text = "Service";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 568);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 51;
            label6.Text = "Total Unit";
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(514, 522);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(241, 28);
            cmbService.TabIndex = 52;
            // 
            // NUDTotalUnit
            // 
            NUDTotalUnit.Location = new Point(514, 565);
            NUDTotalUnit.Name = "NUDTotalUnit";
            NUDTotalUnit.Size = new Size(127, 27);
            NUDTotalUnit.TabIndex = 53;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(661, 563);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 614);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 55;
            label2.Text = "Price";
            // 
            // NUDPrice
            // 
            NUDPrice.Location = new Point(514, 612);
            NUDPrice.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            NUDPrice.Name = "NUDPrice";
            NUDPrice.Size = new Size(241, 27);
            NUDPrice.TabIndex = 56;
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Location = new Point(499, 649);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(52, 20);
            lblAction.TabIndex = 57;
            lblAction.Text = "Action";
            // 
            // ManagePackage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 685);
            Controls.Add(lblAction);
            Controls.Add(NUDPrice);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(NUDTotalUnit);
            Controls.Add(cmbService);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(RTDescription);
            Controls.Add(txtPackName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtSearch);
            Controls.Add(cmbSerach);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(lblHay);
            Controls.Add(btnLogOut);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Name = "ManagePackage";
            Text = "ManagePackage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)packageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewManagePackageBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewManagePackageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDTotalUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTime;
        private Button btnLogOut;
        private Label lblHay;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idPackageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namePackageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePackageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionPackageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationPackageDataGridViewTextBoxColumn;
        private BindingSource packageBindingSource;
        private DataGridViewTextBoxColumn namePackageDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionPackageDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pricePackageDataGridViewTextBoxColumn1;
        private BindingSource viewManagePackageBindingSource;
        private ComboBox cmbSerach;
        private TextBox txtSearch;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Label label3;
        private Label label4;
        private TextBox txtPackName;
        private RichTextBox RTDescription;
        private Label label5;
        private Label label6;
        private ComboBox cmbService;
        private NumericUpDown NUDTotalUnit;
        private Button btnAdd;
        private DataGridViewTextBoxColumn idPackageDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalUnitServiceDetailPackageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IdService;
        private DataGridViewTextBoxColumn EstimationDurationService;
        private DataGridViewTextBoxColumn PriceUnitService;
        private DataGridViewTextBoxColumn NameService;
        private BindingSource viewManagePackageBindingSource1;
        private Label label2;
        private NumericUpDown NUDPrice;
        private Label lblAction;
    }
}