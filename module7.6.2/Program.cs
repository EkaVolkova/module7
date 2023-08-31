using System;

/// <summary>
/// Создайте класс-обобщение Car для автомобиля. Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый). 
/// Для типов двигателей также создайте классы — ElectricEngine и GasEngine.
/// В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.
/// </summary>
namespace module7._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Car<T>
    {
        public T Engine = default;
    }
    class ElectricEngine
    {

    }
    class GasEngine
    {

    }

}
