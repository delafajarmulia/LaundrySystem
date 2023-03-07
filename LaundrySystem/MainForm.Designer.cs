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
            btnLogOut.Location = new Point(694, 12);
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
            lblHay.Location = new Point(559, 21);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}