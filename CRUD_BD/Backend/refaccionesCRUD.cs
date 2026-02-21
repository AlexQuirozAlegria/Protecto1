using MySql.Data.MySqlClient; 
using System;
using System.Data;

namespace CRUD_BD.Backend
{
    /// <summary>
    /// LOS DATOS DE LAS REFACCIONES SE MANEJAN A TRAVÉS DE ESTA CLASE, 
    /// QUE SE ENCARGA DE REALIZAR LAS OPERACIONES CRUD
    /// </summary>
    public class RefaccionesDAO
    {
        /// <summary>
        /// CONEXION A LA BASE DE DATOS, SE UTILIZA PARA EJECUTAR LOS COMANDOS SQL
        /// </summary>
        private ConexionBD conexion = new ConexionBD();


        /// <summary>
        /// AGREGA UNA NUEVA REFACCIÓN A LA BASE DE DATOS, 
        /// RECIBE UN OBJETO REFACCION CON LOS DATOS A GUARDAR
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool Agregar(Refaccion r)
        {
            string query = "INSERT INTO Refacciones (codigo_refaccion, nombre, marca, precio_unitario, stock_actual, stock_minimo, proveedor) " +
                           "VALUES (@cod, @nom, @mar, @pre, @sta, @stm, @prov)";
            return Ejecutar(query, r);
        }

        /// <summary>
        /// MODIFICA LOS DATOS DE UNA REFACCIÓN EXISTENTE EN LA BASE DE DATOS,
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>

        public bool Modificar(Refaccion r)
        {
            string query = "UPDATE Refacciones SET nombre=@nom, marca=@mar, " +
                           "precio_unitario=@pre, stock_actual=@sta, stock_minimo=@stm, proveedor=@prov " +
                           "WHERE codigo_refaccion=@cod";

            return Ejecutar(query, r);
        }

        /// <summary>
        /// ELIMINA UNA REFACCIÓN DE LA BASE DE DATOS, 
        /// RECIBE EL CÓDIGO DE LA REFACCIÓN A ELIMINAR
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>

        public bool Eliminar(string codigo)
        {
            string query = "DELETE FROM Refacciones WHERE codigo_refaccion = @cod";

            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cod", codigo);
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
        /// OBTIENE TODAS LAS REFACCIONES DE LA BASE DE DATOS 
        /// Y LAS RETORNA EN UN DATATABLE
        /// </summary>
        /// <returns></returns>
        public DataTable ObtenerTodas()
        {
            return conexion.ObtenerDatos("SELECT * FROM Refacciones");
        }

        /// <summary>
        /// EJECUTA LOS COMANDOS SQL DE AGREGAR Y MODIFICAR,
        /// LOS AGREGA A LA BASE DE DATOS UTILIZANDO LOS PARÁMETROS DEL OBJETO 
        /// REFACCION RECIBIDO
        /// </summary>
        /// <param name="query"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private bool Ejecutar(string query, Refaccion r)
        {
            try
            {
                using (var conn = conexion.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cod", r.Codigo);
                        cmd.Parameters.AddWithValue("@nom", r.Nombre);
                        cmd.Parameters.AddWithValue("@mar", r.Marca);
                        cmd.Parameters.AddWithValue("@pre", r.PrecioUnitario);
                        cmd.Parameters.AddWithValue("@sta", r.StockActual);
                        cmd.Parameters.AddWithValue("@stm", r.StockMinimo);
                        cmd.Parameters.AddWithValue("@prov", r.Proveedor);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}