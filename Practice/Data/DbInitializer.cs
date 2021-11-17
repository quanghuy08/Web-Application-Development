using Practice.Models;
using System;
using System.Linq;
namespace Practice.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();


            if (context.Employees.Any())
            {
                return;   
            }

            var employees = new Employees[]
            {
            new Employees{ID="EM001",EmployeeName="John Carter",Department="HR",Salary=3000},
            new Employees{ID="EM002",EmployeeName="Michael Bean",Department="SC",Salary=1300},
            new Employees{ID="EM003",EmployeeName="Jimmy Floy",Department="MD",Salary=2000},
            new Employees{ID="EM004",EmployeeName="Mary Brown",Department="MD",Salary=2000},
            };

            foreach (Employees s in employees)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();

           
        }
    }
}
