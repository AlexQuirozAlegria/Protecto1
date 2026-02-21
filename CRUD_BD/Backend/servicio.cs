namespace CRUD_BD.Backend
{

    /// <summary>
    
    /// OBTIENE LOS DATOS DE LOS SERVICIOS DESDE LA BASE DE DATOS
    
    /// </summary>
    
    public class Servicio
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public int TiempoHoras { get; set; }
    }
}