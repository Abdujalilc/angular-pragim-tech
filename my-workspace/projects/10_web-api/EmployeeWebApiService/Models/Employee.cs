using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApiService.Models
{
  public class Employee
  {
    [Key]
    public string code { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public decimal annualSalary { get; set; }
    public string dateOfBirth { get; set; }
  }
}
