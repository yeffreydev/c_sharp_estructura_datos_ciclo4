namespace Clases;
public class ListaDoble
{
    /*public class Nodo
  {
      public Nodo ant = null;
      public Persona dato;
      public Nodo sig = null;
  }*/
    /*public class Persona
  {
      public int dni;
      public string nombre;
  }
  */
    Nodo primero = null;
    Nodo ultimo = null;
    //insertarInicio [x]
    //insertarFinal [x]
    //mostrar [x]
    //buscarPorDNI [x]
    //buscarPorIndice [x]
    //eliminarPorDni [x]
    //eliminarPorIndice [x]
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

    //create the method insertarInicio para esta lista doble
    public void insertarInicio(Persona persona)
    {
        Nodo nuevo = new Nodo();
        nuevo.dato = persona;
        if (primero == null)
        {
            primero = nuevo;
            ultimo = nuevo;
        }
        else
        {
            nuevo.sig = primero;
            primero.ant = nuevo;
            primero = nuevo;
        }
    }

    //create the method insertarFinal para esta lista doble
    public void insertarFinal(Persona persona)
    {
        Nodo nuevo = new Nodo();
        nuevo.dato = persona;
        if (primero == null)
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

    //create the method mostarPrimeroAUltimo para esta lista doble
    public void mostarPrimeroAUltimo()
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            Nodo aux = primero;
            while (aux != null)
            {
                Console.WriteLine(aux.dato);
                aux = aux.sig;
            }
        }
    }
    //create the method mostrarUltimoAPrimero para esta lista doble
    public void mostrarUltimoAPrimero()
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            Nodo aux = ultimo;
            while (aux != null)
            {
                Console.WriteLine(aux.dato);
                aux = aux.ant;
            }
        }
    }
    //create the method buscarPorDNI para esta lista doble
    public Nodo buscarPorDNI(int dni)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
            return null;
        }
        else
        {
            Nodo aux = primero;
            while (aux != null)
            {
                if (aux.dato.dni == dni)
                {
                    return aux;
                }
                aux = aux.sig;
            }
            return null;
        }
    }
    //create the method buscarPorIndice para esta lista doble
    public Nodo buscarPorIndice(int indice)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
            return null;
        }
        else
        {
            Nodo aux = primero;
            int i = 0;
            while (aux != null)
            {
                if (i == indice)
                {
                    return aux;
                }
                aux = aux.sig;
                i++;
            }
            return null;
        }
    }

    //create the method eliminarPorDni para esta lista doble
    public void eliminarPorDni(int dni)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            Nodo aux = primero;
            while (aux != null)
            {
                if (aux.dato.dni == dni)
                {
                    if (aux == primero && aux == ultimo)
                    {
                        primero = null;
                        ultimo = null;
                    }
                    else if (aux == primero)
                    {
                        primero = primero.sig;
                        primero.ant = null;
                    }
                    else if (aux == ultimo)
                    {
                        ultimo = ultimo.ant;
                        ultimo.sig = null;
                    }
                    else
                    {
                        aux.ant.sig = aux.sig;
                        aux.sig.ant = aux.ant;
                    }
                    Console.WriteLine("Persona eliminada");
                    return;
                }
                aux = aux.sig;
            }
            Console.WriteLine("Persona no encontrada");
        }
    }
    //create the method eliminarPorIndice para esta lista doble
    public void eliminarPorIndice(int indice)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            Nodo aux = primero;
            int i = 0;
            while (aux != null)
            {
                if (i == indice)
                {
                    if (aux == primero && aux == ultimo)
                    {
                        primero = null;
                        ultimo = null;
                    }
                    else if (aux == primero)
                    {
                        primero = primero.sig;
                        primero.ant = null;
                    }
                    else if (aux == ultimo)
                    {
                        ultimo = ultimo.ant;
                        ultimo.sig = null;
                    }
                    else
                    {
                        aux.ant.sig = aux.sig;
                        aux.sig.ant = aux.ant;
                    }
                    Console.WriteLine("Persona eliminada");
                    return;
                }
                aux = aux.sig;
                i++;
            }
            Console.WriteLine("Persona no encontrada");
        }
    }
}
