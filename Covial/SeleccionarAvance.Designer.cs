namespace Presentation
{
    partial class SeleccionarAvance
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
            panelTabla = new Panel();
            datosListar = new DataGridView();
            Eliminar = new DataGridViewCheckBoxColumn();
            groupBuscar = new GroupBox();
            lblTotal = new Label();
            textBuscar = new TextBox();
            lblBuscar = new Label();
            panel_barra = new Panel();
            lblTitulo = new Label();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupBuscar.SuspendLayout();
            panel_barra.SuspendLayout();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.Controls.Add(datosListar);
            panelTabla.Location = new Point(1, 106);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(788, 193);
            panelTabla.TabIndex = 14;
            // 
            // datosListar
            // 
            datosListar.AllowUserToAddRows = false;
            datosListar.AllowUserToDeleteRows = false;
            datosListar.AllowUserToOrderColumns = true;
            datosListar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datosListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosListar.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            datosListar.Location = new Point(12, 10);
            datosListar.Name = "datosListar";
            datosListar.ReadOnly = true;
            datosListar.Size = new Size(764, 167);
            datosListar.TabIndex = 0;
            datosListar.DoubleClick += datosListar_DoubleClick;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // groupBuscar
            // 
            groupBuscar.Controls.Add(lblTotal);
            groupBuscar.Controls.Add(textBuscar);
            groupBuscar.Controls.Add(lblBuscar);
            groupBuscar.Location = new Point(3, 45);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(788, 55);
            groupBuscar.TabIndex = 13;
            groupBuscar.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTotal.Location = new Point(558, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 18);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label";
            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Century Gothic", 8.25F);
            textBuscar.Location = new Point(96, 19);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(400, 21);
            textBuscar.TabIndex = 1;
            textBuscar.TextChanged += textBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblBuscar.Location = new Point(33, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(57, 18);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // panel_barra
            // 
            panel_barra.BackColor = Color.FromArgb(48, 157, 228);
            panel_barra.Controls.Add(lblTitulo);
            panel_barra.Location = new Point(-2, 0);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(816, 39);
            panel_barra.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 18);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listado de avances";
            // 
            // SeleccionarAvance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 321);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Controls.Add(panel_barra);
            Name = "SeleccionarAvance";
            Text = "Seleccionar Avance";
            Load += SeleccionarAvance_Load;
            panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datosListar).EndInit();
            groupBuscar.ResumeLayout(false);
            groupBuscar.PerformLayout();
            panel_barra.ResumeLayout(false);
            panel_barra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTabla;
        private DataGridView datosListar;
        private DataGridViewCheckBoxColumn Eliminar;
        private GroupBox groupBuscar;
        private Label lblTotal;
        private TextBox textBuscar;
        private Label lblBuscar;
        private Panel panel_barra;
        private Label lblTitulo;
    }
}