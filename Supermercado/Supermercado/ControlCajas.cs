using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Supermercado
{
    public partial class ControlCajas : Form
    {
        public Repositorio repo { get; set; } = new Repositorio();

        public Random Random { get; set; } = new Random();

        public ControlCajas()
        {
            InitializeComponent();
        }

        private void btnCrearCaja_Click(object sender, EventArgs e)
        {
            dgCajas.Enabled = true;
            btnCerrarCaja.Enabled = true;
            btnAgregar.Enabled = true;

            dgCajas.DataSource = null;
            dgCajas.DataSource = repo.crearListaCajas();

            dgCajas.Columns.Remove("ClientesAtendidos");
            dgCajas.Columns.Remove("ClientesEnEspera");
            dgCajas.Columns.Remove("ClienteActual");
            dgCajas.Columns.Remove("Posicion");
        }


        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                var cajaSeleccionada = new Caja();

                int indexSeleccionada = dgCajas.CurrentCell.RowIndex;
                
                cajaSeleccionada = repo.ListaCaja[indexSeleccionada];

                var clientesEnEspera = cajaSeleccionada.ClientesEnEspera;

                if(repo.ListaCaja.Count>1)
                {
                    repo.cerrarCaja(cajaSeleccionada);
                }
                else if (repo.ListaCaja.Count == 1 && cajaSeleccionada.ClientesEnEspera == 0)
                {
                    repo.cerrarCaja(cajaSeleccionada);
                }
                else if (repo.ListaCaja.Count == 1 && cajaSeleccionada.ClientesEnEspera != 0)
                    MessageBox.Show("Debe atender todos los clientes para cerrar esta caja");

                if (clientesEnEspera != 0)
                {
                    var minimo = repo.ListaCaja.OrderBy(p => p.ClientesEnEspera).FirstOrDefault();

                    minimo.ListaClientes.AddRange(cajaSeleccionada.ListaClientes);

                    minimo.ClientesEnEspera += clientesEnEspera;

                    minimo.ClienteActual = cajaSeleccionada.ClienteActual;

                }

                refrescarGrilla();
                dgCajas.Columns.Remove("ClientesAtendidos");
                dgCajas.Columns.Remove("ClientesEnEspera");
                dgCajas.Columns.Remove("Posicion");

                if (repo.ListaCaja.Count == 0)
                {
                    btnCerrarCaja.Enabled = false;
                    btnAgregar.Enabled = false;
                    dgCajas.Columns.Remove("Numero");
                    dgCajas.Enabled = false;
                }

                dgCajas.Columns.Remove("ClienteActual");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocurrió un error inesperado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
            btnAgregar.Enabled = false;
            btnCerrarCaja.Enabled = false;
            dgCajas.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
            var cajaSeleccionada = new Caja();

            int indexSeleccionada = dgCajas.CurrentCell.RowIndex;

            repo.crearCliente(Random.Next());

            cajaSeleccionada = repo.ListaCaja[indexSeleccionada];

            lbEspera.Text = "Clientes en espera: " + cajaSeleccionada.ClientesEnEspera;

            var clienteActual = cajaSeleccionada.ClienteActual;

            if (cajaSeleccionada.ListaClientes.Count != 0)
                lbNombre.Text = "Cliente Actual: " + clienteActual.Nombre;
            else
                lbNombre.Text = "Sin Clientes";

            btnSiguiente.Enabled = true;
            btnCerrarCaja.Enabled = true;
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Ocurrió un error inesperado");
            }
        }

        private void dgCajas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cajaSeleccionada = new Caja();

            int indexSeleccionada = dgCajas.CurrentCell.RowIndex;

            cajaSeleccionada = repo.ListaCaja[indexSeleccionada];

            lbAtendidos.Text = "Clientes atendidos: " + cajaSeleccionada.ClientesAtendidos;

            lbEspera.Text = "Clientes en espera: " + cajaSeleccionada.ClientesEnEspera;

            var clienteActual = cajaSeleccionada.ClienteActual;

            if (cajaSeleccionada.ListaClientes.Count != 0)
                lbNombre.Text = "Cliente Actual: " + clienteActual.Nombre;
            else
                lbNombre.Text = "Sin Clientes";

            if (cajaSeleccionada.ClientesEnEspera != 0)
                btnSiguiente.Enabled = true;
            else
                btnSiguiente.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
            var cajaSeleccionada = new Caja();

            int indexSeleccionada = dgCajas.CurrentCell.RowIndex;

            cajaSeleccionada = repo.ListaCaja[indexSeleccionada];

            cajaSeleccionada.atenderCliente(cajaSeleccionada);

            lbAtendidos.Text = "Clientes atendidos: " + cajaSeleccionada.ClientesAtendidos;

            lbEspera.Text = "Clientes en espera: " + cajaSeleccionada.ClientesEnEspera;

            var clienteActual = cajaSeleccionada.ClienteActual;

            if (cajaSeleccionada.ListaClientes.Count != 0)
                lbNombre.Text = "Cliente Actual: " + clienteActual.Nombre;
            else
                lbNombre.Text = "Sin Clientes";

            if (cajaSeleccionada.ClientesEnEspera == 0)
                btnSiguiente.Enabled = false;

            }
            catch(Exception Ex)
            {
                MessageBox.Show("Ocurrió un error inesperado");
            }

        }

        private void refrescarGrilla()
        {
            dgCajas.DataSource = null;
            dgCajas.DataSource = repo.ListaCaja;

            lbAtendidos.Text = "";
            lbEspera.Text = "";
            lbNombre.Text = "";
        }
    }
}
