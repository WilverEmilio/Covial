namespace Presentation
{
    partial class Ingreso_Programas
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
            groupBotones = new GroupBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            groupDatos = new GroupBox();
            btnBuscarTipoPrograma = new Button();
            btnBuscarPlanAnual = new Button();
            textNombreTipoPrograma = new TextBox();
            lblTipoPrograma = new Label();
            textIdTipoPrograma = new TextBox();
            textNombrePlanAnual = new TextBox();
            lblPlanAnual = new Label();
            textIdPlanAnual = new TextBox();
            lblAnoFin = new Label();
            dateTimePickerFin = new DateTimePicker();
            lblAnoInicio = new Label();
            dateTimePickerInicio = new DateTimePicker();
            textIdPrograma = new TextBox();
            textDescripcion = new TextBox();
            textNombre = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            panelTabla = new Panel();
            lblTotal = new Label();
            checkEliminar = new CheckBox();
            datosListar = new DataGridView();
            Eliminar = new DataGridViewCheckBoxColumn();
            groupBuscar = new GroupBox();
            textBuscar = new TextBox();
            lblBuscar = new Label();
            panel_barra = new Panel();
            errorIcon = new ErrorProvider(components);
            ttMensaje = new ToolTip(components);
            groupBotones.SuspendLayout();
            groupDatos.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupBuscar.SuspendLayout();
            panel_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(169, 18);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingreso De Programas";
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnEliminar);
            groupBotones.Controls.Add(btnCancelar);
            groupBotones.Controls.Add(btnEditar);
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Controls.Add(btnNuevo);
            groupBotones.Location = new Point(12, 506);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(788, 100);
            groupBotones.TabIndex = 9;
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
            // groupDatos
            // 
            groupDatos.Controls.Add(btnBuscarTipoPrograma);
            groupDatos.Controls.Add(btnBuscarPlanAnual);
            groupDatos.Controls.Add(textNombreTipoPrograma);
            groupDatos.Controls.Add(lblTipoPrograma);
            groupDatos.Controls.Add(textIdTipoPrograma);
            groupDatos.Controls.Add(textNombrePlanAnual);
            groupDatos.Controls.Add(lblPlanAnual);
            groupDatos.Controls.Add(textIdPlanAnual);
            groupDatos.Controls.Add(lblAnoFin);
            groupDatos.Controls.Add(dateTimePickerFin);
            groupDatos.Controls.Add(lblAnoInicio);
            groupDatos.Controls.Add(dateTimePickerInicio);
            groupDatos.Controls.Add(textIdPrograma);
            groupDatos.Controls.Add(textDescripcion);
            groupDatos.Controls.Add(textNombre);
            groupDatos.Controls.Add(lblNombre);
            groupDatos.Controls.Add(lblDescripcion);
            groupDatos.Location = new Point(12, 319);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(788, 183);
            groupDatos.TabIndex = 8;
            groupDatos.TabStop = false;
            // 
            // btnBuscarTipoPrograma
            // 
            btnBuscarTipoPrograma.Location = new Point(744, 141);
            btnBuscarTipoPrograma.Name = "btnBuscarTipoPrograma";
            btnBuscarTipoPrograma.Size = new Size(34, 23);
            btnBuscarTipoPrograma.TabIndex = 24;
            btnBuscarTipoPrograma.Text = "B";
            btnBuscarTipoPrograma.UseVisualStyleBackColor = true;
            btnBuscarTipoPrograma.Click += btnBuscarTipoPrograma_Click;
            // 
            // btnBuscarPlanAnual
            // 
            btnBuscarPlanAnual.Location = new Point(349, 142);
            btnBuscarPlanAnual.Name = "btnBuscarPlanAnual";
            btnBuscarPlanAnual.Size = new Size(34, 23);
            btnBuscarPlanAnual.TabIndex = 23;
            btnBuscarPlanAnual.Text = "B";
            btnBuscarPlanAnual.UseVisualStyleBackColor = true;
            btnBuscarPlanAnual.Click += btnBuscarPlanAnual_Click;
            // 
            // textNombreTipoPrograma
            // 
            textNombreTipoPrograma.Font = new Font("Century Gothic", 9.75F);
            textNombreTipoPrograma.Location = new Point(538, 139);
            textNombreTipoPrograma.Name = "textNombreTipoPrograma";
            textNombreTipoPrograma.Size = new Size(200, 23);
            textNombreTipoPrograma.TabIndex = 22;
            // 
            // lblTipoPrograma
            // 
            lblTipoPrograma.AutoSize = true;
            lblTipoPrograma.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTipoPrograma.Location = new Point(420, 141);
            lblTipoPrograma.Name = "lblTipoPrograma";
            lblTipoPrograma.Size = new Size(116, 18);
            lblTipoPrograma.TabIndex = 21;
            lblTipoPrograma.Text = "Tipo programa";
            // 
            // textIdTipoPrograma
            // 
            textIdTipoPrograma.Font = new Font("Century Gothic", 9.75F);
            textIdTipoPrograma.Location = new Point(404, 138);
            textIdTipoPrograma.Name = "textIdTipoPrograma";
            textIdTipoPrograma.Size = new Size(10, 23);
            textIdTipoPrograma.TabIndex = 20;
            textIdTipoPrograma.Visible = false;
            // 
            // textNombrePlanAnual
            // 
            textNombrePlanAnual.Font = new Font("Century Gothic", 9.75F);
            textNombrePlanAnual.Location = new Point(135, 142);
            textNombrePlanAnual.Name = "textNombrePlanAnual";
            textNombrePlanAnual.Size = new Size(200, 23);
            textNombrePlanAnual.TabIndex = 19;
            // 
            // lblPlanAnual
            // 
            lblPlanAnual.AutoSize = true;
            lblPlanAnual.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblPlanAnual.Location = new Point(33, 142);
            lblPlanAnual.Name = "lblPlanAnual";
            lblPlanAnual.Size = new Size(85, 18);
            lblPlanAnual.TabIndex = 18;
            lblPlanAnual.Text = "Plan anual";
            // 
            // textIdPlanAnual
            // 
            textIdPlanAnual.Font = new Font("Century Gothic", 9.75F);
            textIdPlanAnual.Location = new Point(17, 139);
            textIdPlanAnual.Name = "textIdPlanAnual";
            textIdPlanAnual.Size = new Size(10, 23);
            textIdPlanAnual.TabIndex = 17;
            textIdPlanAnual.Visible = false;
            // 
            // lblAnoFin
            // 
            lblAnoFin.AutoSize = true;
            lblAnoFin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblAnoFin.Location = new Point(17, 108);
            lblAnoFin.Name = "lblAnoFin";
            lblAnoFin.Size = new Size(136, 18);
            lblAnoFin.TabIndex = 16;
            lblAnoFin.Text = "Fecha fin prevista";
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(183, 108);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(200, 23);
            dateTimePickerFin.TabIndex = 15;
            // 
            // lblAnoInicio
            // 
            lblAnoInicio.AutoSize = true;
            lblAnoInicio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblAnoInicio.Location = new Point(17, 76);
            lblAnoInicio.Name = "lblAnoInicio";
            lblAnoInicio.Size = new Size(160, 18);
            lblAnoInicio.TabIndex = 14;
            lblAnoInicio.Text = "Fecha inicio prevista";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(183, 73);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(200, 23);
            dateTimePickerInicio.TabIndex = 13;
            // 
            // textIdPrograma
            // 
            textIdPrograma.Font = new Font("Century Gothic", 9.75F);
            textIdPrograma.Location = new Point(357, 32);
            textIdPrograma.Name = "textIdPrograma";
            textIdPrograma.Size = new Size(10, 23);
            textIdPrograma.TabIndex = 8;
            textIdPrograma.Visible = false;
            // 
            // textDescripcion
            // 
            textDescripcion.Font = new Font("Century Gothic", 9.75F);
            textDescripcion.Location = new Point(521, 27);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(255, 99);
            textDescripcion.TabIndex = 6;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Century Gothic", 9.75F);
            textNombre.Location = new Point(135, 32);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(200, 23);
            textNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblNombre.Location = new Point(17, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblDescripcion.Location = new Point(418, 32);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(97, 18);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripción";
            // 
            // panelTabla
            // 
            panelTabla.Controls.Add(lblTotal);
            panelTabla.Controls.Add(checkEliminar);
            panelTabla.Controls.Add(datosListar);
            panelTabla.Location = new Point(12, 105);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(788, 208);
            panelTabla.TabIndex = 7;
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
            checkEliminar.Location = new Point(707, 183);
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
            datosListar.Size = new Size(764, 167);
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
            // groupBuscar
            // 
            groupBuscar.Controls.Add(textBuscar);
            groupBuscar.Controls.Add(lblBuscar);
            groupBuscar.Location = new Point(12, 44);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(788, 55);
            groupBuscar.TabIndex = 6;
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
            // panel_barra
            // 
            panel_barra.BackColor = Color.FromArgb(48, 157, 228);
            panel_barra.Controls.Add(lblTitulo);
            panel_barra.Location = new Point(0, -1);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(816, 39);
            panel_barra.TabIndex = 5;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // Ingreso_Programas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 623);
            Controls.Add(groupBotones);
            Controls.Add(groupDatos);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Controls.Add(panel_barra);
            Name = "Ingreso_Programas";
            Text = "Ingreso_Programas";
            Load += Ingreso_Programas_Load;
            groupBotones.ResumeLayout(false);
            groupDatos.ResumeLayout(false);
            groupDatos.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).EndInit();
            groupBuscar.ResumeLayout(false);
            groupBuscar.PerformLayout();
            panel_barra.ResumeLayout(false);
            panel_barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private GroupBox groupBotones;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private GroupBox groupDatos;
        private TextBox textIdPrograma;
        private TextBox textDescripcion;
        private TextBox textNombre;
        private Label lblNombre;
        private Label lblDescripcion;
        private Panel panelTabla;
        private Label lblTotal;
        private CheckBox checkEliminar;
        private DataGridView datosListar;
        private DataGridViewCheckBoxColumn Eliminar;
        private GroupBox groupBuscar;
        private TextBox textBuscar;
        private Label lblBuscar;
        private Panel panel_barra;
        private Label lblPlanAnual;
        private TextBox textIdPlanAnual;
        private Label lblAnoFin;
        private DateTimePicker dateTimePickerFin;
        private Label lblAnoInicio;
        private DateTimePicker dateTimePickerInicio;
        private Button btnBuscarTipoPrograma;
        private Button btnBuscarPlanAnual;
        private TextBox textNombreTipoPrograma;
        private Label lblTipoPrograma;
        private TextBox textIdTipoPrograma;
        private TextBox textNombrePlanAnual;
        private ErrorProvider errorIcon;
        private ToolTip ttMensaje;
    }
}