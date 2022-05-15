using System;
using System.Collections;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myNumbers = { 5, 1, 8, 9 };
            //Console.WriteLine(myNumbers.Max());  // returns the largest value
            //Console.WriteLine(myNumbers.Min());  // returns the smallest value
            //Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
            /*
            int[] arrayInt;
            arrayInt = new int[5];
            arrayInt[0] = 4;
            arrayInt[1] = 5;
            arrayInt[3] = 6;
            for(int i=0;i<arrayInt.Length ;i++ )
            {
                Console.WriteLine(arrayInt[i]);
            }
            foreach(int i in arrayInt)
            {
                Console.WriteLine(arrayInt[i]);
            }
            

            int[] arrayInt = new int[4];
            for(int i=0;i<arrayInt.Length;i++)
            {
                arrayInt[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arrayInt.Length;i++)
            {
                Console.WriteLine(arrayInt[i]);
            }
         */
            /*
             * OOP 
                car car1 = new car();
                car1.color = "red";
                car1.speed = 1.8f;
                car car2 = new car();
                car2.color = "blue";
                car2.speed = 1.9f;
                Console.WriteLine(car2.color);
            */
            /*
            int[] arrayint = new int[5];
            for(int i=0;i<arrayint.Length;i++)
            {
                arrayint[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\n");
            foreach(int i in arrayint)
            {
                Console.WriteLine(i);
            }
            */
            /*
            int[,] array2D = new int[2, 2];
            for(int i=0;i<array2D.GetLength(0);i++)
            {
                for(int j=0;j<array2D.GetLength(1);j++)
                {
                    array2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.WriteLine(array2D[i, j]+"");
                }
                Console.WriteLine("\n");
            }
            */

             
             
            int[] line=new int[1001];
            int[] arrayPTtrung = new int[1001];
          
            int n = Convert.ToInt32(Console.ReadLine());
            int[] phanTudaLoc = new int[n];

            var arlist1 = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                line[i] = Convert.ToInt32(Console.ReadLine());
            }
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (line[i] == line[j])
                    {
                        dem++;
                        arrayPTtrung[line[i]] += 1;
                    }

                }
                if(dem==0)
                {
                    arlist1.Add(line[i])  ;
                }
                dem = 0;
            }
            /*
             arraylist

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            arlist1.Sort();
            foreach (var i in arlist1)
            {
             //   Console.WriteLine(i);
            }
            // Console.WriteLine("\n");
            */

            int max1 = 0;
            int max2 = 0;

            // vì nó chạy từ bé đến lớn mời tìm max min kiểu này
            for(int i=0;i<arrayPTtrung.Length;i++)
            {
               if(arrayPTtrung[i] >=1 && i>max1 )
                {
                    max2 = max1;
                    max1 = i;
                 }
            }

            if(max1*max2==0)
            {
                Console.WriteLine("-1");
            }
            else
            {
             //   int s=((max1!=0 && max2==0):)
                Console.WriteLine(max1 * max2);
            }

            search2Max(line);
       }
       static void search2Max(int[] array)
        {
            int max1 = 0;
            int max2 = 0;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]>max1)
                {
                   
                    max1 = array[i];
                }    
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max2&& array[i]<max1)
                {

                    max2 = array[i];
                }
            }

            Console.WriteLine("max 2 va max 1 lan luot la");
            Console.WriteLine(max2);
            Console.WriteLine(max1);
        }
   }
    public class car
    {
           public float speed;
           public string color;
    }

}