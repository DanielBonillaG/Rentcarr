using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Presentacion
{
    public partial class FrmVehiculos : Form
    {
        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var vehiculo = new Entidades.Vehiculo(txtPlaca.Text , txtMarca.Text,int.Parse(txtKMactual.Text));
            Guardar(vehiculo);
        }
        void Guardar(Entidades.Vehiculo vehiculo)
        {
            var repositorio = new RepositorioVehiculo();
           MessageBox.Show( repositorio.Insertar(vehiculo));
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            CargarLista();
            CargarGrilla();
        }
        void CargarLista()
        {
            var lista = new RepositorioVehiculo().Todos("");
            listaVehiculos.DataSource = lista;
            listaVehiculos.DisplayMember = "Marca";
            listaVehiculos.ValueMember = "PlacaVehiculo";
        }
        void CargarGrilla()
        {
            var lista = new RepositorioVehiculo().Todos("");
            GrillaVehiculos.DataSource = lista;
          
        }

        private void listaVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = listaVehiculos.SelectedValue.ToString();
        }
    }
}
