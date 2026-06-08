using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Boletim.Models;

namespace Boletim.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
    public IActionResult Boletim()
    {
        List<string> disciplinas = new List<string>()
        {
            "Internet das Coisas",
            "Projeto de Extensão",
            "Programação Front-End",
            "Arquitetura de Computadores",
            "Desenvolvimento Web"
        };

        // Mudamos para números inteiros sem vírgula
        List<int> notas = new List<int>()
        {
            10, 
            7,  
            6,  
            4,  
            8   
        };

        ViewBag.Materias = disciplinas;
        ViewBag.Notas = notas;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}