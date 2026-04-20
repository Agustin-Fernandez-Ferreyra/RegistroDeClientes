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
    public partial class AgregarClientes : Form
    {
        public AgregarClientes()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (Vectores.IND < Vectores.Clientes.Length)
            {
                Int32 i = 0;
                while (Vectores.Clientes[i].Codgio != Convert.ToInt32(TxtCodigo.Text) && i < Vectores.IND)
                {
                    i++;
                }
                if (i == Vectores.IND)
                {
                    Vectores.Clientes[Vectores.IND].Codgio = Convert.ToInt32(TxtCodigo.Text);
                    Vectores.Clientes[Vectores.IND].Usuario = TxtNombreYApellido.Text;
                    Vectores.Clientes[Vectores.IND].Deuda = Convert.ToDecimal(TxtDeuda.Text);
                    Vectores.Clientes[Vectores.IND].limite = Convert.ToDecimal(TxtListadoDeCreditos.Text);
                    Vectores.IND++;
                    MessageBox.Show("Registro cargado correctamente");
                    TxtCodigo.Text = "";
                    TxtNombreYApellido.Text = "";
                    TxtDeuda.Text = "";
                    TxtListadoDeCreditos.Text = "";
                }
                else
                {
                    MessageBox.Show("El codigo ya existe, ingrese otro");
                    TxtCodigo.Text = "";

                }

            }
            else
            {
                MessageBox.Show("No se pueden cargar mas clientes");
                TxtCodigo.Text = "";
            }
        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {
            BtnCargar.Enabled = false;
            

        }

        private void comprobar()
        {
            if (TxtCodigo.Text != "" && TxtNombreYApellido.Text != "" && TxtDeuda.Text != "" && TxtListadoDeCreditos.Text != "")
            {
                BtnCargar.Enabled = true;
            }
            else
            {
                BtnCargar.Enabled = false;
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void TxtNombreYApellido_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void TxtDeuda_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void TxtListadoDeCreditos_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }
    }
}
