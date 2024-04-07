using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restotestng
{
    public partial class ucProduct : UserControl
    {
        /*public event EventHandler onSelect = null;*/
        public ucProduct()
        {
            InitializeComponent();

        }


        public int PId { get;set;}
        public string PPrice { get; set; }
        public string DisplayPrice
        {
            get { return price.Text; }
            set { price.Text = "\u20B1" + value; }
        }

        public string PCategory {
            get { return category.Text; }
            set { category.Text = value;
                category.Text = value.Trim();
                if (category.Text == "Meal")
                {
                    category.Location = new Point(131, category.Location.Y);
                }
                else if (category.Text == "Drinks")
                {
                    category.Location = new Point(128, category.Location.Y);
                }
                else
                {
                    category.Location = new Point(121, category.Location.Y);
                }
            } 
        }

        public string PName
        {
            get { return productname.Text; }
            set { productname.Text = value;
                if (productname.Text.Length <= 6)
                {
                    productname.Location = new Point(120, productname.Location.Y);
                }
                else if (productname.Text.Length >= 7 && productname.Text.Length <= 10)
                {
                    productname.Location = new Point(113, productname.Location.Y);
                }
                else if (productname.Text.Length >= 11 && productname.Text.Length <= 15)
                {
                    productname.Location = new Point(81, productname.Location.Y);
                }
                else
                {
                    productname.Location = new Point(74, productname.Location.Y);
                }
            }
        }
        public Image PImage
        {
            get { return pimage.Image; }
            set { pimage.Image = value; }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pimage_Click(object sender, EventArgs e)
        {
            // Get the HomeForm instance
            HomeForm homeForm = this.ParentForm as HomeForm;
            if (homeForm != null)
            {
                // Create the additems instance and pass the HomeForm instance
                additems addItemsForm = new additems(PCategory, PPrice, PName, PId, homeForm);
                addItemsForm.ShowDialog();
            }
        }

        private void productname_Click(object sender, EventArgs e)
        {

        }

        private void category_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }
        

    }
}
