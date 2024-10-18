using System;
namespace rajender
{
    class name
    {
        static void Main(string[] args)
        {
            //hello
            #region Accept array number
            //Console.Write("Enter the element size:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.Write("Enter the element at arr[" + i + "]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            #endregion
            #region Number in words

            //        using System;
            //        namespace raj
            //{
            //    class name
            //    {
            //        public static void txt(int num)
            //        {
            //            switch (num)
            //            {
            //                case 1:
            //                    Console.Write("one");
            //                    break;
            //                case 2:
            //                    Console.Write("Two");
            //                    break;
            //                case 3:
            //                    Console.Write("Three");
            //                    break;
            //                case 4:
            //                    Console.Write("Four");
            //                    break;
            //                case 5:
            //                    Console.Write("Five");
            //                    break;
            //                case 6:
            //                    Console.Write("Six");
            //                    break;
            //                case 7:
            //                    Console.Write("Seven");
            //                    break;
            //                case 8:
            //                    Console.Write("Eight");
            //                    break;
            //                case 9:
            //                    Console.Write("Nine");
            //                    break;
            //                case 10:
            //                    Console.Write("Ten");
            //                    break;
            //                case 11:
            //                    Console.Write("Eleven");
            //                    break;
            //                case 12:
            //                    Console.Write("Twovel");
            //                    break;
            //                case 13:
            //                    Console.Write("Thirteen");
            //                    break;
            //                case 14:
            //                    Console.Write("Fourteen");
            //                    break;
            //                case 15:
            //                    Console.Write("Fiveteen");
            //                    break;
            //                case 16:
            //                    Console.Write("sixteen");
            //                    break;
            //                case 17:
            //                    Console.Write("Seventeen");
            //                    break;
            //                case 18:
            //                    Console.Write("Eighteen");
            //                    break;
            //                case 19:
            //                    Console.Write("Nineteen");
            //                    break;
            //                case 20:
            //                    Console.Write("Twenty");
            //                    break;
            //                case 30:
            //                    Console.Write("thirty");
            //                    break;
            //                case 40:
            //                    Console.Write("forty");
            //                    break;
            //                case 50:
            //                    Console.Write("fifty");
            //                    break;
            //                case 60:
            //                    Console.Write("sixty");
            //                    break;
            //                case 70:
            //                    Console.Write("seventy");
            //                    break;
            //                case 80:
            //                    Console.Write("eieghty");
            //                    break;
            //                case 90:
            //                    Console.Write("Ninty");
            //                    break;
            //                case 100:
            //                    Console.Write("one hundred");
            //                    break;
            //            }
            //        }
            //        static void Main(string[] args)
            //        {
            //            Console.WriteLine("Enter the number :");
            //            int n = Convert.ToInt32(Console.ReadLine());
            //            if (n == 100)
            //            {
            //                txt(100);
            //            }
            //            if (n <= 20)
            //            {
            //                txt(n);
            //            }
            //            else
            //            {
            //                txt(n / 10 * 10);
            //                txt(n % 10);
            //            }
            //        }
            //    }
            //}
            #endregion
            #region even elements in array
            //int[] arr = { 12, 9, 15, 6, 7, 11, 4 };
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(arr[i]%2==0)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //}
            #endregion
            #region first and last digit in array
            //int[] arr = { 12, 9, 15, 6, 7, 11, 4 };
            //Console.Write(arr[0] + " ");
            //Console.Write(arr[arr.Length-1] + " ");
            #endregion
            #region meadin number find
            //int[] arr = { 1,2, 9, 15 };
            //int c = arr.Length / 2;
            //// Check if the array has an even number of elements
            //if (arr.Length % 2 == 0)
            //{
            //    // If it's even, calculate the average of the middle two elements
            //    int average = (arr[c] + arr[c - 1]) / 2;
            //    Console.WriteLine(average);
            //}
            //else
            //{
            //    // If it's odd, simply print the middle element
            //    Console.WriteLine(arr[c]);
            //}
            #endregion
            #region sum even and odd
            //int[] arr = { 12, 9, 15, 6, 7, 11, 14 };
            //int evensum = 0, oddsum = 0;
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(arr[i]%2==0)
            //    {
            //        evensum=evensum+arr[i];
            //    }
            //    else
            //    {
            //        oddsum = oddsum + arr[i];
            //    }
            //}
            //Console.WriteLine("Even sum is "+evensum);
            //Console.WriteLine("Odd sum is  "+oddsum);
            #endregion
            #region display alternative elements
            //int[] arr = { 12, 9, 15, 6, 7, 11, 4 };
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(arr[i]+" ");
            //    }
            //}
            #endregion
            #region above 2 digits elements
            //int[] arr = { 12, 9, 15, 6, 7, 11, 4 };
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(arr[i]>10)
            //    {
            //        Console.Write(arr[i]+" ");
            //    }
            //}
            #endregion
            #region find biggest no.
            //int[] arr = { 0, 9, 15, 67, 11, 4 };
            //int max = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(max + " ");
            #endregion
            #region find lowest no.
            //int[] arr = { 0, 9, 15, 6, 7, 11, 4 };
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(min + " ");
            #endregion
            #region low nd high no.
            //int[] arr = { 12, 9, 15, 6, 7, 11, 4 };
            //int max = 0, t = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        t = max;
            //        max = arr[i];
            //        continue;
            //    }
            //    if (arr[i] < t)
            //    {
            //        t = arr[i];
            //    }
            //}
            //Console.WriteLine(max + " ");
            //Console.WriteLine(t + " ");
            #endregion
            #region two biggst nos.
            //int[] arr = { 12, 9, 15, 6, 7, 11, 4 };
            //int max = 0, t = 0 ;            
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(arr[i]>max)
            //    {
            //        t = max;
            //        max = arr[i];
            //        continue;
            //    }
            //    if(arr[i]>t)
            //    {
            //        t = arr[i];
            //    }
            //}
            //Console.WriteLine(max+" ");
            //Console.WriteLine(t+" ");
            #endregion
            #region display elements
            //Console.Write("Enter the size of array:");
            //int size = int.Parse(Console.ReadLine());
            //int[]arr = new int[size];
            //for(int i=0;i<size;i++)
            //{
            //    Console.Write("Enter the element of array["+i+"]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.Write(arr[i]+" ");
            //}
            #endregion
            #region array in reverse order
            //Console.Write("Enter the array size:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.Write("Enter the array[" + i + "]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=arr.Length-1;i>=0;i--)
            //{
            //    Console.Write(arr[i]+" ");
            //}
            #endregion
            #region 3 subjs avarage
            //int[] arr = new int[3];
            //int a, toatal = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the array[" + i + "]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            // a =( arr[0] + arr[1] + arr[2]) / 3;
            //toatal = arr[0] + arr[1] + arr[2];
            //Console.WriteLine("The avarage of 3 subjs is "+a+" ");
            //Console.WriteLine("The toal marks of 3 subjs "+toatal+" ");
            #endregion
            #region read array even find
            //Console.Write("Enter the array size:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the array[" + i + "]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(arr[i]%2==0)
            //    {
            //        Console.WriteLine(arr[i]+" ");
            //    }
            //}
            #endregion
            #region read arry odd find
            //Console.Write("Enter the array size:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the array[" + i + "]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        Console.WriteLine(arr[i] + " ");
            //    }
            //}
            #endregion
            #region  even odd count
            //int evesum = 0, oddsum = 0;
            //Console.Write("Enter the array size:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the array[" + i + "]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(arr[i]%2!=0)
            //    {
            //        evesum++;
            //    }
            //    else
            //    {
            //        oddsum++;
            //    }
            //}
            //Console.WriteLine("The even sum is:"+evesum+" ");
            //Console.WriteLine("The odd sum is:"+oddsum+" ");
            #endregion
            #region count males and females
            //int male = 0, female = 0;
            //Console.Write("Enter the size of count:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //char[] arr = new char[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the gender[" + i + "]:");
            //    arr[i] = Convert.ToChar(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 'm')
            //    {
            //        male++;
            //    }
            //    else
            //    {
            //        female++;
            //    }
            //}
            //Console.WriteLine("Number of males: " + male);
            //Console.WriteLine("Number of females: " + female);
            #endregion
            #region read prime no
            int[] arr = { 121, 1, 223, 4, 5, 1, 2, 34, 5, 0 };
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count++;

                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            #endregion
            #region second round qualified
            //Console.Write("Enter the number:");
            //int x = int.Parse(Console.ReadLine());
            //int count = 0;
            //int[] arr = { 1122, 1145, 1156, 1187, 1245, 1265 };
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(arr[i]==x)
            //    {
            //        count++;
            //        break;
            //    }
            //}
            //if(count==1)
            //{
            //    Console.WriteLine("Qualified");
            //}
            //else
            //{
            //    Console.WriteLine("Not Qualified");
            //}
            #endregion
            #region customer is avilable or not
            //int count = 0;
            //Console.Write("Enter the array size:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the array[" + i + "]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Write("Enter the user number:");
            //int x = int.Parse(Console.ReadLine());
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if(arr[i]==x)
            //    {
            //        count++;
            //        break;
            //    }
            //}
            //if(count==1)
            //{
            //    Console.WriteLine("Customer is available");
            //}
            //else
            //{
            //    Console.WriteLine("Customer is not available");
            //}
            #endregion
            #region find duplicates
            //Console.Write("Enter the array size:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the array[" + i + "]:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 0;
            //    if (arr[i] != 0)
            //    {
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                arr[j] = 0;
            //                count++;
            //            }
            //        }
            //        if (count > 0)
            //        {
            //            Console.WriteLine(arr[i] + " ");
            //        }
            //    }
            //}
            #endregion
            #region sum of 2 arrays
            //int[] x = { 1, 2, 3, 4, 5 };
            //int[] y = { 1, 2, 3 };
            //int xsum = 0, ysum = 0;
            //for(int i=0;i<x.Length;i++)
            //{
            //    xsum = xsum + x[i];
            //}
            //Console.Write(xsum + " ");
            //for(int j=0;j<y.Length;j++)
            //{
            //    ysum = ysum + y[j];
            //}
            //Console.WriteLine(ysum+" ");
            #endregion
            #region sum of even and odd
            //int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] y = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int evensum=0,eodd = 0, oddsum=0,oodd = 0;
            //for(int i=0;i<x.Length;i++)
            //{
            //    if(x[i]%2==0)
            //    {
            //        evensum = evensum + x[i];
            //    }
            //    else
            //    {
            //        eodd = eodd + x[i];
            //    }
            //}
            //for(int j=0;j<y.Length;j++)
            //{
            //    if(y[j]%2==0)
            //    {
            //        oddsum = oddsum + y[j];
            //    }
            //    else
            //    {
            //        oodd = oodd + y[j];
            //    }
            //}
            //Console.WriteLine((evensum+oddsum));
            //Console.WriteLine((eodd+oodd));
            #endregion
            #region find highst and lowest
            //int[] arr = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };
            //int min = arr[0], max = 0;
            //for(int i=0;i<arr.Length;i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        continue;
            //    }
            //    if (arr[i]<min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            #endregion
            #region without dublicates
            //int[] arr = { 11, 22, 33, 44, 11, 11, 77, 66, 77, 888, 99, 88, 77 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 0)
            //    {
            //        Console.WriteLine(arr[i] + " ");
            //    }
            //}
            #endregion
            #region palindrome
            //int[] arr = { 123, 456, 789, 12, 43, 121, 55155 };
            //for(int i=0;i<arr.Length;i++)
            //{
            //    int rev = 0, r = 0, t = arr[i];
            //    while(t!=0)
            //    {
            //        r = t %10;
            //        rev = rev * 10 + (r);
            //        t = t / 10;
            //    }
            //    if(rev==arr[i])
            //    {
            //        Console.WriteLine("Is palindrome"+" "+rev);
            //    }
            //}
            #endregion
            #region duplicates are not accepted
            //Console.Write("Enter the size of array:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            Console.WriteLine("Duplicates are not allowed");
            //            i--;
            //            break;

            //        }

            //    }
            //}
            #endregion
            #region order in accesnding
            //Console.Write("Enter elements");
            //int[] arr = { 10, 30, 20, 40, 60, 50, 70, 89, 99 };
            //for(int i=0;i<arr.Length;i++)
            //{
            //    for(int j=i+1;j<arr.Length;j++)
            //    {
            //        if(arr[i]>arr[j])
            //        {
            //            int c = arr[j];
            //            arr[j] = arr[i];
            //            arr[i] = c;

            //        }

            //    }
            //    Console.Write(arr[i] + " ");
            //}
            #endregion
            #region missing numbers from an array
            //int[] arr = { 1, 3, 5, 6, 8, 9 };
            //{
            //    int k = 1;
            //    for (int i = 0; i < arr.Length; i++, k++)
            //    {
            //        if (k != arr[i])
            //        {
            //            i--;
            //            Console.Write(k + " ");
            //        }
            //    }
            //}
            #endregion
            #region decimal to binary
            //int n = 28, dec = 0, p = 1;
            //while (n > 0)
            //{
            //    dec = dec + (n % 2) * p;
            //    n = n / 2;
            //    p = p * 10;
            //}
            //Console.WriteLine(dec);
            #endregion
            #region Binary to Decimal
            //Console.WriteLine("Enter the number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int dec = 0;
            //int p = 1;
            //while (n > 0)
            //{
            //    dec = dec + (n % 10) * p;
            //    n = n / 10;
            //    p = p * 2;
            //}
            //Console.WriteLine(dec);
            #endregion
            #region check how many no's 2 count

            //    Console.WriteLine("Enter the size of array:");
            //    int size = Convert.ToInt32(Console.ReadLine());
            //    int[] arr = new int[size];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write("Enter the element at array[" + i + "]:");
            //        arr[i] = int.Parse(Console.ReadLine());
            //    }
            //    int count = 0;
            //    int r = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] < 10)
            //        {
            //            if (arr[i] == 2)
            //            {
            //                count++;
            //            }
            //        }
            //        else
            //        {
            //            if (arr[i] > 10)
            //            {
            //                int x = arr[i];
            //                while (x > 0)
            //                {
            //                    r = x % 10;
            //                    if (r == 2)
            //                    {
            //                        count++;
            //                    }
            //                    x = x / 10;
            //                }
            //            }
            //        }
            //    }
            //    Console.WriteLine(count);
            //}
            #endregion
            #region find index diff b/w min,max
            //int[] arr = { 25, 36, 96, 12, 56, 109 };
            //int max = arr[0], min = arr[0], li = 0, si = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //        li = i;
            //    }
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //        si = i;
            //    }
            //}
            //int x = li - si;
            //Console.WriteLine("Index Differences : " + x);
            #endregion
            #region replace even left and odd right

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] arr2 = new int[8];
            //int j = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        arr2[j] = arr[i];
            //        j++;
            //    }
            //}
            //for (int k = 0; k < arr.Length; k++)
            //{
            //    if (arr[k] % 2 != 0)
            //    {
            //        arr2[j] = arr[k];
            //        j++;
            //    }
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}
            #endregion
            #region element occured times
            //Console.WriteLine("Enter the size of array:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the element at arr[" + i + ":]");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] != 0)
            //    {
            //        int count = 1;
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                arr[j] = 0;
            //                count++;
            //            }
            //        }
            //        Console.WriteLine(arr[i] + " is occured " + count + " times");
            //    }
            //}
            #endregion
            #region find min and max value
            //Console.WriteLine("Enter the sizd of array:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter the elements at arr[" + i + "]:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int max = 0;
            //int min = 0;
            //max = arr[0];
            //min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < max)
            //        max = arr[i];
            //    if (arr[i] > min)
            //        min = arr[i];
            //}
            //Console.WriteLine(min + " " + max);
            #endregion
            #region Reverse order array 
            //Console.Write("Enter the size of array :");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the array at arr[" + i + "]: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
            //{
            //    int temp = arr[i];
            //    arr[i] = arr[j];
            //    arr[j] = temp;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion
            #region Singleton DesignPattern
            //public class Singleton
            //{
            //    static Singleton instance;

            //    private Singleton()
            //    {
            //        Console.WriteLine("this is constructor");
            //    }
            //    public static Singleton GetInstance()
            //    {
            //        if (instance == null)
            //            instance = new Singleton();
            //        return instance;
            //    }
            //    public void Show()
            //    {
            //        Console.WriteLine("This is show method");
            //    }
            //}
            //class programe
            //{
            //    static void Main(string[] args)
            //    {
            //        Singleton.GetInstance().Show();
            //    }
            //}
            #endregion
        }
    }

}
