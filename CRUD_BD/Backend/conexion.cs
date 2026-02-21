using MySql.Data.MySqlClient;
using System;
using System.Data;

public class ConexionBD
{
    /// <summary>
    /// CONEXION A LA BASE DE DATOS
    /// </summary>
    private string connectionString =
        "Server=20.55.232.75;Port=3306;Database=Automotriz;Uid=alex;Pwd=12345678;";


    /// <summary>
    /// RETORNA UNA NUEVA CONEXION A LA BASE DE DATOS
    /// </summary>
    /// <returns></returns>
    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    /// <summary>
    /// EJECUTA UN COMANDO SQL (INSERT, UPDATE, DELETE) Y RETORNA 
    /// TRUE SI SE EJECUTÓ CORRECTAMENTE, O FALSE EN CASO DE ERROR
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    public bool EjecutarComando(string query)
    {
        try
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            return false;
        }
    }

    /// <summary>
    /// EJECUTA UNA CONSULTA SQL (SELECT) Y RETORNA LOS RESULTADOS EN UN DATATABLE
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    public DataTable ObtenerDatos(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("Error al leer datos: " + ex.Message);
        }
        return dt;
    }
}