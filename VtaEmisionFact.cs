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
    public partial class VtaEmisionFact : Form
    {
        public VtaEmisionFact()
        {
            InitializeComponent();
        }

        private void BtnGenFact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Factura Generada con el Folio: 11111111");
        }

        private void BtnCanFact_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cancelar?", "Esta apunto de salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                VtEmisor f1 = new VtEmisor();
                f1.Show();
            }
        }
    }
}
