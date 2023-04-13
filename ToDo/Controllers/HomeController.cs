using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private ToDoContext _toDoContext;

    public HomeController(ILogger<HomeController> logger,ToDoContext toDoContext)
    {
        _logger = logger;
        _toDoContext = toDoContext;
    }

    public IActionResult Index()
    {
     
       ViewBag.TodoList = _toDoContext.ToDos.Where(c => c.Completed == false).ToList();
   
       
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {

        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

