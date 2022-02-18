using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplisonu1.Models;

namespace WebApplisonu1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbcontext dbcontext;
        public EmployeeController(ApplicationDbcontext _dbContext)
        {

            dbcontext = _dbContext;  
        }

        public IActionResult Index()
        
            
            {
                var departments = dbcontext.Departments.ToList();
                return View(departments);
            }

        public IActionResult EmloyeeList(int id)
        {
            var employee = dbcontext.Employees.Where(e => e.Department.id==id);
            return View(employee);
            
                          
            
      
        }
            
        }
    }

