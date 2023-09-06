namespace Clases;
public class ListaSimpleCircular
{
    //Nodo ./Nodo.cs
    /*
    namespace Clases;
    public class Nodo
    {
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
    - [] mostar
    - [] buscarPorDNI
    - [] buscarPorIndice
    - [] eliminarPorDni
    - [] eliminarPorIndice
    */
    //create properties for ListaSimpleCircular
    public Nodo primero = null;
    public Nodo ultimo = null;
    public int cantidad = 0;

    //create public method insertarPrimero
    public void insertarPrimero(Persona p)
    {
        Nodo nuevo = new Nodo();
        nuevo.dato = p;
        if (primero == null)
        {
            primero = nuevo;
            ultimo = nuevo;
            ultimo.sig = primero;
        }
        else
        {
            nuevo.sig = primero;
            primero = nuevo;
            ultimo.sig = primero;
        }
        cantidad++;
    }
    //create public method insertarUltimo
    public void insertarUltimo(Persona p)
    {
        Nodo nuevo = new Nodo();
        nuevo.dato = p;
        if (primero == null)
        {
            primero = nuevo;
            ultimo = nuevo;
            ultimo.sig = primero;
        }
        else
        {
            ultimo.sig = nuevo;
            ultimo = nuevo;
            ultimo.sig = primero;
        }
        cantidad++;
    }
    //create public method mostrar
    public void mostrar()
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

    //create public method buscarPorDNI
    public Persona buscarPorDNI(int dni)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
            return null;
        }
        else
        {
            Nodo aux = primero;
            do
            {
                if (aux.dato.dni == dni)
                {
                    return aux.dato;
                }
                aux = aux.sig;
            } while (aux != primero);
            return null;
        }
    }
    //create public method buscarPorIndice
    public Persona buscarPorIndice(int indice)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
            return null;
        }
        else
        {
            if (indice < 0 || indice >= cantidad)
            {
                Console.WriteLine("Indice fuera de rango");
                return null;
            }
            else
            {
                Nodo aux = primero;
                int i = 0;
                do
                {
                    if (i == indice)
                    {
                        return aux.dato;
                    }
                    aux = aux.sig;
                    i++;
                } while (aux != primero);
                return null;
            }
        }
    }
    //create public method eliminarPorDni and return boolean
    public bool eliminarPorDni(int dni)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
            return false;
        }
        else
        {
            Nodo aux = primero;
            Nodo ant = null;
            do
            {
                if (aux.dato.dni == dni)
                {
                    if (ant == null)
                    {
                        primero = aux.sig;
                        ultimo.sig = primero;
                    }
                    else
                    {
                        ant.sig = aux.sig;
                    }
                    cantidad--;
                    return true;
                }
                ant = aux;
                aux = aux.sig;
            } while (aux != primero);
            return false;
        }
    }
    //create public method eliminarPorIndice and return boolean
    public bool eliminarPorIndice(int indice)
    {
        if (primero == null)
        {
            Console.WriteLine("Lista vacia");
            return false;
        }
        else
        {
            if (indice < 0 || indice >= cantidad)
            {
                Console.WriteLine("Indice fuera de rango");
                return false;
            }
            else
            {
                Nodo aux = primero;
                Nodo ant = null;
                int i = 0;
                do
                {
                    if (i == indice)
                    {
                        if (ant == null)
                        {
                            primero = aux.sig;
                            ultimo.sig = primero;
                        }
                        else
                        {
                            ant.sig = aux.sig;
                        }
                        cantidad--;
                        return true;
                    }
                    ant = aux;
                    aux = aux.sig;
                    i++;
                } while (aux != primero);
                return false;
            }
        }
    }

}