using System;

/// <summary>
/// Для класса Obj перегрузите операторы + и -, чтобы результатом работы оператора был новый экземпляр класса Obj, а операции производились над полем Value.
/// </summary>
namespace module7._2._12
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
        public int Value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }
}
