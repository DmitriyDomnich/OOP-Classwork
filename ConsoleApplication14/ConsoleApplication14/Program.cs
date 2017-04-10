using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    struct City
    {
      public  string Name;
      public int People;
    }

    class Program
    {
        static void Main(string[] args)
        {
            City[] array=new City[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Name = Console.ReadLine();
                array[i].People = Convert.ToInt32(Console.ReadLine());

            }

            int maxPeople=0;

            for (int i = 0; i < array.Length; i++)
            {
                if (maxPeople < array[i].People)
                    maxPeople = array[i].People;
            }
            Console.WriteLine(maxPeople);
            int maxCity=0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (maxCity> array[0].Name.Length)
                {
                    maxCity = array[i].Name.Length;
                    index = i;
                }
            }

            Console.WriteLine(array[index].Name);

        }
    }
}
