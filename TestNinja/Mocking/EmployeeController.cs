using System.Data.Entity;

namespace TestNinja.Mocking
{
    public class EmployeeController
    {
        private IEmployeeStorage _storage;
        private EmployeeContext _db;

        public EmployeeController(IEmployeeStorage employeeStorage)
        {
            _storage = employeeStorage;
            _db = new EmployeeContext();
        }

        public ActionResult DeleteEmployee(int id)
        {
            _storage.DeleteEmployee(id);
            return RedirectToAction("Employees");
        }

        private ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }
 
    public class RedirectResult : ActionResult { }
    
    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class Employee
    {
    }
}