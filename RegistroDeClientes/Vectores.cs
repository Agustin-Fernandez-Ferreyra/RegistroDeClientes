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


        static public void Precargar()
            {
            Clientes[IND].Codgio = 1;
            Clientes[IND].Usuario = "Juan Perez";
            Clientes[IND].Deuda = 500;
            Clientes[IND].limite = 1000;
            IND++;
            Clientes[IND].Codgio = 2;
            Clientes[IND].Usuario = "Maria Gomez";
            Clientes[IND].Deuda = 300;
            Clientes[IND].limite = 800;
            IND++;
            Clientes[IND].Codgio = 3;
            Clientes[IND].Usuario = "Carlos Sanchez";
            Clientes[IND].Deuda = 200;
            Clientes[IND].limite = 600;
            IND++; // Actualizar el índice para reflejar los registros precargados
        }

        public static void OrdenarPorcodigosAscendente()
        {
            if (IND <= 1) return;

            Int32 c = 0;
            Int32 i = 0;
            Registro aux;

            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Codgio > Clientes[i + 1].Codgio)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }


        public static void OrdenarPorcodigosDescendente()
        {
            if (IND <= 1) return;

            Int32 c = 0;
            Int32 i = 0;
            Registro aux;

            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Codgio < Clientes[i + 1].Codgio)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }

        public static void OrdenarPorNombreAscendente()
        {
            if (IND <= 1) return;

            Int32 c = 0;
            Int32 i = 0;
            Registro aux;

            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (string.Compare(Clientes[i].Usuario, Clientes[i + 1].Usuario, StringComparison.CurrentCulture) > 0)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorNombreDescendente()
        {
            if (IND <= 1) return;

            Int32 c = 0;
            Int32 i = 0;
            Registro aux;

            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (string.Compare(Clientes[i].Usuario, Clientes[i + 1].Usuario, StringComparison.CurrentCulture) < 0)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorLimiteAscendente()
        {
            if (IND <= 1) return;
            Int32 c = 0;
            Int32 i = 0;
            Registro aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].limite > Clientes[i + 1].limite)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorLimiteDescendente()
        {
            if (IND <= 1) return;
            Int32 c = 0;
            Int32 i = 0;
            Registro aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].limite < Clientes[i + 1].limite)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorDeudaAscendente()
        {
            if (IND <= 1) return;
            Int32 c = 0;
            Int32 i = 0;
            Registro aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda > Clientes[i + 1].Deuda)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }
        public static void OrdenarPorDeudaDescendente()
        {
            if (IND <= 1) return;
            Int32 c = 0;
            Int32 i = 0;
            Registro aux;
            while (c < IND - 1)
            {
                i = 0;
                while (i < IND - 1)
                {
                    if (Clientes[i].Deuda < Clientes[i + 1].Deuda)
                    {
                        aux = Clientes[i];
                        Clientes[i] = Clientes[i + 1];
                        Clientes[i + 1] = aux;
                    }
                    i++;
                }
                c++;
            }
        }
}
}

