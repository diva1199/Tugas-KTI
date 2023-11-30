using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApp.Models;
using MyWebApp.Repositories;

namespace MyWebApp.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentRepository _studentRepository;

        public StudentsController(ILogger<StudentsController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
           //Student student = new Student()
           // {
            //    StudentId = 1,
            //    Name = "JasseDoe",
             //   Email = "Jasse@gmail.com",
             //   BirthDate = new DateOnly (1999,10,5) 
           // };


            //ViewData["Message"] = "Hello from the StudentsController!";
            ViewData["Date"] = DateTime.Now;
            //ViewBag.Pesan = "Hello from view bag";
            ViewData["Title"] = "student List";
            var models = _studentRepository.GetAll();
            return View(models);
        }
        public IActionResult Description()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}