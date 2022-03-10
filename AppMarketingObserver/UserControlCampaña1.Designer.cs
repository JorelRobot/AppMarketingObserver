namespace AppMarketingObserver
{
    partial class UserControlCampaña1
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelIdea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(214, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campaña Aceptada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(230, 99);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(47, 20);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Titulo";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // labelIdea
            // 
            this.labelIdea.AutoSize = true;
            this.labelIdea.Location = new System.Drawing.Point(232, 146);
            this.labelIdea.Name = "labelIdea";
            this.labelIdea.Size = new System.Drawing.Size(38, 20);
            this.labelIdea.TabIndex = 2;
            this.labelIdea.Text = "Idea";
            this.labelIdea.Click += new System.EventHandler(this.labelIdea_Click);
            // 
            // UserControlCampaña1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelIdea);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.label1);
            this.Name = "UserControlCampaña1";
            this.Size = new System.Drawing.Size(815, 242);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public Label labelTitulo;
        public Label labelIdea;
    }
}
