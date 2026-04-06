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
        //Declaracion de un regustro
        private struct Registro
        {
            public Int32 Codgio;
            public string Usuario;
            public Decimal Deuda;
            public Decimal limite;
        }
        // Declaracion de vectores
        private Registro [] Clientes = new Registro[10]; 
        

        // declaracion de Indice
        private Int32 IND = 0;

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (IND < Clientes.Length)
            { 
                Clientes[IND].Codgio = Convert.ToInt32(TxtCodigo.Text);
                Clientes[IND].Usuario = TxtUsuario.Text;
                Clientes[IND].Deuda = Convert.ToDecimal(Txtdeuda.Text);
                Clientes[IND].limite = Convert.ToDecimal(TxtLimite.Text);
                IND++;
                Listar();
                MessageBox.Show("Registro cargado correctamente");
               TxtCodigo.Text = "";
               TxtUsuario.Text = "";
               Txtdeuda.Text = "";
               TxtLimite.Text = "";
               
            }
            else
            {
                MessageBox.Show("No se pueden cargar mas clientes");
            }
            
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            Decimal total = 0;
            DgvClientes.Rows.Clear();
            for (Int32 i = 0; i < IND; i++)
            {
                DgvClientes.Rows.Add(Clientes[i].Codgio, Clientes[i].Usuario, Clientes[i].limite, Clientes[i].Deuda);
                total += Clientes[i].Deuda;
                LblTotalDeuda.Text = total.ToString();
            }
        }

        private void FrmGestionDeClientes_Load(object sender, EventArgs e)
        {
            BtnCargar.Enabled = false;
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
    }
}