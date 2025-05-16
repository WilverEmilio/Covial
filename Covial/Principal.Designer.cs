namespace Presentation
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            covialToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            contratistasToolStripMenuItem = new ToolStripMenuItem();
            tiposDeProgramaToolStripMenuItem = new ToolStripMenuItem();
            planesAnualesToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeProgramasYProyectosToolStripMenuItem = new ToolStripMenuItem();
            programasToolStripMenuItem = new ToolStripMenuItem();
            proyectosToolStripMenuItem = new ToolStripMenuItem();
            avancesDelProyectoToolStripMenuItem = new ToolStripMenuItem();
            gestiónFinancieraToolStripMenuItem = new ToolStripMenuItem();
            órdenesDePagoToolStripMenuItem = new ToolStripMenuItem();
            consultasReportesToolStripMenuItem = new ToolStripMenuItem();
            reportesDeProyectosToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { covialToolStripMenuItem, mantenimientoToolStripMenuItem, gestiónDeProgramasYProyectosToolStripMenuItem, gestiónFinancieraToolStripMenuItem, consultasReportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1035, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // covialToolStripMenuItem
            // 
            covialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem });
            covialToolStripMenuItem.Name = "covialToolStripMenuItem";
            covialToolStripMenuItem.Size = new Size(52, 20);
            covialToolStripMenuItem.Text = "Covial";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(96, 22);
            cerrarSesiónToolStripMenuItem.Text = "Salir";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, contratistasToolStripMenuItem, tiposDeProgramaToolStripMenuItem, planesAnualesToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(101, 20);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(173, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // contratistasToolStripMenuItem
            // 
            contratistasToolStripMenuItem.Name = "contratistasToolStripMenuItem";
            contratistasToolStripMenuItem.Size = new Size(173, 22);
            contratistasToolStripMenuItem.Text = "Contratistas";
            contratistasToolStripMenuItem.Click += contratistasToolStripMenuItem_Click;
            // 
            // tiposDeProgramaToolStripMenuItem
            // 
            tiposDeProgramaToolStripMenuItem.Name = "tiposDeProgramaToolStripMenuItem";
            tiposDeProgramaToolStripMenuItem.Size = new Size(173, 22);
            tiposDeProgramaToolStripMenuItem.Text = "Tipos de Programa";
            tiposDeProgramaToolStripMenuItem.Click += tiposDeProgramaToolStripMenuItem_Click;
            // 
            // planesAnualesToolStripMenuItem
            // 
            planesAnualesToolStripMenuItem.Name = "planesAnualesToolStripMenuItem";
            planesAnualesToolStripMenuItem.Size = new Size(173, 22);
            planesAnualesToolStripMenuItem.Text = "Planes Anuales";
            planesAnualesToolStripMenuItem.Click += planesAnualesToolStripMenuItem_Click;
            // 
            // gestiónDeProgramasYProyectosToolStripMenuItem
            // 
            gestiónDeProgramasYProyectosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programasToolStripMenuItem, proyectosToolStripMenuItem, avancesDelProyectoToolStripMenuItem });
            gestiónDeProgramasYProyectosToolStripMenuItem.Name = "gestiónDeProgramasYProyectosToolStripMenuItem";
            gestiónDeProgramasYProyectosToolStripMenuItem.Size = new Size(199, 20);
            gestiónDeProgramasYProyectosToolStripMenuItem.Text = "Gestión de Programas y Proyectos";
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(187, 22);
            programasToolStripMenuItem.Text = "Programas";
            programasToolStripMenuItem.Click += programasToolStripMenuItem_Click;
            // 
            // proyectosToolStripMenuItem
            // 
            proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            proyectosToolStripMenuItem.Size = new Size(187, 22);
            proyectosToolStripMenuItem.Text = "Proyectos";
            proyectosToolStripMenuItem.Click += proyectosToolStripMenuItem_Click;
            // 
            // avancesDelProyectoToolStripMenuItem
            // 
            avancesDelProyectoToolStripMenuItem.Name = "avancesDelProyectoToolStripMenuItem";
            avancesDelProyectoToolStripMenuItem.Size = new Size(187, 22);
            avancesDelProyectoToolStripMenuItem.Text = "Avances del Proyecto";
            avancesDelProyectoToolStripMenuItem.Click += avancesDelProyectoToolStripMenuItem_Click;
            // 
            // gestiónFinancieraToolStripMenuItem
            // 
            gestiónFinancieraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { órdenesDePagoToolStripMenuItem });
            gestiónFinancieraToolStripMenuItem.Name = "gestiónFinancieraToolStripMenuItem";
            gestiónFinancieraToolStripMenuItem.Size = new Size(116, 20);
            gestiónFinancieraToolStripMenuItem.Text = "Gestión Financiera";
            // 
            // órdenesDePagoToolStripMenuItem
            // 
            órdenesDePagoToolStripMenuItem.Name = "órdenesDePagoToolStripMenuItem";
            órdenesDePagoToolStripMenuItem.Size = new Size(164, 22);
            órdenesDePagoToolStripMenuItem.Text = "Órdenes de Pago";
            órdenesDePagoToolStripMenuItem.Click += órdenesDePagoToolStripMenuItem_Click;
            // 
            // consultasReportesToolStripMenuItem
            // 
            consultasReportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportesDeProyectosToolStripMenuItem });
            consultasReportesToolStripMenuItem.Name = "consultasReportesToolStripMenuItem";
            consultasReportesToolStripMenuItem.Size = new Size(128, 20);
            consultasReportesToolStripMenuItem.Text = "Consultas / Reportes";
            // 
            // reportesDeProyectosToolStripMenuItem
            // 
            reportesDeProyectosToolStripMenuItem.Name = "reportesDeProyectosToolStripMenuItem";
            reportesDeProyectosToolStripMenuItem.Size = new Size(120, 22);
            reportesDeProyectosToolStripMenuItem.Text = "Reportes";
            reportesDeProyectosToolStripMenuItem.Click += reportesDeProyectosToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1035, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 505);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1035, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(48, 17);
            toolStripStatusLabel1.Text = "COVIAL";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 527);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += Principal_Load;
            InputLanguageChanging += Principal_InputLanguageChanging;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem covialToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem contratistasToolStripMenuItem;
        private ToolStripMenuItem tiposDeProgramaToolStripMenuItem;
        private ToolStripMenuItem planesAnualesToolStripMenuItem;
        private ToolStripMenuItem gestiónDeProgramasYProyectosToolStripMenuItem;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem proyectosToolStripMenuItem;
        private ToolStripMenuItem avancesDelProyectoToolStripMenuItem;
        private ToolStripMenuItem gestiónFinancieraToolStripMenuItem;
        private ToolStripMenuItem órdenesDePagoToolStripMenuItem;
        private ToolStripMenuItem consultasReportesToolStripMenuItem;
        private ToolStripMenuItem reportesDeProyectosToolStripMenuItem;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}