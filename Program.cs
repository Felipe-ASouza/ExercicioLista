using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered? "); //Quantos funcionários serão cadastrados?
            int n = int.Parse(Console.ReadLine());
            
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: "); 
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            
            Console.Write("Enter the employee id that will h ave salary increase: "); //Informe o ID do funcionário que terá aumento salarial
            int searchID = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchID); //Verifica se o ID informado existe na lista de funcionários cadastrados.
            if (emp != null) //se o ID do funcionário nao for null (Se o funcionário existir)
            {
                Console.Write("Enter the percentage: "); //entre com a porcentagem
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porcentagem);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This id does not exist!");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("Update list of Employees");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
            

        }
    }
}