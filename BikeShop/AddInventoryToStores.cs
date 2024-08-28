using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeShop
{
    public partial class AddInventoryToStores : Form
    {
        string connectionString, sqlQuery, storeName, bikeName;
        int storeID, bikeNameID;
        SqlConnection con;
        SqlCommand sc;
        SqlDataReader dr;

        public AddInventoryToStores()
        {
            InitializeComponent();

            // Gets data from database to Store drop down
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringBikeShop"].ConnectionString;
            sqlQuery = "select * from Store";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    storeName = dr["StoreName"].ToString();
                    AddInventStoreNameComboBox.Items.Add(storeName);
                }
            }

            con.Close();

            // Gets data from database to Bike Name drop down
            sqlQuery = "select * from BikeName";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    bikeName = dr["BikeName"].ToString();
                    AddInventBikeNameComboBox.Items.Add(bikeName);
                }
            }
            con.Close();
        }

        private void AddInventStoreNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckComboBoxes())
            {
                AddInventButton.Enabled = true;
            }
        }

        private void AddInventBikeNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckComboBoxes())
            {
                AddInventButton.Enabled = true;
            }
        }

        private void AddInventQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckComboBoxes())
            {
                AddInventButton.Enabled = true;
            }
        }

        private void AddInventGoBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Inventory inventory = new();
            inventory.ShowDialog();
            Close();
        }

        private void AddInventButton_Click(object sender, EventArgs e)
        {
            sqlQuery = "SELECT StoreID FROM Store WHERE StoreName='" + AddInventStoreNameComboBox.Text + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                storeID = int.Parse(dr["StoreID"].ToString());
            }
            con.Close();

            sqlQuery = "SELECT BikeNameID FROM BikeName WHERE BikeName='" + AddInventBikeNameComboBox.Text + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                bikeNameID = int.Parse(dr["BikeNameID"].ToString());
            }
            con.Close();

            int isThereStock = 1;
            sqlQuery = "SELECT COUNT(1) FROM Stock WHERE StoreID=" + storeID + " AND BikeNameID=" + bikeNameID + "";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                isThereStock = int.Parse(dr[0].ToString());
            }
            con.Close();

            int qty = int.Parse(AddInventQuantityComboBox.Text);
            if (isThereStock == 0)
            {
                sqlQuery = "INSERT INTO Stock (StoreID, BikeNameID, Qty) VALUES (" + storeID 
                    + "," + bikeNameID + "," + qty 
                    + ")";
                con = new SqlConnection(connectionString);
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                sc.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                int oldQty = 0;
                sqlQuery = "SELECT Qty FROM Stock WHERE StoreID=" + storeID + "AND BikeNameID=" + bikeNameID;
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                if (dr != null)
                {
                    dr.Read();
                    oldQty = int.Parse(dr["Qty"].ToString());
                }
                con.Close();

                qty += oldQty;

                sqlQuery = "UPDATE Stock SET Qty=" + qty + " WHERE StoreID=" + storeID + " AND BikeNameID=" + bikeNameID;
                con = new SqlConnection(connectionString);
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                sc.ExecuteNonQuery();
                con.Close();
            }

            AddInventStoreNameComboBox.SelectedIndex = -1;
            AddInventBikeNameComboBox.SelectedIndex = -1;
            AddInventQuantityComboBox.SelectedIndex = -1;
            AddInventButton.Enabled = false;
        }

        public bool CheckComboBoxes()
        {
            if (AddInventStoreNameComboBox.SelectedIndex != -1 
                && AddInventBikeNameComboBox.SelectedIndex != -1
                && AddInventQuantityComboBox.SelectedIndex != -1)
            {
                return true;
            }

            return false;
        }
    }
}
