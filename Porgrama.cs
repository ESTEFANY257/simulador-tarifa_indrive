public class SimuladorTarifa
{
   public static void Main(string[] args)
    {
       Console.WriteLine("================================");
        Console.WriteLine(" InDrive - Simulador de Tarifa");
        Console.WriteLine("================================");
        // Entrada de Datos
        // Declaración de variables
        string nombre; nombreVehiculo;
        double distania, tarifaBase, costoKm, subtotal, descuento, tarifaFinal;
        int hora; tipoVehiculo;
        bool esHoraPico;
        Console.WriteLine("Nombre del Pasajero");
        nombre = Console.ReadLine();
        
        Console.WriteLine("Ingrese distania del viaje (km):");
        distania = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Hora de Salida (0 hrs - 23 hrs): ");
        hora = int.Parse(Console.ReadLine());
       
        Console.WriteLine("\nTipo de Vehículo: ");
        Console.WriteLine(" 1. Economico");
        Console.WriteLine(" 2. Confort");
        Console.WriteLine(" 3. Premium");
        Console.WriteLine(" 4. Moto");
        Console.WriteLine("Ingrese la opción: ");
        tipoVehiculo = int.Parse(Console.ReadLine()); 
        // Proceso
    }
}
