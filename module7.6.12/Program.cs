using System;

/// <summary>
/// С учётом полученных знаний по наследованию обобщений, дополните схему классов автомобиля, добавив классы для электромобиля и бензинового — ElectricCar и GasCar.
/// </summary>
namespace module7._6._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;
        public abstract void ChangePart<TPartCar>(TPartCar newPart) where TPartCar : PartCar;
       
    }
    class ElectricCar : Car<ElectricEngine>
    {

        public override void ChangePart<TPartCar>(TPartCar newPart)
        {

        }
    }
    class GasCar : Car<GasEngine> 
    {

        public override void ChangePart<TPartCar>(TPartCar newPart)
        {

        }
    }
    abstract class Engine
    {

    }
    abstract class PartCar
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
