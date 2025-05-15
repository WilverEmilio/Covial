using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class SeleccionarProyecto : Form
    {
        public SeleccionarProyecto()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {
            this.datosListar.Columns[0].Visible = false; //Columna Eliminar
        }

        private void Mostrar()
        {
            this.datosListar.DataSource = ProyectoModel.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = ProyectoModel.BuscarNombre(this.textBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void SeleccionarProyecto_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void datosListar_DoubleClick(object sender, EventArgs e)
        {
            Ingreso_AvancesProyecto form = Ingreso_AvancesProyecto.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.datosListar.CurrentRow.Cells["proyecto_id"].Value);
            par2 = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_proyecto"].Value);
            form.setProyecto(par1, par2);
            this.Hide();
        }
    }
}
