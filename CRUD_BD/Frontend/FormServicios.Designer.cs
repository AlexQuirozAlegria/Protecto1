using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD_BD
{
    partial class FormServicios
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            label6 = new Label();
            numCosto = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtClave = new TextBox();
            label1 = new Label();
            dgvServicios = new DataGridView();
            numTiempo = new NumericUpDown();
            ((ISupportInitialize)numCosto).BeginInit();
            ((ISupportInitialize)dgvServicios).BeginInit();
            ((ISupportInitialize)numTiempo).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(712, 263);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 37;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(712, 193);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(712, 228);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(712, 158);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 127);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 29;
            label6.Text = "Tiempo estimado:";
            label6.Click += label6_Click;
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 2;
            numCosto.Location = new Point(141, 85);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(197, 27);
            numCosto.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 83);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 27;
            label5.Text = "Costo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 17);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 23;
            label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(488, 17);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(329, 124);
            txtDescripcion.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 27);
            txtNombre.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 52);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 21;
            label2.Text = "Nombre:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(141, 20);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(197, 27);
            txtClave.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 19;
            label1.Text = "Clave de servicio:";
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(12, 158);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 51;
            dgvServicios.Size = new Size(679, 280);
            dgvServicios.TabIndex = 38;
            dgvServicios.CellClick += dgvServicios_CellClick;
            // 
            // numTiempo
            // 
            numTiempo.Location = new Point(141, 125);
            numTiempo.Name = "numTiempo";
            numTiempo.Size = new Size(197, 27);
            numTiempo.TabIndex = 30;
            // 
            // FormServicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 450);
            Controls.Add(dgvServicios);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(numTiempo);
            Controls.Add(numCosto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(label1);
            Name = "FormServicios";
            Text = "Servicios";
            Load += FormServicios_Load;
            ((ISupportInitialize)numCosto).EndInit();
            ((ISupportInitialize)dgvServicios).EndInit();
            ((ISupportInitialize)numTiempo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Label label6;
        private NumericUpDown numCosto;
        private Label label5;
        private Label label3;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtClave;
        private Label label1;
        private DataGridView dgvServicios;
        private NumericUpDown numTiempo;
    }
}