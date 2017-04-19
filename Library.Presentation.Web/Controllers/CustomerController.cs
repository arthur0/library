using AutoMapper;
using Library.Application.Interfaces;
using Library.Domain.Entities;
using Library.Presentation.Web.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Library.Presentation.Web.Controllers
{

    public class CustomerController : Controller
    {
        private readonly ICustomerAppService _customerApp;

        public CustomerController(ICustomerAppService customerApp)
        {
            _customerApp = customerApp;
        }
        
        // GET: Customer
        public ActionResult Index()
        {
            var customerViewModel = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(_customerApp.GetAll());
            return View(customerViewModel);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            var customer = _customerApp.GetByID(id);
            var customerViewModel = Mapper.Map<Customer, CustomerViewModel>(customer);
            return View(customerViewModel);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                var customerDomain = Mapper.Map<CustomerViewModel, Customer>(customer);
                _customerApp.Add(customerDomain);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerViewModel customer)
        {
            if (ModelState.IsValid)
            {
                var customerDomain = Mapper.Map<CustomerViewModel, Customer>(customer);
                _customerApp.Update(customerDomain);
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
