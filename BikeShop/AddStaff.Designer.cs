namespace BikeShop
{
    partial class AddStaff
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
            this.AddStaffLNameTextBox = new System.Windows.Forms.TextBox();
            this.AddStaffFNameTextBox = new System.Windows.Forms.TextBox();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.AddStaffButton = new System.Windows.Forms.Button();
            this.AddStaffGoBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStaffLNameTextBox
            // 
            this.AddStaffLNameTextBox.Location = new System.Drawing.Point(226, 56);
            this.AddStaffLNameTextBox.Name = "AddStaffLNameTextBox";
            this.AddStaffLNameTextBox.Size = new System.Drawing.Size(205, 31);
            this.AddStaffLNameTextBox.TabIndex = 23;
            // 
            // AddStaffFNameTextBox
            // 
            this.AddStaffFNameTextBox.Location = new System.Drawing.Point(12, 56);
            this.AddStaffFNameTextBox.Name = "AddStaffFNameTextBox";
            this.AddStaffFNameTextBox.Size = new System.Drawing.Size(163, 31);
            this.AddStaffFNameTextBox.TabIndex = 22;
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(226, 9);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(95, 25);
            this.LNameLabel.TabIndex = 21;
            this.LNameLabel.Text = "Last Name";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(97, 25);
            this.FNameLabel.TabIndex = 19;
            this.FNameLabel.Text = "First Name";
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Location = new System.Drawing.Point(12, 168);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(112, 34);
            this.AddStaffButton.TabIndex = 26;
            this.AddStaffButton.Text = "Add Staff";
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // AddStaffGoBackBtn
            // 
            this.AddStaffGoBackBtn.Location = new System.Drawing.Point(646, 168);
            this.AddStaffGoBackBtn.Name = "AddStaffGoBackBtn";
            this.AddStaffGoBackBtn.Size = new System.Drawing.Size(142, 34);
            this.AddStaffGoBackBtn.TabIndex = 27;
            this.AddStaffGoBackBtn.Text = "Go Back";
            this.AddStaffGoBackBtn.UseVisualStyleBackColor = true;
            this.AddStaffGoBackBtn.Click += new System.EventHandler(this.AddStaffGoBackBtn_Click);
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.AddStaffGoBackBtn);
            this.Controls.Add(this.AddStaffButton);
            this.Controls.Add(this.AddStaffLNameTextBox);
            this.Controls.Add(this.AddStaffFNameTextBox);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Name = "AddStaff";
            this.Text = "AddStaffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox AddStaffLNameTextBox;
        private TextBox AddStaffFNameTextBox;
        private Label LNameLabel;
        private Label FNameLabel;
        private Button AddStaffButton;
        private Button AddStaffGoBackBtn;
    }
}