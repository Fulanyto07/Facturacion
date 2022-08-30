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
    public partial class VtReceptor : Form
    {
        public VtReceptor()
        {
            InitializeComponent();
        }
        private void AbrirConsFactRecep(object formConsultaRecep)
        {
            if (this.panelContRecep.Controls.Count > 0)
                this.panelContRecep.Controls.RemoveAt(0);
            Form FCR = formConsultaRecep as Form;
            FCR.TopLevel = false;
            FCR.Dock = DockStyle.Fill;
            this.panelContRecep.Controls.Add(FCR);
            this.panelContRecep.Tag = FCR;
            FCR.Show();
        }

        private void BtnConsultaRecep_Click(object sender, EventArgs e)
        {
            AbrirConsFactRecep(new VtaConsulta());
        }
        private void AbrirCancFactRecep(object formCancelarRecep)
        {
            if (this.panelContRecep.Controls.Count > 0)
                this.panelContRecep.Controls.RemoveAt(0);
            Form FCFR = formCancelarRecep as Form;
            FCFR.TopLevel = false;
            FCFR.Dock = DockStyle.Fill;
            this.panelContRecep.Controls.Add(FCFR);
            this.panelContRecep.Tag = FCFR;
            FCFR.Show();
        }

        private void BtnCancelacionRecep_Click(object sender, EventArgs e)
        {
            AbrirCancFactRecep(new VtaCancelar());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
