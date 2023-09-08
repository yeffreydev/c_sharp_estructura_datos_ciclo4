using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDobleCircular ldc = new ListaDobleCircular();




            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Agregar Canciones");
                Console.WriteLine("2. Mostrar Canciones Inicio a fin");
                Console.WriteLine("3. Mostrar Canciones Fin a Inicio");
                Console.WriteLine("4. Buscar Cancion por nombre o Artista");
                Console.WriteLine("5. Eliminar Cancion por nombre");
                Console.WriteLine("6. Reproducir Cancion");

                Console.WriteLine("0.Salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("SALIENDO...");
                        break;
                    case 1:
                        Console.Clear();
                        AgregarCanciones(ldc);
                        Console.WriteLine("Canciones agregadas");
                        break;
                    case 2:
                        Console.Clear();
                        ldc.mostrarPrimeroAUltimo();
                        break;
                    case 3:
                        Console.Clear();
                        ldc.mostrarUltimoAPrimero();
                        break;
                    case 4:
                        Console.Clear();
                        string nombreOArtista = Console.ReadLine();
                        ldc.buscarPorNombreOArtista(nombreOArtista);
                        break;
                    case 5:
                        Console.Clear();
                        string nombre = Console.ReadLine();
                        ldc.eliminarCancionPorNombre(nombre);
                        break;
                    case 6:
                        Console.Clear();
                        ldc.reproducir();
                        break;


                    default:
                        Console.WriteLine("OPCION INCORRECTA");
                        break;
                }
                Console.ReadKey();
            } while (op != 0);

            Console.ReadKey();
        }
        public static void AgregarCanciones(ListaDobleCircular ldc)
        {
            Cancion c1 = new Cancion("Al Callao", "2023", "Rauw Alejandro", "Playa Saturno");
            Cancion c2 = new Cancion("Pienso en ti", "2023", "Chechito", "Pienso en ti");
            Cancion c3 = new Cancion("Moscow Mule", "2022", "Bad Bunny", "Un verano sin ti");
            Cancion c4 = new Cancion("Riri", "2022", "Young Miko", " Trap kitty");
            Cancion c5 = new Cancion("Tusa", "2020", "Karol G", " Tusa");
            Cancion c6 = new Cancion("Traicionera", "2016", "Sebastian Yatra", " Mantra");
            Cancion c7 = new Cancion("Sensacion Del bloque", "2015", "De la Ghetto", " Reggeton Rulers");
            Cancion c8 = new Cancion("Es un secreto", "2015", "Plan B", "House of pleasure");
            Cancion c9 = new Cancion("Tu foto", "2018", "Ozuna", " Odisea");
            Cancion c10 = new Cancion("Tusa", "2020", "Karol G", " Tusa");


            ldc.insertarUltimo(c1);
            ldc.insertarUltimo(c2);
            ldc.insertarUltimo(c3);
            ldc.insertarUltimo(c4);
            ldc.insertarUltimo(c5);
            ldc.insertarUltimo(c6);
            ldc.insertarUltimo(c7);
            ldc.insertarUltimo(c8);
            ldc.insertarUltimo(c9);
            ldc.insertarUltimo(c10);

        }
    }
}
