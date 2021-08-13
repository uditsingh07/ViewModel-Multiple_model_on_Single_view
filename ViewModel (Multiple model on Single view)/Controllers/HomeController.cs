using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel__Multiple_model_on_Single_view_;
using ViewModel__Multiple_model_on_Single_view_.Models;

namespace ViewModel__Multiple_model_on_Single_view_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var student = Getstudnets();
            var employee = GetEmployees();

            IndexVM model = new IndexVM();
            model.Student = student;
            model.Employees = employee;
            return View(model);
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(){Id=1,Name="Udit",Email="udit@gmail.com"},
                new Employee(){Id=2,Name="Singh",Email="singh@gmail.com"}
            };
        }
        
        private List<Student> Getstudnets()
        {
            return new List<Student>
            {
                new Student(){Id=1,Name="John",Email="John@gmail.com"},
                new Student(){Id=2,Name="Doe",Email="doe@gmail.com"}
            };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}