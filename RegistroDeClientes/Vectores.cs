using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeClientes
{
    internal class Vectores
    {
        public struct Registro
        {
            public Int32 Codgio;
            public string Usuario;
            public Decimal Deuda;
            public Decimal limite;
        }
        // Declaracion de vectores
        static public Registro[] Clientes = new Registro[10];


        // declaracion de Indice
        static public Int32 IND = 0;
    }
}

