using Clases;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            int op;
            do
            {
                op = mostrarMenu();
                switch (op)
                {
                    case 1:
                        registrarPersona(lista);
                        break;
                    case 2:
                        lista.mostrar();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.Write("\nenter para continuar");
                Console.ReadKey();
            } while (op != 3);
        }

        static int mostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("1. insertar");
            Console.WriteLine("2. mostrar");
            Console.WriteLine("3. salir");
            Console.Write("ingresa opcion: ");
            return int.Parse(Console.ReadLine());
        }
        static void registrarPersona(ListaSimple lista)
        {
            Console.WriteLine("=====FORMULARIO====");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Persona persona = new Persona(dni, nombre, apellido, edad);
            lista.insertar(persona);
        }
    }
}
