using System;

/// <summary>
/// Реализуйте в классе BaseClass виртуальный метод Display с типом void и без параметров, который будет выводить сообщение "Метод класса BaseClass" в консоль,
/// а затем переопределите его в DerivedClass, чтобы он выводил сообщение "Метод класса DerivedClass".
/// </summary>
namespace module7._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class BaseClass
        {
            public virtual void Display()
            {
                Console.WriteLine("Метод класса BaseClass");
            }
        }

        class DerivedClass : BaseClass
        {
            public override void Display()
            {
                Console.WriteLine("Метод класса DerivedClass");
            }
        }

    }
}
