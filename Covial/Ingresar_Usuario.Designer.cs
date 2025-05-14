namespace Presentation
{
    partial class Ingresar_Usuario
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
            groupBuscar = new GroupBox();
            textBuscar = new TextBox();
            lblBuscar = new Label();
            panelTabla = new Panel();
            lblTotal = new Label();
            checkEliminar = new CheckBox();
            checkHabilitado = new CheckBox();
            datosListar = new DataGridView();
            groupDatos = new GroupBox();
            textIdUsuario = new TextBox();
            textContraseña = new TextBox();
            textUsuario = new TextBox();
            textNombre = new TextBox();
            comboRol = new ComboBox();
            lblNombre = new Label();
            lblRol = new Label();
            lblContrasena = new Label();
            lblUsuario = new Label();
            groupBotones = new GroupBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            ttMensaje = new ToolTip(components);
            errorIcon = new ErrorProvider(components);
            Eliminar = new DataGridViewCheckBoxColumn();
            panel_barra.SuspendLayout();
            groupBuscar.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosListar).BeginInit();
            groupDatos.SuspendLayout();
            groupBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // panel_barra
            // 
            panel_barra.BackColor = Color.FromArgb(48, 157, 228);
            panel_barra.Controls.Add(lblTitulo);
            panel_barra.Location = new Point(0, 1);
            panel_barra.Name = "panel_barra";
            panel_barra.Size = new Size(800, 39);
            panel_barra.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(151, 18);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingreso De Usuarios";
            // 
            // groupBuscar
            // 
            groupBuscar.Controls.Add(textBuscar);
            groupBuscar.Controls.Add(lblBuscar);
            groupBuscar.Location = new Point(12, 46);
            groupBuscar.Name = "groupBuscar";
            groupBuscar.Size = new Size(776, 55);
            groupBuscar.TabIndex = 1;
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
            panelTabla.Controls.Add(checkHabilitado);
            panelTabla.Controls.Add(datosListar);
            panelTabla.Location = new Point(12, 107);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(776, 208);
            panelTabla.TabIndex = 2;
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
            // checkHabilitado
            // 
            checkHabilitado.AutoSize = true;
            checkHabilitado.Location = new Point(598, 183);
            checkHabilitado.Name = "checkHabilitado";
            checkHabilitado.Size = new Size(81, 19);
            checkHabilitado.TabIndex = 1;
            checkHabilitado.Text = "Habilitado";
            checkHabilitado.UseVisualStyleBackColor = true;
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
            // groupDatos
            // 
            groupDatos.Controls.Add(textIdUsuario);
            groupDatos.Controls.Add(textContraseña);
            groupDatos.Controls.Add(textUsuario);
            groupDatos.Controls.Add(textNombre);
            groupDatos.Controls.Add(comboRol);
            groupDatos.Controls.Add(lblNombre);
            groupDatos.Controls.Add(lblRol);
            groupDatos.Controls.Add(lblContrasena);
            groupDatos.Controls.Add(lblUsuario);
            groupDatos.Location = new Point(12, 321);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(776, 110);
            groupDatos.TabIndex = 3;
            groupDatos.TabStop = false;
            // 
            // textIdUsuario
            // 
            textIdUsuario.Font = new Font("Century Gothic", 9.75F);
            textIdUsuario.Location = new Point(359, 22);
            textIdUsuario.Name = "textIdUsuario";
            textIdUsuario.Size = new Size(10, 23);
            textIdUsuario.TabIndex = 8;
            textIdUsuario.Visible = false;
            // 
            // textContraseña
            // 
            textContraseña.Font = new Font("Century Gothic", 9.75F);
            textContraseña.Location = new Point(491, 66);
            textContraseña.Name = "textContraseña";
            textContraseña.Size = new Size(215, 23);
            textContraseña.TabIndex = 7;
            // 
            // textUsuario
            // 
            textUsuario.Font = new Font("Century Gothic", 9.75F);
            textUsuario.Location = new Point(491, 27);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(215, 23);
            textUsuario.TabIndex = 6;
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Century Gothic", 9.75F);
            textNombre.Location = new Point(118, 22);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(211, 23);
            textNombre.TabIndex = 5;
            // 
            // comboRol
            // 
            comboRol.Font = new Font("Century Gothic", 9.75F);
            comboRol.FormattingEnabled = true;
            comboRol.Location = new Point(118, 61);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(211, 25);
            comboRol.TabIndex = 4;
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
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblRol.Location = new Point(44, 66);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 18);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblContrasena.Location = new Point(392, 71);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(93, 18);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            lblUsuario.Location = new Point(392, 27);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 18);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // groupBotones
            // 
            groupBotones.Controls.Add(btnEliminar);
            groupBotones.Controls.Add(btnCancelar);
            groupBotones.Controls.Add(btnEditar);
            groupBotones.Controls.Add(btnGuardar);
            groupBotones.Controls.Add(btnNuevo);
            groupBotones.Location = new Point(12, 437);
            groupBotones.Name = "groupBotones";
            groupBotones.Size = new Size(776, 100);
            groupBotones.TabIndex = 4;
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
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // Ingresar_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(groupBotones);
            Controls.Add(groupDatos);
            Controls.Add(panelTabla);
            Controls.Add(groupBuscar);
            Controls.Add(panel_barra);
            Name = "Ingresar_Usuario";
            Text = "Ingresar_Usuario";
            Load += Ingresar_Usuario_Load;
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

        private Panel panel_barra;
        private Label lblTitulo;
        private GroupBox groupBuscar;
        private Label lblBuscar;
        private TextBox textBuscar;
        private Panel panelTabla;
        private CheckBox checkEliminar;
        private CheckBox checkHabilitado;
        private DataGridView datosListar;
        private GroupBox groupDatos;
        private TextBox textContraseña;
        private TextBox textUsuario;
        private TextBox textNombre;
        private ComboBox comboRol;
        private Label lblNombre;
        private Label lblRol;
        private Label lblContrasena;
        private Label lblUsuario;
        private GroupBox groupBotones;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnNuevo;
        private ToolTip ttMensaje;
        private ErrorProvider errorIcon;
        private Label lblTotal;
        private TextBox textIdUsuario;
        private DataGridViewCheckBoxColumn Eliminar;
    }
}