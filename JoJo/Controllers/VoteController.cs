using JoJo.Data;
using Microsoft.AspNetCore.Mvc;

namespace JoJo.Controllers;

public class VoteController : Controller
{
    private readonly Repository _repository;

    public VoteController(Repository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        return View(_repository.GetAll());
    }

    public IActionResult VoteResult()
    {
        // Просто пример данных — "результаты голосования"
        return View(_repository.GetAll());
    }
}