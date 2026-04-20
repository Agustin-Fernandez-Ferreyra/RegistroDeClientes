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
    public partial class FrmClientesDeudores : Form
    {
        public FrmClientesDeudores()
        {
            InitializeComponent();
        }      
        private void BtnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            Decimal total = 0;
            DgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                DgvClientes.Rows.Add(Vectores.Clientes[i].Codgio, Vectores.Clientes[i].Usuario, Vectores.Clientes[i].limite, Vectores.Clientes[i].Deuda);
                total += Vectores.Clientes[i].Deuda;
                LblTotalDeuda.Text = total.ToString();
            }
        }
        private void BtnListarDeudores_Click(object sender, EventArgs e)
        {
            Decimal total = 0;
            Int32 contadorDeudores = 0; 
            Decimal promedio = 0;

            DgvClientes.Rows.Clear();

            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                if (Vectores.Clientes[i].Deuda > 0)
                {
                    DgvClientes.Rows.Add(Vectores.Clientes[i].Codgio, Vectores.Clientes[i].Usuario, Vectores.Clientes[i].limite, Vectores.Clientes[i].Deuda);

                    total += Vectores.Clientes[i].Deuda;
                    contadorDeudores++; 
                }
            }

        
            LblTotalDeuda.Text = total.ToString();
            LblcantidadClientes.Text = contadorDeudores.ToString();

            
            if (contadorDeudores > 0)
            {
                promedio = total / contadorDeudores;
            }

            LblPromedioDeuda.Text = promedio.ToString("N2"); //siempre la etiquetas van fuera del ciclo para que no se actualice cada vez que se agrega un deudor, sino al final del proceso de listado de deudores.
        }
        
    } 
}
