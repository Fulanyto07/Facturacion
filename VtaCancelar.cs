using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class VtaCancelar : Form
    {
        public VtaCancelar()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Regresar?", "Esta apunto de salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                VtEmisor f1 = new VtEmisor();
                f1.Show();
            }
        }
    }
}
