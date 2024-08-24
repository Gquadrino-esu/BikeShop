namespace BikeShop
{
    partial class AddInventoryToStores
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
            this.AddInventBikeNameComboBox = new System.Windows.Forms.ComboBox();
            this.AddInventBikeQuantityLabel = new System.Windows.Forms.Label();
            this.AddInventBikeNameLabel = new System.Windows.Forms.Label();
            this.AddInventStoreNameComboBox = new System.Windows.Forms.ComboBox();
            this.AddInventStoreNameLabel = new System.Windows.Forms.Label();
            this.AddInventButton = new System.Windows.Forms.Button();
            this.AddInventQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.AddInventGoBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddInventBikeNameComboBox
            // 
            this.AddInventBikeNameComboBox.FormattingEnabled = true;
            this.AddInventBikeNameComboBox.Location = new System.Drawing.Point(207, 56);
            this.AddInventBikeNameComboBox.Name = "AddInventBikeNameComboBox";
            this.AddInventBikeNameComboBox.Size = new System.Drawing.Size(114, 33);
            this.AddInventBikeNameComboBox.TabIndex = 18;
            this.AddInventBikeNameComboBox.SelectedIndexChanged += new System.EventHandler(this.AddInventBikeNameComboBox_SelectedIndexChanged);
            // 
            // AddInventBikeQuantityLabel
            // 
            this.AddInventBikeQuantityLabel.AutoSize = true;
            this.AddInventBikeQuantityLabel.Location = new System.Drawing.Point(413, 9);
            this.AddInventBikeQuantityLabel.Name = "AddInventBikeQuantityLabel";
            this.AddInventBikeQuantityLabel.Size = new System.Drawing.Size(80, 25);
            this.AddInventBikeQuantityLabel.TabIndex = 17;
            this.AddInventBikeQuantityLabel.Text = "Quantity";
            // 
            // AddInventBikeNameLabel
            // 
            this.AddInventBikeNameLabel.AutoSize = true;
            this.AddInventBikeNameLabel.Location = new System.Drawing.Point(207, 9);
            this.AddInventBikeNameLabel.Name = "AddInventBikeNameLabel";
            this.AddInventBikeNameLabel.Size = new System.Drawing.Size(96, 25);
            this.AddInventBikeNameLabel.TabIndex = 16;
            this.AddInventBikeNameLabel.Text = "Bike Name";
            // 
            // AddInventStoreNameComboBox
            // 
            this.AddInventStoreNameComboBox.FormattingEnabled = true;
            this.AddInventStoreNameComboBox.Location = new System.Drawing.Point(12, 56);
            this.AddInventStoreNameComboBox.Name = "AddInventStoreNameComboBox";
            this.AddInventStoreNameComboBox.Size = new System.Drawing.Size(114, 33);
            this.AddInventStoreNameComboBox.TabIndex = 21;
            this.AddInventStoreNameComboBox.SelectedIndexChanged += new System.EventHandler(this.AddInventStoreNameComboBox_SelectedIndexChanged);
            // 
            // AddInventStoreNameLabel
            // 
            this.AddInventStoreNameLabel.AutoSize = true;
            this.AddInventStoreNameLabel.Location = new System.Drawing.Point(12, 9);
            this.AddInventStoreNameLabel.Name = "AddInventStoreNameLabel";
            this.AddInventStoreNameLabel.Size = new System.Drawing.Size(105, 25);
            this.AddInventStoreNameLabel.TabIndex = 20;
            this.AddInventStoreNameLabel.Text = "Store Name";
            // 
            // AddInventButton
            // 
            this.AddInventButton.Enabled = false;
            this.AddInventButton.Location = new System.Drawing.Point(12, 135);
            this.AddInventButton.Name = "AddInventButton";
            this.AddInventButton.Size = new System.Drawing.Size(149, 47);
            this.AddInventButton.TabIndex = 22;
            this.AddInventButton.Text = "Add Inventory";
            this.AddInventButton.UseVisualStyleBackColor = true;
            this.AddInventButton.Click += new System.EventHandler(this.AddInventButton_Click);
            // 
            // AddInventQuantityComboBox
            // 
            this.AddInventQuantityComboBox.FormattingEnabled = true;
            this.AddInventQuantityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.AddInventQuantityComboBox.Location = new System.Drawing.Point(413, 56);
            this.AddInventQuantityComboBox.Name = "AddInventQuantityComboBox";
            this.AddInventQuantityComboBox.Size = new System.Drawing.Size(77, 33);
            this.AddInventQuantityComboBox.TabIndex = 23;
            this.AddInventQuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.AddInventQuantityComboBox_SelectedIndexChanged);
            // 
            // AddInventGoBackButton
            // 
            this.AddInventGoBackButton.Location = new System.Drawing.Point(661, 135);
            this.AddInventGoBackButton.Name = "AddInventGoBackButton";
            this.AddInventGoBackButton.Size = new System.Drawing.Size(127, 47);
            this.AddInventGoBackButton.TabIndex = 24;
            this.AddInventGoBackButton.Text = "Go Back";
            this.AddInventGoBackButton.UseVisualStyleBackColor = true;
            this.AddInventGoBackButton.Click += new System.EventHandler(this.AddInventGoBackButton_Click);
            // 
            // AddInventoryToStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.AddInventGoBackButton);
            this.Controls.Add(this.AddInventQuantityComboBox);
            this.Controls.Add(this.AddInventButton);
            this.Controls.Add(this.AddInventStoreNameComboBox);
            this.Controls.Add(this.AddInventStoreNameLabel);
            this.Controls.Add(this.AddInventBikeNameComboBox);
            this.Controls.Add(this.AddInventBikeQuantityLabel);
            this.Controls.Add(this.AddInventBikeNameLabel);
            this.Name = "AddInventoryToStores";
            this.Text = "AddInventoryToStores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox AddInventBikeNameComboBox;
        private Label AddInventBikeQuantityLabel;
        private Label AddInventBikeNameLabel;
        private ComboBox AddInventStoreNameComboBox;
        private Label AddInventStoreNameLabel;
        private Button AddInventButton;
        private ComboBox AddInventQuantityComboBox;
        private Button AddInventGoBackButton;
    }
}