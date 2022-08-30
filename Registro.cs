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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
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
            string sql = "insert into users(user,pass,name,rol) values ('" + new_user.Text + "' , '" + new_pass.Text + "', '" + name.Text + "' , '" + Roles.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("USUARIO REGISTRADO");
                this.Hide();
                Login n1 = new Login();
                n1.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Esta apunto de salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                Login f1 = new Login();
                f1.Show();

            }
        }

        private void CerrarReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void new_user_Leave(object sender, EventArgs e)
        {
            if (new_user.Text == "")
            {
                new_user.Text = "Ingrese el usuario";
                new_user.ForeColor = Color.Black;
            }
        }

        private void new_user_Enter(object sender, EventArgs e)
        {
            if (new_user.Text == "Ingrese su usuario")
            {
                new_user.Text = "";
                new_user.ForeColor = Color.Black;
            }
        }

        private void new_pass_Leave(object sender, EventArgs e)
        {
            if (new_pass.Text == "")
            {
                new_pass.Text = "Ingrese una contraseña";
                new_pass.ForeColor = Color.Black;
                new_pass.UseSystemPasswordChar = true;
            }
        }

        private void new_pass_Enter(object sender, EventArgs e)
        {
            if (new_pass.Text == "Ingrese una contraseña")
            {
                new_pass.Text = "";
                new_pass.ForeColor = Color.Black;
                new_pass.UseSystemPasswordChar = true;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (new_user.Text == "")
            {
                new_user.Text = "Ingrese su Nombre";
                new_user.ForeColor = Color.Black;
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (new_user.Text == "Ingrese su Nombre")
            {
                new_user.Text = "";
                new_user.ForeColor = Color.Black;
            }
        }
    }
}
