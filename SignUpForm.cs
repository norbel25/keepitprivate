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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace restotestng
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public class UserInfo
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public long PhoneNumber { get; set; }
            public string Sex { get; set; }
        }
        UserInfo User = new UserInfo();
        private void Get()
        {
            if (string.IsNullOrWhiteSpace(username.TextInput) ||
                string.IsNullOrWhiteSpace(password.TextInput) ||
                string.IsNullOrWhiteSpace(firstname.TextInput) ||
                string.IsNullOrWhiteSpace(lastname.TextInput) ||
                !long.TryParse(phonenumber.TextInput, out long phoneNumberValue))
            {
                MessageBox.Show("Please fill valid data in all fields.");
                return;
            }

            User.Username = username.TextInput;
            User.Password = password.TextInput;
            User.FirstName = firstname.TextInput;
            User.LastName = lastname.TextInput;
            User.PhoneNumber = phoneNumberValue;

            if (maleradiobutton.Checked)
            {
                User.Sex = maleradiobutton.Text;
            }
            else if (femaleradiobutton.Checked)
            {
                User.Sex = femaleradiobutton.Text;
            }
            else
            {
                MessageBox.Show("Please select a gender.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Get();

                SqlConnection con = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;TrustServerCertificate=True");
                con.Open();

                SqlCommand cmduser = new SqlCommand("INSERT INTO [User] (Username, Password) VALUES (@Username, @Password); SELECT SCOPE_IDENTITY()", con);
                cmduser.Parameters.AddWithValue("@Username", User.Username);
                cmduser.Parameters.AddWithValue("@Password", User.Password);

                int newUserId = Convert.ToInt32(cmduser.ExecuteScalar());
                SqlCommand cmdcustomerinfo = new SqlCommand("INSERT INTO [Customer] (UserId, FirstName, LastName, PhoneNumber, Sex) VALUES (@UserId, @FirstName, @LastName, @PhoneNumber, @Sex)", con);
                cmdcustomerinfo.Parameters.AddWithValue("@UserId", newUserId);
                cmdcustomerinfo.Parameters.AddWithValue("@FirstName", User.FirstName);
                cmdcustomerinfo.Parameters.AddWithValue("@LastName", User.LastName);
                cmdcustomerinfo.Parameters.AddWithValue("@PhoneNumber", User.PhoneNumber);
                cmdcustomerinfo.Parameters.AddWithValue("@Sex", User.Sex);
                int j = cmdcustomerinfo.ExecuteNonQuery();

                if (newUserId > 0 && j > 0)
                {
                    MessageBox.Show("You can now close this form", "Successfully Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showf5("success", "Sign Up Successfully");
                    username.TextInput = String.Empty;
                    password.TextInput = String.Empty;
                    firstname.TextInput = String.Empty;
                    lastname.TextInput = String.Empty;
                    phonenumber.TextInput = String.Empty;
                    maleradiobutton.Checked = false;
                    femaleradiobutton.Checked = false;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void showf5(string type, string message)
        {
            Form5 f5 = new Form5(type, message);
            f5.Show();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.TextInput))
            {
                username.BorderColor = Color.Red;
                usernamewarning.Visible = true;
            }
            else
            {
                username.BorderColor = Color.FromArgb(159, 127, 42);
                usernamewarning.Visible = false;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.TextInput))
            {
                password.BorderColor = Color.Red;
                passwordwarning.Visible = true;
            }
            else
            {
                password.BorderColor = Color.FromArgb(159, 127, 42);
                passwordwarning.Visible = false;
            }
        }

        private void lastname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastname.TextInput))
            {
                lastname.BorderColor = Color.Red;
                lastnamewarning.Visible = true;
            }
            else
            {
                lastname.BorderColor = Color.FromArgb(159, 127, 42);
                lastnamewarning.Visible = false;
            }
        }

        private void phonenumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phonenumber.TextInput))
            {
                phonenumber.BorderColor = Color.Red;
                phonenumberwarning.Visible = true;
            }
            else
            {
                phonenumber.BorderColor = Color.FromArgb(159, 127, 42);
                phonenumberwarning.Visible = false;
            }
        }

        private void username_Load(object sender, EventArgs e)
        {

        }

        private void password_MouseDown(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Password MouseDown event triggered");
            passwordwarning.Visible = false;
        }

        private void username_MouseDown_1(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Password MouseDown event triggered");
            usernamewarning.Visible = false;
        }

        private void firstname_MouseDown(object sender, MouseEventArgs e)
        {
            firstnamewarning.Visible = false;
        }

        private void firstname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.TextInput))
            {
                firstname.BorderColor = Color.Red;
                firstnamewarning.Visible = true;
            }
            else
            {
                firstname.BorderColor = Color.FromArgb(159, 127, 42);
                firstnamewarning.Visible = false;
            }
        }

        private void lastname_MouseDown(object sender, MouseEventArgs e)
        {
            lastnamewarning.Visible = false;
        }

        private void phonenumber_MouseDown(object sender, MouseEventArgs e)
        {
            phonenumberwarning.Visible = false;
        }

        private void username_Enter(object sender, EventArgs e)
        {
            usernamewarning.Visible = false;
        }

        private void password_Enter(object sender, EventArgs e)
        {
            passwordwarning.Visible = false;
        }

        private void firstname_Enter(object sender, EventArgs e)
        {
            firstnamewarning.Visible = false;
        }

        private void lastname_Enter(object sender, EventArgs e)
        {
            lastnamewarning.Visible = false;
        }

        private void phonenumber_Enter(object sender, EventArgs e)
        {
            phonenumberwarning.Visible = false;
        }
    }
}
