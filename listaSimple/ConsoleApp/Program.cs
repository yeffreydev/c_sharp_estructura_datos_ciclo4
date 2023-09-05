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
                        registrarPersona(lista, true);
                        break;
                    case 2:
                        registrarPersona(lista);
                        break;
                    case 3:
                        lista.mostrar();
                        break;
                    case 4:
                        buscarPersonaPorDni(lista);
                        break;
                    case 5:
                        buscarPersonaPorIndice(lista);
                        break;
                    case 6:
                        eliminarPersonaPorDni(lista);
                        break;
                    case 7:
                        eliminarPersonaPorIndice(lista);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.Write("\nenter para continuar");
                Console.ReadKey();
            } while (op != 0);
        }

        static int mostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("1. insertar Inicio ");
            Console.WriteLine("2. insertar Final ");
            Console.WriteLine("3. mostrar");
            Console.WriteLine("4. buscar persona por dni");
            Console.WriteLine("5. buscar persona por indice");
            Console.WriteLine("6. eliminar persona por dni");
            Console.WriteLine("7. eliminar persona por indice");
            Console.WriteLine("0. salir");
            Console.Write("ingresa opcion: ");
            return int.Parse(Console.ReadLine());
        }
        static void registrarPersona(ListaSimple lista, bool insertarInicio = false)//pociincio|final
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
            if (insertarInicio)
            {
                lista.insertarInicio(persona);
                return;
            }
            lista.insertarFinal(persona);
        }
        static void buscarPersonaPorIndice(ListaSimple lista)
        {
            Console.WriteLine("=====BUSCAR PERSONA POR INDICE====");
            Console.Write("Indice: ");
            int i = int.Parse(Console.ReadLine());
            lista.buscarPorIndice(i);

        }
        static void buscarPersonaPorDni(ListaSimple lista)
        {
            Console.WriteLine("=====BUSCAR PERSONA POR DNI====");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            lista.buscarPorDni(dni);
        }
        static void eliminarPersonaPorDni(ListaSimple lista)
        {
            Console.WriteLine("=====ELIMINAR PERSONA POR DNI====");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            lista.eliminarPorDni(dni);
        }
        static void eliminarPersonaPorIndice(ListaSimple lista)
        {
            Console.WriteLine("=====ELIMINAR PERSONA POR INDICE====");
            Console.Write("INDICE: ");
            int i = int.Parse(Console.ReadLine());
            lista.eliminarPersonaPorIndice(i);
        }
    }
}
