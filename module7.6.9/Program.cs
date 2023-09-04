using System;


/// <summary>
/// Установите ограничения на универсальные типы в классе Car (7.6.7). Такие, чтобы поле Engine могло принимать тип ElectricEngine и GasEngine,
/// а параметр newPart метода ChangePart мог бы принимать только типы частей машины (Battery, Differential, Wheel).
/// </summary>
namespace module7._6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine = default;
        public virtual void ChangePart<TPartCar>(TPartCar newPart) where TPartCar : PartCar
        {

        }
    }
    class Engine
    {

    }
    class PartCar
    {

    }
    class ElectricEngine : Engine
    {

    }
    class GasEngine : Engine
    {

    }
    class Battery : PartCar
    {

    }
    class Differential : PartCar
    {

    }
    class Wheel : PartCar
    {

    }
}
