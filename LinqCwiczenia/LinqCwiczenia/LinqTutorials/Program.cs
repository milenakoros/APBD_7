using System;
using System.Collections.Generic;
using LinqTutorials;
using LinqTutorials.Models;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All emps");
            var emps = LinqTasks.GetAllEmps();
            foreach (var value in emps)
            {
                Console.WriteLine(value.ToString());
            }
            
            Console.WriteLine("\nSELECT * FROM Emps WHERE Job = \"Backend programmer\"");
            var t1 = LinqTasks.Task1();
            foreach (var value in t1)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nSELECT * FROM Emps Job = \"Frontend programmer\" AND Salary>1000 ORDER BY Ename DESC;");
            var t2 = LinqTasks.Task2();
            foreach (var value in t2)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nSELECT MAX(Salary) FROM Emps");
            var t3 = LinqTasks.Task3();
            Console.WriteLine(t3);
            
            Console.WriteLine("\nSELECT * FROM Emps WHERE Salary=(SELECT MAX(Salary) FROM Emps)");
            var t4 = LinqTasks.Task4();
            foreach (var value in t4)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nSELECT ename AS Nazwisko, job AS Praca FROM Emps;");
            var t5 = LinqTasks.Task5();
            foreach (var value in t5)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nSELECT Emps.Ename, Emps.Job, Depts.Dname FROM Emps\nINNER JOIN Depts ON Emps.Deptno=Depts.Deptno\nRezultat: Złączenie kolekcji Emps i Depts.");
            var t6 = LinqTasks.Task6();
            foreach (var value in t6)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nSELECT Job AS Praca, COUNT(1) LiczbaPracownikow FROM Emps GROUP BY Job;");
            var t7 = LinqTasks.Task7();
            foreach (var value in t7)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nReturn the value \"true\" if at least one of the elements in the collection works as a \"Backend programmer\".");
            var t8 = LinqTasks.Task8();
            Console.WriteLine(t8);
            
            Console.WriteLine("\nSELECT TOP 1 * FROM Emp WHERE Job=\"Frontend programmer\" ORDER BY HireDate DESC;");
            var t9 = LinqTasks.Task9();
            Console.WriteLine(t9);
            
            Console.WriteLine("\nTask10\nSELECT Ename, Job, Hiredate FROM Emps\nUNION\nSELECT \"Brak wartości\", null, null;");
            var t10 = LinqTasks.Task10();
            foreach (var value in t10)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nTask11\nUsing LINQ, retrieve employees divided by departments.");
            var t11 = LinqTasks.Task11();
            foreach (var value in t11)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nReturn only those employees who have at least 1 direct subordinate.");
            var t12 = LinqTasks.Task12();
            foreach (var value in t12)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nFind the number that appears an odd number of times in the array of ints.");
            var arr = new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            var t13 = LinqTasks.Task13(arr);
            Console.WriteLine(t13);
            
            Console.WriteLine("\nReturn only those departments that have exactly 5 employees or no employees at all.");
            var t14 = LinqTasks.Task14();
            foreach (var value in t14)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nSELECT Job AS Praca, COUNT(1) LiczbaPracownikow FROM Emps\nWHERE Job LIKE '%A%'\nGROUP BY Job\nHAVING COUNT(*)>2\nORDER BY COUNT(*) DESC;");
            var t15 = LinqTasks.Task15();
            foreach (var value in t15)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nSELECT * FROM Emps, Depts;");
            var t16 = LinqTasks.Task16();
            foreach (var value in t16)
            {
                Console.WriteLine(value);
            }
            
            Console.WriteLine("\nSELECT * FROM Emps, Depts;");
            var t17 = LinqTasks.Task17();
            foreach (var value in t17)
            {
                Console.WriteLine(value);
            }
        }
    }
}
