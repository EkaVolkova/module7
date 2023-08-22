using System;

/// <summary>
/// Для класса DerivedClass создайте 2 конструктора: один, принимающий 2 параметра — name и description, второй — принимающий 3 параметра name, description и counter.
/// </summary>
namespace module7._1._10
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
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description) : base(name)
        {
            Description = description;
        }
        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }
    }
}
