using CRUD_BD.Backend;
using System;
using System.Windows.Forms;

namespace CRUD_BD
{
    public partial class Form1 : Form
    {
        RefaccionesDAO dao = new RefaccionesDAO();

        private string codigoSeleccionado = "";

        public Form1()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvRefacciones.DataSource = dao.ObtenerTodas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Refaccion r = LlenarObjeto();

            if (string.IsNullOrEmpty(r.Codigo))
            {
                MessageBox.Show("Debes escribir un código.");
                return;
            }

            if (dao.Agregar(r))
            {
                MessageBox.Show("Guardado con éxito.");
                CargarTabla();
                Limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigoSeleccionado))
            {
                MessageBox.Show("Selecciona una fila primero.");
                return;
            }

            Refaccion r = LlenarObjeto();

            r.Codigo = codigoSeleccionado;

            if (dao.Modificar(r))
            {
                MessageBox.Show("Modificado con éxito.");
                CargarTabla();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigoSeleccionado))
            {
                MessageBox.Show("Selecciona una fila primero.");
                return;
            }

            if (MessageBox.Show("¿Seguro de borrar esto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dao.Eliminar(codigoSeleccionado))
                {
                    MessageBox.Show("Eliminado.");
                    CargarTabla();
                    Limpiar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvRefacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRefacciones.Rows[e.RowIndex];

                codigoSeleccionado = fila.Cells["codigo_refaccion"].Value.ToString();

                txtCodigo.Text = fila.Cells["codigo_refaccion"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtMarca.Text = fila.Cells["marca"].Value.ToString();
                txtProveedor.Text = fila.Cells["proveedor"].Value.ToString();

                numPrecio.Value = Convert.ToDecimal(fila.Cells["precio_unitario"].Value);
                numStockActual.Value = Convert.ToDecimal(fila.Cells["stock_actual"].Value);
                numStockMinimo.Value = Convert.ToDecimal(fila.Cells["stock_minimo"].Value);

                txtCodigo.Enabled = false;
            }
        }

        private Refaccion LlenarObjeto()
        {
            Refaccion r = new Refaccion();
            r.Codigo = txtCodigo.Text;
            r.Nombre = txtNombre.Text;
            r.Marca = txtMarca.Text;
            r.Proveedor = txtProveedor.Text;
            r.PrecioUnitario = numPrecio.Value;
            r.StockActual = (int)numStockActual.Value;
            r.StockMinimo = (int)numStockMinimo.Value;
            return r;
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtMarca.Clear();
            txtProveedor.Clear();
            numPrecio.Value = 0;
            numStockActual.Value = 0;
            numStockMinimo.Value = 0;
            codigoSeleccionado = "";
            txtCodigo.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}