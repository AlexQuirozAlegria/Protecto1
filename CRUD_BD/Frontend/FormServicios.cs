using CRUD_BD.Backend;
using System;
using System.Windows.Forms;

namespace CRUD_BD
{
    public partial class FormServicios : Form
    {
        ServiciosDAO dao = new ServiciosDAO();

        private int idSeleccionado = 0;

        public FormServicios()
        {
            InitializeComponent();
            numCosto.Maximum = 1000000;
            numCosto.Minimum = 0;
            numTiempo.Maximum = 1000;
            CargarTabla();
            txtClave.Enabled = false;
        }

        private void CargarTabla()
        {
            dgvServicios.DataSource = dao.ObtenerTodos();
        }

        private void Limpiar()
        {
            txtClave.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            numCosto.Value = 0;
            numTiempo.Value = 0;
            idSeleccionado = 0;
        }

        private Servicio LlenarObjeto()
        {
            Servicio s = new Servicio();
            s.Nombre = txtNombre.Text;
            s.Descripcion = txtDescripcion.Text;
            s.Costo = numCosto.Value;
            s.TiempoHoras = (int)numTiempo.Value;
            return s;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del servicio es obligatorio.");
                return;
            }

            Servicio nuevo = LlenarObjeto();

            if (dao.Agregar(nuevo))
            {
                MessageBox.Show("Servicio guardado correctamente.");
                CargarTabla();
                Limpiar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Por favor selecciona un servicio de la tabla.");
                return;
            }

            Servicio servicioEditado = LlenarObjeto();
            servicioEditado.Id = idSeleccionado;

            if (dao.Modificar(servicioEditado))
            {
                MessageBox.Show("Servicio actualizado correctamente.");
                CargarTabla();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Seguro de eliminar este servicio?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dao.Eliminar(idSeleccionado))
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

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvServicios.Rows[e.RowIndex].IsNewRow) return;

            try
            {
                DataGridViewRow fila = dgvServicios.Rows[e.RowIndex];

                if (fila.Cells["clave_servicio"].Value != null)
                {
                    idSeleccionado = Convert.ToInt32(fila.Cells["clave_servicio"].Value);

                    txtClave.Text = fila.Cells["clave_servicio"].Value.ToString();
                    txtNombre.Text = fila.Cells["nombre_servicio"].Value.ToString();

                    if (fila.Cells["descripcion"].Value != DBNull.Value)
                        txtDescripcion.Text = fila.Cells["descripcion"].Value.ToString();
                    else
                        txtDescripcion.Clear();

                    if (fila.Cells["costo_base"].Value != DBNull.Value)
                        numCosto.Value = Convert.ToDecimal(fila.Cells["costo_base"].Value);
                    else
                        numCosto.Value = 0;

                    if (fila.Cells["tiempo_estimado"].Value != DBNull.Value)
                        numTiempo.Value = Convert.ToDecimal(fila.Cells["tiempo_estimado"].Value);
                    else
                        numTiempo.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar: " + ex.Message);
            }
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}