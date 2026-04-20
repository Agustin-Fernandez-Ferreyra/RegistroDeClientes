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
    public partial class ListadoDeTodosLosClientes : Form
    {
        public ListadoDeTodosLosClientes()
        {
            InitializeComponent();
        }

        private void ListadoDeTodosLosClientes_Load(object sender, EventArgs e)
        {
            Decimal total = 0;
            Decimal promedio = 0;

            DgvClientes.Rows.Clear();

            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                DgvClientes.Rows.Add(
                    Vectores.Clientes[i].Codgio,
                    Vectores.Clientes[i].Usuario,
                    Vectores.Clientes[i].limite,
                    Vectores.Clientes[i].Deuda
                );

                total += Vectores.Clientes[i].Deuda;
            }
     
            LblTotaldeDeuda.Text = total.ToString("N2");
            LblCantidadDeClientes.Text = Vectores.IND.ToString();
            if (Vectores.IND > 0)
            {
                promedio = total / Vectores.IND;
            }
            lblPromedioDeDeuda.Text = promedio.ToString("N2");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
