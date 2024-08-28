using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeShop
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new();
            orderForm.ShowDialog();
            this.Close();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventoryForm = new();
            inventoryForm.ShowDialog();
            this.Close();
        }
    }
}
