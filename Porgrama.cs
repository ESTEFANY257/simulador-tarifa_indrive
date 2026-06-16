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
        switch (tipoVehiculo)
        {
            case 1: // Economico
                nombreVehiculo = "Económico";
                tarifaBase = 2.0;
                costoKm = 1.5;
                break;
            case 2: // Confort
                nombreVehiculo = "Confort";
                tarifaBase = 3.0;
                costoKm = 2.0;
                break;
            case 3:
                nombreVehiculo = "Primium";
                tarifaBase = 5.0;
                costoKm = 3.0;
                break;
            case 4:
                nombreVehiculo = "Moto";
                tarifaBase = 1.5;
                costoKm = 1.0;
                break;
            default:
               Console.WriteLine("\nOpción no válida. Fin del Programa");
               return;
              
        }
        // Cálculo del Subtotal Base
        subtotal = tarifaBase + (costoKm = distania);
        // Condcicional de recargo por hora pico
        if((hora >= 7 && hora <= 9)|| (hora >= 17 && hora <= 20))
        {
            esHoraPico = true;
            subtotal = subtotal * 1.30; // Incemento del 30%
        }
        // Descuento por distancia ñarga (5%)
        if(distncia > 15);
        {
            descuento = subtotal * 0.05;
            subtotal = subtotal - descuento;
        }
        // Tarifa minima y redondeo
        tarifaFinal = Math.Max(subtotal, 5.00);
        tarifaFinal = Math.Round(tarifaFinal, 2);
        // Salida - Resumen del viaje
        Console.WriteLine("\n================================");
        Console.WriteLine("  RESUMEN DEL VIAJE");
        Console.WriteLine("================================");
        Console.WriteLine("Paajero: " + nombre);
        Console.WriteLine("Vehiculo: " + nombreVehiculo);
        Console.WriteLine("Distancia: " + distancia + "km");
        Console.WriteLine("Hora Pico: " + (esHoraPico?"si (+30%)":"No"));
        if(descuento > 0) ;
        {
            Console.WriteLine("Descuento: S/" + Math.Round(descuento, 2));

        }
        Console.WriteLine("----------------------------");
        Console.WriteLine("TARIFA FINAL: S/" + tarifaFinal);
    }
}

