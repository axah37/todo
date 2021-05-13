using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System;

namespace todoApp.Controllers
{
    public class TodoController:Controller
    {
        [Route("")]
        // GET: /
        public IActionResult Index(){
            return View();
        }

        [Route("/create")]
        // GET: /Todo/create
        public IActionResult CreateTodo(){
            return View();
        }

        public IActionResult ProcessCreateTodo(Todo todo){
            Console.WriteLine(todo.Id);
            Console.WriteLine(todo.description);
            Console.WriteLine(todo.done);

            saveChanges(todo); // Done Async so not blocking, order doesn't matter

            Console.WriteLine("After save");

            return View("~/Views/Todo/Index.cshtml");
        }

        async public void saveChanges(Todo todo){
            using(DbContext db = new TodoContext()){
                db.Add(todo);
                await db.SaveChangesAsync();
                Console.WriteLine("Done Writing to db");
            }
        }
    }
}