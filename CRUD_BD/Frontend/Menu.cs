using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_BD.Frontend
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            FormServicios ventana = new FormServicios();

            this.Hide();

            ventana.ShowDialog();

            this.Show();
        }

        private void btnRefacciones_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();

            this.Hide();

            ventana.ShowDialog();

            this.Show();
        }
    }
}
