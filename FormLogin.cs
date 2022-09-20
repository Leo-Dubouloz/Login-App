using Dashboard.Database;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dashboard
{
    public partial class FormLogin : Form
    {
        //Database.UserService uService = new Database.UserService();
        //Database.User uUser = new Database.User();
        public FormLogin()
        {
            InitializeComponent();

            //Make Form draggable
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.ShowDialog();
            this.Close();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DbContext db = new DbContext();
            String name = tbName.Text;
            String password = tbPassword.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `name` = @name and `password` = @password", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // check if the user exists or not
            if (table.Rows.Count > 0)
            {
                this.Hide();
                FormLogin mainform = new FormLogin();
                mainform.Show();
            }
            else
            {
                // check if the username field is empty
                if (name.Trim().Equals("")) MessageBox.Show("Enter Your name To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                // check if the password field is empty
                else if (password.Trim().Equals("")) MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // check if the username or the password don't exist
                else MessageBox.Show("Wrong Username Or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }

        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            string name_check = tbName.Text;
            if (name_check.Equals("Your name")) tbName.Text = "";
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            string name_check = tbName.Text;
            if(name_check.Equals("Your name") || name_check.Equals("")) tbName.Text = "Your name";
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            string password_check = tbPassword.Text;
            if (password_check.Equals("password")) tbPassword.Text = "";
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            string password_check = tbPassword.Text;
            if (password_check.Equals("password") || password_check.Equals("")) tbPassword.Text = "password";
        }
    }

}