namespace Clases;

public class ListaDobleCircular<T>
{
    public Nodo<T>? primero = null; //descripcion: es el primer nodo de la lista
    public Nodo<T>? ultimo = null; //descripcion: es el ultimo nodo de la lista
    public int cantidad = 0;
    public delegate bool EvaluadorDato(T? dato);
    public delegate void CallBackMostar(T? dato);

    //public method insertarPrimero en ListaDobleCircular
    public void Insertar(T dato)
    {
        Nodo<T> nuevo = new Nodo<T> { dato = dato };
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
    public void InsertarUltimo(T dato)
    {
        Nodo<T> nuevo = new Nodo<T>();
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
    public void Mostrar(CallBackMostar cbm)
    {
        if (primero == null)
            Console.WriteLine("Lista vacia");
        else
        {
            Nodo<T>? aux = primero;
            do
            {
                cbm(aux.dato);
                aux = aux?.sig;
            } while (aux != primero);
        }
    }

    //create public method mostrarUltimoAPrimero en ListaDobleCircular
    public void MostrarReversa(CallBackMostar cbm)
    {
        if (primero == null)
            Console.WriteLine("Lista vacia");
        else
        {
            Nodo<T>? aux = ultimo;
            do
            {
                cbm(aux.dato);
                aux = aux.ant;
            } while (aux != ultimo);
        }
    }

    //create public method buscarPorDNI en ListaDobleCircular
    public Nodo<T>? Buscar(EvaluadorDato ed)
    {
        if (primero == null)
            return null;
        Nodo<T>? nodoEncontrado = null;
        //logic for search
        Nodo<T>? temp = primero;
        do
        {
            if (ed(temp.dato))
            {
                nodoEncontrado = temp;
                break;
            }
            temp = temp?.sig;
        } while (temp != primero);

        return nodoEncontrado;
    }

    public Nodo<T>? Buscar(int indice)
    {
        if (indice > (cantidad - 1) || indice < 0)
            return null;
        if (primero == null)
            return null;
        Nodo<T>? nodoEncontrado = null;
        //logic for search
        int contador = 0;
        Nodo<T>? temp = primero;
        do
        {
            if (contador == indice)
            {
                return temp;
            }
            contador++;
            temp = temp?.sig;
        } while (temp != primero);

        return nodoEncontrado;
    }

    //create public method eliminarPorDni en ListaDobleCircular and return boolean


    // //create public method eliminarPorIndice en ListaDobleCircular and return boolean
    public bool Eliminar(EvaluadorDato ed)
    {
        Nodo<T>? aux = Buscar(ed);
        if (aux == null)
            return false;

        if (aux == primero)
        {
            if (primero.sig == primero)
            {
                ultimo = null;
                primero = null;
            }
            else
            {
                primero = aux.sig;
                primero.ant = ultimo;
                ultimo.sig = primero;
            }
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

    public bool Eliminar(int indice)
    {
        Nodo<T>? aux = Buscar(indice);
        if (aux == null)
            return false;

        if (aux == primero)
        {
            if (primero.sig == primero)
            {
                ultimo = null;
                primero = null;
            }
            else
            {
                primero = aux.sig;
                primero.ant = ultimo;
                ultimo.sig = primero;
            }
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
}
