using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplisonu1.Models;
namespace WebApplisonu1.Controllers
{
 public class CustmoreController : Controller
    {

        private ApplicationDbcontext dbContext;

        public CustmoreController(ApplicationDbcontext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            var products = dbContext.Custmores.ToList();
            return View(products);
        }
            public IActionResult create()
            {
                return View();
            }
        [HttpPost]
        public IActionResult create(Custmore custmore)
        {
            if (ModelState.IsValid)
            {
                dbContext.Custmores.Add(custmore);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(custmore);
            }
        }
        public IActionResult Delete(int id)
        {
            var Custmore = dbContext.Custmores.SingleOrDefault(e => e.id == id);
            dbContext.Custmores.Remove(Custmore);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
           var Custmore = dbContext.Custmores.SingleOrDefault(e => e.id ==id);
            return View();
        }
        [HttpPost]
        public IActionResult Update(Custmore custmore)
        { 
            dbContext.Custmores.Update(custmore);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }

        }
    
