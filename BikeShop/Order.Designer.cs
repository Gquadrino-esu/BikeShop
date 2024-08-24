namespace BikeShop
{
    partial class OrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StoreLabel = new System.Windows.Forms.Label();
            this.OrderStaffLabel = new System.Windows.Forms.Label();
            this.CustomerFNameLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.OrderBikeNameLabel1 = new System.Windows.Forms.Label();
            this.OrderBikeQuantityLabel1 = new System.Windows.Forms.Label();
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.ItemsOnOrderLabel = new System.Windows.Forms.Label();
            this.OrderStaffButton = new System.Windows.Forms.Button();
            this.OrderManagerButton = new System.Windows.Forms.Button();
            this.OrderCustomerButton = new System.Windows.Forms.Button();
            this.OrderAddItemButton = new System.Windows.Forms.Button();
            this.OrderStoreItemLabel1 = new System.Windows.Forms.Label();
            this.OrderStoreComboBox = new System.Windows.Forms.ComboBox();
            this.OrderStaffComboBox = new System.Windows.Forms.ComboBox();
            this.OrderCustComboBox = new System.Windows.Forms.ComboBox();
            this.OrderBikeStoreComboBox = new System.Windows.Forms.ComboBox();
            this.OrderBikeComboBox = new System.Windows.Forms.ComboBox();
            this.OrderGoBackBtn = new System.Windows.Forms.Button();
            this.OrderBikeQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.OrderDiscountTextBox = new System.Windows.Forms.TextBox();
            this.OrderErrorLabel = new System.Windows.Forms.Label();
            this.OrderItemCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StoreLabel
            // 
            this.StoreLabel.AutoSize = true;
            this.StoreLabel.Location = new System.Drawing.Point(64, 25);
            this.StoreLabel.Name = "StoreLabel";
            this.StoreLabel.Size = new System.Drawing.Size(53, 25);
            this.StoreLabel.TabIndex = 0;
            this.StoreLabel.Text = "Store";
            // 
            // OrderStaffLabel
            // 
            this.OrderStaffLabel.AutoSize = true;
            this.OrderStaffLabel.Location = new System.Drawing.Point(230, 25);
            this.OrderStaffLabel.Name = "OrderStaffLabel";
            this.OrderStaffLabel.Size = new System.Drawing.Size(48, 25);
            this.OrderStaffLabel.TabIndex = 1;
            this.OrderStaffLabel.Text = "Staff";
            // 
            // CustomerFNameLabel
            // 
            this.CustomerFNameLabel.AutoSize = true;
            this.CustomerFNameLabel.Location = new System.Drawing.Point(595, 23);
            this.CustomerFNameLabel.Name = "CustomerFNameLabel";
            this.CustomerFNameLabel.Size = new System.Drawing.Size(141, 25);
            this.CustomerFNameLabel.TabIndex = 2;
            this.CustomerFNameLabel.Text = "Customer Name";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(435, 25);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(82, 25);
            this.DiscountLabel.TabIndex = 3;
            this.DiscountLabel.Text = "Discount";
            // 
            // OrderBikeNameLabel1
            // 
            this.OrderBikeNameLabel1.AutoSize = true;
            this.OrderBikeNameLabel1.Location = new System.Drawing.Point(64, 266);
            this.OrderBikeNameLabel1.Name = "OrderBikeNameLabel1";
            this.OrderBikeNameLabel1.Size = new System.Drawing.Size(96, 25);
            this.OrderBikeNameLabel1.TabIndex = 5;
            this.OrderBikeNameLabel1.Text = "Bike Name";
            // 
            // OrderBikeQuantityLabel1
            // 
            this.OrderBikeQuantityLabel1.AutoSize = true;
            this.OrderBikeQuantityLabel1.Location = new System.Drawing.Point(64, 371);
            this.OrderBikeQuantityLabel1.Name = "OrderBikeQuantityLabel1";
            this.OrderBikeQuantityLabel1.Size = new System.Drawing.Size(80, 25);
            this.OrderBikeQuantityLabel1.TabIndex = 6;
            this.OrderBikeQuantityLabel1.Text = "Quantity";
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.Location = new System.Drawing.Point(12, 547);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(166, 41);
            this.CompleteOrderButton.TabIndex = 7;
            this.CompleteOrderButton.Text = "Complete Order";
            this.CompleteOrderButton.UseVisualStyleBackColor = true;
            this.CompleteOrderButton.Click += new System.EventHandler(this.CompleteOrderButton_Click);
            // 
            // ItemsOnOrderLabel
            // 
            this.ItemsOnOrderLabel.AutoSize = true;
            this.ItemsOnOrderLabel.Location = new System.Drawing.Point(64, 120);
            this.ItemsOnOrderLabel.Name = "ItemsOnOrderLabel";
            this.ItemsOnOrderLabel.Size = new System.Drawing.Size(137, 25);
            this.ItemsOnOrderLabel.TabIndex = 8;
            this.ItemsOnOrderLabel.Text = "Items on Order:";
            // 
            // OrderStaffButton
            // 
            this.OrderStaffButton.Location = new System.Drawing.Point(336, 547);
            this.OrderStaffButton.Name = "OrderStaffButton";
            this.OrderStaffButton.Size = new System.Drawing.Size(126, 41);
            this.OrderStaffButton.TabIndex = 17;
            this.OrderStaffButton.Text = "Add Staff";
            this.OrderStaffButton.UseVisualStyleBackColor = true;
            this.OrderStaffButton.Click += new System.EventHandler(this.StaffButton_Click);
            // 
            // OrderManagerButton
            // 
            this.OrderManagerButton.Location = new System.Drawing.Point(468, 547);
            this.OrderManagerButton.Name = "OrderManagerButton";
            this.OrderManagerButton.Size = new System.Drawing.Size(201, 41);
            this.OrderManagerButton.TabIndex = 18;
            this.OrderManagerButton.Text = "Add/Change Manager";
            this.OrderManagerButton.UseVisualStyleBackColor = true;
            this.OrderManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // OrderCustomerButton
            // 
            this.OrderCustomerButton.Location = new System.Drawing.Point(184, 547);
            this.OrderCustomerButton.Name = "OrderCustomerButton";
            this.OrderCustomerButton.Size = new System.Drawing.Size(146, 41);
            this.OrderCustomerButton.TabIndex = 19;
            this.OrderCustomerButton.Text = "Add Customer";
            this.OrderCustomerButton.UseVisualStyleBackColor = true;
            this.OrderCustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // OrderAddItemButton
            // 
            this.OrderAddItemButton.Location = new System.Drawing.Point(591, 186);
            this.OrderAddItemButton.Name = "OrderAddItemButton";
            this.OrderAddItemButton.Size = new System.Drawing.Size(187, 42);
            this.OrderAddItemButton.TabIndex = 20;
            this.OrderAddItemButton.Text = "Add Item";
            this.OrderAddItemButton.UseVisualStyleBackColor = true;
            this.OrderAddItemButton.Click += new System.EventHandler(this.OrderAddItemButton_Click);
            // 
            // OrderStoreItemLabel1
            // 
            this.OrderStoreItemLabel1.AutoSize = true;
            this.OrderStoreItemLabel1.Location = new System.Drawing.Point(64, 156);
            this.OrderStoreItemLabel1.Name = "OrderStoreItemLabel1";
            this.OrderStoreItemLabel1.Size = new System.Drawing.Size(53, 25);
            this.OrderStoreItemLabel1.TabIndex = 24;
            this.OrderStoreItemLabel1.Text = "Store";
            // 
            // OrderStoreComboBox
            // 
            this.OrderStoreComboBox.FormattingEnabled = true;
            this.OrderStoreComboBox.Location = new System.Drawing.Point(64, 72);
            this.OrderStoreComboBox.Name = "OrderStoreComboBox";
            this.OrderStoreComboBox.Size = new System.Drawing.Size(136, 33);
            this.OrderStoreComboBox.TabIndex = 26;
            this.OrderStoreComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderStoreComboBox_SelectedIndexChanged);
            // 
            // OrderStaffComboBox
            // 
            this.OrderStaffComboBox.FormattingEnabled = true;
            this.OrderStaffComboBox.Location = new System.Drawing.Point(230, 72);
            this.OrderStaffComboBox.Name = "OrderStaffComboBox";
            this.OrderStaffComboBox.Size = new System.Drawing.Size(168, 33);
            this.OrderStaffComboBox.TabIndex = 27;
            // 
            // OrderCustComboBox
            // 
            this.OrderCustComboBox.FormattingEnabled = true;
            this.OrderCustComboBox.Location = new System.Drawing.Point(595, 72);
            this.OrderCustComboBox.Name = "OrderCustComboBox";
            this.OrderCustComboBox.Size = new System.Drawing.Size(183, 33);
            this.OrderCustComboBox.TabIndex = 28;
            // 
            // OrderBikeStoreComboBox
            // 
            this.OrderBikeStoreComboBox.Enabled = false;
            this.OrderBikeStoreComboBox.FormattingEnabled = true;
            this.OrderBikeStoreComboBox.Location = new System.Drawing.Point(64, 195);
            this.OrderBikeStoreComboBox.Name = "OrderBikeStoreComboBox";
            this.OrderBikeStoreComboBox.Size = new System.Drawing.Size(168, 33);
            this.OrderBikeStoreComboBox.TabIndex = 30;
            this.OrderBikeStoreComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderStoreComboBox1_SelectedIndexChanged);
            // 
            // OrderBikeComboBox
            // 
            this.OrderBikeComboBox.Enabled = false;
            this.OrderBikeComboBox.FormattingEnabled = true;
            this.OrderBikeComboBox.Location = new System.Drawing.Point(64, 305);
            this.OrderBikeComboBox.Name = "OrderBikeComboBox";
            this.OrderBikeComboBox.Size = new System.Drawing.Size(597, 33);
            this.OrderBikeComboBox.TabIndex = 31;
            this.OrderBikeComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderBikeComboBox_SelectedIndexChanged);
            // 
            // OrderGoBackBtn
            // 
            this.OrderGoBackBtn.Location = new System.Drawing.Point(745, 547);
            this.OrderGoBackBtn.Name = "OrderGoBackBtn";
            this.OrderGoBackBtn.Size = new System.Drawing.Size(166, 41);
            this.OrderGoBackBtn.TabIndex = 32;
            this.OrderGoBackBtn.Text = "Go Back";
            this.OrderGoBackBtn.UseVisualStyleBackColor = true;
            this.OrderGoBackBtn.Click += new System.EventHandler(this.OrderGoBackBtn_Click);
            // 
            // OrderBikeQuantityComboBox
            // 
            this.OrderBikeQuantityComboBox.Enabled = false;
            this.OrderBikeQuantityComboBox.FormattingEnabled = true;
            this.OrderBikeQuantityComboBox.Location = new System.Drawing.Point(64, 410);
            this.OrderBikeQuantityComboBox.Name = "OrderBikeQuantityComboBox";
            this.OrderBikeQuantityComboBox.Size = new System.Drawing.Size(64, 33);
            this.OrderBikeQuantityComboBox.TabIndex = 33;
            // 
            // OrderDiscountTextBox
            // 
            this.OrderDiscountTextBox.Location = new System.Drawing.Point(435, 74);
            this.OrderDiscountTextBox.Name = "OrderDiscountTextBox";
            this.OrderDiscountTextBox.Size = new System.Drawing.Size(72, 31);
            this.OrderDiscountTextBox.TabIndex = 34;
            this.OrderDiscountTextBox.Text = "0";
            // 
            // OrderErrorLabel
            // 
            this.OrderErrorLabel.AutoSize = true;
            this.OrderErrorLabel.Location = new System.Drawing.Point(348, 120);
            this.OrderErrorLabel.Name = "OrderErrorLabel";
            this.OrderErrorLabel.Size = new System.Drawing.Size(50, 25);
            this.OrderErrorLabel.TabIndex = 35;
            this.OrderErrorLabel.Text = "Error";
            // 
            // OrderItemCountLabel
            // 
            this.OrderItemCountLabel.AutoSize = true;
            this.OrderItemCountLabel.Location = new System.Drawing.Point(230, 120);
            this.OrderItemCountLabel.Name = "OrderItemCountLabel";
            this.OrderItemCountLabel.Size = new System.Drawing.Size(74, 25);
            this.OrderItemCountLabel.TabIndex = 36;
            this.OrderItemCountLabel.Text = "Item #1";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 600);
            this.Controls.Add(this.OrderItemCountLabel);
            this.Controls.Add(this.OrderErrorLabel);
            this.Controls.Add(this.OrderDiscountTextBox);
            this.Controls.Add(this.OrderBikeQuantityComboBox);
            this.Controls.Add(this.OrderGoBackBtn);
            this.Controls.Add(this.OrderBikeComboBox);
            this.Controls.Add(this.OrderBikeStoreComboBox);
            this.Controls.Add(this.OrderCustComboBox);
            this.Controls.Add(this.OrderStaffComboBox);
            this.Controls.Add(this.OrderStoreComboBox);
            this.Controls.Add(this.OrderStoreItemLabel1);
            this.Controls.Add(this.OrderAddItemButton);
            this.Controls.Add(this.OrderCustomerButton);
            this.Controls.Add(this.OrderManagerButton);
            this.Controls.Add(this.OrderStaffButton);
            this.Controls.Add(this.ItemsOnOrderLabel);
            this.Controls.Add(this.CompleteOrderButton);
            this.Controls.Add(this.OrderBikeQuantityLabel1);
            this.Controls.Add(this.OrderBikeNameLabel1);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.CustomerFNameLabel);
            this.Controls.Add(this.OrderStaffLabel);
            this.Controls.Add(this.StoreLabel);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label StoreLabel;
        private Label OrderStaffLabel;
        private Label CustomerFNameLabel;
        private Label DiscountLabel;
        private Label OrderBikeNameLabel1;
        private Label OrderBikeQuantityLabel1;
        private Button CompleteOrderButton;
        private Label ItemsOnOrderLabel;
        private Button OrderStaffButton;
        private Button OrderManagerButton;
        private Button OrderCustomerButton;
        private Button OrderAddItemButton;
        private Label OrderStoreItemLabel1;
        private ComboBox OrderStoreComboBox;
        private ComboBox OrderStaffComboBox;
        private ComboBox OrderCustComboBox;
        private ComboBox OrderBikeStoreComboBox;
        private ComboBox OrderBikeComboBox;
        private Button OrderGoBackBtn;
        private ComboBox OrderBikeQuantityComboBox;
        private TextBox OrderDiscountTextBox;
        private Label OrderErrorLabel;
        private Label OrderItemCountLabel;
    }
}