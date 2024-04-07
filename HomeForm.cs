using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Data;
namespace restotestng
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoDBDataSet4.OrderItem' table. You can move, or remove it, as needed.
            this.orderItemTableAdapter3.Fill(this.restoDBDataSet4.OrderItem);
            await LoadProductsIntoFlowPanelAsync();
            
            /*totalamouts.Text = "\u20B1" + totalamount;*/


        }
        public async Task LoadProductsIntoFlowPanelAsync(string search = null)
        {
            productflowpanel.Controls.Clear();
            SqlConnection con = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;TrustServerCertificate=True");
            await con.OpenAsync();

            string query = "SELECT * FROM [Product]";

            /*if (!string.IsNullOrEmpty(search))
            {
                query += " WHERE ProductName LIKE @searchText";
            }
            /*else*/ if (Mealrb.Checked)
            {
                query += " WHERE Category = 'Meal'";
            }
            else if (Drinksrb.Checked)
            {
                query += " WHERE Category = 'Drinks'";
            }
            else if (Fastfoodrb.Checked)
            {
                query += " WHERE Category = 'Fastfood'";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            /*if (!string.IsNullOrEmpty(search))
            {
                cmd.Parameters.AddWithValue("@searchText", "%" + search + "%");
            }*/
            SqlDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                // Get the product data from the current row
                int id = Convert.ToInt32(reader["ProductID"]);
                string name = reader["ProductName"].ToString();
                string category = reader["Category"].ToString();
                string price = reader["UnitPrice"].ToString();
                Image pimage = Image.FromStream(new MemoryStream((byte[])reader["Image"]));

                // Create a new instance of ucProduct
                ucProduct productControl = new ucProduct();

                // Set the properties
                productControl.PId = id;
                productControl.PName = name;
                productControl.PPrice = price;
                productControl.PCategory = category;
                productControl.PImage = pimage;
                productControl.DisplayPrice = price;

                // Add the UserControl to the flow panel
                productflowpanel.Controls.Add(productControl);
            }

            con.Close();
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private async void Mealrb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Mealrb.Checked)
            {
                await LoadProductsIntoFlowPanelAsync();
            }
        }

        private async void Fastfoodrb_CheckedChanged(object sender, EventArgs e)
        {
            if (Fastfoodrb.Checked)
            {
                await LoadProductsIntoFlowPanelAsync();
            }
        }

        private async void Allrb_CheckedChanged(object sender, EventArgs e)
        {
            if (Allrb.Checked)
            {
                await LoadProductsIntoFlowPanelAsync();
            }
        }

        private async void Drinksrb_CheckedChanged(object sender, EventArgs e)
        {
            if (Drinksrb.Checked)
            {
                await LoadProductsIntoFlowPanelAsync();
            }
        }

        /* private async void searchbar_KeyPress(object sender, KeyPressEventArgs e)
         {
             *//*if (searchbar.Text.Length >= 3)
             {
                 await LoadProductsIntoFlowPanelAsync(searchbar.Text);
             }
             else
             {
                 await LoadProductsIntoFlowPanelAsync();
             }*//*
         }*/
        


        private void searchbar_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void clearbuttonClick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "DELETE FROM OrderItem";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshData();
            CalculateTotalAmount();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void CalculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in currentordergrid.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells["Amount"].Value);
            }
            totalamouts.Text = "\u20B1" + totalAmount.ToString();
        }
        public void RefreshData()
        {
            DataTable dt = GetData();

            currentordergrid.DataSource = dt;
        }
        public DataTable GetData()
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "SELECT * FROM Orderitem";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(data);
                }
                conn.Close();
            }

            return data;
        }

        private void paynowbutton_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            using (SqlConnection conn = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "DELETE FROM OrderItem";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshData();
            CalculateTotalAmount();
        }

        private void paylaterbutton_Click(object sender, EventArgs e)
        {
            // Get the data from DataGridView
            DataTable dt = (DataTable)currentordergrid.DataSource;

            using (SqlConnection conn = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();

                foreach (DataRow row in dt.Rows)
                {
                    string query = "INSERT INTO [Order] (ProductName, Amount, Quantity, Addons) VALUES (@ProductName, @Amount, @Quantity, @Addons)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", row["ProductName"]);
                        cmd.Parameters.AddWithValue("@Amount", row["Amount"]);
                        cmd.Parameters.AddWithValue("@Quantity", row["Quantity"]);
                        cmd.Parameters.AddWithValue("@Addons", row["Addons"]);

                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }
            
            // Clear the current order grid
            using (SqlConnection conn = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "DELETE FROM OrderItem";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshData();
            totalamouts.Text = "\u20B1" + "0";
        }

    }
}