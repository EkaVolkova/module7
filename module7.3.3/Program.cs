using System;

/// <summary>
/// Создайте классы для следующих объектов компьютера: процессор (Processor), материнская карта (MotherBoard), видеокарта (GraphicCard). 
/// Унаследуйте их от класса ComputerPart.
/// Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.
/// </summary>
namespace module7._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class ComputerPart
    {
        public abstract void Work();
    }
    class Processor : ComputerPart
    {
        public override void Work()
        {
            
        }
    }
    class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            
        }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work()
        {
            
        }
    }
}
