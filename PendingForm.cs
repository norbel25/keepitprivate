using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restotestng
{
    public partial class PendingForm : Form
    {
        public PendingForm()
        {
            InitializeComponent();
        }

        private void PendingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restoDBDataSet7.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter2.Fill(this.restoDBDataSet7.Order);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderTableAdapter.FillBy(this.restoDBDataSet5.Order);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void RefreshData()
        {
            DataTable dt = GetData();

            dataGridView1.DataSource = dt;
        }
        public DataTable GetData()
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "SELECT * FROM [Order]";

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
                string query = "DELETE FROM [Order]";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
