namespace BikeShop
{
    partial class AddManager
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
            this.AddManagerButton = new System.Windows.Forms.Button();
            this.AddManNameLabel = new System.Windows.Forms.Label();
            this.AddManStoreLabel = new System.Windows.Forms.Label();
            this.AddManStoreComboBox = new System.Windows.Forms.ComboBox();
            this.AddManNameComboBox = new System.Windows.Forms.ComboBox();
            this.AddManGoBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddManagerButton
            // 
            this.AddManagerButton.Location = new System.Drawing.Point(12, 172);
            this.AddManagerButton.Name = "AddManagerButton";
            this.AddManagerButton.Size = new System.Drawing.Size(154, 45);
            this.AddManagerButton.TabIndex = 31;
            this.AddManagerButton.Text = "Add Manager";
            this.AddManagerButton.UseVisualStyleBackColor = true;
            this.AddManagerButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // AddManNameLabel
            // 
            this.AddManNameLabel.AutoSize = true;
            this.AddManNameLabel.Location = new System.Drawing.Point(226, 13);
            this.AddManNameLabel.Name = "AddManNameLabel";
            this.AddManNameLabel.Size = new System.Drawing.Size(134, 25);
            this.AddManNameLabel.TabIndex = 28;
            this.AddManNameLabel.Text = "Manager Name";
            // 
            // AddManStoreLabel
            // 
            this.AddManStoreLabel.AutoSize = true;
            this.AddManStoreLabel.Location = new System.Drawing.Point(12, 13);
            this.AddManStoreLabel.Name = "AddManStoreLabel";
            this.AddManStoreLabel.Size = new System.Drawing.Size(53, 25);
            this.AddManStoreLabel.TabIndex = 27;
            this.AddManStoreLabel.Text = "Store";
            // 
            // AddManStoreComboBox
            // 
            this.AddManStoreComboBox.FormattingEnabled = true;
            this.AddManStoreComboBox.Location = new System.Drawing.Point(12, 60);
            this.AddManStoreComboBox.Name = "AddManStoreComboBox";
            this.AddManStoreComboBox.Size = new System.Drawing.Size(105, 33);
            this.AddManStoreComboBox.TabIndex = 34;
            // 
            // AddManNameComboBox
            // 
            this.AddManNameComboBox.FormattingEnabled = true;
            this.AddManNameComboBox.Location = new System.Drawing.Point(224, 60);
            this.AddManNameComboBox.Name = "AddManNameComboBox";
            this.AddManNameComboBox.Size = new System.Drawing.Size(174, 33);
            this.AddManNameComboBox.TabIndex = 36;
            // 
            // AddManGoBackBtn
            // 
            this.AddManGoBackBtn.Location = new System.Drawing.Point(651, 172);
            this.AddManGoBackBtn.Name = "AddManGoBackBtn";
            this.AddManGoBackBtn.Size = new System.Drawing.Size(137, 45);
            this.AddManGoBackBtn.TabIndex = 37;
            this.AddManGoBackBtn.Text = "Go Back";
            this.AddManGoBackBtn.UseVisualStyleBackColor = true;
            this.AddManGoBackBtn.Click += new System.EventHandler(this.AddManGoBackBtn_Click);
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 245);
            this.Controls.Add(this.AddManGoBackBtn);
            this.Controls.Add(this.AddManNameComboBox);
            this.Controls.Add(this.AddManStoreComboBox);
            this.Controls.Add(this.AddManagerButton);
            this.Controls.Add(this.AddManNameLabel);
            this.Controls.Add(this.AddManStoreLabel);
            this.Name = "AddManager";
            this.Text = "AddManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddManagerButton;
        private Label AddManNameLabel;
        private Label AddManStoreLabel;
        private ComboBox AddManStoreComboBox;
        private ComboBox AddManNameComboBox;
        private Button AddManGoBackBtn;
    }
}