using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Facturacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = user.Text;
            contraseña = pass.Text;
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; Database = proyecto; User id=Carlos; password=hipersp31");
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            String sql = "select user,pass from users where user = '" + nombre + "' AND pass = '" + contraseña + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + nombre);
            }
            else
            {
                MessageBox.Show("No existe el usuario " + nombre);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
            this.Hide();
        }

        private void CloseLog_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void muestra_CheckedChanged(object sender, EventArgs e)
        {
            if (muestra.Checked == true)
            {
                pass.UseSystemPasswordChar = false;

            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {
                user.Text = "Ingrese su usuario";
                user.ForeColor = Color.Black;
            }
        }

        private void user_Enter(object sender, EventArgs e)
        {
            if (user.Text == "Ingrese su usuario")
            {
                user.Text = "";
                user.ForeColor = Color.Black;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Ingrese su contraseña";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = false;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Ingrese su contraseña")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
                pass.UseSystemPasswordChar = true;
            }

        }
    }
    
}
