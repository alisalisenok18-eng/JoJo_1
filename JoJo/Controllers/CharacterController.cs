using JoJo.Data;
using Microsoft.AspNetCore.Mvc;

namespace JoJo.Controllers;

public class CharacterController : Controller
{
    private readonly Repository _repository;

    public CharacterController(Repository repository)
    {
        _repository = repository;
    }

    // Табличный список
    public IActionResult List()
    {
        return View(_repository.GetAll());
    }

    // Детальная страница персонажа
    public IActionResult Details(int id)
    {
        var character = _repository.GetAll().FirstOrDefault(c => c.Id == id);
        if (character == null) return NotFound();
        return View(character);
    }
}