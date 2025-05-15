namespace Presentation
{
    partial class Ingreso_Proyecto
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
            ttMensaje = new ToolTip(components);
            errorIcon = new ErrorProvider(components);
            groupBotones = new GroupBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            groupDatos = new GroupBox();
            textEstado = new TextBox();
            label1 = new Label();
            textIdUser = new TextBox();
            textCreadoPor = new TextBox();
            lblCreadoPor = new Label();
            lblAnoFin = new Label();
            textPresupuesto = new TextBox();
            dateTimePickerFin = new DateTimePicker();
            lblPresupuesto = new Label();
            lblAnoInicio = new Label();
            textCostoUnitario = new TextBox();
            dateTimePickerInicio = new DateTimePicker();
            lblCostoUnitario = new Label();
            textCantidadEstimada = new TextBox();
            lblCantidadEstimada = new Label();
            textUbicacion = new TextBox();
            lblUbicacion = new Label();
            btnBuscarContratista = new Button();
            btnBuscarPrograma = new Button();
            textNombreContratista = new TextBox();
            lblContratista = new Label();
            textIdContratista = new TextBox();
            textNombrePrograma = new TextBox();
            lblPrograma = new Label();
            textIdPrograma = new TextBox();
            textIdProyecto = new TextBox();
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
            lblTitulo = new Label();
            textUnidadDeMedida = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            groupBotones.SuspendLayout();
            groupDatos.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupBuscar.SuspendLayout();
            panel_barra.SuspendLayout();
            SuspendLayout();
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnEliminar);
            groupBotones.Controls.Add(btnCancelar);
            groupBotones.Controls.Add(btnEditar);
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Controls.Add(btnNuevo);
            groupBotones.Location = new Point(12, 530);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(1285, 100);
            groupBotones.TabIndex = 14;
            groupBotones.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(749, 34);
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
            btnCancelar.Location = new Point(644, 34);
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
            btnEditar.Location = new Point(542, 34);
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
            btnGuardar.Location = new Point(433, 34);
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
            btnNuevo.Location = new Point(329, 34);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 45);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupDatos
            // 
            groupDatos.Controls.Add(textUnidadDeMedida);
            groupDatos.Controls.Add(label2);
            groupDatos.Controls.Add(textEstado);
            groupDatos.Controls.Add(label1);
            groupDatos.Controls.Add(textIdUser);
            groupDatos.Controls.Add(textCreadoPor);
            groupDatos.Controls.Add(lblCreadoPor);
            groupDatos.Controls.Add(lblAnoFin);
            groupDatos.Controls.Add(textPresupuesto);
            groupDatos.Controls.Add(dateTimePickerFin);
            groupDatos.Controls.Add(lblPresupuesto);
            groupDatos.Controls.Add(lblAnoInicio);
            groupDatos.Controls.Add(textCostoUnitario);
            groupDatos.Controls.Add(dateTimePickerInicio);
            groupDatos.Controls.Add(lblCostoUnitario);
            groupDatos.Controls.Add(textCantidadEstimada);
            groupDatos.Controls.Add(lblCantidadEstimada);
            groupDatos.Controls.Add(textUbicacion);
            groupDatos.Controls.Add(lblUbicacion);
            groupDatos.Controls.Add(btnBuscarContratista);
            groupDatos.Controls.Add(btnBuscarPrograma);
            groupDatos.Controls.Add(textNombreContratista);
            groupDatos.Controls.Add(lblContratista);
            groupDatos.Controls.Add(textIdContratista);
            groupDatos.Controls.Add(textNombrePrograma);
            groupDatos.Controls.Add(lblPrograma);
            groupDatos.Controls.Add(textIdPrograma);
            groupDatos.Controls.Add(textIdProyecto);
            groupDatos.Controls.Add(textDescripcion);
            groupDatos.Controls.Add(textNombre);
            groupDatos.Controls.Add(lblNombre);
            groupDatos.Controls.Add(lblDescripcion);
            groupDatos.Location = new Point(12, 318);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(1285, 206);
            groupDatos.TabIndex = 13;
            groupDatos.TabStop = false;
            // 
            // textEstado
            // 
            textEstado.Font = new Font("Century Gothic", 9.75F);
            textEstado.Location = new Point(519, 168);
            textEstado.Name = "textEstado";
            textEstado.Size = new Size(200, 23);
            textEstado.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label1.Location = new Point(433, 173);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 36;
            label1.Text = "Estado";
            // 
            // textIdUser
            // 
            textIdUser.Font = new Font("Century Gothic", 9.75F);
            textIdUser.Location = new Point(1067, 155);
            textIdUser.Name = "textIdUser";
            textIdUser.Size = new Size(10, 23);
            textIdUser.TabIndex = 35;
            textIdUser.Visible = false;
            // 
            // textCreadoPor
            // 
            textCreadoPor.Font = new Font("Century Gothic", 9.75F);
            textCreadoPor.Location = new Point(937, 155);
            textCreadoPor.Name = "textCreadoPor";
            textCreadoPor.Size = new Size(98, 23);
            textCreadoPor.TabIndex = 34;
            // 
            // lblCreadoPor
            // 
            lblCreadoPor.AutoSize = true;
            lblCreadoPor.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblCreadoPor.Location = new Point(782, 160);
            lblCreadoPor.Name = "lblCreadoPor";
            lblCreadoPor.Size = new Size(94, 18);
            lblCreadoPor.TabIndex = 33;
            lblCreadoPor.Text = "Creado por";
            // 
            // lblAnoFin
            // 
            lblAnoFin.AutoSize = true;
            lblAnoFin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblAnoFin.Location = new Point(1108, 84);
            lblAnoFin.Name = "lblAnoFin";
            lblAnoFin.Size = new Size(136, 18);
            lblAnoFin.TabIndex = 20;
            lblAnoFin.Text = "Fecha fin prevista";
            // 
            // textPresupuesto
            // 
            textPresupuesto.Font = new Font("Century Gothic", 9.75F);
            textPresupuesto.Location = new Point(937, 115);
            textPresupuesto.Name = "textPresupuesto";
            textPresupuesto.Size = new Size(98, 23);
            textPresupuesto.TabIndex = 32;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(1067, 113);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(200, 23);
            dateTimePickerFin.TabIndex = 19;
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblPresupuesto.Location = new Point(764, 116);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(167, 18);
            lblPresupuesto.TabIndex = 31;
            lblPresupuesto.Text = "Presupuesto estimada";
            // 
            // lblAnoInicio
            // 
            lblAnoInicio.AutoSize = true;
            lblAnoInicio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblAnoInicio.Location = new Point(1084, 35);
            lblAnoInicio.Name = "lblAnoInicio";
            lblAnoInicio.Size = new Size(160, 18);
            lblAnoInicio.TabIndex = 18;
            lblAnoInicio.Text = "Fecha inicio prevista";
            // 
            // textCostoUnitario
            // 
            textCostoUnitario.Font = new Font("Century Gothic", 9.75F);
            textCostoUnitario.Location = new Point(937, 75);
            textCostoUnitario.Name = "textCostoUnitario";
            textCostoUnitario.Size = new Size(98, 23);
            textCostoUnitario.TabIndex = 30;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(1067, 56);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(200, 23);
            dateTimePickerInicio.TabIndex = 17;
            // 
            // lblCostoUnitario
            // 
            lblCostoUnitario.AutoSize = true;
            lblCostoUnitario.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblCostoUnitario.Location = new Point(782, 79);
            lblCostoUnitario.Name = "lblCostoUnitario";
            lblCostoUnitario.Size = new Size(109, 18);
            lblCostoUnitario.TabIndex = 29;
            lblCostoUnitario.Text = "Costo unitario";
            // 
            // textCantidadEstimada
            // 
            textCantidadEstimada.Font = new Font("Century Gothic", 9.75F);
            textCantidadEstimada.Location = new Point(937, 35);
            textCantidadEstimada.Name = "textCantidadEstimada";
            textCantidadEstimada.Size = new Size(98, 23);
            textCantidadEstimada.TabIndex = 28;
            // 
            // lblCantidadEstimada
            // 
            lblCantidadEstimada.AutoSize = true;
            lblCantidadEstimada.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblCantidadEstimada.Location = new Point(782, 39);
            lblCantidadEstimada.Name = "lblCantidadEstimada";
            lblCantidadEstimada.Size = new Size(149, 18);
            lblCantidadEstimada.TabIndex = 27;
            lblCantidadEstimada.Text = "Cantidad estimado";
            // 
            // textUbicacion
            // 
            textUbicacion.Font = new Font("Century Gothic", 9.75F);
            textUbicacion.Location = new Point(519, 128);
            textUbicacion.Name = "textUbicacion";
            textUbicacion.Size = new Size(200, 23);
            textUbicacion.TabIndex = 26;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblUbicacion.Location = new Point(430, 129);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(85, 18);
            lblUbicacion.TabIndex = 25;
            lblUbicacion.Text = "Ubicación";
            // 
            // btnBuscarContratista
            // 
            btnBuscarContratista.Location = new Point(725, 79);
            btnBuscarContratista.Name = "btnBuscarContratista";
            btnBuscarContratista.Size = new Size(34, 23);
            btnBuscarContratista.TabIndex = 24;
            btnBuscarContratista.Text = "B";
            btnBuscarContratista.UseVisualStyleBackColor = true;
            btnBuscarContratista.Click += btnBuscarContratista_Click;
            // 
            // btnBuscarPrograma
            // 
            btnBuscarPrograma.Location = new Point(725, 32);
            btnBuscarPrograma.Name = "btnBuscarPrograma";
            btnBuscarPrograma.Size = new Size(34, 23);
            btnBuscarPrograma.TabIndex = 23;
            btnBuscarPrograma.Text = "B";
            btnBuscarPrograma.UseVisualStyleBackColor = true;
            btnBuscarPrograma.Click += btnBuscarPrograma_Click;
            // 
            // textNombreContratista
            // 
            textNombreContratista.Font = new Font("Century Gothic", 9.75F);
            textNombreContratista.Location = new Point(519, 79);
            textNombreContratista.Name = "textNombreContratista";
            textNombreContratista.Size = new Size(200, 23);
            textNombreContratista.TabIndex = 22;
            // 
            // lblContratista
            // 
            lblContratista.AutoSize = true;
            lblContratista.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblContratista.Location = new Point(433, 79);
            lblContratista.Name = "lblContratista";
            lblContratista.Size = new Size(86, 18);
            lblContratista.TabIndex = 21;
            lblContratista.Text = "Contratista";
            // 
            // textIdContratista
            // 
            textIdContratista.Font = new Font("Century Gothic", 9.75F);
            textIdContratista.Location = new Point(404, 74);
            textIdContratista.Name = "textIdContratista";
            textIdContratista.Size = new Size(10, 23);
            textIdContratista.TabIndex = 20;
            // 
            // textNombrePrograma
            // 
            textNombrePrograma.Font = new Font("Century Gothic", 9.75F);
            textNombrePrograma.Location = new Point(519, 32);
            textNombrePrograma.Name = "textNombrePrograma";
            textNombrePrograma.Size = new Size(200, 23);
            textNombrePrograma.TabIndex = 19;
            // 
            // lblPrograma
            // 
            lblPrograma.AutoSize = true;
            lblPrograma.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblPrograma.Location = new Point(433, 36);
            lblPrograma.Name = "lblPrograma";
            lblPrograma.Size = new Size(80, 18);
            lblPrograma.TabIndex = 18;
            lblPrograma.Text = "Programa";
            // 
            // textIdPrograma
            // 
            textIdPrograma.Font = new Font("Century Gothic", 9.75F);
            textIdPrograma.Location = new Point(404, 32);
            textIdPrograma.Name = "textIdPrograma";
            textIdPrograma.Size = new Size(10, 23);
            textIdPrograma.TabIndex = 17;
            // 
            // textIdProyecto
            // 
            textIdProyecto.Font = new Font("Century Gothic", 9.75F);
            textIdProyecto.Location = new Point(6, 35);
            textIdProyecto.Name = "textIdProyecto";
            textIdProyecto.Size = new Size(10, 23);
            textIdProyecto.TabIndex = 8;
            // 
            // textDescripcion
            // 
            textDescripcion.Font = new Font("Century Gothic", 9.75F);
            textDescripcion.Location = new Point(120, 63);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(255, 88);
            textDescripcion.TabIndex = 6;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Century Gothic", 9.75F);
            textNombre.Location = new Point(120, 32);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(255, 23);
            textNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblNombre.Location = new Point(17, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 18);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblDescripcion.Location = new Point(17, 62);
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
            panelTabla.Location = new Point(12, 104);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(1285, 208);
            panelTabla.TabIndex = 12;
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
            checkEliminar.Location = new Point(1198, 182);
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
            datosListar.Size = new Size(1255, 167);
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
            groupBuscar.Location = new Point(12, 43);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(1285, 55);
            groupBuscar.TabIndex = 11;
            groupBuscar.TabStop = false;
            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Century Gothic", 8.25F);
            textBuscar.Location = new Point(436, 22);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(495, 21);
            textBuscar.TabIndex = 1;
            textBuscar.TextChanged += textBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblBuscar.Location = new Point(373, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(57, 18);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // panel_barra
            // 
            panel_barra.BackColor = Color.FromArgb(48, 157, 228);
            panel_barra.Controls.Add(lblTitulo);
            panel_barra.Location = new Point(0, -2);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(1310, 39);
            panel_barra.TabIndex = 10;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(157, 18);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingreso De Proyecto";
            // 
            // textUnidadDeMedida
            // 
            textUnidadDeMedida.Font = new Font("Century Gothic", 9.75F);
            textUnidadDeMedida.Location = new Point(175, 172);
            textUnidadDeMedida.Name = "textUnidadDeMedida";
            textUnidadDeMedida.Size = new Size(200, 23);
            textUnidadDeMedida.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label2.Location = new Point(17, 173);
            label2.Name = "label2";
            label2.Size = new Size(147, 18);
            label2.TabIndex = 38;
            label2.Text = "Unidad de medida";
            // 
            // Ingreso_Proyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 651);
            Controls.Add(groupBotones);
            Controls.Add(groupDatos);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Controls.Add(panel_barra);
            Name = "Ingreso_Proyecto";
            Text = "Ingreso_Proyecto";
            Load += Ingreso_Proyecto_Load;
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
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
            ResumeLayout(false);
        }

        #endregion

        private ToolTip ttMensaje;
        private ErrorProvider errorIcon;
        private GroupBox groupBotones;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private GroupBox groupDatos;
        private Button btnBuscarContratista;
        private Button btnBuscarPrograma;
        private TextBox textNombreContratista;
        private Label lblContratista;
        private TextBox textIdContratista;
        private TextBox textNombrePrograma;
        private Label lblPrograma;
        private TextBox textIdPrograma;
        private TextBox textIdProyecto;
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
        private Label lblTitulo;
        private TextBox textPresupuesto;
        private Label lblPresupuesto;
        private TextBox textCostoUnitario;
        private Label lblCostoUnitario;
        private TextBox textCantidadEstimada;
        private Label lblCantidadEstimada;
        private TextBox textUbicacion;
        private Label lblUbicacion;
        private Label lblAnoFin;
        private DateTimePicker dateTimePickerFin;
        private Label lblAnoInicio;
        private DateTimePicker dateTimePickerInicio;
        private TextBox textIdUser;
        private TextBox textCreadoPor;
        private Label lblCreadoPor;
        private TextBox textEstado;
        private Label label1;
        private TextBox textUnidadDeMedida;
        private Label label2;
    }
}