namespace BikeShop
{
    partial class AddCustomer
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
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.AddCustLNameTextBox = new System.Windows.Forms.TextBox();
            this.AddCustFNameTextBox = new System.Windows.Forms.TextBox();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.AddCustCCPinTextBox = new System.Windows.Forms.TextBox();
            this.AddCustCCNumberTextBox = new System.Windows.Forms.TextBox();
            this.CCPinLabel = new System.Windows.Forms.Label();
            this.CCNumberLabel = new System.Windows.Forms.Label();
            this.AddCustomerGoBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(12, 241);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(140, 61);
            this.AddCustomerButton.TabIndex = 31;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // AddCustLNameTextBox
            // 
            this.AddCustLNameTextBox.Location = new System.Drawing.Point(226, 56);
            this.AddCustLNameTextBox.Name = "AddCustLNameTextBox";
            this.AddCustLNameTextBox.Size = new System.Drawing.Size(205, 31);
            this.AddCustLNameTextBox.TabIndex = 30;
            // 
            // AddCustFNameTextBox
            // 
            this.AddCustFNameTextBox.Location = new System.Drawing.Point(12, 56);
            this.AddCustFNameTextBox.Name = "AddCustFNameTextBox";
            this.AddCustFNameTextBox.Size = new System.Drawing.Size(163, 31);
            this.AddCustFNameTextBox.TabIndex = 29;
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(226, 9);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(95, 25);
            this.LNameLabel.TabIndex = 28;
            this.LNameLabel.Text = "Last Name";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(97, 25);
            this.FNameLabel.TabIndex = 27;
            this.FNameLabel.Text = "First Name";
            // 
            // AddCustCCPinTextBox
            // 
            this.AddCustCCPinTextBox.Location = new System.Drawing.Point(12, 172);
            this.AddCustCCPinTextBox.Name = "AddCustCCPinTextBox";
            this.AddCustCCPinTextBox.Size = new System.Drawing.Size(71, 31);
            this.AddCustCCPinTextBox.TabIndex = 35;
            // 
            // AddCustCCNumberTextBox
            // 
            this.AddCustCCNumberTextBox.Location = new System.Drawing.Point(485, 56);
            this.AddCustCCNumberTextBox.Name = "AddCustCCNumberTextBox";
            this.AddCustCCNumberTextBox.Size = new System.Drawing.Size(163, 31);
            this.AddCustCCNumberTextBox.TabIndex = 34;
            // 
            // CCPinLabel
            // 
            this.CCPinLabel.AutoSize = true;
            this.CCPinLabel.Location = new System.Drawing.Point(12, 125);
            this.CCPinLabel.Name = "CCPinLabel";
            this.CCPinLabel.Size = new System.Drawing.Size(130, 25);
            this.CCPinLabel.TabIndex = 33;
            this.CCPinLabel.Text = "Credit Card Pin";
            // 
            // CCNumberLabel
            // 
            this.CCNumberLabel.AutoSize = true;
            this.CCNumberLabel.Location = new System.Drawing.Point(485, 9);
            this.CCNumberLabel.Name = "CCNumberLabel";
            this.CCNumberLabel.Size = new System.Drawing.Size(171, 25);
            this.CCNumberLabel.TabIndex = 32;
            this.CCNumberLabel.Text = "Credit Card Number";
            // 
            // AddCustomerGoBackBtn
            // 
            this.AddCustomerGoBackBtn.Location = new System.Drawing.Point(648, 241);
            this.AddCustomerGoBackBtn.Name = "AddCustomerGoBackBtn";
            this.AddCustomerGoBackBtn.Size = new System.Drawing.Size(140, 61);
            this.AddCustomerGoBackBtn.TabIndex = 36;
            this.AddCustomerGoBackBtn.Text = "Go Back";
            this.AddCustomerGoBackBtn.UseVisualStyleBackColor = true;
            this.AddCustomerGoBackBtn.Click += new System.EventHandler(this.AddCustomerGoBackBtn_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.AddCustomerGoBackBtn);
            this.Controls.Add(this.AddCustCCPinTextBox);
            this.Controls.Add(this.AddCustCCNumberTextBox);
            this.Controls.Add(this.CCPinLabel);
            this.Controls.Add(this.CCNumberLabel);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.AddCustLNameTextBox);
            this.Controls.Add(this.AddCustFNameTextBox);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddCustomerButton;
        private TextBox AddCustLNameTextBox;
        private TextBox AddCustFNameTextBox;
        private Label LNameLabel;
        private Label FNameLabel;
        private TextBox AddCustCCPinTextBox;
        private TextBox AddCustCCNumberTextBox;
        private Label CCPinLabel;
        private Label CCNumberLabel;
        private Button AddCustomerGoBackBtn;
    }
}