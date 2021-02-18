    using System.Collections.Generic;
    using TestApplication.Models;
    using Microsoft.AspNetCore.Mvc;

    namespace TestApplication.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class StudentsController : ControllerBase
        {
            public static List<Students> GetStudents()
            {
                List<Students> students = new List<Students>();
                students.Add(new Students(){Id = 1, FirstName = "bob", LastName="bub", Age=13});
                return students;
            }

            [HttpGet]
            public IEnumerable<Students> GetStudents_List()
            {
                return GetStudents();
            }
        }
    }