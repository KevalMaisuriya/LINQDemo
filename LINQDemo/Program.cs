using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> strList = new List<string>() { "Keval", "Maisuriya" };

            //var methodResult = strList.SelectMany(x => x).ToList();

            //var queryResuy = (from str in strList
            //                  from st in str
            //                  select st).ToList();






            //var dataSource = new List<Employee>
            //{
            //    new Employee(){Id=1, Name="Tom", Email="tom@gmail.com",Programming=new List<string>(){ "C#","Java","PHP"} },
            //    new Employee(){Id=1, Name="Kim", Email="kim@gmail.com",Programming=new List<string>(){ "LINQ","Java","MVC"} },
            //    new Employee(){Id=1, Name="Harry", Email="harry@gmail.com",Programming=new List<string>(){ "C#","SQL","VB"} }
            //};

            //var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

            //var querySyntax = (from emp in dataSource
            //                   from skill in emp.Programming
            //                   select skill).ToList();


            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine("Programming " + item);
            //}

            //var queryResult = (from ds in dataSource
            //                   select ds).ToList();

            //Where in LINQ

            //var dataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var querySyntax = (from number in dataSource
            //                   where number < 5
            //                   select number).ToList() ;

            //var methodSyntax = dataSource.Where(num => num < 5).ToList();
            //foreach(var item in dataSource)
            //{
            //    Console.WriteLine(dataSource);
            //} 



            //Sorting Operator

            //var dataSourceInt = new List<int>() { 5, 7, 8, 9, 3, 6, 2, 1, 4 };

            //var querySyntax = (from num in dataSourceInt
            //                   where num > 7
            //                   orderby num 
            //                   select num).ToList();

            //var methodSyntax = dataSourceInt.Where(num => num < 9).OrderBy(num => num).ToList();

            //foreach(var item in methodSyntax)
            //{
            //    Console.WriteLine(item);
            //}



            //Reverse in LINQ
            //int[] rollNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var mq = rollNums.Reverse();

            //var qs = (from num in rollNums
            //         select num).Reverse();

            //foreach (var item in mq)
            //{
            //    Console.WriteLine(item);
            //}



            // Start Paging using skip and take operators (Pagination)
            //do
            //{
            //    IEnumerable<Student> students = Student.GetAllStudents();

            //    Console.WriteLine("Please Enter the page number between the 1,2,3 and 4");
            //    int pageNumber = 0;

            //    if (int.TryParse(Console.ReadLine(), out pageNumber))
            //    {
            //        if (pageNumber >= 1 && pageNumber <= 4)
            //        {
            //            int pageSize = 3;
            //            IEnumerable<Student> result = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            //            Console.WriteLine();
            //            Console.WriteLine("Displying Page" + pageNumber);
            //            foreach (Student s in result)
            //            {
            //                Console.WriteLine(s.StudentId + "\t" + s.Name + "\t" + s.TotalMarks);
            //            }
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please number must be an integer between 1 and 4");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please number must be an integer between 1 and 4");
            //    }
            //} while (1 == 1);
            // End Paging using skip and take operators (Pagination)


            // Start Group By in Linq
            var employeeGroups = Employee.GetAllEmployees().GroupBy(x => x.Department);

            foreach(var group in employeeGroups)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Count());   
            }

            // End Group By in Linq










            //Console.ReadLine();
        }
    }
}
