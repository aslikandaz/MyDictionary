using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevDictionary
{
    class MyDictionary<K, V>
    {
        K[] arrayKey;
        V[] arrayValue;

        public MyDictionary()
        {
            arrayKey = new K[0];
            arrayValue = new V[0];
        }

        public void Add(K Key, V Value)
        {
            K[] tempAnahtar = arrayKey;
            V[] tempDeğer = arrayValue;

            if (arrayValue.Contains(Value)==true || arrayKey.Contains(Key)==true) // contains dizi içindeki elemanlarda arama yapar ve true ya da false değer döner
            {
                Console.WriteLine("bu anahtar ya da değer dizide mevcut");
                // dizide verilen değer ya da anahtar varsa eklemeyerek ekrana bilgi basar
            }
            else // dizide değer ve anahtar bulunmazsa ekleme işlemini yapar
            {
                arrayKey = new K[tempAnahtar.Length + 1];
                arrayValue = new V[tempDeğer.Length + 1];

                for (int i = 0; i < tempDeğer.Length; i++)
                {
                    arrayKey[i] = tempAnahtar[i];
                    arrayValue[i] = tempDeğer[i];
                }
                arrayKey[arrayKey.Length - 1] = Key;
                arrayValue[arrayValue.Length - 1] = Value;
            }
           
        }

        // dizideki değer sayısını döner
        public int Length
        {
            get { return arrayValue.Length; }
        }


    }

}
