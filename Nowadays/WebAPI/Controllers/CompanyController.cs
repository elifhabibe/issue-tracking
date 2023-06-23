using Business.Services.Abstract;
using Business.Services.Concrete;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        ICompanyService _companyService = new CompanyService();

        [HttpGet("company")]
        public IActionResult GetCompany(int id)
        {
            var company = _companyService.GetCompany(id);
            return Ok(company);
        }
        [HttpGet("companies")]
        public IActionResult GetAllCompany()
        {
            var companies = _companyService.GetAll();
            return Ok(companies);
        }
        [HttpPost("add")]
        public IActionResult AddCompany(Company company)
        {
            var result = _companyService.Add(company);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult UpdateCompany(Company company)
        {
            var result = _companyService.Update(company);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult DeleteCompany(int id)
        {
            var result = _companyService.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
