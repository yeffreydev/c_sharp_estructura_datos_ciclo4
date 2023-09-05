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
}
