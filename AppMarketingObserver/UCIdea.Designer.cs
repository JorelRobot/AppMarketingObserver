namespace AppMarketingObserver
{
    partial class UCIdea
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIdeaTitulo = new System.Windows.Forms.Label();
            this.labelIdeaDescripcion = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIdeaEstatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIdeaTitulo
            // 
            this.labelIdeaTitulo.AutoSize = true;
            this.labelIdeaTitulo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdeaTitulo.Location = new System.Drawing.Point(24, 19);
            this.labelIdeaTitulo.Name = "labelIdeaTitulo";
            this.labelIdeaTitulo.Size = new System.Drawing.Size(147, 38);
            this.labelIdeaTitulo.TabIndex = 0;
            this.labelIdeaTitulo.Text = "Titulo Idea";
            // 
            // labelIdeaDescripcion
            // 
            this.labelIdeaDescripcion.AutoSize = true;
            this.labelIdeaDescripcion.Location = new System.Drawing.Point(3, 9);
            this.labelIdeaDescripcion.Name = "labelIdeaDescripcion";
            this.labelIdeaDescripcion.Size = new System.Drawing.Size(157, 20);
            this.labelIdeaDescripcion.TabIndex = 1;
            this.labelIdeaDescripcion.Text = "Descripcion de la idea";
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(327, 94);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(94, 29);
            this.btnAprobar.TabIndex = 2;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelIdeaDescripcion);
            this.panel1.Location = new System.Drawing.Point(24, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 63);
            this.panel1.TabIndex = 3;
            // 
            // labelIdeaEstatus
            // 
            this.labelIdeaEstatus.AutoSize = true;
            this.labelIdeaEstatus.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelIdeaEstatus.Location = new System.Drawing.Point(341, 19);
            this.labelIdeaEstatus.Name = "labelIdeaEstatus";
            this.labelIdeaEstatus.Size = new System.Drawing.Size(80, 20);
            this.labelIdeaEstatus.TabIndex = 2;
            this.labelIdeaEstatus.Text = "Pendiente";
            // 
            // UCIdea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelIdeaEstatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.labelIdeaTitulo);
            this.Name = "UCIdea";
            this.Size = new System.Drawing.Size(442, 139);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label labelIdeaTitulo;
        public Label labelIdeaDescripcion;
        private Button btnAprobar;
        private Panel panel1;
        public Label labelIdeaEstatus;
    }
}
