using Clases;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ListaDobleCircular lista = new ListaDobleCircular();
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
                        lista.mostrarPrimeroAUltimo();
                        break;
                    case 4:
                        lista.mostrarUltimoAPrimero();
                        break;
                    case 5:
                        buscarPersonaPorDni(lista);
                        break;
                    case 6:
                        buscarPersonaPorIndice(lista);
                        break;
                    case 7:
                        eliminarPersonaPorDni(lista);
                        break;
                    case 8:
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
            Console.WriteLine("3. mostrar Primero Ultimo");
            Console.WriteLine("4. mostrar Ultimo Primero");
            Console.WriteLine("5. buscar persona por dni");
            Console.WriteLine("6. buscar persona por indice");
            Console.WriteLine("7. eliminar persona por dni");
            Console.WriteLine("8. eliminar persona por indice");
            Console.WriteLine("0. salir");
            Console.Write("ingresa opcion: ");
            return int.Parse(Console.ReadLine());
        }
        static void registrarPersona(ListaDobleCircular lista, bool insertarInicio = false)//pociincio|final
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
        static void buscarPersonaPorDni(ListaDobleCircular lista)
        {
            Console.WriteLine("=====BUSCAR PERSONA POR DNI====");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Nodo nodo = lista.buscarPorDNI(dni);
            if (nodo != null)
            {
                Console.WriteLine("persona encontrada");
                Console.WriteLine(nodo.dato);
                return;
            }
            Console.WriteLine("persona no encontrada");
        }

        //buscar persona por indice
        static void buscarPersonaPorIndice(ListaDobleCircular lista)
        {
            Console.WriteLine("=====BUSCAR PERSONA POR INDICE====");
            Console.Write("INDICE: ");
            int indice = int.Parse(Console.ReadLine());
            Nodo nodo = lista.buscarPorIndice(indice);
            if (nodo != null)
            {
                Console.WriteLine("persona encontrada");
                Console.WriteLine(nodo.dato);
                return;
            }
            Console.WriteLine("persona no encontrada");
        }

        //eliminar persona por dni
        static void eliminarPersonaPorDni(ListaDobleCircular lista)
        {
            Console.WriteLine("=====ELIMINAR PERSONA POR DNI====");
            Console.Write("DNI: ");
            int dni = int.Parse(Console.ReadLine());
            lista.eliminarPorDni(dni);
            Boolean isDeleted = lista.eliminarPorDni(dni);
            if (isDeleted)
            {
                Console.WriteLine("persona eliminada");
                return;
            }
            Console.WriteLine("persona no encontrada");
        }
        //eliminar persona por indice
        static void eliminarPersonaPorIndice(ListaDobleCircular lista)
        {
            Console.WriteLine("=====ELIMINAR PERSONA POR INDICE====");
            Console.Write("INDICE: ");
            int indice = int.Parse(Console.ReadLine());
            Boolean isDeleted = lista.eliminarPorIndice(indice);
            if (isDeleted)
            {
                Console.WriteLine("persona eliminada");
                return;
            }
            Console.WriteLine("persona no encontrada");
        }
    }
}