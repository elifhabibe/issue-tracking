using Business.Services.Abstract;
using Business.Services.Concrete;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IssueController : Controller
    {
        IIssueService _issueService = new IssueService();

        [HttpGet("issue")]
        public IActionResult GetIssue(int id)
        {
            var issue = _issueService.GetIssue(id);
            return Ok(issue);
        }
        [HttpGet("issues")]
        public IActionResult GetAllIssue()
        {
            var issues = _issueService.GetAll();
            return Ok(issues);
        }
        [HttpPost("add")]
        public IActionResult AddIssue(Issue issue)
        {
            var result = _issueService.Add(issue);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult UpdateIssue(Issue issue)
        {
            var result = _issueService.Update(issue);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult DeleteIssue(int id)
        {
            var result = _issueService.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
