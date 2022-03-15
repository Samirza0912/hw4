using System;

namespace homework4
{
    class Program
    {
        //int tipindən bir array olur
        //içində müsbət və mənfi ədədlər olur
        //elə bir method yazın ki, bu array-i parametr olaraq qəbul etsin
        //və qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun
        //daha sonra içindəki mənfi ədədləri müsbətə çevirib
        //həmin array-i geriyə qaytarsın
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -3 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Convertplus(ref arr);
            Console.WriteLine("methoddan sonra");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
        static int[] Convertplus(ref int[] num)
        { 
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]<0)
                {
                    num[i]*=-1;
                }
            }return num;
        }

        
            

           
        
        
    }
}

