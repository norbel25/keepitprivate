using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace restotestng
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        string filepath;
        private void selectimagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png) | * .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                productimage.Image = new Bitmap(filepath);
            }
        }


        private void addproductbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productname.TextInput) ||
                !long.TryParse(price.TextInput, out long productprice))
            {
                MessageBox.Show("Please fill Product Name and Price.");
                return;
            }
            Image temp = new Bitmap(productimage.Image);
            Byte[] imageByteArray; // This is a byte array that will hold the binary data of the image
            MemoryStream ms = new MemoryStream(); // This creates a new memory stream. A memory stream is a system-provided stream that you can read from and write to in memory.
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // This saves the 'temp' image to the memory stream in PNG format. 'temp' should be a Bitmap or Image object.
            imageByteArray = ms.ToArray(); // This converts the data in the memory stream to a byte array.
            SqlConnection con = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Product] (ProductName, UnitPrice, Category, Image) VALUES (@ProductName, @UnitPrice, @Category, @Image); SELECT SCOPE_IDENTITY()", con);
            cmd.Parameters.AddWithValue("@ProductName", productname.TextInput);
            cmd.Parameters.AddWithValue("@UnitPrice", productprice);
            cmd.Parameters.AddWithValue("@Category", category.TextInput);
            cmd.Parameters.AddWithValue("@Image", imageByteArray);
            int newProductID = Convert.ToInt32(cmd.ExecuteScalar());
            if (newProductID > 0)
            {
                MessageBox.Show("The product has been add", "Product Added", MessageBoxButtons.OK);
                productname.TextInput = String.Empty;
                price.TextInput = String.Empty;
                category.TextInput = String.Empty;
                if (productimage.Image != null)
                {
                    productimage.Image.Dispose();
                    productimage.Image = null;
                }
            }
            con.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
