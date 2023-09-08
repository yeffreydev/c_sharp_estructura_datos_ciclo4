namespace Clases;

public class Persona
{
    public int codigo;
    public string nombre;
    public int edad;

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
        generateCode();
    }
    private void generateCode()
    {
        Random r = new Random();
        codigo = r.Next(1001, 9999);
    }

    public override string ToString()
    {
        return $"Codigo: {codigo} - Nombre: {nombre} - Edad: {edad}";
    }
}