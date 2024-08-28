using Microsoft.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace BikeShop
{
    public partial class OrderForm : Form
    {
        string connectionString, sqlQuery, staffFName, custFName;
        SqlConnection con;
        SqlCommand sc;
        SqlDataReader dr;
        int orderStoreID, storeID, staffID, custID, discount, bikeNameID;
        List<int> bikeNameIDList;
        List<string[]> itemsList;

        private void OrderBikeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!OrderBikeQuantityComboBox.Enabled)
            {
                OrderBikeQuantityComboBox.Enabled = true;
            }
            else
            {
                OrderBikeQuantityComboBox.Items.Clear();
            }

            // Gets user's bike choice
            string[] bikeName = OrderBikeComboBox.Text.Split(",");
            sqlQuery = "SELECT BikeNameID FROM BikeName WHERE BikeName='" + bikeName[0] + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                bikeNameID = int.Parse(dr["BikeNameID"].ToString());
            }
            con.Close();

            // Get Qty from Stock
            sqlQuery = "SELECT Qty FROM Stock WHERE StoreID='" + storeID
                + "' AND BikeNameID='" + bikeNameID + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                int z = 1;
                while (z <= int.Parse(dr["Qty"].ToString()))
                {
                    OrderBikeQuantityComboBox.Items.Add(z);
                    z++;
                }
            }
            con.Close();
        }

        private void OrderStoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!OrderBikeStoreComboBox.Enabled)
            {
                OrderBikeStoreComboBox.Enabled = true;
            }
            else
            {
                OrderBikeStoreComboBox.Items.Clear();
            }

            // Gets data from database to the Store drop down
            // under the Add Items category
            sqlQuery = "select * from Store";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    OrderBikeStoreComboBox.Items.Add(dr["StoreName"].ToString());
                }
            }
            con.Close();
        }

        private void OrderStoreComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!OrderBikeComboBox.Enabled)
            {
                OrderBikeComboBox.Enabled = true;
            }
            else
            {
                OrderBikeComboBox.Items.Clear();
                bikeNameIDList.Clear();
            }

            // Gets user's store choice
            sqlQuery = "SELECT StoreID FROM Store WHERE StoreName='" + OrderBikeStoreComboBox.Text + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                storeID = int.Parse(dr["StoreID"].ToString());
            }
            con.Close();

            // Display possible bikes
            List<string[]> bikeInfoList = new List<string[]>();
            sqlQuery = "SELECT BikeNameID FROM Stock WHERE StoreID=" + storeID;
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    if (!bikeNameIDList.Contains(int.Parse(dr["BikeNameID"].ToString())))
                    {
                        bikeNameIDList.Add(int.Parse(dr["BikeNameID"].ToString()));
                    }
                }
            }
            con.Close();

            for (int i = 0; i < bikeNameIDList.Count; i++)
            {
                sqlQuery = "SELECT * FROM BikeName WHERE BikeNameID=" + bikeNameIDList[i];
                con = new SqlConnection(connectionString);
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        string[] bikeInfo = new string[5];
                        bikeInfo[0] = dr["BikeName"].ToString();
                        bikeInfo[1] = dr["BikeYear"].ToString();
                        bikeInfo[2] = dr["BikePrice"].ToString();
                        bikeInfo[3] = dr["BikeBrandID"].ToString();
                        bikeInfo[4] = dr["BikeCatID"].ToString();
                        bikeInfoList.Add(bikeInfo);
                    }
                }
                con.Close();
            }
            

            for (int i = 0; i < bikeInfoList.Count; i++)
            {
                // Gets data from BikeBrand database to the first Bike drop down
                sqlQuery = "SELECT BikeBrandName FROM BikeBrand WHERE BikeBrandID=" + int.Parse(bikeInfoList[i][3]);
                con = new SqlConnection(connectionString);
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        bikeInfoList[i][3] = dr["BikeBrandName"].ToString();
                    }
                }
                con.Close();

                // Gets data from BikeCat database to the first Bike drop down
                sqlQuery = "SELECT BikeCatName FROM BikeCategory WHERE BikeCatID=" + bikeInfoList[i][4];
                con = new SqlConnection(connectionString);
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        bikeInfoList[i][4] = dr["BikeCatName"].ToString();
                    }
                }
                con.Close();
            }

            for (int i = 0; i < bikeInfoList.Count; i++)
            {
                string bikeString = bikeInfoList[i][0] + ", ";
                bikeString += bikeInfoList[i][1] + ", ";
                bikeString += "$" + bikeInfoList[i][2] + ", ";
                bikeString += bikeInfoList[i][3] + ", ";
                bikeString += bikeInfoList[i][4];
                OrderBikeComboBox.Items.Add(bikeString);
            }
        }

        public OrderForm()
        {
            InitializeComponent();

            OrderErrorLabel.Text = "";

            itemsList = new List<string[]>();
            bikeNameIDList = new List<int>();

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
                    OrderStoreComboBox.Items.Add(dr["StoreName"].ToString());
                }
            }
            con.Close();

            // Gets data from database to Staff drop down
            sqlQuery = "select * from Staff";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            string staffName;
            if (dr != null)
            {
                while (dr.Read())
                {
                    staffName = dr["StaffFName"].ToString();
                    staffName += " ";
                    staffName += dr["StaffLName"].ToString();
                    OrderStaffComboBox.Items.Add(staffName);
                }
            }
            con.Close();

            // Gets data from database to Customer drop down
            sqlQuery = "select * from Customer";
            con = new SqlConnection(connectionString);
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            string customerName;
            if (dr != null)
            {
                while (dr.Read())
                {
                    customerName = dr["CustFName"].ToString();
                    customerName += " ";
                    customerName += dr["CustLName"].ToString();
                    OrderCustComboBox.Items.Add(customerName);
                }
            }
            con.Close();
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddStaff addStaffForm = new AddStaff();
            addStaffForm.ShowDialog();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.ShowDialog();
        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddManager addManager = new AddManager();
            addManager.ShowDialog();
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            // No Identity should be less than 0, so -1 means the order hasn't been made yet
            int orderID = -1;

            // Gets user's store choice
            sqlQuery = "SELECT StoreID FROM Store WHERE StoreName='" + OrderStoreComboBox.Text + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                orderStoreID = int.Parse(dr["StoreID"].ToString());
            }
            con.Close();

            // Gets user's employee choice
            staffFName = OrderStaffComboBox.Text.Split(' ')[0];
            sqlQuery = "SELECT StaffID FROM Staff WHERE StaffFName='" + staffFName + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                staffID = int.Parse(dr["StaffID"].ToString());
            }
            con.Close();

            // Gets user's customer choice
            custFName = OrderCustComboBox.Text.Split(' ')[0];
            sqlQuery = "SELECT CustID FROM Customer WHERE CustFName='" + custFName + "'";
            con.Open();
            sc = new SqlCommand(sqlQuery, con);
            dr = sc.ExecuteReader();
            if (dr != null)
            {
                dr.Read();
                custID = int.Parse(dr["CustID"].ToString());
            }
            con.Close();

            // Gets user's discount
            discount = int.Parse(OrderDiscountTextBox.Text);

            // Now, I need to deal with Stock table
            // Probably need a list to contain it all
            // I need itemsList, but I don't think I need the id list
            for (int j = 0; j < itemsList.Count; j++)
            {
                int oldQty = 0, newQty, orderQty;

                // Then, convert info from Forms into IDs
                // Change BikeName to BikeNameID
                sqlQuery = "SELECT BikeNameID FROM BikeName WHERE BikeName='" + itemsList[j][0] + "'";
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                if (dr != null)
                {
                    dr.Read();
                    bikeNameID = int.Parse(dr["BikeNameID"].ToString());
                }
                con.Close();

                // Change StoreName to StoreID
                sqlQuery = "SELECT StoreID FROM Store WHERE StoreName='" + itemsList[j][2] + "'";
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                if (dr != null)
                {
                    dr.Read();
                    storeID = int.Parse(dr["StoreID"].ToString());
                }
                con.Close();

                // Now get old quantity from Stock table using the ids
                sqlQuery = "SELECT Qty FROM Stock WHERE StoreID='" + storeID + "' AND BikeNameID='" 
                    + bikeNameID + "'";
                con.Open();
                sc = new SqlCommand(sqlQuery, con);
                dr = sc.ExecuteReader();
                if (dr != null)
                {
                    dr.Read();
                    oldQty = int.Parse(dr["Qty"].ToString());
                }
                con.Close();

                // Finally, add to Stock table
                orderQty = int.Parse(itemsList[j][1]);
                newQty = oldQty - orderQty;
                if (newQty >= 0)
                {
                    sqlQuery = "UPDATE Stock SET Qty=" + newQty + " WHERE StoreID = '" + storeID
                        + "' AND BikeNameID = '" + bikeNameID + "'";
                    con.Open();
                    sc = new SqlCommand(sqlQuery, con);
                    sc.ExecuteNonQuery();
                    con.Close();

                    // Add to Order table
                    if (orderID == -1)
                    {
                        sqlQuery = "INSERT INTO CustomerOrder (OrderDate, CustID, StoreID, StaffID, OrderDiscount) Values (CAST(GETDATE() AS Date),"
                            + custID + "," + orderStoreID + ", " + staffID + "," + discount + "); " + "SELECT SCOPE_IDENTITY()";
                        con.Open();
                        sc = new SqlCommand(sqlQuery, con);
                        dr = sc.ExecuteReader();
                        if (dr != null)
                        {
                            dr.Read();
                            orderID = int.Parse(dr[0].ToString());
                        }
                        con.Close();
                    }

                    // Also, add to CustomerOrderItems table
                    sqlQuery = "INSERT INTO CustomerOrderItems (CustOrderID, BikeNameID, StoreID, BikeQty) VALUES ("
                        + orderID + "," + bikeNameID + "," + storeID + "," + orderQty + ")";
                    con.Open();
                    sc = new SqlCommand(sqlQuery, con);
                    sc.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    int count = j + 1;
                    if (OrderErrorLabel.Text.Equals(""))
                    {
                        OrderErrorLabel.Text = "Some items in your order were removed.\n";
                    }
                    OrderErrorLabel.Text += "Item #" + count + " is invalid.\n";
                }
            }

            itemsList.Clear();
            OrderItemCountLabel.Text = "";
        }

        private void OrderAddItemButton_Click(object sender, EventArgs e)
        {
            string[] item = new string[3];
            item[0] = OrderBikeComboBox.Text.Split(",")[0];
            item[1] = OrderBikeQuantityComboBox.Text;
            item[2] = OrderBikeStoreComboBox.Text;
            itemsList.Add(item);
            int count = itemsList.Count + 1;
            OrderItemCountLabel.Text = "Item #" + count;
        }

        private void OrderGoBackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenuForm = new();
            mainMenuForm.ShowDialog();
            Close();
        }
    }
}