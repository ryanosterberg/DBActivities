using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeService service = new EmployeeService();

        // GET: Employees
        public ActionResult Index()
        {
            return View(service.GetAllEmployees());
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,hireDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                service.AddEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = service.GetEmployeeById((int)id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = service.GetEmployeeById(id);
            service.DeleteEmployee(employee);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Filtered(int yearsWorked)
        {
            return View("Index", service.GetEmployeeByWorkLength(yearsWorked));
        }
    }
}