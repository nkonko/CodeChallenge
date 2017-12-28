using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;

namespace Supermercado
{
    public class Repositorio
    {
        public List<Caja> ListaCaja { get; set; } = new List<Caja>();

        public int NumCaja { get; set; }

        public int Posicion { get; set; }

        public List<Caja> crearListaCajas()
        {
            if (ListaCaja.Count == 0)
            {
                NumCaja = 1;
                Posicion = 0;
            }
            else
            {
                NumCaja += 1;
                Posicion += 1;
            }
            ListaCaja.Add(new Caja(NumCaja, Posicion));

            reordenarCajas();

            return ListaCaja;
        }

        public void cerrarCaja(Caja cajaSeleccionada)
        {
            ListaCaja.Remove(cajaSeleccionada);

            if (ListaCaja.Count > 0)
            {
                for (int i = 0; i < ListaCaja.Count; i++)
                {
                    ListaCaja[i].Posicion = i;
                    reordenarCajas();
                }
            }
        }

        public void crearCliente(int numCliente)
        {
            try
            {
                var nombre = nombreRandom();

                var clienteAct = new Cliente(numCliente, nombre);

                var minimo = ListaCaja.OrderBy(p => p.ClientesEnEspera).FirstOrDefault();

                ListaCaja.ElementAt(minimo.Posicion).ClienteActual = clienteAct;

                ListaCaja.ElementAt(minimo.Posicion).ListaClientes.Add(clienteAct);

                ListaCaja.ElementAt(minimo.Posicion).ClientesEnEspera = ListaCaja.ElementAt(minimo.Posicion).ListaClientes.Count;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
        }

        public string randomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public string nombreRandom()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(randomString(8));
            return builder.ToString();
        }

        private void reordenarCajas()
        {
            if (ListaCaja.Count > 0)
            {
                for (int i = 0; i < ListaCaja.Count; i++)
                {
                    ListaCaja[i].Posicion = i;
                }
            }
        }
    }
}
