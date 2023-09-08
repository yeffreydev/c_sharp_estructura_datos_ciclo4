namespace Clases;

public class ListaDoble
{
    private Nodo primero;
    private Nodo ultimo;
    public ListaDoble()
    {
        primero = null;
        ultimo = null;
    }
    public bool vacia()
    {
        return primero == null;
    }
    public void insertar(Persona p)
    {
        Nodo nuevo = new Nodo();
        nuevo.dato = p;
        if (vacia())
        {
            primero = nuevo;
            ultimo = nuevo;
        }
        else
        {
            ultimo.sig = nuevo;
            nuevo.ant = ultimo;
            ultimo = nuevo;
        }
    }
    public void mostrar()
    {
        if (!vacia())
        {
            Nodo temp = primero;
            while (temp != null)
            {
                Console.WriteLine(temp.dato);
                temp = temp.sig;
            }
        }
    }
    public void mostrarInverso()
    {
        if (!vacia())
        {
            Nodo temp = ultimo;
            while (temp != null)
            {
                Console.WriteLine(temp.dato);
                temp = temp.ant;
            }
        }
    }

    public Persona buscar(int cod)
    {
        if (!vacia())
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (temp.dato.codigo == cod)
                {
                    return temp.dato;
                }
                temp = temp.sig;
            }
        }
        return null;
    }

    public Persona buscar(string nombre)
    {
        if (!vacia())
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (temp.dato.nombre.ToLower() == nombre.ToLower())
                {
                    return temp.dato;
                }
                temp = temp.sig;
            }
        }
        return null;
    }

    public void ordenarPorCodigo()
    {
        if (!vacia())
        {
            Nodo temp = primero;
            while (temp != null)
            {
                Nodo temp2 = temp.sig;
                while (temp2 != null)
                {
                    if (temp.dato.codigo > temp2.dato.codigo)
                    {
                        Persona aux = temp.dato;
                        temp.dato = temp2.dato;
                        temp2.dato = aux;
                    }
                    temp2 = temp2.sig;
                }
                temp = temp.sig;
            }
        }
    }

    public void ordenarPorNombre()
    {
        if (vacia())
        {
            Console.WriteLine("Lista vacia");
        }
        Nodo temp = primero;
        while (temp != null)
        {
            Nodo temp2 = temp.sig;
            while (temp2 != null)
            {
                if (temp.dato.nombre.CompareTo(temp2.dato.nombre) > 0)
                {
                    Persona aux = temp.dato;
                    temp.dato = temp2.dato;
                    temp2.dato = aux;
                }
                temp2 = temp2.sig;
            }
            temp = temp.sig;
        }
    }

    public void ordenarPorEdad()
    {
        if (!vacia())
        {
            Nodo temp = primero;
            while (temp != null)
            {
                Nodo temp2 = temp.sig;
                while (temp2 != null)
                {
                    if (temp.dato.edad > temp2.dato.edad)
                    {
                        Persona aux = temp.dato;
                        temp.dato = temp2.dato;
                        temp2.dato = aux;
                    }
                    temp2 = temp2.sig;
                }
                temp = temp.sig;
            }
        }
    }


    public int cantidad()
    {
        int cant = 0;
        Nodo temp = primero;
        while (temp != null)
        {
            cant++;
            temp = temp.sig;
        }
        return cant;
    }

    public void eliminarPersonaPorCodigo(int cod)
    {
        if (!vacia())
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (temp.dato.codigo == cod)
                {
                    if (temp == primero)
                    {
                        primero = primero.sig;
                        if (primero != null)
                        {
                            primero.ant = null;
                        }
                    }
                    else if (temp == ultimo)
                    {
                        ultimo = ultimo.ant;
                        ultimo.sig = null;
                    }
                    else
                    {
                        Nodo anterior = temp.ant;
                        Nodo siguiente = temp.sig;
                        anterior.sig = siguiente;
                        siguiente.ant = anterior;
                    }
                }
                temp = temp.sig;
            }
        }
    }


    //vaciar lista
    public void vaciar()
    {
        primero = null;
        ultimo = null;
    }
}