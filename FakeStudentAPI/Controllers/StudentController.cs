using FakeStudentAPI.Model;
using FakeStudentAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FakeStudentAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private StudentService Students;

    public StudentController(StudentService students)
    {
        Students = students;
    }

    [HttpGet]
    public Student[] Get()
    {
        return (Students.Students);
    }
}