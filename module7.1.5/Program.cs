using System;

/// <summary>
/// Для следующего списка объектов создайте схему классов (объявите нужные классы и установите связи между ними):
///     Apple(яблоко)
///     Banana(банан);
///     Pear(груша);
///     Potato(картофель);
///     Carrot(морковь).
/// </summary>
namespace module7._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Fruit : Food
    {

    }
    class Vegetable : Food
    {

    }
    class Food
    {

    }
    class Apple : Fruit
    {

    }
    class Banana : Fruit
    {

    }
    class Pear : Fruit
    {

    }
    class Potato : Vegetable
    {

    }
    class Carrot : Vegetable
    {

    }
}
