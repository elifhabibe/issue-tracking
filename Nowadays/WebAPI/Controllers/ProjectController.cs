using Business.Services.Abstract;
using Business.Services.Concrete;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        IProjectService _projectService = new ProjectService();
        [HttpGet("project")]
        public IActionResult GetProject(int id)
        {
            var project = _projectService.GetProject(id);
            return Ok(project);
        }
        [HttpGet("projects")]
        public IActionResult GetAllProject()
        {
            var projects = _projectService.GetAll();
            return Ok(projects);
        }
        [HttpPost("add")]
        public IActionResult AddProject(Project project)
        {
            var result = _projectService.Add(project);
            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult UpdateProject(Project project)
        {
            var result = _projectService.Update(project);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("delete")]
        public IActionResult DeleteProject(int id)
        {
            var result = _projectService.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
