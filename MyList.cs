using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Genericıntro
{
    class MyList<T>
    {
         T[] items;

         public MyList()
         {
             items = new T[0];
         }

         public void Add(T item)
         {
             T[] tempArray = items;
             items = new T[items.Length+1];
             int i = 0;
             foreach (var temp in tempArray)
             {
                 items[i] = temp;
                 i++;
             }

             items[items.Length - 1] = item;








         }

         public int Lenght
         {
             get { return items.Length; }
         }

         public T[] Items
         {
             get { return items; }
         }





    }
}
