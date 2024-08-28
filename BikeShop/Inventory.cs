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
    public partial class Inventory : Form
    {
        readonly DataTable dt = new();
        readonly string connectionString;
        string sqlQuery;
        SqlConnection con;
        SqlCommand sc;
        SqlDataReader dr;
        SqlDataAdapter adapter;
        DataGridView dgv;
        int choice;
        string custFName, custLName, custName, bikeName;

        public Inventory()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringBikeShop"].ConnectionString;
            con = new SqlConnection(connectionString);
            dgv = new DataGridView();
            choice = 0;
        }

        private void ItemsByStoreButton_Click(object sender, EventArgs e)
        {
            CreateNewTable();

            // Should be items sold by store, not availability
            sqlQuery = "SELECT StoreName AS 'Store Order was Placed At', BikeName, BikeQty " +
                "FROM CustomerOrder custOrder " +
                "JOIN Store store ON store.StoreID = custOrder.StoreID " +
                "JOIN CustomerOrderItems custItems ON custItems.CustOrderID = custOrder.CustOrderID " +
                "JOIN BikeName bike ON bike.BikeNameID = custItems.BikeNameID " +
                "ORDER BY StoreName, BikeName";
            ReadDatathroughAdapter(sqlQuery, dt);
            dgv.DataSource = dt;
            con.Close();
        }

        private void ItemsByStaffButton_Click(object sender, EventArgs e)
        {
            CreateNewTable();

            sqlQuery = "SELECT StaffFName, StaffLName, BikeName, SUM(BikeQty) AS 'Qty'" +
                "FROM CustomerOrder custOrder " +
                "JOIN Staff staff ON staff.StaffID = custOrder.StoreID " +
                "JOIN CustomerOrderItems custItems ON custItems.CustOrderID = custOrder.CustOrderID " +
                "JOIN BikeName bike ON bike.BikeNameID = custItems.BikeNameID " +
                "GROUP BY StaffFName, StaffLName, BikeName " +
                "ORDER BY StaffLName, StaffFName";
            ReadDatathroughAdapter(sqlQuery, dt);
            dgv.DataSource = dt;
            con.Close();
        }

        private void ItemsByOrderButton_Click(object sender, EventArgs e)
        {
            RemoveTable();

            choice = 2;
            InventChoiceLabel.Visible = true;
            InventChoiceLabel.Text = "Select Customer";
            InventChoiceComboBox.Visible = true;
            InventChoiceComboBox.SelectedIndex = -1;
            InventChoiceComboBox.Items.Clear();
            InventChoiceButton.Visible = true;
            InventChoiceButton.Text = "Enter";

            // Gets data from Customer table to Choice drop down
            sqlQuery = "select * from Customer";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    custFName = dr["custFName"].ToString();
                    custLName = dr["custLName"].ToString();
                    custName = custFName + " " + custLName;
                    InventChoiceComboBox.Items.Add(custName);
                }
            }
            con.Close();
        }

        private void BikeQtyButton_Click(object sender, EventArgs e)
        {
            RemoveTable();

            choice = 1;
            InventChoiceLabel.Visible = true;
            InventChoiceLabel.Text = "Select Bike";
            InventChoiceComboBox.Visible = true;
            InventChoiceComboBox.SelectedIndex = -1;
            InventChoiceComboBox.Items.Clear();
            InventChoiceButton.Visible = true;
            InventChoiceButton.Text = "Enter";

            // Gets data from BikeName table to Choice drop down
            sqlQuery = "select * from BikeName";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    InventChoiceComboBox.Items.Add(dr["BikeName"].ToString());
                }
            }
            con.Close();
        }

        private void BikeNameButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddBike addBike = new();
            addBike.ShowDialog();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddInventoryToStores addInvent = new();
            addInvent.ShowDialog();
        }

        private void InventoryGoBackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new();
            mainMenu.ShowDialog();
            Close();
        }

        private void InventAddStoreButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddStore addStore = new();
            addStore.ShowDialog();
        }

        private void InventChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InventChoiceComboBox.SelectedIndex != -1)
            {
                InventChoiceButton.Enabled = true;
            }
            else
            {
                InventChoiceButton.Enabled = false;
            }
        }

        public DataGridView CreateNewTable()
        {
            RemoveTable();
            dgv.Location = new Point(12, 222);
            dgv.Size = new Size(776, 528);
            Controls.Add(dgv);
            return dgv;
        }

        public void RemoveTable()
        {
            Controls.Remove(dgv);
            dgv = new()
            {
                DataSource = null
            };
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Refresh();
        }

        private void InventChoiceButton_Click(object sender, EventArgs e)
        {
            CreateNewTable();
            if (choice == 1)
            {
                bikeName = InventChoiceComboBox.Text;

                sqlQuery = "SELECT BikeName, BikeCatName, BikeBrandName, StoreName, Qty " +
                "FROM Stock stock " +
                "JOIN Store store ON store.StoreID = stock.StoreID " +
                "JOIN BikeName bike ON bike.BikeNameID = stock.BikeNameID " +
                "JOIN BikeCategory bikeCat ON bikeCat.BikeCatID = bike.BikeCatID " +
                "JOIN BikeBrand bikeBrand ON bikeBrand.BikeBrandID = bike.BikeBrandID " +
                "WHERE BikeName = '" + bikeName + "'";
            }
            else if (choice == 2)
            {
                custName = InventChoiceComboBox.Text;
                custFName = custName.Split(" ")[0];
                custLName = custName.Split(" ")[1];

                sqlQuery = "SELECT custOrder.CustOrderID, CustFName, CustLName, StaffFName, StaffLName, storeOrder.StoreName AS 'Store Where Order Was Placed', BikeName, BikeQty, OrderDiscount, storeItems.StoreName AS 'Original Store'" +
                    "FROM CustomerOrder custOrder " +
                    "JOIN Customer cust ON cust.CustID = custOrder.CustID " +
                    "JOIN Staff staff ON staff.StaffID = custOrder.StaffID " + 
                    "JOIN Store storeOrder ON storeOrder.StoreID = custOrder.StoreID " +
                    "JOIN CustomerOrderItems custItems ON custItems.CustOrderID = custOrder.CustOrderID " +
                    "JOIN BikeName bike ON bike.BikeNameID = custItems.BikeNameID " + 
                    "JOIN Store storeItems ON storeItems.StoreID = custItems.StoreID " + 
                    "WHERE CustFName = '" + custFName + "' AND CustLName = '" + custLName + "'";
            }
            ReadDatathroughAdapter(sqlQuery, dt);
            dgv.DataSource = dt;
            con.Close();

            InventChoiceLabel.Visible = false;
            InventChoiceComboBox.Visible = false;
            InventChoiceButton.Visible = false;
        }

        // Got this useful method from C# SignUp form using SQL Database, made by Coding Cafe on YouTube
        public void ReadDatathroughAdapter(string query, DataTable tblName)
        {
            con.Open();

            sc = new SqlCommand(sqlQuery, con)
            {
                Connection = con,
                CommandText = query,
                CommandType = CommandType.Text
            };

            adapter = new SqlDataAdapter(sc);
            tblName.Clear();
            tblName.Columns.Clear();
            adapter.Fill(tblName);
        }
    }
}
