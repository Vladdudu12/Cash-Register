using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Store
{
    public partial class LoginForm : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=db_store;user=root;Pwd=Steaua123!@?");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user =  textBoxUser.Text;
            string pass = textBoxPassword.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where username='" + textBoxUser.Text + "' AND password='" + textBoxPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                mainForm mainForm = new mainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Date de autentificare invalide!" + '\n' + "Incercati din nou");
            }
            con.Close();
        }

        private void labelLoginInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
