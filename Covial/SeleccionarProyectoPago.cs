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
    public partial class SeleccionarProyectoPago : Form
    {
        public SeleccionarProyectoPago()
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

        private void textBuscar_TextChanged_1(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void SeleccionarProyectoPago_Load_1(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void datosListar_DoubleClick_1(object sender, EventArgs e)
        {
            Ingresar_OrdenPago form = Ingresar_OrdenPago.GetInstancia();
            string par1, par2, par3, par4, pas5, par6, pas7;
            par1 = Convert.ToString(this.datosListar.CurrentRow.Cells["proyecto_id"].Value);
            par2 = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_proyecto"].Value);
            par3 = Convert.ToString(this.datosListar.CurrentRow.Cells["descripcion"].Value);
            par4 = Convert.ToString(this.datosListar.CurrentRow.Cells["ubicacion"].Value);
            pas5 = Convert.ToString(this.datosListar.CurrentRow.Cells["cantidad_estimada"].Value);
            par6 = Convert.ToString(this.datosListar.CurrentRow.Cells["costo_unitario_estimado"].Value);
            pas7 = Convert.ToString(this.datosListar.CurrentRow.Cells["presupuesto_estimado"].Value);
            form.SetProyecto(par1, par2, par3, par4, pas5, par6, pas7);
            this.Hide();
        }
    }
}
