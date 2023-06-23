using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using Entity.Models;

namespace Business.Services.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeDal _employeeDal = new EmployeeDal();
        public Employee Add(Employee employee)
        {
            return _employeeDal.Add(employee);
        }

        public bool Delete(int Id)
        {
            return _employeeDal.Delete(new Employee() { Id = Id });
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetEmployee(int id)
        {
            return _employeeDal.Get(x=>x.Id == id);
        }

        public bool Update(Employee employee)
        {
            return _employeeDal.Update(employee);
        }
    }
}
