using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AreaProject.Areas.HomePage.Controllers
{

    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }



    [Area("HomePage")]
    public class HomePageController : Controller
    {
        private readonly List<Person> _people = new List<Person>
        {
            new Person{ Name = "Patrick", Age = 24, City = "Stockton", Country = "England", PersonID = 1},
            new Person{ Name = "P", Age = 24, City = "Stockton", Country = "England", PersonID = 2},
            new Person{ Name = "A", Age = 24, City = "Stockton", Country = "England", PersonID = 3},
            new Person{ Name = "T", Age = 24, City = "Stockton", Country = "England", PersonID = 4},
            new Person{ Name = "R", Age = 24, City = "Stockton", Country = "England", PersonID = 5},
            new Person{ Name = "Y", Age = 24, City = "Stockton", Country = "England", PersonID = 6},
            new Person{ Name = "K", Age = 24, City = "Stockton", Country = "England", PersonID = 7}
        };


        public IActionResult Index()
        {
            return View(_people);
        }
    }
}