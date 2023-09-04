namespace Clases;
public class Persona
{
    public int dni;
    public string nombre;
    public string appellido;
    public int edad;
    public Persona(int dni, string nombre, string apellido, int edad)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.appellido = apellido;
        this.edad = edad;
    }
    //overwrite toSting method
    public override string ToString()
    {
        return $"DNI: {this.dni}\nNombre: {this.nombre}\nApellido: {this.appellido}\nEdad: {this.edad}";
    }

}
