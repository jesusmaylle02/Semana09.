using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                
                Console.WriteLine("================================");
                Console.WriteLine("Tienda de Don Lucas");
                Console.WriteLine("================================");
                Console.WriteLine("1: Registrar venta");
                Console.WriteLine("2: Registrar devolución");
                Console.WriteLine("3: Cerrar Caja");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");

                string opcion = Console.ReadLine();
                Console.Clear() ;

                switch (opcion)
                {
                    case "1":
                        
                        Console.WriteLine("================================");
                        Console.WriteLine("Registrar Venta de:");
                        Console.WriteLine("================================");
                        Console.WriteLine("1: Limpieza");
                        Console.WriteLine("2: Abarrotes");
                        Console.WriteLine("3: Golosinas");
                        Console.WriteLine("4: Electrónicos");
                        Console.WriteLine("5: <- Regresar");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese una opción: ");
                        string ventaOpcion = Console.ReadLine();

                        switch (ventaOpcion)
                        {
                            case "1":
                                Console.WriteLine("Opción 1 seleccionada: Registrar venta de Limpieza");
                               
                                break;
                            case "2":
                                Console.WriteLine("Opción 2 seleccionada: Registrar venta de Abarrotes");
                                
                                break;
                            case "3":
                                Console.WriteLine("Opción 3 seleccionada: Registrar venta de Golosinas");
                                
                                break;
                            case "4":
                                Console.WriteLine("Opción 4 seleccionada: Registrar venta de Electrónicos");
                                
                                break;
                            case "5":
                                Console.WriteLine("Opción 5 seleccionada: Regresar");
                                break;
                            default:
                                Console.WriteLine("Opción inválida");
                                break;
                        }
                        break;
                    case "2":

                        Console.WriteLine("==============================");
                        Console.WriteLine("Registrar devolucion de: ");
                        Console.WriteLine("==============================");
                        Console.WriteLine("1: Limpieza");
                        Console.WriteLine("2: Abarrotes");
                        Console.WriteLine("3: Golosinas");
                        Console.WriteLine("4: Electrónicos");
                        Console.WriteLine("5: <- Regresar");
                        Console.WriteLine("================================");
                        Console.Write("Ingrese una opción: ");
                        string devolucionOpcion = Console.ReadLine();

                        switch (devolucionOpcion)
                        {
                            case "1":
                                Console.WriteLine("Opción 1 seleccionada: Registrar venta de Limpieza");

                                break;
                            case "2":
                                Console.WriteLine("Opción 2 seleccionada: Registrar venta de Abarrotes");

                                break;
                            case "3":
                                Console.WriteLine("Opción 3 seleccionada: Registrar venta de Golosinas");

                                break;
                            case "4":
                                Console.WriteLine("Opción 4 seleccionada: Registrar venta de Electrónicos");

                                break;
                            case "5":
                                Console.WriteLine("Opción 5 seleccionada: Regresar");
                                break;
                            default:
                                Console.WriteLine("Opción inválida");
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine("Opción 3 seleccionada: Cerrar Caja");
                        
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }



                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            
            
               
                
            
        }
    }
}
