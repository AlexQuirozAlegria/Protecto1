namespace CRUD_BD.Frontend
{
    partial class Menu
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
            btnServicios = new Button();
            btnRefacciones = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnServicios
            // 
            btnServicios.Location = new Point(153, 89);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(130, 43);
            btnServicios.TabIndex = 0;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnRefacciones
            // 
            btnRefacciones.Location = new Point(153, 138);
            btnRefacciones.Name = "btnRefacciones";
            btnRefacciones.Size = new Size(130, 43);
            btnRefacciones.TabIndex = 1;
            btnRefacciones.Text = "Refacciones";
            btnRefacciones.UseVisualStyleBackColor = true;
            btnRefacciones.Click += btnRefacciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 28);
            label1.Name = "label1";
            label1.Size = new Size(232, 41);
            label1.TabIndex = 2;
            label1.Text = "Menu principal";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 219);
            Controls.Add(label1);
            Controls.Add(btnRefacciones);
            Controls.Add(btnServicios);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnServicios;
        private Button btnRefacciones;
        private Label label1;
    }
}