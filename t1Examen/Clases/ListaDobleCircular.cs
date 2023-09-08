namespace Clases;


public class ListaDobleCircular


{

    public Nodo primero = null;
    public Nodo ultimo = null;
    public int cantidad = 0;


    public void insertarUltimo(Cancion dato)
    {
        Nodo nuevo = new Nodo();
        nuevo.dato = dato;
        if (primero == null)
        {
            primero = nuevo;
            ultimo = nuevo;
            primero.sig = primero;
            primero.ant = primero;
        }
        else
        {
            nuevo.sig = primero;
            nuevo.ant = ultimo;
            primero.ant = nuevo;
            ultimo.sig = nuevo;
            ultimo = nuevo;
        }
        cantidad++;
    }
    public void mostrarPrimeroAUltimo()
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            Nodo aux = primero;
            do
            {
                Console.WriteLine(aux.dato);
                aux = aux.sig;
            } while (aux != primero);
        }
    }
    public void mostrarUltimoAPrimero()
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            Nodo aux = ultimo;
            do
            {
                Console.WriteLine(aux.dato);
                aux = aux.ant;
            } while (aux != ultimo);
        }
    }
    public void buscarPorNombreOArtista(string nombreOArtista)
    {
        bool encontrado = false;
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            Nodo aux = primero;
            do
            {
                if (aux.dato.nombre == nombreOArtista || aux.dato.artista == nombreOArtista)
                {
                    Console.WriteLine(aux.dato);
                    encontrado = true;
                }
                aux = aux.sig;
            } while (aux != primero);

            if (!encontrado)
            {
                Console.WriteLine("No se encontraron canciones");
            }
        }
    }

    public void eliminarCancionPorNombre(string nombre)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            Nodo aux = primero;
            do
            {
                if (aux.dato.nombre == nombre)
                {
                    if (aux == primero)
                    {
                        if (aux.sig == primero)
                        {
                            primero = null;
                            ultimo = null;
                        }
                        primero = primero.sig;
                        primero.ant = ultimo;
                        ultimo.sig = primero;
                    }
                    else if (aux == ultimo)
                    {
                        ultimo = ultimo.ant;
                        ultimo.sig = primero;
                        primero.ant = ultimo;
                    }
                    else
                    {
                        aux.ant.sig = aux.sig;
                        aux.sig.ant = aux.ant;
                    }
                    cantidad--;
                    Console.WriteLine("Cancion eliminada");
                    return;
                }
                aux = aux.sig;
            } while (aux != primero);
            Console.WriteLine("Cancion no encontrada");
        }
    }


    public void reproducir()
    {
        if (primero != null)
        {
            Nodo actual = primero;
            int contador = 1;
            Boolean salir = false;
            do
            {
                Console.WriteLine("Reproduciendo");
                Console.WriteLine(actual.dato);
                Console.WriteLine("1. Anterior");
                Console.WriteLine("2. Siguiente");
                Console.WriteLine("3. Salir");

                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        actual = actual.ant;
                        break;
                    case 2:
                        actual = actual.sig;
                        break;
                    case 3:
                        Console.WriteLine("SALIENDO...");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("OPCION NO VALIDA");
                        break;
                }
                contador++;
            } while (!salir);
        }
        else
        {
            Console.WriteLine("No hay canciones");
        }
    }




}