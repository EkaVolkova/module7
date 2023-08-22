using System;

/// <summary>
/// Впишите пропущенный код для параметров в Console.WriteLine вместо ??? так, чтобы в консоли выводилось "Привет, Грег, я интеллектуальный помощник Олег":
/// Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", ???);
/// </summary>
namespace module7._1._7
{
    class SmartHelper
    {
        private string name;

        public SmartHelper(string name)
        {
            this.name = name;
        }

        public void Greetings(string name)
        {
            Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SmartHelper helper = new SmartHelper("Олег");
            helper.Greetings("Грег");

            Console.ReadKey();
        }

    }
}
