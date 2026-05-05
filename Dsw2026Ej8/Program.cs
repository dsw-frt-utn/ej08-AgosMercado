namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problema5 miResolucion = new Problema5();
            Sale ventaMino = new RetailSale();
            ventaMino.Amount = 1000;
            Sale ventaMayo = new WholesaleSale();
            ventaMayo.Amount = 1000;
            Console.WriteLine($"Venta Minorista (1000): {miResolucion.ObtenerImporteFinal(ventaMino)}");
            Console.WriteLine($"Venta Mayorista (1000): {miResolucion.ObtenerImporteFinal(ventaMayo)}");
        }
    }
}
