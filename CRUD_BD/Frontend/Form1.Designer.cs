namespace CRUD_BD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtMarca = new TextBox();
            label4 = new Label();
            txtProveedor = new TextBox();
            label5 = new Label();
            numPrecio = new NumericUpDown();
            label6 = new Label();
            numStockActual = new NumericUpDown();
            label7 = new Label();
            numStockMinimo = new NumericUpDown();
            btnGuardar = new Button();
            dgvRefacciones = new DataGridView();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRefacciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Código Refacción:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(163, 23);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(228, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 61);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 27);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 71);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(566, 68);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(210, 27);
            txtMarca.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 32);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 6;
            label4.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(566, 25);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(210, 27);
            txtProveedor.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 104);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 8;
            label5.Text = "Precio:";
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(163, 102);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(228, 27);
            numPrecio.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 144);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 10;
            label6.Text = "Existencia Actual:";
            // 
            // numStockActual
            // 
            numStockActual.Location = new Point(163, 140);
            numStockActual.Name = "numStockActual";
            numStockActual.Size = new Size(228, 27);
            numStockActual.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(457, 107);
            label7.Name = "label7";
            label7.Size = new Size(103, 20);
            label7.TabIndex = 12;
            label7.Text = "Stock Mínimo:";
            // 
            // numStockMinimo
            // 
            numStockMinimo.Location = new Point(566, 107);
            numStockMinimo.Name = "numStockMinimo";
            numStockMinimo.Size = new Size(210, 27);
            numStockMinimo.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(818, 138);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvRefacciones
            // 
            dgvRefacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRefacciones.Location = new Point(12, 190);
            dgvRefacciones.Name = "dgvRefacciones";
            dgvRefacciones.RowHeadersWidth = 51;
            dgvRefacciones.Size = new Size(950, 305);
            dgvRefacciones.TabIndex = 15;
            dgvRefacciones.CellClick += dgvRefacciones_CellClick;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(818, 23);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(818, 101);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(818, 61);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 507);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dgvRefacciones);
            Controls.Add(btnGuardar);
            Controls.Add(numStockMinimo);
            Controls.Add(label7);
            Controls.Add(numStockActual);
            Controls.Add(label6);
            Controls.Add(numPrecio);
            Controls.Add(label5);
            Controls.Add(txtProveedor);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRefacciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtMarca;
        private Label label4;
        private TextBox txtProveedor;
        private Label label5;
        private NumericUpDown numPrecio;
        private Label label6;
        private NumericUpDown numStockActual;
        private Label label7;
        private NumericUpDown numStockMinimo;
        private Button btnGuardar;
        private DataGridView dgvRefacciones;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}
