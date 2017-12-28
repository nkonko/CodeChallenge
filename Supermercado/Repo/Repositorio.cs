using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace Supermercado
{
    public class Repositorio
    {
        public List<Caja> listaCaja { get; set; }

        public Repositorio()
        {
            listaCaja = new List<Caja>();
        }

        private int? NumCaja { get; set; }


        public List<Caja> crearListaCajas()
        {

            NumCaja = NumCaja == null ? 1 : NumCaja++;


            listaCaja.Add(new Caja(NumCaja));

            return listaCaja;
        }

        public static Cliente crearCliente(int numCliente, string nombre)
        {

            return new Cliente(numCliente, nombre);
        }




    }
}
