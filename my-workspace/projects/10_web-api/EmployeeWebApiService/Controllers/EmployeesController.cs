using EmployeeWebApiService.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApiService.Controllers
{
  [ApiController]
  public class EmployeesController : ControllerBase
  {
    private readonly ApplicationContext _context;
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger, ApplicationContext context)
    {
      _logger = logger;
      _context = context;
    }
    [Route("/api/employees")]
    [HttpGet]
    public IEnumerable<Employee> Get()
    {
      return _context.Employees.ToList();
    }
    [Route("/api/employees/{code}")]
    [HttpGet]
    public Employee? GetByCode(string code)
    {
      return _context.Employees.Where(e => e.code == code).FirstOrDefault();
    }
  }
}
