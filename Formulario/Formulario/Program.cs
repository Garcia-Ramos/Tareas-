using System;

namespace Formulario
{
    class Program
    {
        static void Main(string[] args)
        {
            String n, ap, am, nt, c, o;
            int e;
            Console.Write("Ingresa los datos que se solicitan a continuacion: ");
            Console.WriteLine("\nNombre: ");
            n = Console.ReadLine();
            Console.WriteLine("\nApellido paterno: ");
            ap = Console.ReadLine();
            Console.WriteLine("\nApellido Materno: ");
            am = Console.ReadLine();
            Console.WriteLine("\nEdad: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNumero Telefonico: ");
            nt = Console.ReadLine();
            Console.WriteLine("\nCorreo: ");
            c = Console.ReadLine();
            Console.WriteLine("\nOcupacion: ");
            o = Console.ReadLine();

            if (e > 18)
            {
                Console.WriteLine("\n\nResgistro Exitoso, sus datos son los siguientes:");
                Console.WriteLine("\nNombre: " + n + ap + am);
                Console.WriteLine("\nEdad:" + e);
                Console.WriteLine("\nNumero de telefono: " + nt);
                Console.WriteLine("\nOcupacion:" + o);
            }
            else if (e < 18)
            {
                Console.WriteLine("\nRegistro Fallido, el usuario es menor de edad");
            }

            Console.Write("\n\nFin del programa");
            Console.ReadLine();
        }
    }
}
            


