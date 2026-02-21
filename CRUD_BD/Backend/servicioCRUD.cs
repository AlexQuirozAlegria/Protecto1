using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CRUD_BD.Backend
{

    /// <summary>
    /// LOS DATOS DE LOS SERVICIOS SE MANEJAN A TRAVÉS DE ESTA CLASE
    /// CREA UNA CONEXION A LA BASE DE DATOS Y REALIZA LAS OPERACIONES CRUD
    /// </summary>
    public class ServiciosDAO
    {
        private ConexionBD conexion = new ConexionBD();

        /// <summary>
        /// AGREGAR UN NUEVO SERVICIO A LA BASE DE DATOS, 
        /// RECIBE UN OBJETO SERVICIO CON LOS DATOS A GUARDAR
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Agregar(Servicio s)
        {
            string query = "INSERT INTO Servicios (nombre_servicio, descripcion, costo_base, tiempo_estimado) " +
                           "VALUES (@nom, @desc, @costo, @tiempo)";
            return Ejecutar(query, s);
        }


        /// <summary>
        /// ACTUALIZAR LOS DATOS DE UN SERVICIO EXISTENTE EN LA BASE DE DATOS
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Modificar(Servicio s)
        {
            string query = "UPDATE Servicios SET nombre_servicio=@nom, descripcion=@desc, " +
                           "costo_base=@costo, tiempo_estimado=@tiempo " +
                           "WHERE clave_servicio=@id";
            return Ejecutar(query, s);
        }

        /// <summary>
        /// EJECUTA UNA CONSULTA SQL (SELECT) Y RETORNA LOS RESULTADOS EN UN DATATABLE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public bool Eliminar(int id)
        {
            string query = "DELETE FROM Servicios WHERE clave_servicio = @id";
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// OBTIENE TODOS LOS SERVICIOS REGISTRADOS EN LA BASE DE DATOS 
        /// Y LOS RETORNA EN UN DATATABLE
        /// </summary>
        /// <returns></returns>
        public DataTable ObtenerTodos()
        {
            return conexion.ObtenerDatos("SELECT * FROM Servicios");
        }

        /// <summary>
        /// EJECUTA UNA CONSULTA SQL (INSERT, UPDATE O DELETE) 
        /// UTILIZANDO LOS DATOS DE UN OBJETO SERVICIO
        /// </summary>
        /// <param name="query"></param>
        /// <param name="s"></param>
        /// <returns></returns>

        private bool Ejecutar(string query, Servicio s)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", s.Id);
                        cmd.Parameters.AddWithValue("@nom", s.Nombre);
                        cmd.Parameters.AddWithValue("@desc", s.Descripcion);
                        cmd.Parameters.AddWithValue("@costo", s.Costo);
                        cmd.Parameters.AddWithValue("@tiempo", s.TiempoHoras);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error SQL: " + ex.Message);
                return false;
            }
        }
    }
}