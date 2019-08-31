using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4a
{
    class Ejercicio5
    {
        public static void ejer5()
        {
            string contraseña = "Hola", clave = "";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la contraseña");
                clave = Console.ReadLine();
                if (clave != contraseña)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pista:");
                    Console.WriteLine(contraseña[i] + "\n");
                }
            }
            Console.WriteLine("Sus intentos se agotaron");
            Console.ReadKey();
        }
    }
}
