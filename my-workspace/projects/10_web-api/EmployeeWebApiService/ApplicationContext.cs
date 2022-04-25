using EmployeeWebApiService.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApiService
{
  public class ApplicationContext : DbContext
  {
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }
  }
}
