namespace Presentation
{
    partial class Ingreso_Contratista
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            panel_barra = new Panel();
            groupBuscar = new GroupBox();
            textBuscar = new TextBox();
            lblBuscar = new Label();
            panelTabla = new Panel();
            lblTotal = new Label();
            checkEliminar = new CheckBox();
            datosListar = new DataGridView();
            Eliminar = new DataGridViewCheckBoxColumn();
            groupDatos = new GroupBox();
            textTelefono = new TextBox();
            textIdContratista = new TextBox();
            textDireccion = new TextBox();
            textContacto = new TextBox();
            textNombre = new TextBox();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblContacto = new Label();
            groupBotones = new GroupBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            ttMensaje = new ToolTip(components);
            errorIcon = new ErrorProvider(components);
            panel_barra.SuspendLayout();
            groupBuscar.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupDatos.SuspendLayout();
            groupBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(175, 18);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingreso De Contratistas";
            // 
            // panel_barra
            // 
            panel_barra.BackColor = Color.FromArgb(48, 157, 228);
            panel_barra.Controls.Add(lblTitulo);
            panel_barra.Location = new Point(1, 1);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(800, 39);
            panel_barra.TabIndex = 1;
            // 
            // groupBuscar
            // 
            groupBuscar.Controls.Add(textBuscar);
            groupBuscar.Controls.Add(lblBuscar);
            groupBuscar.Location = new Point(12, 46);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(776, 55);
            groupBuscar.TabIndex = 2;
            groupBuscar.TabStop = false;
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
            // panelTabla
            // 
            panelTabla.Controls.Add(lblTotal);
            panelTabla.Controls.Add(checkEliminar);
            panelTabla.Controls.Add(datosListar);
            panelTabla.Location = new Point(12, 107);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(776, 208);
            panelTabla.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTotal.Location = new Point(12, 183);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 18);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label";
            // 
            // checkEliminar
            // 
            checkEliminar.AutoSize = true;
            checkEliminar.Location = new Point(694, 183);
            checkEliminar.Name = "checkEliminar";
            checkEliminar.Size = new Size(69, 19);
            checkEliminar.TabIndex = 2;
            checkEliminar.Text = "Eliminar";
            checkEliminar.UseVisualStyleBackColor = true;
            checkEliminar.CheckedChanged += checkEliminar_CheckedChanged;
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
            datosListar.Size = new Size(751, 167);
            datosListar.TabIndex = 0;
            datosListar.CellContentClick += datosListar_CellContentClick;
            datosListar.CellContentDoubleClick += datosListar_CellContentDoubleClick;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // groupDatos
            // 
            groupDatos.Controls.Add(textTelefono);
            groupDatos.Controls.Add(textIdContratista);
            groupDatos.Controls.Add(textDireccion);
            groupDatos.Controls.Add(textContacto);
            groupDatos.Controls.Add(textNombre);
            groupDatos.Controls.Add(lblNombre);
            groupDatos.Controls.Add(lblTelefono);
            groupDatos.Controls.Add(lblDireccion);
            groupDatos.Controls.Add(lblContacto);
            groupDatos.Location = new Point(12, 330);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(776, 110);
            groupDatos.TabIndex = 9;
            groupDatos.TabStop = false;
            // 
            // textTelefono
            // 
            textTelefono.Font = new Font("Century Gothic", 9.75F);
            textTelefono.Location = new Point(118, 66);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(215, 23);
            textTelefono.TabIndex = 9;
            // 
            // textIdContratista
            // 
            textIdContratista.Font = new Font("Century Gothic", 9.75F);
            textIdContratista.Location = new Point(359, 22);
            textIdContratista.Name = "textIdContratista";
            textIdContratista.Size = new Size(10, 23);
            textIdContratista.TabIndex = 8;
            textIdContratista.Visible = false;
            // 
            // textDireccion
            // 
            textDireccion.Font = new Font("Century Gothic", 9.75F);
            textDireccion.Location = new Point(491, 66);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(215, 23);
            textDireccion.TabIndex = 7;
            // 
            // textContacto
            // 
            textContacto.Font = new Font("Century Gothic", 9.75F);
            textContacto.Location = new Point(491, 27);
            textContacto.Name = "textContacto";
            textContacto.Size = new Size(215, 23);
            textContacto.TabIndex = 6;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Century Gothic", 9.75F);
            textNombre.Location = new Point(118, 22);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(211, 23);
            textNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblNombre.Location = new Point(44, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTelefono.Location = new Point(44, 66);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(75, 18);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono ";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblDireccion.Location = new Point(392, 71);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(81, 18);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Dirección";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblContacto.Location = new Point(392, 27);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(77, 18);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnEliminar);
            groupBotones.Controls.Add(btnCancelar);
            groupBotones.Controls.Add(btnEditar);
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Controls.Add(btnNuevo);
            groupBotones.Location = new Point(12, 446);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(776, 100);
            groupBotones.TabIndex = 10;
            groupBotones.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(538, 33);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 45);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnCancelar.Location = new Point(433, 33);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnEditar.Location = new Point(331, 33);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 45);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(222, 33);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 45);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnNuevo.Location = new Point(118, 33);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 45);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // Ingreso_Contratista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 598);
            Controls.Add(groupBotones);
            Controls.Add(groupDatos);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Controls.Add(panel_barra);
            Name = "Ingreso_Contratista";
            Text = "Ingreso_Contratista";
            Load += Ingreso_Contratista_Load;
            panel_barra.ResumeLayout(false);
            panel_barra.PerformLayout();
            groupBuscar.ResumeLayout(false);
            groupBuscar.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).EndInit();
            groupDatos.ResumeLayout(false);
            groupDatos.PerformLayout();
            groupBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panel_barra;
        private GroupBox groupBuscar;
        private TextBox textBuscar;
        private Label lblBuscar;
        private Panel panelTabla;
        private Label lblTotal;
        private CheckBox checkEliminar;
        private DataGridView datosListar;
        private DataGridViewCheckBoxColumn Eliminar;
        private GroupBox groupDatos;
        private TextBox textTelefono;
        private TextBox textIdContratista;
        private TextBox textDireccion;
        private TextBox textContacto;
        private TextBox textNombre;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblContacto;
        private GroupBox groupBotones;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private ToolTip ttMensaje;
        private ErrorProvider errorIcon;
    }
}