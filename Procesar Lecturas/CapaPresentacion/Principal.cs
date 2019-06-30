using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soporte form = new Soporte();
            form.ShowDialog();
        }

        private void OpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones form = new Opciones();
            form.ShowDialog();
        }

        private void ActualizarMedidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PadronClientes form = new PadronClientes();
            form.ShowDialog();
        }
    }
}
