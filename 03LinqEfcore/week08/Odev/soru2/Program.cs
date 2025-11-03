using soru2.Data;
using soru2.Data.Concrete.EfCore;
using soru2.Entity;

namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        var context = new CompanyContext();
        var departmentRepository = new DepartmenRepository(context);
        var employeeRepository = new EmployeeRepository(context);

        #region Veri ekleme 1.Şekil
        // İStersek önce departmanı tanımlar sonra çalışanları verebiliriz istersek her ikisinide aynı anda tanımlayabilirz yazım tercihi sana kalmış 
        var department1 = new Department // department1 nesnesi department clasına eklendi
        {
            Name = "Software"

        };

        departmentRepository.Add(department1); // department1 adlı nesneyi Repoya ekledik ve ıd'leri birbirine bağladık 
        Console.WriteLine("1. Software Departmantı Eklendi ");

        //1.Çalışan Tanımlama
        var employe1 = new Employee
        {
            FullName = "Samet Ece",
            Position = "Developer",
            Salary = 100000,
            DepartmentId = department1.Id //1.Departmana eklendi

        };
        employeeRepository.Add(employe1); // employe1 adlı nesneyi employeeReposity ye ekle Yani EmployeeRepository'e
        Console.WriteLine("1.Çalışan Eklendi");

        //2.Çalışan

        var employe2 = new Employee
        {
            FullName = "Selin Ece",
            Position = "Developer",
            Salary = 150000,
            DepartmentId = department1.Id  //1.Departmana eklendi
        };
        employeeRepository.Add(employe2);
        Console.WriteLine("2.Çalışan Eklendi");


        #endregion

        #region Veri Ekleme 2. Şekil
        // departmanı tanımla içine çalışanı ve efcore idlerini otomatik olarak bağlayacak
        var department2 = new Department
        {
            Name = "Accounting",
            Employees = new List<Employee>
           {
               new Employee {FullName="ali" , Position="Muhasebe", Salary=20000},
               new Employee {FullName="veli" , Position="Muhasebe", Salary=25000}

           }
        };
        departmentRepository.Add(department2);
        Console.WriteLine("2.Departman Accounting Oluşturuldu Ve içerisin de 2 kişi çalışıyor.");

        var department3 = new Department
        {
            Name = "Human Resouces",
            Employees = new List<Employee>
            {
                new Employee {FullName="ayşe",Position="İk",Salary=30000},
                new Employee {FullName="ayşe",Position="İk",Salary=30000}

           }
        };
        departmentRepository.Add(department3);
        Console.WriteLine("3.Departman Human Resource Oluşturuldu Ve içerisin de 2 kişi çalışıyor.");


        #endregion


        #region Projeksiyon ile listeleme

        decimal minSalary = 100000;
        var highPaidSoftwareEmployees = employeeRepository.GetHighSalarySoftwareEmployees(minSalary);

        Console.WriteLine($"Software departmanında maaşı {minSalary}₺ üzeri çalışanlar:");
        foreach (var e in highPaidSoftwareEmployees)
        {
            Console.WriteLine($"{e.FullName} - {e.Position}");
        }


        #endregion


        #region Veri Silme

        int employeeIdToDelete = 3; // örnek Id



        //  Çalışanı bul
        var employee = employeeRepository.GetById(employeeIdToDelete);


        if (employee != null)
        {
            //  Silme işlemini bildir ve kaydet
            employeeRepository.Delete(employeeIdToDelete);


            Console.WriteLine($"Çalışan {employee.FullName} işten çıkarıldı ve veritabanından silindi.");
        }
        else
        {
            Console.WriteLine("Çalışan bulunamadı.");


        }




        #endregion







    }
       
    }

