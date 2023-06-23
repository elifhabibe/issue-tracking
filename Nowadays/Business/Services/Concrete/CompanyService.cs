using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concrete
{
    public class CompanyService : ICompanyService
    {
        ICompanyDal _companyDal = new CompanyDal();
        public Company Add(Company company)
        {
            return _companyDal.Add(company);
        }

        public bool Delete(int id)
        {
            return _companyDal.Delete(new Company() { Id = id});
        }

        public List<Company> GetAll()
        {
            return _companyDal.GetAll();
        }

        public Company GetCompany(int id)
        {
            return _companyDal.Get(x => x.Id == id);
        }

        public bool Update(Company company)
        {
            return _companyDal.Update(company);
        }
    }
}
