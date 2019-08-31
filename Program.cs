using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4a
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo, total = 0.0;
            for (int i = 1; i <= 20; i++)
            {
                sueldo = 0.0;
                Console.WriteLine("Ingrese el sueldo del trabajador # {0}", i);
                sueldo = Convert.ToDouble(Console.ReadLine());
                total += sueldo;
            }
            Console.WriteLine("Total de sueldos: {0:C2}", total);
            Console.WriteLine("Promedio de sueldos: {0:C2}", total / 20);
            Console.ReadKey();





            Console.WriteLine();
            Console.WriteLine("\n ********************Ejercicio 2********************");
            Console.WriteLine();
            Ejercicio2.ejer2();
            Console.WriteLine("\n ********************Ejercicio 3********************");
            Console.WriteLine();
            Ejercicio3.ejer3();
            Console.WriteLine("\n ********************Ejercicio 4********************");
            Console.WriteLine();
            Ejercicio4.ejer4();
            Console.WriteLine("\n ********************Ejercicio 5********************");
            Console.WriteLine();
            Ejercicio5.ejer5();
            
    }
}
