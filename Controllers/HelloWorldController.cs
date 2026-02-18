using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        ViewData["Mensaje"] = "Hola Sergio, ahora estamos enviando datos dinámicos.";
        return View();
    }

    public IActionResult Saludo(string nombre)
    {
        return Content("Hola " + nombre);
    }

    public IActionResult Saludo1(string id)
    {
        return Content("Hola " + id);
    }

    public IActionResult Saludo2(string id)
    {
        ViewData["Nombre"] = id;
        return View();
    }

    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hola " + name;
        ViewData["NumTimes"] = numTimes;

        return View();
    }

    public IActionResult Perfil()
    {
        Persona persona0 = new Persona
        {
            Nombre = "Sergio Bravo",
            Edad = 42
        };

        var persona1 = new Persona { Nombre = "Sergio Bonito", Edad = 40 };
        var persona = new Persona("Sergio Francisco", 40);

        return View(persona);
    }

}