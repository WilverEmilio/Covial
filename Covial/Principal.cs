using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public string usuario_id = "";
        public string nombre_usuario = "";
        public string rol = "";
        public Principal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar sesión?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_Usuario frm = Ingresar_Usuario.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Principal_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            GestionanUsuarios();

            this.label1.Text = "Rol: " + this.rol;
        }

        private void contratistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso_Contratista frm = Ingreso_Contratista.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tiposDeProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso_Tipo_Programa frm = Ingreso_Tipo_Programa.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void planesAnualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso_Plan_Anual frm = Ingreso_Plan_Anual.GetInstancia();
            frm.UsuarioId = this.usuario_id;
            frm.NombreUsuario = this.nombre_usuario;
            frm.Rol = this.rol;
            frm.MdiParent = this;
            frm.Show();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso_Programas frm = Ingreso_Programas.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso_Proyecto frm = Ingreso_Proyecto.GetInstancia();
            frm.UsuarioId = this.usuario_id;
            frm.NombreUsuario = this.nombre_usuario;
            frm.Rol = this.rol;
            frm.MdiParent = this;
            frm.Show();
        }

        private void avancesDelProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso_AvancesProyecto frm = Ingreso_AvancesProyecto.GetInstancia();
            frm.UsuarioId = this.usuario_id;
            frm.NombreUsuario = this.nombre_usuario;
            frm.Rol = this.rol;
            frm.MdiParent = this;
            frm.Show();
        }

        private void órdenesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresar_OrdenPago frm = Ingresar_OrdenPago.GetInstancia();
            frm.UsuarioId = this.usuario_id;
            frm.NombreUsuario = this.nombre_usuario;
            frm.Rol = this.rol;
            frm.MdiParent = this;
            frm.Show();
        }

        private void reportesDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteProyectos reporteProyectos = Reportes.ReporteProyectos.GetInstancia();
            reporteProyectos.MdiParent = this;
            reporteProyectos.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GestionanUsuarios()
        {
            if (rol == "Administrador")
            {
                this.mantenimientoToolStripMenuItem.Enabled = true;
                this.gestiónDeProgramasYProyectosToolStripMenuItem.Enabled = true;
                this.gestiónFinancieraToolStripMenuItem.Enabled = true;
                this.consultasReportesToolStripMenuItem.Enabled = true;
            }
            else if (rol == "Supervisor")
            {
                this.mantenimientoToolStripMenuItem.Enabled = false;
                this.gestiónDeProgramasYProyectosToolStripMenuItem.Enabled = true;
                this.gestiónFinancieraToolStripMenuItem.Enabled = false;
                this.consultasReportesToolStripMenuItem.Enabled = false;
                this.programasToolStripMenuItem.Enabled = false;
                this.proyectosToolStripMenuItem.Enabled = false;
            }
            else if (rol == "Consulta")
            {
                this.mantenimientoToolStripMenuItem.Enabled = false;
                this.gestiónDeProgramasYProyectosToolStripMenuItem.Enabled = false;
                this.gestiónFinancieraToolStripMenuItem.Enabled = false;
                this.consultasReportesToolStripMenuItem.Enabled = false;
            }
        }

    }
}
