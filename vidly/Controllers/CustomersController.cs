using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.ViewModels;
using vidly.Models;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            var Customers = _context.Customers.Include(c => c.MembershipType).ToList();
            
            return View(Customers);
        }

        [Route("Customers/{id}")]
        public ActionResult Details(int id)
        {
            var customers = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(a => a.Id == id);
            
            if (customers == null)
                return HttpNotFound();


            return View(customers);
        }
    }
    
}