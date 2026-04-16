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
    public partial class FrmListadoOrdenado : Form
    {
        public FrmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            switch(CmbCampo.SelectedIndex)
            {
                case 0:
                    if (Cmbmodo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarPorcodigosAscendente();

                    }
                    else
                    {
                        Vectores.OrdenarPorcodigosDescendente();
                    }
                    break;
                case 1:
                    if (Cmbmodo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarPorNombreAscendente();

                    }
                    else
                    {
                        Vectores.OrdenarPorNombreDescendente();
                    }
                    break;
                    case 2:
                    if (Cmbmodo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarPorLimiteAscendente();

                    }
                    else
                    {
                        Vectores.OrdenarPorLimiteDescendente();
                    }
                    break;
                    case 3:
                    if (Cmbmodo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarPorcodigosAscendente();

                    }
                    else
                    {
                        Vectores.OrdenarPorcodigosDescendente();
                    }
                    break;
                   


            }
            DgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                DgvClientes.Rows.Add(Vectores.Clientes[i].Codgio, Vectores.Clientes[i].Usuario, Vectores.Clientes[i].Deuda, Vectores.Clientes[i].limite);  

            }
        }

        private void FrmListadoOrdenado_Load(object sender, EventArgs e)
        {
          Vectores.Precargar();
        }
    }
}
