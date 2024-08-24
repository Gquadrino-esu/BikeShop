namespace BikeShop
{
    partial class Inventory
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
            this.ItemsByOrderButton = new System.Windows.Forms.Button();
            this.ItemsByStaffButton = new System.Windows.Forms.Button();
            this.ItemsByStoreButton = new System.Windows.Forms.Button();
            this.BikeQtyButton = new System.Windows.Forms.Button();
            this.BikeNameButton = new System.Windows.Forms.Button();
            this.InventoryAddInventButton = new System.Windows.Forms.Button();
            this.InventoryGoBackBtn = new System.Windows.Forms.Button();
            this.InventAddStoreButton = new System.Windows.Forms.Button();
            this.InventChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.InventChoiceLabel = new System.Windows.Forms.Label();
            this.InventChoiceButton = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // ItemsByOrderButton
            // 
            this.ItemsByOrderButton.Location = new System.Drawing.Point(244, 144);
            this.ItemsByOrderButton.Name = "ItemsByOrderButton";
            this.ItemsByOrderButton.Size = new System.Drawing.Size(226, 72);
            this.ItemsByOrderButton.TabIndex = 30;
            this.ItemsByOrderButton.Text = "All Items Sold by all Orders";
            this.ItemsByOrderButton.UseVisualStyleBackColor = true;
            this.ItemsByOrderButton.Click += new System.EventHandler(this.ItemsByOrderButton_Click);
            // 
            // ItemsByStaffButton
            // 
            this.ItemsByStaffButton.Location = new System.Drawing.Point(244, 79);
            this.ItemsByStaffButton.Name = "ItemsByStaffButton";
            this.ItemsByStaffButton.Size = new System.Drawing.Size(226, 41);
            this.ItemsByStaffButton.TabIndex = 29;
            this.ItemsByStaffButton.Text = "Items Sold by Staff";
            this.ItemsByStaffButton.UseVisualStyleBackColor = true;
            this.ItemsByStaffButton.Click += new System.EventHandler(this.ItemsByStaffButton_Click);
            // 
            // ItemsByStoreButton
            // 
            this.ItemsByStoreButton.Location = new System.Drawing.Point(244, 12);
            this.ItemsByStoreButton.Name = "ItemsByStoreButton";
            this.ItemsByStoreButton.Size = new System.Drawing.Size(226, 41);
            this.ItemsByStoreButton.TabIndex = 28;
            this.ItemsByStoreButton.Text = "Items Sold by Store";
            this.ItemsByStoreButton.UseVisualStyleBackColor = true;
            this.ItemsByStoreButton.Click += new System.EventHandler(this.ItemsByStoreButton_Click);
            // 
            // BikeQtyButton
            // 
            this.BikeQtyButton.Location = new System.Drawing.Point(12, 144);
            this.BikeQtyButton.Name = "BikeQtyButton";
            this.BikeQtyButton.Size = new System.Drawing.Size(226, 72);
            this.BikeQtyButton.TabIndex = 27;
            this.BikeQtyButton.Text = "Bike Qty Availability at all Stores";
            this.BikeQtyButton.UseVisualStyleBackColor = true;
            this.BikeQtyButton.Click += new System.EventHandler(this.BikeQtyButton_Click);
            // 
            // BikeNameButton
            // 
            this.BikeNameButton.Location = new System.Drawing.Point(12, 79);
            this.BikeNameButton.Name = "BikeNameButton";
            this.BikeNameButton.Size = new System.Drawing.Size(226, 41);
            this.BikeNameButton.TabIndex = 26;
            this.BikeNameButton.Text = "Add Bike Name";
            this.BikeNameButton.UseVisualStyleBackColor = true;
            this.BikeNameButton.Click += new System.EventHandler(this.BikeNameButton_Click);
            // 
            // InventoryAddInventButton
            // 
            this.InventoryAddInventButton.Location = new System.Drawing.Point(12, 12);
            this.InventoryAddInventButton.Name = "InventoryAddInventButton";
            this.InventoryAddInventButton.Size = new System.Drawing.Size(226, 41);
            this.InventoryAddInventButton.TabIndex = 25;
            this.InventoryAddInventButton.Text = "Add Inventory to Stores";
            this.InventoryAddInventButton.UseVisualStyleBackColor = true;
            this.InventoryAddInventButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // InventoryGoBackBtn
            // 
            this.InventoryGoBackBtn.Location = new System.Drawing.Point(562, 175);
            this.InventoryGoBackBtn.Name = "InventoryGoBackBtn";
            this.InventoryGoBackBtn.Size = new System.Drawing.Size(226, 41);
            this.InventoryGoBackBtn.TabIndex = 34;
            this.InventoryGoBackBtn.Text = "Go Back";
            this.InventoryGoBackBtn.UseVisualStyleBackColor = true;
            this.InventoryGoBackBtn.Click += new System.EventHandler(this.InventoryGoBackBtn_Click);
            // 
            // InventAddStoreButton
            // 
            this.InventAddStoreButton.Location = new System.Drawing.Point(476, 12);
            this.InventAddStoreButton.Name = "InventAddStoreButton";
            this.InventAddStoreButton.Size = new System.Drawing.Size(226, 41);
            this.InventAddStoreButton.TabIndex = 35;
            this.InventAddStoreButton.Text = "Add Store";
            this.InventAddStoreButton.UseVisualStyleBackColor = true;
            this.InventAddStoreButton.Click += new System.EventHandler(this.InventAddStoreButton_Click);
            // 
            // InventChoiceComboBox
            // 
            this.InventChoiceComboBox.FormattingEnabled = true;
            this.InventChoiceComboBox.Location = new System.Drawing.Point(12, 264);
            this.InventChoiceComboBox.Name = "InventChoiceComboBox";
            this.InventChoiceComboBox.Size = new System.Drawing.Size(216, 33);
            this.InventChoiceComboBox.TabIndex = 36;
            this.InventChoiceComboBox.Visible = false;
            this.InventChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.InventChoiceComboBox_SelectedIndexChanged);
            // 
            // InventChoiceLabel
            // 
            this.InventChoiceLabel.AutoSize = true;
            this.InventChoiceLabel.Location = new System.Drawing.Point(12, 236);
            this.InventChoiceLabel.Name = "InventChoiceLabel";
            this.InventChoiceLabel.Size = new System.Drawing.Size(59, 25);
            this.InventChoiceLabel.TabIndex = 37;
            this.InventChoiceLabel.Text = "label1";
            this.InventChoiceLabel.Visible = false;
            // 
            // InventChoiceButton
            // 
            this.InventChoiceButton.Enabled = false;
            this.InventChoiceButton.Location = new System.Drawing.Point(244, 264);
            this.InventChoiceButton.Name = "InventChoiceButton";
            this.InventChoiceButton.Size = new System.Drawing.Size(101, 33);
            this.InventChoiceButton.TabIndex = 38;
            this.InventChoiceButton.Text = "button1";
            this.InventChoiceButton.UseVisualStyleBackColor = true;
            this.InventChoiceButton.Visible = false;
            this.InventChoiceButton.Click += new System.EventHandler(this.InventChoiceButton_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 976);
            this.Controls.Add(this.InventChoiceButton);
            this.Controls.Add(this.InventChoiceLabel);
            this.Controls.Add(this.InventChoiceComboBox);
            this.Controls.Add(this.InventAddStoreButton);
            this.Controls.Add(this.InventoryGoBackBtn);
            this.Controls.Add(this.ItemsByOrderButton);
            this.Controls.Add(this.ItemsByStaffButton);
            this.Controls.Add(this.ItemsByStoreButton);
            this.Controls.Add(this.BikeQtyButton);
            this.Controls.Add(this.BikeNameButton);
            this.Controls.Add(this.InventoryAddInventButton);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ItemsByOrderButton;
        private Button ItemsByStaffButton;
        private Button ItemsByStoreButton;
        private Button BikeQtyButton;
        private Button BikeNameButton;
        private Button InventoryAddInventButton;
        private Button InventoryGoBackBtn;
        private Button InventAddStoreButton;
        private ComboBox InventChoiceComboBox;
        private Label InventChoiceLabel;
        private Button InventChoiceButton;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}