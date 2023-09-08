using Clases;


namespace ConsoleApp;

internal class ConsoleApp
{
    public static void Main(string[] args)
    {
        ListaDoble lista = new ListaDoble();
        int opcion = 0;
        do
        {
            Console.WriteLine("1. Registrar persona");
            Console.WriteLine("2. Mostrar personas Inicio-Final");
            Console.WriteLine("3. Mostrar personas Final-Inicio");
            Console.WriteLine("4. Buscar persona por codigo o nombre");
            Console.WriteLine("5. Ordenar por nombre");
            Console.WriteLine("6. Eliminar Persona por codigo");
            Console.WriteLine("7. Vaciar Lista");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {

                case 1:
                    registrarPersona(lista);
                    continuar("Persona registrada");
                    break;
                case 2:
                    lista.mostrar();
                    continuar("Fin de la lista");
                    break;
                case 3:
                    lista.mostrarInverso();
                    continuar("Fin de la lista");
                    break;
                case 4:
                    buscarPersona(lista);
                    continuar("");
                    break;
                case 5:
                    lista.ordenarPorNombre();
                    continuar("Lista ordenada");
                    break;
                case 6:
                    eliminarPersona(lista);
                    continuar("");
                    break;
                case 7:
                    lista.vaciar();
                    continuar("Lista vaciada");
                    break;
                case 0:
                    Console.WriteLine("Adios");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;

            }
            Console.Clear();
        } while (opcion != 0);
    }
    static void continuar(string msg)
    {
        if (msg == "")
        {
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            return;
        }
        Console.WriteLine(msg);
        Console.WriteLine("Presione una tecla para continuar");
        Console.ReadKey();
    }
    static void registrarPersona(ListaDoble lista)
    {
        Console.WriteLine("Ingrese el nombre de la persona");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la edad de la persona");
        int edad = int.Parse(Console.ReadLine());
        Persona p = new Persona(nombre, edad);
        lista.insertar(p);
    }
    static void buscarPersona(ListaDoble lista)
    {
        Console.WriteLine("Ingrese el codigo o nombre de la persona ");
        string stringBuscar = Console.ReadLine();
        Persona p;
        try
        {

            //para buscar por nombre
            p = lista.buscar(int.Parse(stringBuscar));
            if (p == null)
            {
                //para buscar por codigo
                p = lista.buscar(stringBuscar);
            }
            if (p != null)
            {
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("No existe la persona");
            }
        }
        catch (Exception e)
        {
            p = lista.buscar(stringBuscar);
            if (p != null)
            {
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("No existe la persona");
            }
        }
    }

    static void eliminarPersona(ListaDoble lista)
    {
        Console.WriteLine("Ingrese el codigo de la persona");
        int cod = int.Parse(Console.ReadLine());
        Persona p = lista.buscar(cod);
        if (p != null)
        {
            lista.eliminarPersonaPorCodigo(p.codigo);
            Console.WriteLine("Persona eliminada");
        }
        else
        {
            Console.WriteLine("No existe la persona");
        }
    }
}