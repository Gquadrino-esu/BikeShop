namespace BikeShop
{
    partial class AddBike
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBikeYearTextBox = new System.Windows.Forms.TextBox();
            this.BikeYearLabel = new System.Windows.Forms.Label();
            this.AddBikePriceTextBox = new System.Windows.Forms.TextBox();
            this.BikePriceLabel = new System.Windows.Forms.Label();
            this.AddBikeTextBox = new System.Windows.Forms.TextBox();
            this.BikeNameLabel = new System.Windows.Forms.Label();
            this.AddBikeButton = new System.Windows.Forms.Button();
            this.AddBikeGoBackButton = new System.Windows.Forms.Button();
            this.AddBikeBrandComboBox = new System.Windows.Forms.ComboBox();
            this.AddBikeCatComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bike Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bike Category";
            // 
            // AddBikeYearTextBox
            // 
            this.AddBikeYearTextBox.Location = new System.Drawing.Point(224, 56);
            this.AddBikeYearTextBox.Name = "AddBikeYearTextBox";
            this.AddBikeYearTextBox.Size = new System.Drawing.Size(182, 31);
            this.AddBikeYearTextBox.TabIndex = 14;
            this.AddBikeYearTextBox.TextChanged += new System.EventHandler(this.AddBikeYearTextBox_TextChanged);
            // 
            // BikeYearLabel
            // 
            this.BikeYearLabel.AutoSize = true;
            this.BikeYearLabel.Location = new System.Drawing.Point(220, 9);
            this.BikeYearLabel.Name = "BikeYearLabel";
            this.BikeYearLabel.Size = new System.Drawing.Size(81, 25);
            this.BikeYearLabel.TabIndex = 16;
            this.BikeYearLabel.Text = "Bike Year";
            // 
            // AddBikePriceTextBox
            // 
            this.AddBikePriceTextBox.Location = new System.Drawing.Point(449, 56);
            this.AddBikePriceTextBox.Name = "AddBikePriceTextBox";
            this.AddBikePriceTextBox.Size = new System.Drawing.Size(182, 31);
            this.AddBikePriceTextBox.TabIndex = 15;
            this.AddBikePriceTextBox.TextChanged += new System.EventHandler(this.AddBikePriceTextBox_TextChanged);
            // 
            // BikePriceLabel
            // 
            this.BikePriceLabel.AutoSize = true;
            this.BikePriceLabel.Location = new System.Drawing.Point(445, 9);
            this.BikePriceLabel.Name = "BikePriceLabel";
            this.BikePriceLabel.Size = new System.Drawing.Size(86, 25);
            this.BikePriceLabel.TabIndex = 14;
            this.BikePriceLabel.Text = "Bike Price";
            // 
            // AddBikeTextBox
            // 
            this.AddBikeTextBox.Location = new System.Drawing.Point(16, 56);
            this.AddBikeTextBox.Name = "AddBikeTextBox";
            this.AddBikeTextBox.Size = new System.Drawing.Size(182, 31);
            this.AddBikeTextBox.TabIndex = 13;
            this.AddBikeTextBox.TextChanged += new System.EventHandler(this.AddBikeTextBox_TextChanged);
            // 
            // BikeNameLabel
            // 
            this.BikeNameLabel.AutoSize = true;
            this.BikeNameLabel.Location = new System.Drawing.Point(12, 9);
            this.BikeNameLabel.Name = "BikeNameLabel";
            this.BikeNameLabel.Size = new System.Drawing.Size(96, 25);
            this.BikeNameLabel.TabIndex = 12;
            this.BikeNameLabel.Text = "Bike Name";
            // 
            // AddBikeButton
            // 
            this.AddBikeButton.Enabled = false;
            this.AddBikeButton.Location = new System.Drawing.Point(20, 319);
            this.AddBikeButton.Name = "AddBikeButton";
            this.AddBikeButton.Size = new System.Drawing.Size(260, 48);
            this.AddBikeButton.TabIndex = 25;
            this.AddBikeButton.Text = "Add Bike";
            this.AddBikeButton.UseVisualStyleBackColor = true;
            this.AddBikeButton.Click += new System.EventHandler(this.AddBikeButton_Click);
            // 
            // AddBikeGoBackButton
            // 
            this.AddBikeGoBackButton.Location = new System.Drawing.Point(598, 319);
            this.AddBikeGoBackButton.Name = "AddBikeGoBackButton";
            this.AddBikeGoBackButton.Size = new System.Drawing.Size(190, 48);
            this.AddBikeGoBackButton.TabIndex = 26;
            this.AddBikeGoBackButton.Text = "Go Back";
            this.AddBikeGoBackButton.UseVisualStyleBackColor = true;
            this.AddBikeGoBackButton.Click += new System.EventHandler(this.AddBikeGoBackButton_Click);
            // 
            // AddBikeBrandComboBox
            // 
            this.AddBikeBrandComboBox.FormattingEnabled = true;
            this.AddBikeBrandComboBox.Location = new System.Drawing.Point(12, 194);
            this.AddBikeBrandComboBox.Name = "AddBikeBrandComboBox";
            this.AddBikeBrandComboBox.Size = new System.Drawing.Size(154, 33);
            this.AddBikeBrandComboBox.TabIndex = 23;
            this.AddBikeBrandComboBox.SelectedIndexChanged += new System.EventHandler(this.AddBikeBrandComboBox_SelectedIndexChanged);
            // 
            // AddBikeCatComboBox
            // 
            this.AddBikeCatComboBox.FormattingEnabled = true;
            this.AddBikeCatComboBox.Location = new System.Drawing.Point(244, 194);
            this.AddBikeCatComboBox.Name = "AddBikeCatComboBox";
            this.AddBikeCatComboBox.Size = new System.Drawing.Size(139, 33);
            this.AddBikeCatComboBox.TabIndex = 24;
            this.AddBikeCatComboBox.SelectedIndexChanged += new System.EventHandler(this.AddBikeCatComboBox_SelectedIndexChanged);
            // 
            // AddBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.AddBikeCatComboBox);
            this.Controls.Add(this.AddBikeBrandComboBox);
            this.Controls.Add(this.AddBikeGoBackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddBikeYearTextBox);
            this.Controls.Add(this.BikeYearLabel);
            this.Controls.Add(this.AddBikePriceTextBox);
            this.Controls.Add(this.BikePriceLabel);
            this.Controls.Add(this.AddBikeTextBox);
            this.Controls.Add(this.BikeNameLabel);
            this.Controls.Add(this.AddBikeButton);
            this.Name = "AddBike";
            this.Text = "AddBike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox AddBikeYearTextBox;
        private Label BikeYearLabel;
        private TextBox AddBikePriceTextBox;
        private Label BikePriceLabel;
        private TextBox AddBikeTextBox;
        private Label BikeNameLabel;
        private Button AddBikeButton;
        private Button AddBikeGoBackButton;
        private ComboBox AddBikeBrandComboBox;
        private ComboBox AddBikeCatComboBox;
    }
}