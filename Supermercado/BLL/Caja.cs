using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Caja
    {
        public int Numero { get; set; }

        public Cliente ClienteActual { get; set; }

        public int ClientesAtendidos { get; set; }

        public int ClientesEnEspera { get; set; }

        public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

        public int Posicion { get; set; }

        public Caja()
        {
        }

        public Caja(int numero, int posicion)
        {
            Numero = numero;
            ClientesAtendidos = 0;
            ClientesEnEspera = 0;
            Posicion = posicion;
        }

        public void atenderCliente(Caja caja)
        {
            try
            {
            if (caja.ClientesEnEspera != 0)
            {
                caja.ClientesAtendidos += 1;
                caja.ClientesEnEspera -= 1;
            }
            if (caja.ListaClientes.Count != 0)
                caja.ListaClientes.RemoveAt(0);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
