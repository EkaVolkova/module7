using System;

/// <summary>
/// Добавьте к схеме классов автомобиля (7.6.2) следующие классы частей автомобиля: Battery, Differential, Wheel. 
/// Также добавьте в класс Car виртуальный обобщённый метод без реализации — ChangePart, который будет принимать один параметр — newPart универсального типа.
/// </summary>
namespace module7._6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Car<T1>
    {
        public T1 Engine = default;
        public virtual void ChangePart<T2>(T2 newPart)
        {

        }
    }
    class ElectricEngine
    {

    }
    class GasEngine
    {

    }
    class Battery
    {

    }
    class Differential
    {

    }
    class Wheel
    {

    }
}
