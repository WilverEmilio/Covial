namespace Presentation.Reportes
{
    partial class ReporteProyectos
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
            btnGenerarPDF = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Location = new Point(254, 51);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(94, 31);
            btnGenerarPDF.TabIndex = 0;
            btnGenerarPDF.Text = "Generar";
            btnGenerarPDF.UseVisualStyleBackColor = true;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label1.Location = new Point(63, 111);
            label1.Name = "label1";
            label1.Size = new Size(168, 18);
            label1.TabIndex = 8;
            label1.Text = "Reporte de proyectos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label2.Location = new Point(57, 64);
            label2.Name = "label2";
            label2.Size = new Size(174, 18);
            label2.TabIndex = 10;
            label2.Text = "Reporte de programas";
            // 
            // button1
            // 
            button1.Location = new Point(254, 98);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 9;
            button1.Text = "Generar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReporteProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 279);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnGenerarPDF);
            Name = "ReporteProyectos";
            Text = "ReporteProyectos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarPDF;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}