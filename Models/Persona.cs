using System.Diagnostics.CodeAnalysis;

namespace MvcMovie.Models;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public Persona()
    {
    }

}
