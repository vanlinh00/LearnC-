using System;
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

            /* 
             
            int[] line=new int[1001];
            int[] arrayPTtrung = new int[1001];
          
            int n = Convert.ToInt32(Console.ReadLine());
            int[] phanTudaLoc = new int[n];

            for (int i = 0; i < n; i++)
            {
                line[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (line[i] == line[j])
                    {
                        arrayPTtrung[line[i]] += 1;
                    }
                    else
                    {   if(phanTudaLoc[i] != line[i])
                        {
                            phanTudaLoc[i] = line[i];
                        }    
                       
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            for (int i=0;i< phanTudaLoc.Length; i++)
            {
                Console.WriteLine(phanTudaLoc[i]);
            }    

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            int count = 0;
            for(int i=0;i< arrayPTtrung.Length; i++)
            {
               if(arrayPTtrung[i]>=2)
                {
                    count++;
                }    
            }    

      //      1 3 4 3 5 3 5



            
            Console.WriteLine("\n");
            int count = 0;
            for(int i=0;i<arrayPTtrung.Length;i++)
            {
                Console.WriteLine(arrayPTtrung[i]);
               if(arrayPTtrung[i] ==1)
                {
                    count++;
                }
            }

            if(count==1)
            {
                Console.WriteLine("hinh chu nhat");

            }
            else
            {
                Console.WriteLine("khong hinh chu nhat");

            }
            */


        }
  
      

    }
    public class car
    {
           public float speed;
           public string color;
    }

}