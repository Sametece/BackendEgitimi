using ŞirketDepartmanVeÇalışanYönetimi.Data;
using ŞirketDepartmanVeÇalışanYönetimi.Entity;

namespace ŞirketDepartmanVeÇalışanYönetimi;

class Program
{
    static void Main(string[] args)
    {

        var context = new CompanyContext();

        #region Veri Ekleme


        if (!context.Departments.Any())
        {
            var softwareDept = new Department
            {
                DepartmentName = "Software",
                Employees = new List<Employee>
                {
                  new Employee {FullName = "Samet Ece",position = "Developer", Salary =80000},
                  new Employee {FullName = "Selin Ece",position = "Developer", Salary =90000},
                  new Employee {FullName = "Naz Ece",position = "Developer", Salary =100000},

                }
            };

            context.Departments.Add(softwareDept);
            context.SaveChanges();
            Console.WriteLine("Developerlar Hazır....");

            var accountDept = new Department
            {
                DepartmentName = "Accouting",
                Employees = new List<Employee>
                {
                    new Employee {FullName = "Ali veli", position = "Muhasebe",Salary = 30000},
                    new Employee {FullName = "Ali kaya", position = "Muhasebe",Salary = 40000},
                    new Employee {FullName = "Mehmet Yılmaz", position = "Muhasebe",Salary = 50000},

                }
            };

            context.Departments.Add(accountDept);
            context.SaveChanges();
            Console.WriteLine("Muhasebeciler Hazır....");

            var HumanDept = new Department
            {
                DepartmentName = "Human Resources",
                Employees = new List<Employee>
                {
                    new Employee {FullName="Ayşe Taş",position="IK",Salary=25000},
                    new Employee {FullName="Ayşen ince",position="IK",Salary=35000},
                    new Employee {FullName="Sultan Taş",position="IK",Salary=45000}
                }
            };

            context.Departments.Add(HumanDept);
            context.SaveChanges();
            Console.WriteLine("İnsan Kaynakları Hazır....");

        }
        else
        {
            Console.WriteLine("Departmanlar Zaten mevcut Tekrar eklenmedi");
        }
        #endregion

       #region Veri Sorgulama
        
       #endregion

    }
}
