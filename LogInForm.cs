using Microsoft.Identity.Client;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace restotestng
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        public class admincheck
        {
            public bool admin;
        }
        admincheck check = new admincheck();

        private void SignIn()
        {
            string enteredUsername = username.TextInput;
            string enteredPassword = password.TextInput;

            SqlConnection con = new SqlConnection("Data Source=MIRAVALLES\\SQLEXPRESS;Initial Catalog=RestoDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            if (!string.IsNullOrEmpty(enteredUsername) && !string.IsNullOrEmpty(enteredPassword))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@Username", enteredUsername);
                cmd.Parameters.AddWithValue("@Password", enteredPassword);

                int matchingCount = (int)cmd.ExecuteScalar();

                if (matchingCount > 0)
                {
                    if (username.TextInput == "admin" && password.TextInput == "admin")
                    {
                        check.admin = true;
                    }
                    else
                    {
                        check.admin = false;
                    }
                    showf5("success", "Login Successfully");

                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.Data = check.admin;
                    f3.Show();
                    username.TextInput = String.Empty;
                    password.TextInput = String.Empty;
                    f3.FormClosed += (s, args) => this.Show();
                }
                else
                {
                    showf5("failed", "Login Failed");
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Can't proceed Due to Blank in TextBox", "Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void showf5(string type, string message)
        {
            Form5 f5 = new Form5(type, message);
            f5.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SignIn();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm f2 = new SignUpForm();
            f2.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void hide_Click(object sender, EventArgs e)
        {
            password.PasswordChar = '\0';
            hide.Visible = false;
            show.Visible = true;
        }

        private void show_Click(object sender, EventArgs e)
        {
            password.PasswordChar = '•';
            hide.Visible = true;
            show.Visible = false;
        }

        private void username_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_Load(object sender, EventArgs e)
        {
            
        }

        private void username_Leave_1(object sender, EventArgs e)
        {
        }

        private void password_Leave_1(object sender, EventArgs e)
        {
 
        }
    }
    public class CustomButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        //Properties
        [Category("Advance Properties")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Advance Properties")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Advance Properties")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Advance Properties")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Advance Properties")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
