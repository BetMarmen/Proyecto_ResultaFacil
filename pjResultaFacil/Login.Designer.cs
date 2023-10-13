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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnInicioSecion = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMini = new PictureBox();
            btnSalir = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            SuspendLayout();
            // 
            // btnInicioSecion
            // 
            btnInicioSecion.BackColor = Color.FromArgb(40, 40, 40);
            btnInicioSecion.FlatStyle = FlatStyle.Flat;
            btnInicioSecion.ForeColor = Color.Gainsboro;
            btnInicioSecion.Location = new Point(324, 257);
            btnInicioSecion.Margin = new Padding(3, 2, 3, 2);
            btnInicioSecion.Name = "btnInicioSecion";
            btnInicioSecion.Size = new Size(405, 40);
            btnInicioSecion.TabIndex = 0;
            btnInicioSecion.Text = "ACCEDER";
            btnInicioSecion.UseVisualStyleBackColor = false;
            btnInicioSecion.Click += btnInicioSecion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 192, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(15, 15, 15);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.DimGray;
            txtUser.Location = new Point(324, 92);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(384, 19);
            txtUser.TabIndex = 2;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(15, 15, 15);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.DimGray;
            txtPass.Location = new Point(324, 161);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(384, 19);
            txtPass.TabIndex = 3;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(476, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(323, 114);
            label2.Name = "label2";
            label2.Size = new Size(385, 15);
            label2.TabIndex = 5;
            label2.Text = "..............................................................................................................................";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(323, 183);
            label3.Name = "label3";
            label3.Size = new Size(385, 15);
            label3.TabIndex = 6;
            label3.Text = "..............................................................................................................................";
            // 
            // btnMini
            // 
            btnMini.Image = (Image)resources.GetObject("btnMini.Image");
            btnMini.Location = new Point(718, 0);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(27, 29);
            btnMini.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMini.TabIndex = 8;
            btnMini.TabStop = false;
            btnMini.Click += btnMini_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(751, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(26, 29);
            btnSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSalir.TabIndex = 9;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnSalir);
            Controls.Add(btnMini);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            Controls.Add(btnInicioSecion);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicioSecion;
        private Panel panel1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox btnMini;
        private PictureBox btnSalir;
    }
}