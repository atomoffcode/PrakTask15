using System;
using System.Collections.Generic;

namespace PrakTask15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Name="Kamil",SurName="Abdullayev",Salary=999,Artist="Michael Jackson",Song="They Don't Care About Us"},
                new Employee{Name="Rufat",SurName="Aliyev",Salary=1001,Artist="ENIGMA",Song="SADENESSS"}

            };
            string fullname;
            int num;
           
            Func<int, string> func = delegate (int num)
            {
                Console.WriteLine(employees[num].Name + ' ' + employees[num].SurName);
                return fullname = employees[num].Name + ' ' + employees[num].SurName;
            };
            
            
            
            
            
            Predicate<int> predicate = delegate (int num)
            {
                return employees[num].Salary > 1000;
            };
            
            
           
            Action<int> songs = delegate (int num)
            {
                Console.WriteLine(employees[num].Artist + ": " + employees[num].Song);
            };
            

            do
            {
                Console.WriteLine("======================================================================================================");
                Console.WriteLine("1. Siyahidaki iscilerin sayini gostermek");
                Console.WriteLine("2. Siyahiyadaki iscinin adini gostermek");
                Console.WriteLine("3. Siyahiya isci elave etmek");
                Console.WriteLine("4. Siyahidaki iscinin maasinin 1000 kecdiyini yoxlamaq");
                Console.WriteLine("5. Siyahidaki iscinin secdiyi mugenni ve mahnisini gostermek");
                Console.WriteLine("======================================================================================================");


                string answerStr = Console.ReadLine();
                double answerNum;
                while (!double.TryParse(answerStr, out answerNum) || answerNum < 1 || answerNum > 5)
                {
                    Console.WriteLine("Duzgun secim edin!");
                    answerStr = Console.ReadLine();
                }
                Console.Clear();
                switch (answerNum)
                {
                    case 1:
                        Console.WriteLine("======================================================================================================");
                        Console.WriteLine($"(Hazirki isci sayi:{ employees.Count})");
                        break;
                    case 2:
                        Console.WriteLine("======================================================================================================");
                        Console.WriteLine($"Iscinin nomresini daxil edin (Hazirki isci sayi:{employees.Count})");
                        num = int.Parse(Console.ReadLine()) - 1;
                        func(num);
                        
                        break;
                    case 3:
                        Console.WriteLine("======================================================================================================");
                        AddEmp(employees);
                        break;
                    case 4:
                        Console.WriteLine("======================================================================================================");
                        Console.WriteLine($"Iscinin nomresini daxil edin (Hazirki isci sayi:{employees.Count})");
                        num = int.Parse(Console.ReadLine()) - 1;
                        predicate(num);
                        Console.WriteLine(predicate(num));
                        
                        break;
                    case 5:
                        Console.WriteLine("======================================================================================================");
                        Console.WriteLine($"Iscinin nomresini daxil edin (Hazirki isci sayi:{employees.Count})");
                        num = int.Parse(Console.ReadLine()) - 1;
                        songs(num);
                        
                        break;


                }

            } while (true);





        }
        static void AddEmp(List<Employee> employees)
        {
            Employee emp = new Employee();
            Console.WriteLine("Isci adini daxil edin");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Isci soyadini daxil edin");
            emp.SurName = Console.ReadLine();
            Console.WriteLine("Iscinin maasini daxil edin");
            emp.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Iscinin sevdiyi mugennini daxil edin");
            emp.Artist = Console.ReadLine();
            Console.WriteLine("Iscinin sevdiyi mahnini daxil edin");
            emp.Song = Console.ReadLine();

            employees.Add(emp);

        }
        static string ShowFullName(List<Employee> employees)
        {
            string fullname;
            int num;
            Console.WriteLine($"Iscinin nomresini daxil edin (Hazirki isci sayi:{employees.Count})");
            num=int.Parse(Console.ReadLine())-1;
            Func<int,string> func = delegate (int num)
            {
                Console.WriteLine(employees[num].Name + ' ' + employees[num].SurName);
                return fullname = employees[num].Name + ' ' + employees[num].SurName;
            };
            fullname=func(num);
            return fullname;
            



        }
        static void CheckSalary(List<Employee> employees)
        {
            int num;
            Console.WriteLine($"Iscinin nomresini daxil edin (Hazirki isci sayi:{employees.Count})");
            num = int.Parse(Console.ReadLine())-1;
            //int s=employees[num].Salary
            Predicate<int> predicate = delegate (int num)
            {
                return employees[num].Salary > 1000;
            };
            Console.WriteLine(predicate(num));


        }
        static void PrintSongs(List<Employee> employees)
        {
            int num;
            Console.WriteLine($"Iscinin nomresini daxil edin (Hazirki isci sayi:{employees.Count})");
            num = int.Parse(Console.ReadLine())-1;
            Action<int> songs = delegate (int num)
              {
                  Console.WriteLine(employees[num].Artist + ": " + employees[num].Song);
              };
            songs(num);
        }
        
        
    }
}
