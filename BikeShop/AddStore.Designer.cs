namespace BikeShop
{
    partial class AddStore
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
            this.AddStoreGoBackBtn = new System.Windows.Forms.Button();
            this.AddStoreButton = new System.Windows.Forms.Button();
            this.AddStoreNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddStoreNameTextBox = new System.Windows.Forms.TextBox();
            this.AddStoreNumberLabel = new System.Windows.Forms.Label();
            this.AddStoreNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddStoreGoBackBtn
            // 
            this.AddStoreGoBackBtn.Location = new System.Drawing.Point(648, 241);
            this.AddStoreGoBackBtn.Name = "AddStoreGoBackBtn";
            this.AddStoreGoBackBtn.Size = new System.Drawing.Size(140, 61);
            this.AddStoreGoBackBtn.TabIndex = 46;
            this.AddStoreGoBackBtn.Text = "Go Back";
            this.AddStoreGoBackBtn.UseVisualStyleBackColor = true;
            this.AddStoreGoBackBtn.Click += new System.EventHandler(this.AddStoreGoBackBtn_Click);
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.Enabled = false;
            this.AddStoreButton.Location = new System.Drawing.Point(12, 241);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Size = new System.Drawing.Size(140, 61);
            this.AddStoreButton.TabIndex = 41;
            this.AddStoreButton.Text = "Add Store";
            this.AddStoreButton.UseVisualStyleBackColor = true;
            this.AddStoreButton.Click += new System.EventHandler(this.AddStoreButton_Click);
            // 
            // AddStoreNumberTextBox
            // 
            this.AddStoreNumberTextBox.Location = new System.Drawing.Point(226, 56);
            this.AddStoreNumberTextBox.MaxLength = 10;
            this.AddStoreNumberTextBox.Name = "AddStoreNumberTextBox";
            this.AddStoreNumberTextBox.Size = new System.Drawing.Size(205, 31);
            this.AddStoreNumberTextBox.TabIndex = 40;
            this.AddStoreNumberTextBox.TextChanged += new System.EventHandler(this.AddStoreNumberTextBox_TextChanged);
            this.AddStoreNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddStoreNumberTextBox_KeyPress);
            // 
            // AddStoreNameTextBox
            // 
            this.AddStoreNameTextBox.Location = new System.Drawing.Point(12, 56);
            this.AddStoreNameTextBox.MaxLength = 20;
            this.AddStoreNameTextBox.Name = "AddStoreNameTextBox";
            this.AddStoreNameTextBox.Size = new System.Drawing.Size(163, 31);
            this.AddStoreNameTextBox.TabIndex = 39;
            this.AddStoreNameTextBox.TextChanged += new System.EventHandler(this.AddStoreNameTextBox_TextChanged);
            // 
            // AddStoreNumberLabel
            // 
            this.AddStoreNumberLabel.AutoSize = true;
            this.AddStoreNumberLabel.Location = new System.Drawing.Point(226, 9);
            this.AddStoreNumberLabel.Name = "AddStoreNumberLabel";
            this.AddStoreNumberLabel.Size = new System.Drawing.Size(390, 25);
            this.AddStoreNumberLabel.TabIndex = 38;
            this.AddStoreNumberLabel.Text = "Store Phone Number (numbers only, no spaces)";
            // 
            // AddStoreNameLabel
            // 
            this.AddStoreNameLabel.AutoSize = true;
            this.AddStoreNameLabel.Location = new System.Drawing.Point(12, 9);
            this.AddStoreNameLabel.Name = "AddStoreNameLabel";
            this.AddStoreNameLabel.Size = new System.Drawing.Size(105, 25);
            this.AddStoreNameLabel.TabIndex = 37;
            this.AddStoreNameLabel.Text = "Store Name";
            // 
            // AddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.AddStoreGoBackBtn);
            this.Controls.Add(this.AddStoreButton);
            this.Controls.Add(this.AddStoreNumberTextBox);
            this.Controls.Add(this.AddStoreNameTextBox);
            this.Controls.Add(this.AddStoreNumberLabel);
            this.Controls.Add(this.AddStoreNameLabel);
            this.Name = "AddStore";
            this.Text = "AddStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddStoreGoBackBtn;
        private Button AddStoreButton;
        private TextBox AddStoreNumberTextBox;
        private TextBox AddStoreNameTextBox;
        private Label AddStoreNumberLabel;
        private Label AddStoreNameLabel;
    }
}