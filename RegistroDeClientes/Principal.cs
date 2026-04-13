using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeClientes
{
    public partial class FrmManejoFormulario : Form
    {
        public FrmManejoFormulario()
        {
            InitializeComponent();
        }

        private void agrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmGestionDeClientes();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmGestionDeClientes();
            Close();
            
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {    
                    
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formuario = new FrmListadoOrdenado();
            formuario.MdiParent = this;
            formuario.Show();
        }
    }
}
