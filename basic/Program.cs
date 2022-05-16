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


            /* B1: Bài toán tìm hình chữ nhật , có cạnh là lớn nhất  ( dien tich lon  nhat)  

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
                    for (int j = i + 1; j < n; j++)
                    {
                        if (line[i] == line[j])
                        {

                            arrayPTtrung[line[i]] += 1;
                        }

                    }

                }
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
            */

            /*
            arraylist
            ar arlist1 = new ArrayList();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            arlist1.Sort();
            foreach (var i in arlist1)
            {
            //   Console.WriteLine(i);
            }
            // Console.WriteLine("\n");


            ArrayList arrlist1 = new ArrayList();
            var arrlist2 = new ArrayList();
            arrlist1.Add(1);
            arrlist1.Add(2);
            arrlist2.Add(3);
            arrlist1.Add("hello world");
            */

            //------------------------------------------------------
            /* 
             * B2:
             tìm ra câu trả lời cho sự sống, vũ trụ và vạn vật.
            Chính xác hơn là ... viết lại các số nhỏ từ đầu vào đến đầu ra. 
            Dừng xử lý đầu vào sau khi đọc số 42.
            Tất cả các số ở đầu vào là số nguyên có một hoặc hai chữ số.
            

            int[] a = { 1, 2, 4, 6, 42,99 };
            for(int i =0;i<a.Length;i++)
            {
                if(a[i]==42)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(a[i]);
                }
            }    
            */

            //------------------------------------------------
            /* B3
             * check có phải là chuỗi con khong
             * SBSTR1 - Substring Check (Bug Funny)
                 1010110010 10110
                 1110111011 10011
                 First two lines of output:
                    1
                    0
             

            int[] A = { 1, 0, 1, 0, 1, 1, 0, 0, 1, 0 };
            int[] B = { 1, 0, 1, 1, 0 };
            //  int[] A = { 1, 1, 1, 0, 1, 1, 1, 0, 1, 1 };
            //   int[] B = { 1, 0, 0, 1, 1 };

            //   4 - 2 + 1;
            //    4-1+1
            //   4-3+1
            //   10-5+1
            ArrayList arrayList = new ArrayList();
            int vonglap = 0;
            int dem = 0;
            int ichuan = 0;
            int checkMangCon = 0;
            while (vonglap < A.Length - B.Length + 1)
            {
                for (int i = ichuan; i < B.Length + dem; i++)
                {
                    arrayList.Add(A[i]);
                }
                int[] myArr = (int[])arrayList.ToArray(typeof(int));

                if (myArr.Length == B.Length && soSanh2Array(B, myArr))
                {
                    checkMangCon++;
                    break;
                }
                dem++;
                ichuan++;
                vonglap++;
                arrayList.Clear();
            }
            if (checkMangCon == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
            */

            //--------------------------------------------------
            /* B4: 
             * PALIN - The Next Palindrome
             * Input:
    2
    808
    2133

    Output:
    818
    2222

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrayCanCheck = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayCanCheck[i] = Convert.ToInt32(Console.ReadLine());
            }
            int dem = 0;
            while (dem < n)
            {
                for (int i = arrayCanCheck[dem] + 1; i < 100000; i++)
                {
                    int[] outarry = Array.ConvertAll(i.ToString().ToArray(), x => (int)x - 48);
                    // xoa phan tu
                    //outarry = outarry.Where(val => val != outarry[outarry.Length / 2]).ToArray();
                    if (soSanhPalindrome(outarry))
                    {
                        Console.WriteLine("\n");
                        inMang1c(outarry);

                        Console.WriteLine("\n");
                        break;
                    }

                }
                dem++;
            }
            */

            /* B5: ARITH - Simple Arithmetics  // chưa giải quyết được nếu phép nhân có số không
             *
       input
4 
12345 + 67890
324-111 
325 * 4405 
1234 * 4

output
12345 
+67890 
------ 
 80235 

 324 
-111 
---- 
 213 

     325 
  * 4405 
  ----- 
   1625 
     0 
 1300 
1300 
------- 
1431625 
            //     int a = 324;
            // int b = 4405;
            string[] a = new string[5];
            string khangCach = "              ";

            Console.WriteLine(khangCach + "325");
            Console.WriteLine(khangCach + "4405");

            Console.WriteLine(khangCach + "-----");

            //Console.WriteLine(khangCach + "1625");
            //Console.WriteLine(khangCach + addKhoangTrang(2) + "0");
            //Console.WriteLine(subKhoangTrang(khangCach, 2) + "1300");
            //Console.WriteLine(subKhoangTrang(khangCach, 3) + "1300");
            //Console.WriteLine(subKhoangTrang(khangCach, 3) + "-------");

            //Console.WriteLine(subKhoangTrang(khangCach, 3) + "1431625");


            int num1 = 325;
            int num2 = 4405;
            int[] arraynum2 = Array.ConvertAll(num2.ToString().ToArray(), x => (int)x - 48);
            int num3 = 0;
            for (int i = arraynum2.Length - 1; i >= 0; i--)
            {
                num3 = num1 * arraynum2[i];
                if (num3 == 0)
                {
                    Console.WriteLine(khangCach + addKhoangTrang(arraynum2.Length - i) + num3);
                }
                else
                {
                    Console.WriteLine(subKhoangTrang(khangCach, arraynum2.Length - i - 1) + num3);
                }
            }
            */
            //  2
            //  m n
            // B6 tim so nguyen tu trong khong tu m - n

            int t = Convert.ToInt32(Console.ReadLine());
            int[,] array2d = new int[t, 2];
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            inMang2c(array2d);

            Console.WriteLine("\n");
            int jj = 0;
            for (int i = 0; i < t; i++)
            {

                checkSNTtrongMdenN(array2d[i, jj], array2d[i, jj + 1]);

            }
        }
        static void search2Max(int[] array)
        {
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max1)
                {
                    max1 = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max2 && array[i] < max1)
                {

                    max2 = array[i];
                }
            }

            Console.WriteLine("max 2 va max 1 lan luot la");
            Console.WriteLine(max2);
            Console.WriteLine(max1);
        }
        static bool soSanh2Array(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }
        static void inMang1c(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
        static void inMang2c(int[,] array2)
        {
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        static void checkSNTtrongMdenN(int m, int n)
        {

            int count = 0;

            for (int j = m; j <= n; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                        if (count == 2 && i == j)
                        {
                            Console.WriteLine(j);
                        }

                    }

                }
                count = 0;
            }
        }
        //b4
        static bool soSanhPalindrome(int[] array)
        {
            int a = (array.Length % 2 != 0) ? 1 : 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                for (int j = array.Length / 2 + a; j < array.Length; j++)
                {
                    if (array[i] != array[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // b5
        static string addKhoangTrang(int soKhoangTrang)
        {
            string a = "";
            string index = " ";
            for (int i = 0; i < soKhoangTrang; i++)
            {
                a += index;
            }
            return a;
        }
        // b5
        static string subKhoangTrang(string khoangTrang, int count)
        {

            return khoangTrang.Remove(1, count);
        }
    }
    public class car
    {
        public float speed;
        public string color;
    }

}