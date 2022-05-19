using System;
using System.Collections;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static async Task Main(string[] args)
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
            /*
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
            */
            /* B7 FCTRL2 - Small factorials 
             * tính gia thừa
             *
            input
            4
            1
            2
            5
            3
            output
            1
            2
            120
            6
            int t = Convert.ToInt32(Console.ReadLine());
            int[] n = new int[t];
            for (int i = 0; i < t; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n");
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(tinhGiaiThua(n[i]));
            }
            */
            /* B8
             * A Needle in the Haystack   : 
             * bài toán tìm cây khim trong đống cỏ   time : 12:27
             * 
            input
            2 
            na 
            banananobano 
            6
            foobar 
            foo 
            9 
            foobarfoo 
            barfoobarfoobarfoobarfoobarfoo


            output
            2 
            4 

            3 
            9 
            15 
            21
             *
            // Console.WriteLine(string.Compare("a", "a"));
            //1111
            //  1    _> 4 = 4-1
            //  12  -> 3 = 4-2+1
            //  123  -> 2 = 4-3+1
            //  1111 -> 1

            int[] res = new int[3];
            int taolao;
            string[,] arrayString = new string[3, 2];
            for (int i = 0; i < 3; i++)
            {
                taolao = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < 2; j++)
                {

                    arrayString[i, j] = Console.ReadLine();
                }

            }
            Console.Write("\n");
            inMang2c(arrayString);
            Console.WriteLine("Output");
            for (int i = 0; i < 3; i++)
            {
                timViTriCuaMangConTrongMangto(arrayString[i, 0], arrayString[i, 1]);
            }
            */

            /* B9 ADDREV - Adding Reversed Numbers
             * tính tổng 2 số đảo ngược
             

            int t = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[t, 2];
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(convertA(a[i, 0]) + convertA(a[i, 1]));
            }
            */

            /*------- ----------------------------------hackerank-----------------------------------------------------------*/
            /*B1
            * Simple Array Sum
            *
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];
            }
            Console.WriteLine(sum);
           * /
            /*
             * B2
             * Compare the Triplets
             *
            int[,] thuThach = new int[2, 3];
            int[] diem = new int[2];

            for (int i = 0; i < thuThach.GetLength(0); i++)
            {
                for (int j = 0; j < thuThach.GetLength(1); j++)
                {
                    thuThach[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int j = 0; j < thuThach.GetLength(1); j++)
            {
                if (thuThach[0, j] > thuThach[1, j])
                {
                    diem[0]++;
                }
                if (thuThach[0, j] < thuThach[1, j])
                {
                    diem[1]++;
                }
            }

            Console.WriteLine("output");
            inMang1c(diem);
            */

            /* B3 học về list cung như arrayList // nói chung là nhưng cái gì cho vào mảng là ông này làm được
             * A Very Big Sum*
             * 
             * 
            List<long> newList = new List<long>();
            newList.Add(100000000);
            newList.Add(1000000);
            Console.WriteLine("in kieu for");
            for (int i = 0; i < newList.Count; i++)
            {
                Console.WriteLine(newList[i]);
            }
            Console.WriteLine("in kieu foreach");
            foreach (long i in newList)
            {
                Console.WriteLine(i);
            }
            // coopy vao 1 mang
            long[] array = new long[newList.Count];
            newList.CopyTo(array, 0);
            foreach (long i in array)
            {
                Console.WriteLine(i);
            }
            // đảo ngược gái trị trong mảng
            newList.Reverse();
            foreach (long i in newList)
            {
                Console.WriteLine(i);
            }
            // add them 1 list nua
            List<long> newList2 = new List<long>();
            newList2.Add(2);
            newList2.Add(2);
            newList.AddRange(newList2);
            foreach (long i in newList)
            {
                Console.WriteLine(i);
            }
            // tìm kiếm 1 phần từ bằng giá trị rồi chả về vị trí của đối tượng
            Console.WriteLine(newList.BinarySearch(2));
            //tim khiem phan tu trong mang xem co ton tai khong

            Console.WriteLine(newList.Contains(2));
            // trả về vị trí đầu tiên tìm thấy giá trị value

            Console.WriteLine(newList.IndexOf(2));
            // chen doi tuong value vao index
            newList.Insert(0, 1123432);
            Console.WriteLine("mang moi da chen thêm phân tử");
            foreach (long i in newList)
            {
                Console.WriteLine(i);
            }
            // tra ve vi tri cuoi cung xuất hiện giá trị value trong list
            Console.WriteLine("vi tri cuoi cung cua gia tri");
            Console.WriteLine(newList.LastIndexOf(2));
            newList.ToArray();

            Console.WriteLine("sap xep la nhu the nao");
            newList.Sort();
            foreach (long i in newList)
            {
                Console.WriteLine(i);
            }

            newList.Clear();
            Console.WriteLine("mang sau khi da clear");
            foreach (long i in newList)
            {
                Console.WriteLine(i);
            }
            */

            /** B4 Diagonal Difference
             * Given a square matrix, calculate the absolute difference between the sums of its diagonals.
             * Cho một ma trận vuông, hãy tính hiệu số tuyệt đối giữa các tổng của các đường chéo của nó.
             * 
            int n = Convert.ToInt32(Console.ReadLine());
            int tongDcLtoF = 1;
            int tongDcRtoL = 1;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i)
                    {
                        // Console.WriteLine("gia tri L to R  " + a[i, j]);
                        tongDcLtoF += a[i, j];
                    }
                    if (j == n - i - 1)
                    {
                        ///  Console.WriteLine("gia tri R to L  " + a[i, j]);
                        tongDcRtoL += a[i, j];
                    }
                }
            }
            Console.WriteLine(Math.Abs(tongDcLtoF - tongDcRtoL));
            */
            /* 
             * B5: Plus Minus
             *
             
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> listA = new List<int>(4);
            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                listA.Add(a);
            }
            plusMinus(listA);
            */

            /* có cả kiểu list của  list
             * List<List<int>> arr   
           // List<int> lista = new List<int> { 1, 2 };
            */

            /*  
             * B6 Staircase
             
            staircase(100);
            */
            /* B7 Mini-Max Sum
             */
            /*
             * B8 bài thi của soket
             
            int[] array = { 1, 1, 4, 4, 2, 2, 5, 5, 5, 3 };

            List<List<int>> arrayList = new List<List<int>>();


            for (int i = 0; i < array.Length; i++)
            {
                arrayList.Add(new List<int>());
                arrayList[i].Add(array[i]);
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i] - array[j]) <= 1)
                    {
                        if (checkB8(arrayList[i], array[j]))
                        {

                            arrayList[i].Add(array[j]);
                        }

                    }
                }
            }
            inListInlist(arrayList);
            */

            /* B8
             * Time Conversion
             * input 07:05:45PM
             * output19:05:45
             
            string s = Console.ReadLine();

            Console.WriteLine(timeConversion(s));
            */
            /* B9 làm toán làm cho số giúp giáo sư tại một trường đại học
             **
             *
             
            int n = 4;
            List<int> list = new List<int>(n);
            list.Add(73);
            list.Add(67);
            list.Add(38);
            list.Add(33);

            foreach (int i in gradingStudents(list))
            {
                Console.WriteLine(i);
            }
            */
            /* //https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true
             * B10 
             *     số quả tao trong phạm vi của s và t
             
            int s = 7, t = 11, a = 5, b = 15, nApples = 3, nOranges = 2;
            List<int> apples = new List<int> { -2, 2, 1 };
            List<int> oranges = new List<int> { 5, -6 };
            countApplesAndOranges(s, t, a, b, apples, oranges);
            */

        }

        /*---------------------------------hackrank funtion-------------------*/
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int sumApples = 0;
            int sumOranges = 0;
            for (int i = 0; i < apples.Count; i++)
            {
                apples[i] += a;
                if (apples[i] >= s && apples[i] < t || apples[i] <= t && apples[i] > s)
                {
                    sumApples++;
                }
            }


            for (int i = 0; i < oranges.Count; i++)
            {
                oranges[i] += b;

                if (oranges[i] >= s && oranges[i] < t || oranges[i] <= t && oranges[i] > s)
                {
                    sumOranges++;
                }
            }


            Console.WriteLine(sumApples);
            Console.WriteLine(sumOranges);
        }

        /// B9
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundArray = new List<int>(grades.Count);
            foreach (int grade in grades)
            {
                ///  Console.WriteLine(grade);
                if (grade < 38 || grade % 10 == 0 || grade % 10 == 5)
                {

                    roundArray.Add(grade);
                }
                else
                {
                    int phanDu = grade % 10;
                    if (phanDu > 5 && 10 - phanDu < 3)
                    {
                        roundArray.Add(grade + 10 - phanDu);
                    }
                    else
                    {
                        if (phanDu < 5 && Math.Abs(5 - phanDu) < 3)
                        {
                            roundArray.Add(grade + 5 - phanDu);

                        }
                        else
                        {
                            roundArray.Add(grade);
                        }
                    }
                }
            }
            return roundArray;
        }
        // B8
        public static string timeConversion(string s)
        {

            String res = "";
            if (s[s.Length - 2].CompareTo('P') == 0)
            {
                if ((s[0].CompareTo('0')) == 0)
                {
                    res += (int.Parse(s[1].ToString()) + 12).ToString();

                }
                else
                {
                    string a = char.ToString(s[0]) + char.ToString(s[1]);
                    if (int.Parse(a) >= 12)
                    {
                        res += a;
                    }
                    else
                    {
                        res += (int.Parse(a) + 12);
                    }

                }
            }
            else
            {
                string a = char.ToString(s[0]) + char.ToString(s[1]);
                if (int.Parse(a) == 12)
                {
                    res += "00";
                }
                else
                {
                    res += a;
                }
            }
            for (int i = 2; i < s.Length - 2; i++)
            {
                // Console.WriteLine(s[i]);
                res += s[i].ToString();

            }
            return res;
        }

        // in list trong list 
        public static void inListInlist(List<List<int>> arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                for (int j = 0; j < arrayList[i].Count; j++)
                {
                    if (arrayList[i].Count != 1)
                    {
                        Console.Write(arrayList[i][j]);
                    }

                }
                Console.Write("\n");
            }
        }

        public static bool checkB8(List<int> arr, int a)
        {

            foreach (int i in arr)
            {
                if (Math.Abs(i - a) > 1)
                {
                    return false;
                }

            }
            return true;
        }
        //B7
        public static void miniMaxSum(List<int> arr)
        {
            int max = 0;
            int min = 0;

            arr.Sort();
            for (int i = 1; i < arr.Count; i++)
            {
                max += arr[i];
            }
            for (int i = 0; i < arr.Count - 1; i++)
            {
                min += arr[i];
            }
            Console.Write(min + " " + max);
        }
        public static void miniMaxSum2(List<int> arr)
        {
            int max = 0;
            int min = 0;
            int tong = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                tong += arr[i];
            }
            for (int j = 0; j < arr.Count; j++)
            {
                if (tong - arr[j] > max)
                {
                    max = tong - arr[j];
                }
            }
            min = tong - arr[0];
            for (int j = 0; j < arr.Count; j++)
            {
                if (tong - arr[j] < min)
                {
                    min = tong - arr[j];
                }
            }
            Console.Write(min + " " + max);
        }

        //B6
        public static void staircase(int n)
        {
            int tru = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + tru; j++)
                {
                    Console.Write(" ");
                }
                for (int index = i + tru; index < n; index++)
                {
                    Console.Write("#");
                }
                tru -= 2;
                Console.Write("\n");
            }
        }
        public static void plusMinus(List<int> arr)
        {
            // float[] res= new float[3];
            int[] res = new int[3];
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    res[0]++;
                }
                else if (arr[i] < 0)
                {
                    res[1]++;
                }
                else
                {
                    res[2]++;
                }
            }
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine((double)res[i] / arr.Count);
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
                Console.Write(array[i] + " ");
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
        // b7
        static int tinhGiaiThua(int a)
        {
            int r = 1;
            for (int i = 1; i <= a; i++)
            {
                r = r * i;
            }
            return r;
        }
        // b8
        static void inMang2c(string[,] array2)
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
        static void timViTriCuaMangConTrongMangto(string A, string B)
        {

            if (A.Length > B.Length)
            {
                Console.Write("\n");
            }
            else
            {
                int check = 0;
                for (int i = 0; i < B.Length - A.Length + 1; i++)
                {
                    string subStringofB = B.Substring(i, A.Length);
                    if (String.Compare(A, subStringofB) == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                if (check == 0)
                {
                    Console.Write("\n");
                }
            }

        }
        // B9
        static int convertA(int a)
        {
            string convert = "";
            while (a != 0)
            {
                int newNum = a % 10;
                convert += newNum;
                a = a / 10;
            }


            return Int32.Parse(convert);
        }

    }
    public class car
    {
        public float speed;
        public string color;
    }

}