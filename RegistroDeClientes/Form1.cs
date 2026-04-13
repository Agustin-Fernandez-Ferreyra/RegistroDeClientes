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
    public partial class FrmGestionDeClientes : Form
    {
        public FrmGestionDeClientes()
        {
            InitializeComponent();
        }
        //Declaracion de un registro
       

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (Vectores. IND < Vectores.Clientes.Length)
            {
                Int32 i = 0;
                while (Vectores.Clientes[Vectores.IND].Codgio != Convert.ToInt32(TxtCodigo.Text) && i < Vectores.IND)
                {
                    i++;
                }
                if (i == Vectores.IND)
                {
                    Vectores.Clientes[Vectores.IND].Codgio = Convert.ToInt32(TxtCodigo.Text);
                    Vectores.Clientes[Vectores.IND].Usuario = TxtUsuario.Text;
                    Vectores.Clientes[Vectores.IND].Deuda = Convert.ToDecimal(Txtdeuda.Text);
                    Vectores.Clientes[Vectores.IND].limite = Convert.ToDecimal(TxtLimite.Text);
                    Vectores.IND++;
                    Listar();
                    MessageBox.Show("Registro cargado correctamente");
                    TxtCodigo.Text = "";
                    TxtUsuario.Text = "";
                    Txtdeuda.Text = "";
                    TxtLimite.Text = "";                                    
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
            Listar();

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

        private void FrmGestionDeClientes_Load(object sender, EventArgs e)
        {
            BtnCargar.Enabled = false;
                Precargar();
                Listar();
        }

        private void comprobar()
        {
            if (TxtCodigo.Text != "" && TxtUsuario.Text != "" && Txtdeuda.Text != "" && TxtLimite.Text != "")
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

        private void Txtdeuda_TextChanged(object sender, EventArgs e)
        {
         comprobar();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
        comprobar();
        }

        private void TxtLimite_TextChanged(object sender, EventArgs e)
        {
           comprobar();
        }
        private void Precargar()
        {
            Vectores.Clientes[Vectores.IND].Codgio = 1;
            Vectores.Clientes[Vectores.IND].Usuario = "Juan Perez";
            Vectores.Clientes[Vectores.IND].Deuda = 500;
            Vectores.Clientes[Vectores.IND].limite = 1000;
            Vectores.IND++;
            Vectores.Clientes[Vectores.IND].Codgio = 2;
            Vectores.Clientes[Vectores.IND].Usuario = "Maria Gomez";
            Vectores.Clientes[Vectores.IND].Deuda = 300;
            Vectores.Clientes[Vectores.IND].limite = 800;
            Vectores.IND++;
            Vectores.Clientes[Vectores.IND].Codgio = 3;
            Vectores.Clientes[Vectores.IND].Usuario = "Carlos Sanchez";
            Vectores.Clientes[Vectores.IND].Deuda = 200;
            Vectores.Clientes[Vectores.IND].limite = 600;
            Vectores.IND ++; // Actualizar el índice para reflejar los registros precargados
        }

        private void BtnListarDeudores_Click(object sender, EventArgs e)
        {
            Decimal total = 0;
            DgvClientes.Rows.Clear();
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                if (Vectores.Clientes[i].Deuda > 0)
                {
                    DgvClientes.Rows.Add(Vectores.Clientes[i].Codgio, Vectores.Clientes[i].Usuario, Vectores.Clientes[i].limite, Vectores.Clientes[i].Deuda);
                    total += Vectores.Clientes[i].Deuda;
                }
                
                
            }
            LblTotalDeuda.Text = total.ToString(); //siempre la etiquetas van fuera del ciclo para que no se actualice cada vez que se agrega un deudor, sino al final del proceso de listado de deudores.
        }
    } 
}
