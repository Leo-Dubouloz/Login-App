using Dashboard.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dashboard
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btnExitSignIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewSignUp_Click(object sender, EventArgs e)
        {
            DbContext db = new DbContext();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`Name`, `password`) VALUES (@name, @password)", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tbNameRegister.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = tbNewPassword.Text;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
            // check if this username already exists
                if (checkUsername())
                {
                    MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                 // execute the query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FormLogin formLogin = new FormLogin();
                        formLogin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            // close the connection
            db.closeConnection();
        }


        // check if the username already exists
        public Boolean checkUsername()
        {
            DbContext db = new DbContext();
            String name = tbNameRegister.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Name` = @name", db.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0) return true;
            else return false;   
        }

        // check if the textboxes contains the default values
        public Boolean checkTextBoxesValues()
        {
            String name = tbNameRegister.Text;
            String pass = tbNewPassword.Text;

            if (name.Equals("Your name") || name.Equals("") || pass.Equals("Your password") || pass.Equals("")) return true;
            else return false;
        }

        private void tbNameRegister_Enter(object sender, EventArgs e)
        {
            string name_check = tbNameRegister.Text;
            if (name_check.Equals("Your name")) tbNameRegister.Text = "";
        }

        private void tbNameRegister_Leave(object sender, EventArgs e)
        {
            string name_check = tbNameRegister.Text;
            if (name_check.Equals("Your name") || name_check.Equals("")) tbNameRegister.Text = "Your name";
        }

        private void tbNewPassword_Enter(object sender, EventArgs e)
        {
            string password_check = tbNewPassword.Text;
            if (password_check.Equals("Your password")) tbNewPassword.Text = "";
        }

        private void tbNewPassword_Leave(object sender, EventArgs e)
        {
            string password_check = tbNewPassword.Text;
            if (password_check.Equals("Your password") || password_check.Equals("")) tbNewPassword.Text = "Your password";
        }
    }
}

