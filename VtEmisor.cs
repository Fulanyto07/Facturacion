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
    public partial class VtEmisor : Form
    {
        public VtEmisor()
        {
            InitializeComponent();
        }
        private void AbrirEmisionFact(object formEmision)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form FE = formEmision as Form;
            FE.TopLevel = false;
            FE.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(FE);
            this.panelContenedor.Tag = FE;
            FE.Show();

        }
        private void BtnEmision_Click(object sender, EventArgs e)
        {
            AbrirEmisionFact(new VtaEmisionFact());
        }

        private void CerrarEmisor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirConsFact(object formConsulta)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form FC = formConsulta as Form;
            FC.TopLevel = false;
            FC.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(FC);
            this.panelContenedor.Tag = FC;
            FC.Show();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            AbrirConsFact(new VtaConsulta());
        }
        private void AbrirCancFact(object formCancelar)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form FCF = formCancelar as Form;
            FCF.TopLevel = false;
            FCF.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(FCF);
            this.panelContenedor.Tag = FCF;
            FCF.Show();
        }

        private void BtnCancelacion_Click(object sender, EventArgs e)
        {
            AbrirCancFact(new VtaCancelar());
        }
    }
}
