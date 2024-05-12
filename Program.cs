using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ödev
             * Üç elemanlı bir arrayList oluşturun ve yeni bir arrayListe yapıştırın.
             * Yeni oluşan arrayList i gösterin.
             * Yeni oluşan arrayList 3 eleman daha ekleyerek yeni arrayListin eleman sayısını gösterin.
             * Yeni arrayListi index numarasına göre terse çevirerek gösterin.
             */

            ArrayList indexarray = new ArrayList();
            {
                indexarray.Add("Ege");
                indexarray.Add("Aydın");
                indexarray.Add(615);

                Hashtable arrayList = new Hashtable();

                arrayList.Add("Garemtal");
                arrayList.Add("mtal");
                arrayList.Add(42);

                Console.WriteLine($"yeni olşturulan arraylistin içindeki elemean sayısı {arrayList.Count}");



                for (int j = arrayList.Count - 1; j >= 0; j--)
                {
                    Console.WriteLine(arrayList[j]);
                }
            }



            Console.ReadLine();

        }
    }
}
