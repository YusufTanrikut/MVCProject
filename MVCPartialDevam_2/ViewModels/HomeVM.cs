using MVCPartialDevam_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPartialDevam_2.ViewModels
{
    public class HomeVM
    {
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}