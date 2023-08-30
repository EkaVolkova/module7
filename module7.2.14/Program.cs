using System;

/// <summary>
/// Для следующего класса напишите индексатор, для типа параметра используйте int:
/// </summary>
namespace module7._2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                return 0;
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
            }
        }

    }
}
