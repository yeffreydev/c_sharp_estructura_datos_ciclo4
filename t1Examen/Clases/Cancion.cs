namespace Clases;
public class Cancion
{
    public string nombre;
    public string anoLanzamiento;
    public string artista;
    public string album;

    public Cancion(string nombre, string anoLanzamiento, string artista, string album)
    {
        this.nombre = nombre;
        this.anoLanzamiento = anoLanzamiento;
        this.artista = artista;
        this.album = album;
    }
    public override string ToString()
    {
        return "Nombre: " + nombre + ", Año de lanzamiento: " + anoLanzamiento + ", Artista: " + artista + ", Album: " + album;
    }
}