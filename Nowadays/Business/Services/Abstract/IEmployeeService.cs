using Entity.Models;

namespace Business.Services.Abstract
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int id);
        List<Employee> GetAll();
        Employee Add(Employee employee);
        bool Update(Employee employee);
        bool Delete(int Id);
    }
}
