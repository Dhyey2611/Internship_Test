using Microsoft.AspNetCore.Mvc;


namespace Internship_Test.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }
    }
}