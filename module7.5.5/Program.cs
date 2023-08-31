using System;

/// <summary>
/// Измените класс Obj так, чтобы статические поля инициализировались в статическом конструкторе:
///     class Obj 
///     {
///     public string Name;
///     public string Description;
/// 
///     public static string Parent = "System.Object";
///     public static int DaysInWeek = 7;
///     public static int MaxValue = 2000;
///     }
/// </summary>
namespace module7._5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
}
