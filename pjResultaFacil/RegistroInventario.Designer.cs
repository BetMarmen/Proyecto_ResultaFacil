namespace pjResultaFacil
{
    partial class RegistroInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuCantidad = new System.Windows.Forms.NumericUpDown();
            this.nuPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnregistar = new System.Windows.Forms.Button();
            this.dataInventario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cboFormato = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(129, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE INVENTARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRECIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRODUCTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CANTIDAD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuCantidad);
            this.groupBox1.Controls.Add(this.nuPrecio);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS ";
            // 
            // nuCantidad
            // 
            this.nuCantidad.Location = new System.Drawing.Point(334, 70);
            this.nuCantidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nuCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuCantidad.Name = "nuCantidad";
            this.nuCantidad.Size = new System.Drawing.Size(120, 27);
            this.nuCantidad.TabIndex = 6;
            this.nuCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuPrecio
            // 
            this.nuPrecio.DecimalPlaces = 2;
            this.nuPrecio.Location = new System.Drawing.Point(177, 70);
            this.nuPrecio.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nuPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPrecio.Name = "nuPrecio";
            this.nuPrecio.Size = new System.Drawing.Size(120, 27);
            this.nuPrecio.TabIndex = 5;
            this.nuPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(29, 70);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 27);
            this.txtProducto.TabIndex = 4;
            // 
            // btnregistar
            // 
            this.btnregistar.Location = new System.Drawing.Point(48, 370);
            this.btnregistar.Name = "btnregistar";
            this.btnregistar.Size = new System.Drawing.Size(89, 34);
            this.btnregistar.TabIndex = 5;
            this.btnregistar.Text = "Registrar";
            this.btnregistar.UseVisualStyleBackColor = true;
            this.btnregistar.Click += new System.EventHandler(this.btnregistar_Click);
            // 
            // dataInventario
            // 
            this.dataInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataInventario.Location = new System.Drawing.Point(48, 204);
            this.dataInventario.Name = "dataInventario";
            this.dataInventario.RowTemplate.Height = 29;
            this.dataInventario.Size = new System.Drawing.Size(473, 150);
            this.dataInventario.TabIndex = 6;
            this.dataInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Existencia";
            this.Column4.Name = "Column4";
            // 
            // cboFormato
            // 
            this.cboFormato.FormattingEnabled = true;
            this.cboFormato.Items.AddRange(new object[] {
            "PDF",
            "WORD",
            "EXCEL",
            "TXT"});
            this.cboFormato.Location = new System.Drawing.Point(433, 376);
            this.cboFormato.Name = "cboFormato";
            this.cboFormato.Size = new System.Drawing.Size(121, 28);
            this.cboFormato.TabIndex = 7;
            this.cboFormato.SelectedIndexChanged += new System.EventHandler(this.cboFormato_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "¿En qué formato desea exportarlo?";
            // 
            // RegistroInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboFormato);
            this.Controls.Add(this.dataInventario);
            this.Controls.Add(this.btnregistar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegistroInventario";
            this.Text = "RegistroInventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtProducto;
        private Button btnregistar;
        private DataGridView dataInventario;
        private NumericUpDown nuCantidad;
        private NumericUpDown nuPrecio;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
        private ComboBox cboFormato;
        private Label label5;
    }
}