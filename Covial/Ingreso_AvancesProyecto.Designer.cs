namespace Presentation
{
    partial class Ingreso_AvancesProyecto
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
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            groupDatos = new GroupBox();
            textIdAvance = new TextBox();
            textCantidadReportada = new TextBox();
            lblCantidadReportada = new Label();
            BtnLimpiar = new Button();
            BtnCargarImagen = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            textReportadoPor = new TextBox();
            lblReportadoPor = new Label();
            textIdReportadoPor = new TextBox();
            lblFoto = new Label();
            btnBuscarTipoPrograma = new Button();
            textNombreProyecto = new TextBox();
            lblProyecto = new Label();
            textIdProyecto = new TextBox();
            lblFechaAvance = new Label();
            dateTimePickerInicio = new DateTimePicker();
            textDescripcion = new TextBox();
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
            openFileDialog1 = new OpenFileDialog();
            ttMensaje = new ToolTip(components);
            errorIcon = new ErrorProvider(components);
            groupBotones.SuspendLayout();
            groupDatos.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupBuscar.SuspendLayout();
            panel_barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnEliminar);
            groupBotones.Controls.Add(btnCancelar);
            groupBotones.Controls.Add(btnEditar);
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Controls.Add(btnNuevo);
            groupBotones.Location = new Point(12, 612);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(907, 100);
            groupBotones.TabIndex = 14;
            groupBotones.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnEliminar.Location = new Point(621, 40);
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
            btnCancelar.Location = new Point(516, 40);
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
            btnEditar.Location = new Point(414, 40);
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
            btnGuardar.Location = new Point(305, 40);
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
            btnNuevo.Location = new Point(201, 40);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 45);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupDatos
            // 
            groupDatos.Controls.Add(textIdAvance);
            groupDatos.Controls.Add(textCantidadReportada);
            groupDatos.Controls.Add(lblCantidadReportada);
            groupDatos.Controls.Add(BtnLimpiar);
            groupDatos.Controls.Add(BtnCargarImagen);
            groupDatos.Controls.Add(flowLayoutPanel1);
            groupDatos.Controls.Add(textReportadoPor);
            groupDatos.Controls.Add(lblReportadoPor);
            groupDatos.Controls.Add(textIdReportadoPor);
            groupDatos.Controls.Add(lblFoto);
            groupDatos.Controls.Add(btnBuscarTipoPrograma);
            groupDatos.Controls.Add(textNombreProyecto);
            groupDatos.Controls.Add(lblProyecto);
            groupDatos.Controls.Add(textIdProyecto);
            groupDatos.Controls.Add(lblFechaAvance);
            groupDatos.Controls.Add(dateTimePickerInicio);
            groupDatos.Controls.Add(textDescripcion);
            groupDatos.Controls.Add(lblDescripcion);
            groupDatos.Location = new Point(12, 320);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(907, 286);
            groupDatos.TabIndex = 13;
            groupDatos.TabStop = false;
            // 
            // textIdAvance
            // 
            textIdAvance.Font = new Font("Century Gothic", 9.75F);
            textIdAvance.Location = new Point(143, 34);
            textIdAvance.Name = "textIdAvance";
            textIdAvance.Size = new Size(10, 23);
            textIdAvance.TabIndex = 37;
            textIdAvance.Visible = false;
            // 
            // textCantidadReportada
            // 
            textCantidadReportada.Font = new Font("Century Gothic", 9.75F);
            textCantidadReportada.Location = new Point(187, 162);
            textCantidadReportada.Name = "textCantidadReportada";
            textCantidadReportada.Size = new Size(200, 23);
            textCantidadReportada.TabIndex = 36;
            // 
            // lblCantidadReportada
            // 
            lblCantidadReportada.AutoSize = true;
            lblCantidadReportada.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblCantidadReportada.Location = new Point(22, 162);
            lblCantidadReportada.Name = "lblCantidadReportada";
            lblCantidadReportada.Size = new Size(155, 18);
            lblCantidadReportada.TabIndex = 35;
            lblCantidadReportada.Text = "Cantidad reportada";
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(521, 162);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 34;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnCargarImagen
            // 
            BtnCargarImagen.Location = new Point(521, 126);
            BtnCargarImagen.Name = "BtnCargarImagen";
            BtnCargarImagen.Size = new Size(75, 23);
            BtnCargarImagen.TabIndex = 33;
            BtnCargarImagen.Text = "Cargar";
            BtnCargarImagen.UseVisualStyleBackColor = true;
            BtnCargarImagen.Click += BtnCargarImagen_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Location = new Point(18, 255);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(276, 100);
            flowLayoutPanel1.TabIndex = 32;
            flowLayoutPanel1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textReportadoPor
            // 
            textReportadoPor.Font = new Font("Century Gothic", 9.75F);
            textReportadoPor.Location = new Point(187, 82);
            textReportadoPor.Name = "textReportadoPor";
            textReportadoPor.Size = new Size(200, 23);
            textReportadoPor.TabIndex = 31;
            // 
            // lblReportadoPor
            // 
            lblReportadoPor.AutoSize = true;
            lblReportadoPor.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblReportadoPor.Location = new Point(34, 80);
            lblReportadoPor.Name = "lblReportadoPor";
            lblReportadoPor.Size = new Size(115, 18);
            lblReportadoPor.TabIndex = 30;
            lblReportadoPor.Text = "Reportado por";
            // 
            // textIdReportadoPor
            // 
            textIdReportadoPor.Font = new Font("Century Gothic", 9.75F);
            textIdReportadoPor.Location = new Point(18, 77);
            textIdReportadoPor.Name = "textIdReportadoPor";
            textIdReportadoPor.Size = new Size(10, 23);
            textIdReportadoPor.TabIndex = 29;
            textIdReportadoPor.Visible = false;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblFoto.Location = new Point(442, 126);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(39, 18);
            lblFoto.TabIndex = 25;
            lblFoto.Text = "Foto";
            // 
            // btnBuscarTipoPrograma
            // 
            btnBuscarTipoPrograma.Location = new Point(393, 121);
            btnBuscarTipoPrograma.Name = "btnBuscarTipoPrograma";
            btnBuscarTipoPrograma.Size = new Size(34, 21);
            btnBuscarTipoPrograma.TabIndex = 24;
            btnBuscarTipoPrograma.Text = "B";
            btnBuscarTipoPrograma.UseVisualStyleBackColor = true;
            btnBuscarTipoPrograma.Click += btnBuscarTipoPrograma_Click;
            // 
            // textNombreProyecto
            // 
            textNombreProyecto.Font = new Font("Century Gothic", 9.75F);
            textNombreProyecto.Location = new Point(187, 121);
            textNombreProyecto.Name = "textNombreProyecto";
            textNombreProyecto.Size = new Size(200, 23);
            textNombreProyecto.TabIndex = 22;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblProyecto.Location = new Point(34, 121);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(74, 18);
            lblProyecto.TabIndex = 21;
            lblProyecto.Text = "Proyecto";
            // 
            // textIdProyecto
            // 
            textIdProyecto.Font = new Font("Century Gothic", 9.75F);
            textIdProyecto.Location = new Point(18, 118);
            textIdProyecto.Name = "textIdProyecto";
            textIdProyecto.Size = new Size(10, 23);
            textIdProyecto.TabIndex = 20;
            textIdProyecto.Visible = false;
            // 
            // lblFechaAvance
            // 
            lblFechaAvance.AutoSize = true;
            lblFechaAvance.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblFechaAvance.Location = new Point(17, 32);
            lblFechaAvance.Name = "lblFechaAvance";
            lblFechaAvance.Size = new Size(115, 18);
            lblFechaAvance.TabIndex = 14;
            lblFechaAvance.Text = "Fecha avance";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(187, 32);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(200, 23);
            dateTimePickerInicio.TabIndex = 13;
            // 
            // textDescripcion
            // 
            textDescripcion.Font = new Font("Century Gothic", 9.75F);
            textDescripcion.Location = new Point(521, 27);
            textDescripcion.Multiline = true;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(367, 78);
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
            // panelTabla
            // 
            panelTabla.Controls.Add(lblTotal);
            panelTabla.Controls.Add(checkEliminar);
            panelTabla.Controls.Add(datosListar);
            panelTabla.Location = new Point(12, 106);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(907, 208);
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
            datosListar.Size = new Size(876, 167);
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
            groupBuscar.Location = new Point(12, 45);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(907, 55);
            groupBuscar.TabIndex = 11;
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
            panel_barra.Location = new Point(0, 0);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(932, 39);
            panel_barra.TabIndex = 10;
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // Ingreso_AvancesProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 724);
            Controls.Add(groupBotones);
            Controls.Add(groupDatos);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Controls.Add(panel_barra);
            Name = "Ingreso_AvancesProyecto";
            Text = "Ingreso Avances";
            Load += Ingreso_AvancesProyecto_Load;
            groupBotones.ResumeLayout(false);
            groupDatos.ResumeLayout(false);
            groupDatos.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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

        private GroupBox groupBotones;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private GroupBox groupDatos;
        private Button btnBuscarTipoPrograma;
        private TextBox textNombreProyecto;
        private Label lblProyecto;
        private TextBox textIdProyecto;
        private TextBox textNombrePlanAnual;
        private Label lblPlanAnual;
        private TextBox textIdPlanAnual;
        private Label lblAnoFin;
        private DateTimePicker dateTimePickerFin;
        private Label lblFechaAvance;
        private DateTimePicker dateTimePickerInicio;
        private TextBox textDescripcion;
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
        private Label lblFoto;
        private TextBox textReportadoPor;
        private Label lblReportadoPor;
        private TextBox textIdReportadoPor;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnCargarImagen;
        private Button BtnLimpiar;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private ToolTip ttMensaje;
        private ErrorProvider errorIcon;
        private TextBox textCantidadReportada;
        private Label lblCantidadReportada;
        private TextBox textIdAvance;
    }
}