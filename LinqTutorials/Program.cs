using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task1();
            foreach (var employee in t)
            {
                Console.WriteLine($"Empno: {employee.Empno}, Ename: {employee.Ename}, Job: {employee.Job}, Salary: {employee.Salary}");
            }
            
            var a = LinqTasks.Task2();


            Console.ReadLine();

        }
    }
}
