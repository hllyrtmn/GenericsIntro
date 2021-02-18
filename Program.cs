using System;

namespace Genericıntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            MyList<string> list = new MyList<string>();

            list.Add("halil");

            Console.WriteLine(list.Lenght);

            list.Add("can");

            Console.WriteLine(list.Lenght);

            foreach (var listItem in list.Items)
            {
                Console.WriteLine(listItem);
            }






        }
    }
}
