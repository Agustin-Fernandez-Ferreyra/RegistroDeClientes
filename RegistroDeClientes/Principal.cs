using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            var result = MessageBox.Show("¿Desea apagar el equipo ahora?", "Confirmar apagado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo("shutdown", "/s /t 0");
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ejecutar el apagado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formuario = new FrmListadoOrdenado();
            formuario.MdiParent = this;
            formuario.Show();
        }
    }
}
