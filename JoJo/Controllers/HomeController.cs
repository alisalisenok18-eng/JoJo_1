using JoJo.Data;
using Microsoft.AspNetCore.Mvc;

namespace JoJo.Controllers;

public class HomeController : Controller
{
    private readonly Repository _repository;

    public HomeController(Repository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        var characters = _repository.GetAll();
        return View(characters);
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
}