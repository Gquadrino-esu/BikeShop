using Microsoft.Data.SqlClient;
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
    public partial class AddStore : Form
    {
        string connectionString, sqlQuery;
        SqlConnection con;
        SqlCommand sc;

        public AddStore()
        {
            InitializeComponent();
        }

        private void AddStoreGoBackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Inventory invent = new();
            invent.ShowDialog();
            Close();
        }

        private void AddStoreNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckForContent())
            {
                AddStoreButton.Enabled = true;
            }
            else
            {
                AddStoreButton.Enabled = false;
            }
        }

        private void AddStoreNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddStoreNumberTextBox.TextLength == 10)
            {
                AddStoreNumberTextBox.ForeColor = Color.Black;
                if (CheckForContent())
                {
                    AddStoreButton.Enabled = true;
                }
                else
                {
                    AddStoreButton.Enabled = false;
                }
            }
            else
            {
                AddStoreNumberTextBox.ForeColor = Color.Red;
                AddStoreButton.Enabled = false;
            }
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=GABELAPTOP\\SQLEXPRESS; Initial Catalog=BikeShop; Integrated Security=True; TrustServerCertificate=True";

            sqlQuery = "INSERT INTO Store (StoreName, StorePhone) Values ('"
                + AddStoreNameTextBox.Text + "','" + AddStoreNumberTextBox.Text + "')";

            con = new SqlConnection(connectionString);

            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();

            AddStoreNumberTextBox.Text = "";
            AddStoreNameTextBox.Text = "";
        }

        private void AddStoreNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error, a phone number cannot contain letters.");
            }
        }

        public bool CheckForContent()
        {
            if (!AddStoreNameTextBox.Text.Trim().Equals("")
                && !AddStoreNumberTextBox.Text.Trim().Equals(""))
            {
                return true;
            }

            return false;
        }
    }
}
