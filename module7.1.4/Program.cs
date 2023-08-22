using System;

namespace module7._1._4
{
    /// <summary>
    /// Для следующего класса Employee создайте 2 наследника: ProjectManager и Developer.
    /// Класс ProjectManager должен содержать строковое поле ProjectName, а класс Developer — строковое поле ProgrammingLanguage
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManager : Employee
    {
        public string ProjectName;
    }
    class Developer : Employee
    {
        public string ProgrammingLanguage;
    }
}
