using System;

/// <summary>
/// Измените свойство Counter так, чтобы его можно было переопределить в классе DerivedClass. 
/// Переопределите данное свойство, ограничив занесения в него чисел меньше 0.
/// </summary>
namespace module7._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter
        {
            get => counter;
            set
            {
                if (value >= 0)
                    counter = value;
            }
        }
    }
}
