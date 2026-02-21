namespace CRUD_BD.Backend
{
    /// <summary>
    /// REPRESENTA UNA REFACCIÓN EN EL SISTEMA DE INVENTARIO DE LA AUTOMOTRIZ
    /// OBTIENE LOS DATOS DE LA REFACCIÓN DESDE LA BASE DE DATOS 
    /// Y LOS ALMACENA EN PROPIEDADES
    /// </summary>
    public class Refaccion
    {
        public int Id { get; set; }
        public string Codigo { get; set; }      
        public string Nombre { get; set; }
        public string Marca { get; set; }       
        public decimal PrecioUnitario { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }    
        public string Proveedor { get; set; } 
    }
}