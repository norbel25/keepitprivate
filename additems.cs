using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restotestng
{
    public partial class additems : Form
    {
        private HomeForm homeForm;
        public additems(string category, string itemprice, string pname, int pid, HomeForm homeForm)
        {
            InitializeComponent();
            itemcategory = category;
            this._itemprice = itemprice;
            _pname = pname;
            _pid = pid;
            this.homeForm = homeForm;
        }
        private string _itemcategory;
        private string _itemprice;
        private string _pname;
        private double amount;
        private int _pid;
        producttotal price = new producttotal();
        public class producttotal
        {
            public double sum { get; set; } 
        }
        public string itemcategory 
        {
            get 
            { 
                return _itemcategory; 
            } 
            set 
            { 
                _itemcategory = value; 
                DisableCheckboxes();
            } 
        }
        private void updateprice()
        {
            try
            {
                price.sum = Convert.ToDouble(_itemprice);
                int qty = Convert.ToInt32(qtytb.TextInput);
                if (qty <= 0)
                {
                    throw new ArgumentException("Quantity cannot be less than zero");
                }
                price.sum *= qty;
                 if (largerb.Checked)
                 {
                    price.sum += 50.00;
                 }
                if (smallrb.Checked)
                {
                    price.sum += 0;
                }
                if (ricecb.Checked)
                {
                    price.sum += 15.00;
                }
                if (saucecb.Checked)
                {
                    price.sum += 15.00;
                }
                if (mediumrb.Checked)
                {
                    price.sum += 30.00;
                }
                total.Text = "\u20B1"+price.sum.ToString("F2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(qtytb.TextInput))
                {
                    int qty = Convert.ToInt32(qtytb.TextInput);
                    qty++;
                    qtytb.TextInput = qty.ToString();
                }
                else
                {
                    qtytb.TextInput = "0";
                    int qty = Convert.ToInt32(qtytb.TextInput);
                    qty++;
                    qtytb.TextInput = qty.ToString();
                }
                updateprice();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void decrementbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(qtytb.TextInput))
                {
                    qtytb.TextInput = "1";
                }
                else
                {
                    int qty = Convert.ToInt32(qtytb.TextInput);
                    if (qty > 1)
                    {
                        qty--;
                        qtytb.TextInput = qty.ToString();
                    }
                    else
                    {
                        qtytb.TextInput = "1";
                    }
                }
                updateprice();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }
        private void DisableCheckboxes()
        {

            if (itemcategory == "Drinks")
            {
                ricecb.Enabled = false;
                saucecb.Enabled = false;
            }
            else if (itemcategory == "Fastfood")
            {
                ricecb.Enabled = false;
            }
            else 
            {
                saucecb.Enabled = false;
            }
        }

        private void additems_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            total.Text = "\u20B1" + _itemprice;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ricecb_CheckedChanged(object sender, EventArgs e)
        {
            updateprice();
        }

        private void saucecb_CheckedChanged(object sender, EventArgs e)
        {
            updateprice();

        }

        private void smallrb_CheckedChanged(object sender, EventArgs e)
        {
            updateprice();

        }

        private void mediumrb_CheckedChanged(object sender, EventArgs e)
        {

            updateprice();
        }

        private void largerb_CheckedChanged(object sender, EventArgs e)
        {
            updateprice();

        }

        private void total_Click(object sender, EventArgs e)
        {
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void additems_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int sumofaddons = 0;
                if (ricecb.Checked)
                    sumofaddons += 1;
                if (saucecb.Checked)
                    sumofaddons += 1;
                if (neilcb.Checked)
                    sumofaddons += 1;
                if (jayraldcb.Checked)
                    sumofaddons += 1;

                SqlConnection conn = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                conn.Open();
                string query = "INSERT INTO Orderitem (ProductID, ProductName, UnitPrice, Quantity, Addons, Amount) VALUES (@ProductID, @ProductName, @UnitPrice, @Quantity, @Addons, @Amount)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ProductID", _pid);
                cmd.Parameters.AddWithValue("@ProductName", _pname);
                cmd.Parameters.AddWithValue("@UnitPrice", _itemprice);
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(qtytb.TextInput));
                cmd.Parameters.AddWithValue("@Addons", sumofaddons);
                cmd.Parameters.AddWithValue("@Amount", this.price.sum);
                if (Convert.ToInt32(qtytb.TextInput) <= 0)
                {
                    throw new ArgumentException("Quantity cannot be less than or equal to zero");
                }

                int rowsAffected = cmd.ExecuteNonQuery();
                homeForm.RefreshData();
                homeForm.CalculateTotalAmount();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
