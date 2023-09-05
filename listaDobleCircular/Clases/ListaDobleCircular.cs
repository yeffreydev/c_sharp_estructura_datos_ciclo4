namespace Clases;


public class ListaDobleCircular

//Nodo ./Nodo.cs
/*
namespace Clases;
public class Nodo
{
    public Nodo ant = null;
    public Persona dato;
    public Nodo sig = null;
}*/

//Persona ./Persona.cs
/*
namespace Clases;
public class Persona
{
    public int dni;
    public string nombre;

    //create constructor method for properties
    public Persona(int dni, string nombre)
    {
        this.dni = dni;
        this.nombre = nombre;
    }

    //override ToString method
    public override string ToString()
    {
        return $"DNI: {dni} - Nombre: {nombre}";
    }
}*/

//methods
/*
- [] insertarPrimero
- [] insertarUltimo
- [] mostarPrimeroAUltimo
- [] mostrarUltimoAPrimero
- [] buscarPorDNI
- [] buscarPorIndice
- [] eliminarPorDni
- [] eliminarPorIndice
*/

{

    //create properties
    public Nodo primero = null;//descripcion: es el primer nodo de la lista
    public Nodo ultimo = null;//descripcion: es el ultimo nodo de la lista
    public int cantidad = 0;
    //create public method insertarPrimero en ListaDobleCircular
    public void insertarPrimero(Persona dato)
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
            primero = nuevo;
        }
        cantidad++;
    }

    //create public method insertarUltimo en ListaDobleCircular
    public void insertarUltimo(Persona dato)
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
    //create public method mostrarPrimeroAUltimo en ListaDobleCircular
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
    //create public method mostrarUltimoAPrimero en ListaDobleCircular
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
    //create public method buscarPorDNI en ListaDobleCircular
    public Nodo buscarPorDNI(int dni)
    {
        Nodo aux = primero;
        do
        {
            if (aux.dato.dni == dni)
            {
                return aux;
            }
            aux = aux.sig;
        } while (aux != primero);
        return null;
    }
    //create public method buscarPorIndice en ListaDobleCircular
    public Nodo buscarPorIndice(int indice)
    {
        if (indice >= 0 && indice < cantidad)
        {
            Nodo aux = primero;
            int i = 0;
            do
            {
                if (i == indice)
                {
                    return aux;
                }
                aux = aux.sig;
                i++;
            } while (aux != primero);
        }
        return null;
    }
    //create public method eliminarPorDni en ListaDobleCircular and return boolean 
    public bool eliminarPorDni(int dni)
    {
        Nodo aux = buscarPorDNI(dni);
        if (aux != null)
        {
            if (aux == primero)
            {
                primero = aux.sig;
                primero.ant = ultimo;
                ultimo.sig = primero;
            }
            else if (aux == ultimo)
            {
                ultimo = aux.ant;
                ultimo.sig = primero;
                primero.ant = ultimo;
            }
            else
            {
                aux.ant.sig = aux.sig;
                aux.sig.ant = aux.ant;
            }
            cantidad--;
            return true;
        }
        return false;
    }
    //create public method eliminarPorIndice en ListaDobleCircular and return boolean
    public bool eliminarPorIndice(int indice)
    {
        Nodo aux = buscarPorIndice(indice);
        if (aux != null)
        {
            if (aux == primero)
            {
                primero = aux.sig;
                primero.ant = ultimo;
                ultimo.sig = primero;
            }
            else if (aux == ultimo)
            {
                ultimo = aux.ant;
                ultimo.sig = primero;
                primero.ant = ultimo;
            }
            else
            {
                aux.ant.sig = aux.sig;
                aux.sig.ant = aux.ant;
            }
            cantidad--;
            return true;
        }
        return false;
    }



}
