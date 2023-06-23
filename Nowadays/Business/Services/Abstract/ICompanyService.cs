using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
    public interface ICompanyService
    {
        Company GetCompany(int id);
        List<Company> GetAll();
        Company Add(Company company);
        bool Update(Company company);
        bool Delete(int id);
    }
}
