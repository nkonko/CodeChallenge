using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
        public int NumCliente { get; set; }

        public string Nombre { get; set; }

        public Cliente()
        {
        }

        public Cliente(int numCliente, string nombre)
        {
            NumCliente = numCliente;
            Nombre = nombre;
        }
    }
}
