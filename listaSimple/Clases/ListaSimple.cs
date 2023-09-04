namespace Clases
{

    public class ListaSimple
    {
        //methods
        //insertar [x]
        //mostrar [x]
        //eliminar
        //buscar
        public Nodo primero = null;

        public void insertar(Persona elemento)
        {
            Nodo temporal = primero;
            Nodo nuevo = new Nodo();
            nuevo.value = elemento;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                while (temporal.sig != null)
                {
                    temporal = temporal.sig;
                }
                temporal.sig = nuevo;
            }
        }

        public void mostrar()
        {
            Nodo temporal = primero;
            while (temporal != null)
            {
                //imprimir
                Console.Write("\n=>");
                Console.Write(temporal.value.ToString());
                temporal = temporal.sig;
            }
            //mensaje
        }

        //buscar
        public void buscar(int dni)
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (dni == temp.value.dni)
                {
                    Console.WriteLine("Encontado!!");
                    return;
                }
                temp = temp.sig;
            }
            Console.WriteLine("No encontrado");
        }
        //eliminar
        public void eliminar(int dni)
        {
            Nodo temp = primero;
            Nodo ant = null;
            while (temp != null)
            {
                if (dni == temp.value.dni)
                {
                    //PROCESO DE ELIMINAR
                    if (temp == primero)
                    {
                        //eliminar el primero
                        primero = primero.sig;
                    }
                    else
                    {
                        //eliminar a cualquiera
                        ant.sig = temp.sig;
                    }
                    return;
                }
                ant = temp;
                temp = temp.sig;
            }
            Console.WriteLine("No encontrado");
        }
    }
}


