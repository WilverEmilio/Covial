namespace Presentation
{
    partial class Ingresar_OrdenPago
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
            groupBotones = new GroupBox();
            btnGenerarConstancia = new Button();
            btnCancelar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            groupDatos = new GroupBox();
            textPresupuestoEstimado = new TextBox();
            lblPresupuestoEstimado = new Label();
            textCantidadEstimada = new TextBox();
            lblCantidadEstimada = new Label();
            textPrecioUnitario = new TextBox();
            lblPrecioUnitario = new Label();
            textUbicacionProyecto = new TextBox();
            lblUbicacion = new Label();
            textDescripcionProyecto = new TextBox();
            textNombreProyecto = new TextBox();
            lblDescripcionProyecto = new Label();
            btnBuscarTipoPrograma = new Button();
            textIdProyecto = new TextBox();
            lblProyecto = new Label();
            panelTabla = new Panel();
            lblTotal = new Label();
            datosListar = new DataGridView();
            Eliminar = new DataGridViewCheckBoxColumn();
            groupBuscar = new GroupBox();
            textBuscar = new TextBox();
            lblBuscar = new Label();
            panel_barra = new Panel();
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            btnBuscarContratista = new Button();
            textNombreContratista = new TextBox();
            lblContratista = new Label();
            textIdContratista = new TextBox();
            textRetencion = new TextBox();
            lblRetencion = new Label();
            textImpuesto = new TextBox();
            lblImpuesto = new Label();
            btnCalcular = new Button();
            textEstado = new TextBox();
            lblEstado = new Label();
            textMonto = new TextBox();
            lblMonto = new Label();
            textIdOrdenPago = new TextBox();
            textCreadoPor = new TextBox();
            lblCreadoPor = new Label();
            textIdCreadoPor = new TextBox();
            lblFechadeEmision = new Label();
            dateTimePicker1 = new DateTimePicker();
            textDescripcion = new TextBox();
            lblDescripcion = new Label();
            groupBox2 = new GroupBox();
            textCantidadR = new TextBox();
            label1 = new Label();
            textDescripcionAvance = new TextBox();
            lblDescripconAvance = new Label();
            btnAvance = new Button();
            textIdAvance = new TextBox();
            errorIcon = new ErrorProvider(components);
            ttMensaje = new ToolTip(components);
            groupBotones.SuspendLayout();
            groupDatos.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupBuscar.SuspendLayout();
            panel_barra.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnGenerarConstancia);
            groupBotones.Controls.Add(btnCancelar);
            groupBotones.Controls.Add(btnNuevo);
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Location = new Point(1004, 333);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(129, 243);
            groupBotones.TabIndex = 19;
            groupBotones.TabStop = false;
            groupBotones.Text = "z";
            // 
            // btnGenerarConstancia
            // 
            btnGenerarConstancia.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnGenerarConstancia.Location = new Point(12, 183);
            btnGenerarConstancia.Name = "btnGenerarConstancia";
            btnGenerarConstancia.Size = new Size(97, 45);
            btnGenerarConstancia.TabIndex = 5;
            btnGenerarConstancia.Text = "Constancia";
            btnGenerarConstancia.UseVisualStyleBackColor = true;
            btnGenerarConstancia.Click += btnGenerarConstancia_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnCancelar.Location = new Point(12, 131);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnNuevo.Location = new Point(12, 29);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 45);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(12, 80);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 45);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupDatos
            // 
            groupDatos.Controls.Add(textPresupuestoEstimado);
            groupDatos.Controls.Add(lblPresupuestoEstimado);
            groupDatos.Controls.Add(textCantidadEstimada);
            groupDatos.Controls.Add(lblCantidadEstimada);
            groupDatos.Controls.Add(textPrecioUnitario);
            groupDatos.Controls.Add(lblPrecioUnitario);
            groupDatos.Controls.Add(textUbicacionProyecto);
            groupDatos.Controls.Add(lblUbicacion);
            groupDatos.Controls.Add(textDescripcionProyecto);
            groupDatos.Controls.Add(textNombreProyecto);
            groupDatos.Controls.Add(lblDescripcionProyecto);
            groupDatos.Controls.Add(btnBuscarTipoPrograma);
            groupDatos.Controls.Add(textIdProyecto);
            groupDatos.Controls.Add(lblProyecto);
            groupDatos.Location = new Point(12, 510);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(986, 164);
            groupDatos.TabIndex = 18;
            groupDatos.TabStop = false;
            groupDatos.Text = "Proyecto";
            // 
            // textPresupuestoEstimado
            // 
            textPresupuestoEstimado.Font = new Font("Century Gothic", 9.75F);
            textPresupuestoEstimado.Location = new Point(790, 90);
            textPresupuestoEstimado.Name = "textPresupuestoEstimado";
            textPresupuestoEstimado.Size = new Size(155, 23);
            textPresupuestoEstimado.TabIndex = 51;
            // 
            // lblPresupuestoEstimado
            // 
            lblPresupuestoEstimado.AutoSize = true;
            lblPresupuestoEstimado.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblPresupuestoEstimado.Location = new Point(790, 64);
            lblPresupuestoEstimado.Name = "lblPresupuestoEstimado";
            lblPresupuestoEstimado.Size = new Size(167, 18);
            lblPresupuestoEstimado.TabIndex = 50;
            lblPresupuestoEstimado.Text = "Presupuesto estimado";
            // 
            // textCantidadEstimada
            // 
            textCantidadEstimada.Font = new Font("Century Gothic", 9.75F);
            textCantidadEstimada.Location = new Point(587, 126);
            textCantidadEstimada.Name = "textCantidadEstimada";
            textCantidadEstimada.Size = new Size(155, 23);
            textCantidadEstimada.TabIndex = 49;
            // 
            // lblCantidadEstimada
            // 
            lblCantidadEstimada.AutoSize = true;
            lblCantidadEstimada.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblCantidadEstimada.Location = new Point(426, 131);
            lblCantidadEstimada.Name = "lblCantidadEstimada";
            lblCantidadEstimada.Size = new Size(149, 18);
            lblCantidadEstimada.TabIndex = 48;
            lblCantidadEstimada.Text = "Cantidad estimada";
            // 
            // textPrecioUnitario
            // 
            textPrecioUnitario.Font = new Font("Century Gothic", 9.75F);
            textPrecioUnitario.Location = new Point(587, 95);
            textPrecioUnitario.Name = "textPrecioUnitario";
            textPrecioUnitario.Size = new Size(155, 23);
            textPrecioUnitario.TabIndex = 47;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblPrecioUnitario.Location = new Point(426, 100);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(114, 18);
            lblPrecioUnitario.TabIndex = 46;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // textUbicacionProyecto
            // 
            textUbicacionProyecto.Font = new Font("Century Gothic", 9.75F);
            textUbicacionProyecto.Location = new Point(587, 64);
            textUbicacionProyecto.Name = "textUbicacionProyecto";
            textUbicacionProyecto.Size = new Size(155, 23);
            textUbicacionProyecto.TabIndex = 45;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblUbicacion.Location = new Point(426, 64);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(85, 18);
            lblUbicacion.TabIndex = 44;
            lblUbicacion.Text = "Ubicación";
            // 
            // textDescripcionProyecto
            // 
            textDescripcionProyecto.Font = new Font("Century Gothic", 9.75F);
            textDescripcionProyecto.Location = new Point(160, 90);
            textDescripcionProyecto.Multiline = true;
            textDescripcionProyecto.Name = "textDescripcionProyecto";
            textDescripcionProyecto.Size = new Size(235, 46);
            textDescripcionProyecto.TabIndex = 43;
            // 
            // textNombreProyecto
            // 
            textNombreProyecto.Font = new Font("Century Gothic", 9.75F);
            textNombreProyecto.Location = new Point(162, 59);
            textNombreProyecto.Name = "textNombreProyecto";
            textNombreProyecto.Size = new Size(233, 23);
            textNombreProyecto.TabIndex = 22;
            // 
            // lblDescripcionProyecto
            // 
            lblDescripcionProyecto.AutoSize = true;
            lblDescripcionProyecto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblDescripcionProyecto.Location = new Point(37, 100);
            lblDescripcionProyecto.Name = "lblDescripcionProyecto";
            lblDescripcionProyecto.Size = new Size(97, 18);
            lblDescripcionProyecto.TabIndex = 42;
            lblDescripcionProyecto.Text = "Descripción";
            // 
            // btnBuscarTipoPrograma
            // 
            btnBuscarTipoPrograma.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnBuscarTipoPrograma.Location = new Point(454, 22);
            btnBuscarTipoPrograma.Name = "btnBuscarTipoPrograma";
            btnBuscarTipoPrograma.Size = new Size(193, 32);
            btnBuscarTipoPrograma.TabIndex = 24;
            btnBuscarTipoPrograma.Text = "Buscar proyecto";
            btnBuscarTipoPrograma.UseVisualStyleBackColor = true;
            btnBuscarTipoPrograma.Click += btnBuscarTipoPrograma_Click;
            // 
            // textIdProyecto
            // 
            textIdProyecto.Font = new Font("Century Gothic", 9.75F);
            textIdProyecto.Location = new Point(426, 28);
            textIdProyecto.Name = "textIdProyecto";
            textIdProyecto.Size = new Size(10, 23);
            textIdProyecto.TabIndex = 20;
            textIdProyecto.Visible = false;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblProyecto.Location = new Point(37, 60);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(74, 18);
            lblProyecto.TabIndex = 21;
            lblProyecto.Text = "Proyecto";
            // 
            // panelTabla
            // 
            panelTabla.Controls.Add(lblTotal);
            panelTabla.Controls.Add(datosListar);
            panelTabla.Location = new Point(12, 111);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(1121, 208);
            panelTabla.TabIndex = 17;
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
            datosListar.Size = new Size(1089, 167);
            datosListar.TabIndex = 0;
            datosListar.CellContentClick += datosListar_CellContentClick;
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
            groupBuscar.Location = new Point(86, 50);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(986, 55);
            groupBuscar.TabIndex = 16;
            groupBuscar.TabStop = false;
            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Century Gothic", 8.25F);
            textBuscar.Location = new Point(342, 22);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(400, 21);
            textBuscar.TabIndex = 1;
            textBuscar.TextChanged += textBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblBuscar.Location = new Point(279, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(57, 18);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar";
            // 
            // panel_barra
            // 
            panel_barra.BackColor = Color.FromArgb(48, 157, 228);
            panel_barra.Controls.Add(lblTitulo);
            panel_barra.Location = new Point(0, -3);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(1151, 39);
            panel_barra.TabIndex = 15;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(153, 18);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingreso de avances";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarContratista);
            groupBox1.Controls.Add(textNombreContratista);
            groupBox1.Controls.Add(lblContratista);
            groupBox1.Controls.Add(textIdContratista);
            groupBox1.Controls.Add(textRetencion);
            groupBox1.Controls.Add(lblRetencion);
            groupBox1.Controls.Add(textImpuesto);
            groupBox1.Controls.Add(lblImpuesto);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(textEstado);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(textMonto);
            groupBox1.Controls.Add(lblMonto);
            groupBox1.Controls.Add(textIdOrdenPago);
            groupBox1.Controls.Add(textCreadoPor);
            groupBox1.Controls.Add(lblCreadoPor);
            groupBox1.Controls.Add(textIdCreadoPor);
            groupBox1.Controls.Add(lblFechadeEmision);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textDescripcion);
            groupBox1.Controls.Add(lblDescripcion);
            groupBox1.Location = new Point(12, 325);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(986, 160);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // btnBuscarContratista
            // 
            btnBuscarContratista.Location = new Point(879, 129);
            btnBuscarContratista.Name = "btnBuscarContratista";
            btnBuscarContratista.Size = new Size(34, 23);
            btnBuscarContratista.TabIndex = 49;
            btnBuscarContratista.Text = "B";
            btnBuscarContratista.UseVisualStyleBackColor = true;
            btnBuscarContratista.Click += btnBuscarContratista_Click;
            // 
            // textNombreContratista
            // 
            textNombreContratista.Font = new Font("Century Gothic", 9.75F);
            textNombreContratista.Location = new Point(673, 129);
            textNombreContratista.Name = "textNombreContratista";
            textNombreContratista.Size = new Size(200, 23);
            textNombreContratista.TabIndex = 48;
            // 
            // lblContratista
            // 
            lblContratista.AutoSize = true;
            lblContratista.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblContratista.Location = new Point(587, 129);
            lblContratista.Name = "lblContratista";
            lblContratista.Size = new Size(86, 18);
            lblContratista.TabIndex = 47;
            lblContratista.Text = "Contratista";
            // 
            // textIdContratista
            // 
            textIdContratista.Font = new Font("Century Gothic", 9.75F);
            textIdContratista.Location = new Point(558, 124);
            textIdContratista.Name = "textIdContratista";
            textIdContratista.Size = new Size(10, 23);
            textIdContratista.TabIndex = 46;
            textIdContratista.Visible = false;
            // 
            // textRetencion
            // 
            textRetencion.Font = new Font("Century Gothic", 9.75F);
            textRetencion.Location = new Point(403, 128);
            textRetencion.Name = "textRetencion";
            textRetencion.Size = new Size(129, 23);
            textRetencion.TabIndex = 45;
            // 
            // lblRetencion
            // 
            lblRetencion.AutoSize = true;
            lblRetencion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblRetencion.Location = new Point(297, 129);
            lblRetencion.Name = "lblRetencion";
            lblRetencion.Size = new Size(83, 18);
            lblRetencion.TabIndex = 44;
            lblRetencion.Text = "Retención";
            // 
            // textImpuesto
            // 
            textImpuesto.Font = new Font("Century Gothic", 9.75F);
            textImpuesto.Location = new Point(123, 124);
            textImpuesto.Name = "textImpuesto";
            textImpuesto.Size = new Size(129, 23);
            textImpuesto.TabIndex = 43;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblImpuesto.Location = new Point(17, 125);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(75, 18);
            lblImpuesto.TabIndex = 42;
            lblImpuesto.Text = "Impuesto";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnCalcular.Location = new Point(802, 76);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 35);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // textEstado
            // 
            textEstado.Font = new Font("Century Gothic", 9.75F);
            textEstado.Location = new Point(866, 26);
            textEstado.Name = "textEstado";
            textEstado.Size = new Size(110, 23);
            textEstado.TabIndex = 41;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblEstado.Location = new Point(802, 31);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(56, 18);
            lblEstado.TabIndex = 40;
            lblEstado.Text = "Estado";
            // 
            // textMonto
            // 
            textMonto.Font = new Font("Century Gothic", 9.75F);
            textMonto.Location = new Point(542, 82);
            textMonto.Name = "textMonto";
            textMonto.Size = new Size(234, 23);
            textMonto.TabIndex = 39;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblMonto.Location = new Point(418, 82);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(55, 18);
            lblMonto.TabIndex = 38;
            lblMonto.Text = "Monto";
            // 
            // textIdOrdenPago
            // 
            textIdOrdenPago.Font = new Font("Century Gothic", 9.75F);
            textIdOrdenPago.Location = new Point(162, 31);
            textIdOrdenPago.Name = "textIdOrdenPago";
            textIdOrdenPago.Size = new Size(10, 23);
            textIdOrdenPago.TabIndex = 37;
            textIdOrdenPago.Visible = false;
            // 
            // textCreadoPor
            // 
            textCreadoPor.Font = new Font("Century Gothic", 9.75F);
            textCreadoPor.Location = new Point(187, 78);
            textCreadoPor.Name = "textCreadoPor";
            textCreadoPor.Size = new Size(200, 23);
            textCreadoPor.TabIndex = 31;
            // 
            // lblCreadoPor
            // 
            lblCreadoPor.AutoSize = true;
            lblCreadoPor.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblCreadoPor.Location = new Point(17, 78);
            lblCreadoPor.Name = "lblCreadoPor";
            lblCreadoPor.Size = new Size(94, 18);
            lblCreadoPor.TabIndex = 30;
            lblCreadoPor.Text = "Creado por";
            // 
            // textIdCreadoPor
            // 
            textIdCreadoPor.Font = new Font("Century Gothic", 9.75F);
            textIdCreadoPor.Location = new Point(162, 78);
            textIdCreadoPor.Name = "textIdCreadoPor";
            textIdCreadoPor.Size = new Size(10, 23);
            textIdCreadoPor.TabIndex = 29;
            textIdCreadoPor.Visible = false;
            // 
            // lblFechadeEmision
            // 
            lblFechadeEmision.AutoSize = true;
            lblFechadeEmision.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblFechadeEmision.Location = new Point(17, 32);
            lblFechadeEmision.Name = "lblFechadeEmision";
            lblFechadeEmision.Size = new Size(139, 18);
            lblFechadeEmision.TabIndex = 14;
            lblFechadeEmision.Text = "Fecha de emisión";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(187, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // textDescripcion
            // 
            textDescripcion.Font = new Font("Century Gothic", 9.75F);
            textDescripcion.Location = new Point(541, 22);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(235, 46);
            textDescripcion.TabIndex = 6;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(textCantidadR);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textDescripcionAvance);
            groupBox2.Controls.Add(lblDescripconAvance);
            groupBox2.Controls.Add(btnAvance);
            groupBox2.Controls.Add(textIdAvance);
            groupBox2.Location = new Point(12, 680);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(986, 136);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Avance";
            // 
            // textCantidadR
            // 
            textCantidadR.Font = new Font("Century Gothic", 9.75F);
            textCantidadR.Location = new Point(227, 63);
            textCantidadR.Multiline = true;
            textCantidadR.Name = "textCantidadR";
            textCantidadR.Size = new Size(168, 32);
            textCantidadR.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label1.Location = new Point(59, 64);
            label1.Name = "label1";
            label1.Size = new Size(155, 18);
            label1.TabIndex = 54;
            label1.Text = "Cantidad reportada";
            // 
            // textDescripcionAvance
            // 
            textDescripcionAvance.Font = new Font("Century Gothic", 9.75F);
            textDescripcionAvance.Location = new Point(673, 63);
            textDescripcionAvance.Multiline = true;
            textDescripcionAvance.Name = "textDescripcionAvance";
            textDescripcionAvance.Size = new Size(284, 32);
            textDescripcionAvance.TabIndex = 53;
            // 
            // lblDescripconAvance
            // 
            lblDescripconAvance.AutoSize = true;
            lblDescripconAvance.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblDescripconAvance.Location = new Point(559, 64);
            lblDescripconAvance.Name = "lblDescripconAvance";
            lblDescripconAvance.Size = new Size(97, 18);
            lblDescripconAvance.TabIndex = 52;
            lblDescripconAvance.Text = "Descripción";
            // 
            // btnAvance
            // 
            btnAvance.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            btnAvance.Location = new Point(454, 22);
            btnAvance.Name = "btnAvance";
            btnAvance.Size = new Size(193, 32);
            btnAvance.TabIndex = 24;
            btnAvance.Text = "Buscar avance";
            btnAvance.UseVisualStyleBackColor = true;
            btnAvance.Click += btnAvance_Click;
            // 
            // textIdAvance
            // 
            textIdAvance.Font = new Font("Century Gothic", 9.75F);
            textIdAvance.Location = new Point(426, 28);
            textIdAvance.Name = "textIdAvance";
            textIdAvance.Size = new Size(10, 23);
            textIdAvance.TabIndex = 20;
            textIdAvance.Visible = false;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // Ingresar_OrdenPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 850);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBotones);
            Controls.Add(groupDatos);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Controls.Add(panel_barra);
            Name = "Ingresar_OrdenPago";
            Text = "Ingresar_OrdenPago";
            Load += Ingresar_OrdenPago_Load;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBotones;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private GroupBox groupDatos;
        private TextBox textCantidadReportada;
        private Label lblCantidadReportada;
        private Button btnBuscarTipoPrograma;
        private TextBox textNombreProyecto;
        private Label lblProyecto;
        private TextBox textIdProyecto;
        private Panel panelTabla;
        private Label lblTotal;
        private DataGridView datosListar;
        private DataGridViewCheckBoxColumn Eliminar;
        private GroupBox groupBuscar;
        private TextBox textBuscar;
        private Label lblBuscar;
        private Panel panel_barra;
        private Label lblTitulo;
        private TextBox textUbicacionProyecto;
        private Label lblUbicacion;
        private TextBox textDescripcionProyecto;
        private Label lblDescripcionProyecto;
        private GroupBox groupBox1;
        private TextBox textEstado;
        private Label lblEstado;
        private TextBox textMonto;
        private Label lblMonto;
        private TextBox textIdOrdenPago;
        private TextBox textCreadoPor;
        private Label lblCreadoPor;
        private TextBox textIdCreadoPor;
        private Label lblFechadeEmision;
        private DateTimePicker dateTimePicker1;
        private TextBox textDescripcion;
        private Label lblDescripcion;
        private TextBox textPrecioUnitario;
        private Label lblPrecioUnitario;
        private TextBox textPresupuestoEstimado;
        private Label lblPresupuestoEstimado;
        private TextBox textCantidadEstimada;
        private Label lblCantidadEstimada;
        private GroupBox groupBox2;
        private Button btnAvance;
        private TextBox textIdAvance;
        private TextBox textDescripcionAvance;
        private Label lblDescripconAvance;
        private Button btnCalcular;
        private TextBox textCantidadR;
        private Label label1;
        private TextBox textRetencion;
        private Label lblRetencion;
        private TextBox textImpuesto;
        private Label lblImpuesto;
        private Button btnGenerarConstancia;
        private ErrorProvider errorIcon;
        private ToolTip ttMensaje;
        private Button btnBuscarContratista;
        private TextBox textNombreContratista;
        private Label lblContratista;
        private TextBox textIdContratista;
    }
}