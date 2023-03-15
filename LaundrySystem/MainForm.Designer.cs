namespace LaundrySystem
{
    partial class MainForm
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
            btnManEmployee = new Button();
            btnLogOut = new Button();
            lblHay = new Label();
            lblTime = new Label();
            btnManageSevice = new Button();
            btnManageCustomer = new Button();
            btnManPack = new Button();
            btnServTrans = new Button();
            btnPackTrans = new Button();
            btnView = new Button();
            SuspendLayout();
            // 
            // btnManEmployee
            // 
            btnManEmployee.Location = new Point(130, 68);
            btnManEmployee.Name = "btnManEmployee";
            btnManEmployee.Size = new Size(162, 57);
            btnManEmployee.TabIndex = 0;
            btnManEmployee.Text = "Manage Employee";
            btnManEmployee.UseVisualStyleBackColor = true;
            btnManEmployee.Click += btnManEmployee_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(583, 21);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 39);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblHay
            // 
            lblHay.AutoSize = true;
            lblHay.Location = new Point(448, 30);
            lblHay.Name = "lblHay";
            lblHay.Size = new Size(45, 20);
            lblHay.TabIndex = 2;
            lblHay.Text = "Hello";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(22, 21);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 20);
            lblTime.TabIndex = 3;
            lblTime.Text = "time";
            // 
            // btnManageSevice
            // 
            btnManageSevice.Location = new Point(130, 145);
            btnManageSevice.Name = "btnManageSevice";
            btnManageSevice.Size = new Size(162, 57);
            btnManageSevice.TabIndex = 4;
            btnManageSevice.Text = "Manage Service";
            btnManageSevice.UseVisualStyleBackColor = true;
            btnManageSevice.Click += btnManageSevice_Click;
            // 
            // btnManageCustomer
            // 
            btnManageCustomer.Location = new Point(130, 225);
            btnManageCustomer.Name = "btnManageCustomer";
            btnManageCustomer.Size = new Size(162, 57);
            btnManageCustomer.TabIndex = 5;
            btnManageCustomer.Text = "Manage Customer";
            btnManageCustomer.UseVisualStyleBackColor = true;
            btnManageCustomer.Click += btnManageCustomer_Click;
            // 
            // btnManPack
            // 
            btnManPack.Location = new Point(356, 68);
            btnManPack.Name = "btnManPack";
            btnManPack.Size = new Size(162, 57);
            btnManPack.TabIndex = 6;
            btnManPack.Text = "Manage Package";
            btnManPack.UseVisualStyleBackColor = true;
            btnManPack.Click += btnManPack_Click;
            // 
            // btnServTrans
            // 
            btnServTrans.Location = new Point(356, 145);
            btnServTrans.Name = "btnServTrans";
            btnServTrans.Size = new Size(162, 57);
            btnServTrans.TabIndex = 7;
            btnServTrans.Text = "Service Transaction";
            btnServTrans.UseVisualStyleBackColor = true;
            btnServTrans.Click += btnServTrans_Click;
            // 
            // btnPackTrans
            // 
            btnPackTrans.Location = new Point(356, 225);
            btnPackTrans.Name = "btnPackTrans";
            btnPackTrans.Size = new Size(162, 57);
            btnPackTrans.TabIndex = 8;
            btnPackTrans.Text = "Package Transaction";
            btnPackTrans.UseVisualStyleBackColor = true;
            btnPackTrans.Click += btnPackTrans_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(130, 305);
            btnView.Name = "btnView";
            btnView.Size = new Size(388, 57);
            btnView.TabIndex = 9;
            btnView.Text = "View Transaction";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 450);
            Controls.Add(btnView);
            Controls.Add(btnPackTrans);
            Controls.Add(btnServTrans);
            Controls.Add(btnManPack);
            Controls.Add(btnManageCustomer);
            Controls.Add(btnManageSevice);
            Controls.Add(lblTime);
            Controls.Add(lblHay);
            Controls.Add(btnLogOut);
            Controls.Add(btnManEmployee);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManEmployee;
        private Button btnLogOut;
        private Label lblHay;
        private Label lblTime;
        private Button btnManageSevice;
        private Button btnManageCustomer;
        private Button btnManPack;
        private Button btnServTrans;
        private Button btnPackTrans;
        private Button btnView;
    }
}