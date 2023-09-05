namespace Clases
{

    public class ListaSimple
    {
        //===methods
        //insertarInicio [x]
        //insertarFinal [x]
        //mostrar [x]
        //buscarPorDNI [x]
        //buscarPorIndice [x]
        //eliminarPorDni [x]
        //eliminarPorIndice [x]

        public Nodo primero = null;
        public void insertarInicio(Persona persona)
        {
            if (primero == null)
            {
                this.insertarFinal(persona);
                return;
            }
            Nodo nuevo = new Nodo
            {
                value = persona,
                sig = primero
            };
            primero = nuevo;
        }
        public void insertarFinal(Persona elemento)
        {
            Nodo nuevo = new Nodo();
            nuevo.value = elemento;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temporal = primero;
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

        //buscar por dni
        public void buscarPorIndice(int indice)
        {
            Nodo encontrado = null;
            Nodo temp = primero;
            int i = 0;
            while (temp != null)
            {
                if (i == indice)
                {
                    encontrado = temp;
                }
                i++;
                temp = temp.sig;
            }

            if (encontrado != null)
            {
                Console.WriteLine("Elemento encontrado con el indice " + indice);
                return;
            }
            Console.WriteLine("Elemento no encontrado");


        }

        //buscar
        public void buscarPorDni(int dni)
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
        //eliminar persona por indice
        public void eliminarPersonaPorIndice(int indice)
        {
            Nodo temp = primero;
            Nodo ant = null;
            int i = 0;
            while (temp != null)
            {
                if (i == indice)
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
                    Console.WriteLine($"elemento con indice {i} eliminado con exito!!");
                    return;
                }
                i++;
                ant = temp;
                temp = temp.sig;
            }
            Console.WriteLine("No encontrado");
        }
        //eliminar persona por dni
        public void eliminarPorDni(int dni)
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


