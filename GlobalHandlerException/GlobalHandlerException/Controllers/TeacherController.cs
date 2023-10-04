using GlobalHandlerException.CustomExceptions;
using GlobalHandlerException.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalHandlerException.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        /// <summary>
        /// Get Teacher by Id
        /// </summary>
        /// <returns>Single Teacher</returns>
        [HttpGet("{id}", Name = "GetTeacherById")]
        public async Task<ActionResult> GetTeacherById(int id)
        {
            var service = new TeacherService();
            var response = service.GetTeacherById(id);

            if (response == null)
                throw new NotFoundException("Teacher not found!");

            return Ok(response);
        }
    }
}
