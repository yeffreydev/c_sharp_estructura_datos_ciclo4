using Clases;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ListaSimpleCircular lista = new ListaSimpleCircular();
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
            Console.WriteLine("3. mostrar lista");
            Console.WriteLine("4. buscar persona por dni");
            Console.WriteLine("5. buscar persona por indice");
            Console.WriteLine("6. eliminar persona por dni");
            Console.WriteLine("7. eliminar persona por indice");
            Console.WriteLine("0. salir");
            Console.Write("ingresa opcion: ");
            return int.Parse(Console.ReadLine());
        }
        static void registrarPersona(ListaSimpleCircular lista, bool insertarInicio = false)//pociincio|final
        {
            Console.WriteLine("=====FORMULARIO====");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Persona persona = new Persona(dni, nombre);
            if (insertarInicio)
            {
                lista.insertarPrimero(persona);
                return;
            }
            lista.insertarUltimo(persona);
        }
        static void buscarPersonaPorDni(ListaSimpleCircular lista)
        {
            Console.WriteLine("=====BUSCAR PERSONA POR DNI====");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Persona p = lista.buscarPorDNI(dni);
            if (p != null)
            {
                Console.WriteLine("persona encontrada");
                Console.WriteLine(p);
                return;
            }
            Console.WriteLine("persona no encontrada");
        }

        //buscar persona por indice
        static void buscarPersonaPorIndice(ListaSimpleCircular lista)
        {
            Console.WriteLine("=====BUSCAR PERSONA POR INDICE====");
            Console.Write("INDICE: ");
            int indice = int.Parse(Console.ReadLine());
            Persona p = lista.buscarPorIndice(indice);
            if (p != null)
            {
                Console.WriteLine("persona encontrada");
                Console.WriteLine(p);
                return;
            }
            Console.WriteLine("persona no encontrada");
        }

        //eliminar persona por dni
        static void eliminarPersonaPorDni(ListaSimpleCircular lista)
        {
            Console.WriteLine("=====ELIMINAR PERSONA POR DNI====");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            lista.eliminarPorDni(dni);
        }
        //eliminar persona por indice
        static void eliminarPersonaPorIndice(ListaSimpleCircular lista)
        {
            Console.WriteLine("=====ELIMINAR PERSONA POR INDICE====");
            Console.Write("INDICE: ");
            int indice = int.Parse(Console.ReadLine());
            lista.eliminarPorIndice(indice);
        }
    }
}