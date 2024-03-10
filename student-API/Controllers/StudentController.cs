using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using student_API.Models;

namespace student_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            List<Student> lstStudents=new List<Student>(){
                new Student(){Id=1, Name="Armaan"},
                new Student(){Id=2, Name="Gajal"},
                new Student(){Id=3, Name="Surabhi"},
                new Student(){Id=4, Name="Kajol"},
                new Student(){Id=5, Name="Avneesh"}
            };

            return lstStudents;
        }
    }
}