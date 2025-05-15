namespace Presentation
{
    partial class SeleccionarTipoPrograma
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
            panel_barra = new Panel();
            lblTitulo = new Label();
            panelTabla = new Panel();
            datosListar = new DataGridView();
            Eliminar = new DataGridViewCheckBoxColumn();
            groupBuscar = new GroupBox();
            lblTotal = new Label();
            textBuscar = new TextBox();
            lblBuscar = new Label();
            panel_barra.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupBuscar.SuspendLayout();
            SuspendLayout();
            // 
            // panel_barra
            // 
            panel_barra.BackColor = Color.FromArgb(48, 157, 228);
            panel_barra.Controls.Add(lblTitulo);
            panel_barra.Location = new Point(0, 1);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(816, 39);
            panel_barra.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(223, 18);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listado de tipos de programa";
            // 
            // panelTabla
            // 
            panelTabla.Controls.Add(datosListar);
            panelTabla.Location = new Point(3, 106);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(788, 193);
            panelTabla.TabIndex = 11;
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
            groupBuscar.Location = new Point(5, 44);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(788, 55);
            groupBuscar.TabIndex = 10;
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
            // SeleccionarTipoPrograma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 315);
            Controls.Add(panel_barra);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Name = "SeleccionarTipoPrograma";
            Text = "Listado tipos de programa";
            Load += SeleccionarTipoPrograma_Load;
            panel_barra.ResumeLayout(false);
            panel_barra.PerformLayout();
            panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datosListar).EndInit();
            groupBuscar.ResumeLayout(false);
            groupBuscar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_barra;
        private Label lblTitulo;
        private Panel panelTabla;
        private DataGridView datosListar;
        private DataGridViewCheckBoxColumn Eliminar;
        private GroupBox groupBuscar;
        private Label lblTotal;
        private TextBox textBuscar;
        private Label lblBuscar;
    }
}