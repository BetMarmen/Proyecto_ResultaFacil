namespace pjResultaFacil
{
    partial class Login
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
            this.btnInicioSecion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicioSecion
            // 
            this.btnInicioSecion.Location = new System.Drawing.Point(279, 296);
            this.btnInicioSecion.Name = "btnInicioSecion";
            this.btnInicioSecion.Size = new System.Drawing.Size(122, 37);
            this.btnInicioSecion.TabIndex = 0;
            this.btnInicioSecion.Text = "Iniciar Seción";
            this.btnInicioSecion.UseVisualStyleBackColor = true;
            this.btnInicioSecion.Click += new System.EventHandler(this.btnInicioSecion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnInicioSecion);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnInicioSecion;
    }
}