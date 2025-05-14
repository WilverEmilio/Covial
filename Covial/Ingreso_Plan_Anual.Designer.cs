namespace Presentation
{
    partial class Ingreso_Plan_Anual
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
            panel_barra = new Panel();
            lblTitulo = new Label();
            groupBotones = new GroupBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            groupDatos = new GroupBox();
            lblAno = new Label();
            dateTimePicker1 = new DateTimePicker();
            textIdUser = new TextBox();
            textIdUsuario = new TextBox();
            textCreadoPor = new TextBox();
            textDescripcion = new TextBox();
            textNombre = new TextBox();
            lblNombre = new Label();
            lblCreadoPor = new Label();
            lblDescripcion = new Label();
            panelTabla = new Panel();
            lblTotal = new Label();
            checkEliminar = new CheckBox();
            datosListar = new DataGridView();
            Eliminar = new DataGridViewCheckBoxColumn();
            groupBuscar = new GroupBox();
            textBuscar = new TextBox();
            lblBuscar = new Label();
            errorIcon = new ErrorProvider(components);
            ttMensaje = new ToolTip(components);
            panel_barra.SuspendLayout();
            groupBotones.SuspendLayout();
            groupDatos.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // panel_barra
            // 
            panel_barra.BackColor = Color.FromArgb(48, 157, 228);
            panel_barra.Controls.Add(lblTitulo);
            panel_barra.Location = new Point(0, -1);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(800, 39);
            panel_barra.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(173, 18);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingreso De Plan Anual ";
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnEliminar);
            groupBotones.Controls.Add(btnCancelar);
            groupBotones.Controls.Add(btnEditar);
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Controls.Add(btnNuevo);
            groupBotones.Location = new Point(12, 435);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(776, 100);
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
            groupDatos.Controls.Add(lblAno);
            groupDatos.Controls.Add(dateTimePicker1);
            groupDatos.Controls.Add(textIdUser);
            groupDatos.Controls.Add(textIdUsuario);
            groupDatos.Controls.Add(textCreadoPor);
            groupDatos.Controls.Add(textDescripcion);
            groupDatos.Controls.Add(textNombre);
            groupDatos.Controls.Add(lblNombre);
            groupDatos.Controls.Add(lblCreadoPor);
            groupDatos.Controls.Add(lblDescripcion);
            groupDatos.Location = new Point(12, 319);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(776, 110);
            groupDatos.TabIndex = 8;
            groupDatos.TabStop = false;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblAno.Location = new Point(392, 71);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(38, 18);
            lblAno.TabIndex = 12;
            lblAno.Text = "Año";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(495, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // textIdUser
            // 
            textIdUser.Font = new Font("Century Gothic", 9.75F);
            textIdUser.Location = new Point(375, 66);
            textIdUser.Name = "textIdUser";
            textIdUser.Size = new Size(10, 23);
            textIdUser.TabIndex = 10;
            textIdUser.Visible = false;
            // 
            // textIdUsuario
            // 
            textIdUsuario.Font = new Font("Century Gothic", 9.75F);
            textIdUsuario.Location = new Point(335, 22);
            textIdUsuario.Name = "textIdUsuario";
            textIdUsuario.Size = new Size(10, 23);
            textIdUsuario.TabIndex = 9;
            textIdUsuario.Visible = false;
            // 
            // textCreadoPor
            // 
            textCreadoPor.Font = new Font("Century Gothic", 9.75F);
            textCreadoPor.Location = new Point(154, 66);
            textCreadoPor.Name = "textCreadoPor";
            textCreadoPor.Size = new Size(215, 23);
            textCreadoPor.TabIndex = 7;
            // 
            // textDescripcion
            // 
            textDescripcion.Font = new Font("Century Gothic", 9.75F);
            textDescripcion.Location = new Point(495, 26);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(215, 23);
            textDescripcion.TabIndex = 6;
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
            // lblCreadoPor
            // 
            lblCreadoPor.AutoSize = true;
            lblCreadoPor.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblCreadoPor.Location = new Point(44, 67);
            lblCreadoPor.Name = "lblCreadoPor";
            lblCreadoPor.Size = new Size(94, 18);
            lblCreadoPor.TabIndex = 1;
            lblCreadoPor.Text = "Creado por";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblDescripcion.Location = new Point(392, 27);
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
            panelTabla.Size = new Size(776, 208);
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
            // groupBuscar
            // 
            groupBuscar.Controls.Add(textBuscar);
            groupBuscar.Controls.Add(lblBuscar);
            groupBuscar.Location = new Point(12, 44);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(776, 55);
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
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // Ingreso_Plan_Anual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(panel_barra);
            Controls.Add(groupBotones);
            Controls.Add(groupDatos);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Name = "Ingreso_Plan_Anual";
            Text = "Ingreso_Plan_Anual";
            Load += Ingreso_Plan_Anual_Load;
            panel_barra.ResumeLayout(false);
            panel_barra.PerformLayout();
            groupBotones.ResumeLayout(false);
            groupDatos.ResumeLayout(false);
            groupDatos.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).EndInit();
            groupBuscar.ResumeLayout(false);
            groupBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_barra;
        private Label lblTitulo;
        private GroupBox groupBotones;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private GroupBox groupDatos;
        private TextBox textCreadoPor;
        private TextBox textDescripcion;
        private TextBox textNombre;
        private ComboBox comboRol;
        private Label lblNombre;
        private Label lblRol;
        private Label lblCreadoPor;
        private Label lblDescripcion;
        private Panel panelTabla;
        private Label lblTotal;
        private CheckBox checkEliminar;
        private DataGridView datosListar;
        private DataGridViewCheckBoxColumn Eliminar;
        private GroupBox groupBuscar;
        private TextBox textBuscar;
        private Label lblBuscar;
        private ErrorProvider errorIcon;
        private ToolTip ttMensaje;
        private TextBox textIdUser;
        private TextBox textIdUsuario;
        private Label lblAno;
        private DateTimePicker dateTimePicker1;
    }
}