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

        public void eliminar() { }
    }
}


