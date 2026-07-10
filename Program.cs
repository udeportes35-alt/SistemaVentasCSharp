using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static double totalVentasDia = 0;

    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("      SISTEMA DE VENTAS");
            Console.WriteLine("================================");
            Console.WriteLine("1. Registrar venta");
            Console.WriteLine("2. Ver total vendido");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarVenta();
                    break;

                case 2:
                    MostrarTotalVentas();
                    break;

                case 3:
                    Console.WriteLine("\nGracias por usar el sistema.");
                    break;

                default:
                    Console.WriteLine("\nOpción inválida.");
                    Pausa();
                    break;
            }

        } while (opcion != 3);
    }

    static void RegistrarVenta()
    {
        Console.Clear();
        Console.WriteLine("===== REGISTRO DE VENTA =====");

        Console.Write("Nombre del producto: ");
        string producto = Console.ReadLine();

        Console.Write("Precio del producto: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        double subtotal = CalcularSubtotal(precio, cantidad);
        double igv = CalcularIGV(subtotal);
        double total = subtotal + igv;

        totalVentasDia += total;

        Console.WriteLine("\n===== BOLETA DE VENTA =====");
        Console.WriteLine($"Producto : {producto}");
        Console.WriteLine($"Precio   : S/ {precio:F2}");
        Console.WriteLine($"Cantidad : {cantidad}");
        Console.WriteLine($"Subtotal : S/ {subtotal:F2}");
        Console.WriteLine($"IGV 18%  : S/ {igv:F2}");
        Console.WriteLine($"TOTAL    : S/ {total:F2}");

        Pausa();
    }

    static double CalcularSubtotal(double precio, int cantidad)
    {
        return precio * cantidad;
    }

    static double CalcularIGV(double subtotal)
    {
        return subtotal * 0.18;
    }

    static void MostrarTotalVentas()
    {
        Console.Clear();
        Console.WriteLine("===== REPORTE DE VENTAS =====");
        Console.WriteLine($"Total vendido: S/ {totalVentasDia:F2}");
        Pausa();
    }

    static void Pausa()
    {
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}

