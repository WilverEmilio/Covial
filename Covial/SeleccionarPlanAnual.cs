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
    public partial class SeleccionarPlanAnual : Form
    {
        public SeleccionarPlanAnual()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {
            this.datosListar.Columns[0].Visible = false; //Columna Eliminar
            this.datosListar.Columns[1].Visible = false; //Columna ID
        }

        private void Mostrar()
        {
            this.datosListar.DataSource = PlanAnualModel.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void Buscar()
        {
            this.datosListar.DataSource = PlanAnualModel.BuscarNombre(this.textBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(datosListar.Rows.Count);
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void SeleccionarPlanAnual_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void datosListar_DoubleClick(object sender, EventArgs e)
        {
            Ingreso_Programas form = Ingreso_Programas.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.datosListar.CurrentRow.Cells["plan_anual_id"].Value);
            par2 = Convert.ToString(this.datosListar.CurrentRow.Cells["nombre_plan"].Value);
            form.setPlanAnual(par1, par2);
            this.Hide();
        }
    }
}
