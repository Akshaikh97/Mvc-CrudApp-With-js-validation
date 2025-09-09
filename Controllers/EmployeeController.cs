using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project3._2.Models;

namespace Project3._2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Context context;
        public EmployeeController(Context _context)
        {
            context = _context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var states = context.State?.ToList();
            ViewBag.States = states;
            return View(new Employee());
        }
        [HttpPost]
        public JsonResult Save(Employee employee)
        {
            if (employee.Id == 0)
            {
                context.Employee?.Add(employee);
                context.SaveChanges();
                return Json(new { success = true, message = "Employee saveed successfully" });
            }
            else
            {
                var existing = context.Employee?.Find(employee.Id);
                if (existing != null)
                {
                    existing.Name = employee.Name;
                    existing.Email = employee.Email;
                    existing.Gender = employee.Gender;
                    existing.StateId = employee.StateId;
                    existing.CityId = employee.CityId;
                    existing.IsActive = employee.IsActive;

                    context.Employee?.Update(existing);
                    context.SaveChanges();
                    return Json(new { success = true, message = "Employee update successfully" });
                }
                else
                {
                    return Json(new { success = true, message = "Employee not found" });
                }
            }
        }
        [HttpGet]
        public JsonResult GetCitiesById(int stateId)
        {
            var cities = context.City?
                .Where(c => c.StateId == stateId)
                .Select(c => new
                {
                    c.Id,
                    c.Name
                }).ToList();
            return Json(cities);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var data = context.Employee?
                .Include(e => e.State)
                .Include(e => e.City)
                .Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Email,
                    e.Gender,
                    StateName = e.State.Name,
                    CityName = e.City.Name,
                    IsActive = e.IsActive,
                    StatusText = e.IsActive == true ? "Active" : "Inactive"
                }).ToList();
            return Json(data);
        }
        [HttpGet]
        public IActionResult GetById(int Id)
        {
            var emp = context.Employee?.Find(Id);
            if (emp != null)
            {
                var cities = context.City?
                    .Where(c => c.StateId == emp.StateId)
                    .Select(c => new
                    {
                        c.Id,
                        c.Name
                    }).ToList();

                return Json(new
                {
                    employee = new
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        Email = emp.Email,
                        Gender = emp.Gender,
                        StateId = emp.StateId,
                        CityId = emp.CityId,
                        IsActive = emp.IsActive,
                        StatusText = emp.IsActive == true ? "Active" : "Inactive"
                    },
                    cities = cities
                });
            }
            return Json(null);
        }
    }
}
