using System;

/// <summary>
/// Реализуйте класс-обобщение Record, у которого будут два универсальных параметра: 
/// один — для идентификатора записи (Id), другой — для значения записи (Value). 
/// Также в классе реализуйте поле Date типа DateTime.
/// </summary>
namespace module7._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }
}
