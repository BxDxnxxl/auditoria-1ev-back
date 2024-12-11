namespace models
{
    public class ModeloAutoria
    {
        private static int contadorId = 1;

        public int Id { get; private set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TipoProducto { get; set; } // Ej: Bebida, Snack, Combo
        public int CantidadEnInventario { get; set; }
        public double Precio { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Disponible { get; set; }

        public ModeloAutoria(string nombre, string descripcion, string tipoProducto, int cantidadEnInventario, double precio, DateTime fechaIngreso, bool disponible)
        {
            Id = contadorId++;
            Nombre = nombre;
            Descripcion = descripcion;
            TipoProducto = tipoProducto;
            CantidadEnInventario = cantidadEnInventario;
            Precio = precio;
            FechaIngreso = fechaIngreso;
            Disponible = disponible;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Tipo de Producto: {TipoProducto}");
            Console.WriteLine($"Cantidad en Inventario: {CantidadEnInventario}");
            Console.WriteLine($"Precio: ${Precio:F2}");
            Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
            Console.WriteLine($"Disponible: {(Disponible ? "Sí" : "No")}");
        }
    }
}
