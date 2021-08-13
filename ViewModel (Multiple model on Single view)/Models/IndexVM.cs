using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel__Multiple_model_on_Single_view_.Models
{
    public class IndexVM
    {
        public List<Employee> Employees { get; set; }
        public List<Student> Student { get; set; }
    }
}   