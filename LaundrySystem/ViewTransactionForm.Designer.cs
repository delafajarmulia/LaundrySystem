namespace LaundrySystem
{
    partial class ViewTransactionForm
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
            btnLogOut = new Button();
            lblHay = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idHeaderTransactionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idCostumerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameCostumerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameEmployeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            viewHeaderTransactionBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            Action = new DataGridViewButtonColumn();
            detailTransactionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewHeaderTransactionBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailTransactionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(12, 28);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 20);
            lblTime.TabIndex = 6;
            lblTime.Text = "time";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(807, 19);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 39);
            btnLogOut.TabIndex = 11;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblHay
            // 
            lblHay.AutoSize = true;
            lblHay.Location = new Point(656, 28);
            lblHay.Name = "lblHay";
            lblHay.Size = new Size(45, 20);
            lblHay.TabIndex = 10;
            lblHay.Text = "Hello";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(343, 70);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 44;
            label1.Text = "View Transaction";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idHeaderTransactionDataGridViewTextBoxColumn, idEmployeeDataGridViewTextBoxColumn, idCostumerDataGridViewTextBoxColumn, transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn, completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn, nameCostumerDataGridViewTextBoxColumn, nameEmployeeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = viewHeaderTransactionBindingSource;
            dataGridView1.Location = new Point(17, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(852, 162);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idHeaderTransactionDataGridViewTextBoxColumn
            // 
            idHeaderTransactionDataGridViewTextBoxColumn.DataPropertyName = "IdHeaderTransaction";
            idHeaderTransactionDataGridViewTextBoxColumn.HeaderText = "IdHeaderTransaction";
            idHeaderTransactionDataGridViewTextBoxColumn.MinimumWidth = 6;
            idHeaderTransactionDataGridViewTextBoxColumn.Name = "idHeaderTransactionDataGridViewTextBoxColumn";
            idHeaderTransactionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEmployeeDataGridViewTextBoxColumn
            // 
            idEmployeeDataGridViewTextBoxColumn.DataPropertyName = "IdEmployee";
            idEmployeeDataGridViewTextBoxColumn.HeaderText = "IdEmployee";
            idEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            idEmployeeDataGridViewTextBoxColumn.Name = "idEmployeeDataGridViewTextBoxColumn";
            idEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // idCostumerDataGridViewTextBoxColumn
            // 
            idCostumerDataGridViewTextBoxColumn.DataPropertyName = "IdCostumer";
            idCostumerDataGridViewTextBoxColumn.HeaderText = "IdCostumer";
            idCostumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            idCostumerDataGridViewTextBoxColumn.Name = "idCostumerDataGridViewTextBoxColumn";
            idCostumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn
            // 
            transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn.DataPropertyName = "TransactionDateTimeHeaderTransaction";
            transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn.HeaderText = "TransactionDateTimeHeaderTransaction";
            transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn.Name = "transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn";
            transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn.Width = 125;
            // 
            // completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn
            // 
            completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn.DataPropertyName = "CompleteEstimationDateTimeHeaderTransaction";
            completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn.HeaderText = "CompleteEstimationDateTimeHeaderTransaction";
            completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn.MinimumWidth = 6;
            completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn.Name = "completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn";
            completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameCostumerDataGridViewTextBoxColumn
            // 
            nameCostumerDataGridViewTextBoxColumn.DataPropertyName = "NameCostumer";
            nameCostumerDataGridViewTextBoxColumn.HeaderText = "NameCostumer";
            nameCostumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameCostumerDataGridViewTextBoxColumn.Name = "nameCostumerDataGridViewTextBoxColumn";
            nameCostumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameEmployeeDataGridViewTextBoxColumn
            // 
            nameEmployeeDataGridViewTextBoxColumn.DataPropertyName = "NameEmployee";
            nameEmployeeDataGridViewTextBoxColumn.HeaderText = "NameEmployee";
            nameEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameEmployeeDataGridViewTextBoxColumn.Name = "nameEmployeeDataGridViewTextBoxColumn";
            nameEmployeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // viewHeaderTransactionBindingSource
            // 
            viewHeaderTransactionBindingSource.DataSource = typeof(Model.ViewHeaderTransaction);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(889, 231);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Header Transaction";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(12, 374);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(889, 231);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detail Transaction";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Action });
            dataGridView2.Location = new Point(17, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(852, 162);
            dataGridView2.TabIndex = 45;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.Text = "Complete";
            Action.UseColumnTextForButtonValue = true;
            Action.Width = 125;
            // 
            // detailTransactionBindingSource
            // 
            detailTransactionBindingSource.DataSource = typeof(Model.DetailTransaction);
            // 
            // ViewTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 626);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnLogOut);
            Controls.Add(lblHay);
            Controls.Add(lblTime);
            Name = "ViewTransactionForm";
            Text = "ViewTransactionForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewHeaderTransactionBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailTransactionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Button btnLogOut;
        private Label lblHay;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idHeaderTransactionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmployeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCostumerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateTimeHeaderTransactionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn completeEstimationDateTimeHeaderTransactionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCostumerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameEmployeeDataGridViewTextBoxColumn;
        private BindingSource viewHeaderTransactionBindingSource;
        private BindingSource detailTransactionBindingSource;
        private DataGridViewButtonColumn Action;
    }
}