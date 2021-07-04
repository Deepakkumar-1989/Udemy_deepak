using System;
namespace CSharpeModule1
{
   public class ArrayPart2
    {
        //wap to accept a string and reverse it.
        string s;
        public void ReverseString()
        {
            Console.WriteLine("Enter a String");
            s = Console.ReadLine();
            string s2 = "";
            int i = s.Length;
            for(int a = 0; a < i; a++)
            {
                s2 = s[a] + s2;
            }
            Console.WriteLine("Now New String is  " + s2);
        }
        //wap to accept a number and search in an array

        public void Linear()
        {
            int sh;
            int[] arr = new int[] { 25, 13, 65, 4, 98, 45, 34, 45, 7, 73, 44, 9, 78, 35, -4, 25 };
            int l = arr.Length;
            int i;
            Console.WriteLine("Enter a number which you want to search");
            sh = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<l; i++)
            {
                if (arr[i] == sh)
                {
                    break;
                }
            }
            if (i == l)
            {
                Console.WriteLine("Data NOt found");
            }
            else
            {
                Console.WriteLine(arr[i]+" Found at " + (i + 1) + " Position");
            }
        }
        
        //wap to accept a number and search in an array

        public void LinearMultiple()
        {
            int sh;
            int[] arr = new int[] { 25, 35, 65, 4, 98, 45, 35, 45, 7, 73, 44, 9, 78, 35, -4, 25 };
            int l = arr.Length;
            int i,k=0;
            Console.WriteLine("Enter a number which you want to search");
            sh = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < l; i++)
            {
                if (arr[i] == sh)
                {
                    Console.WriteLine(arr[i] + " Found at " + (i + 1) + " Position");
                    k = 1;
                }
            }
            if (k==0)
            {
                Console.WriteLine("Data Not Found");  
            }
        }
        //wap to accept a number and search in an array
        public void Binary_Search()
        {
            int sh;
            int[] arr = new int[] {7,11,13,19,23,29,31,33,39,41,45,48,51,56,65,71,78,84};
            int l = arr.Length;
            int min = 0, max = l - 1, mid;
            int i, k = 0;
            Console.WriteLine("Enter a number which you want to search");
            sh = Convert.ToInt32(Console.ReadLine());
            while (min <= max)
            {
                mid = (min + max) / 2;//8+17/2=12
                if (arr[mid] == sh)
                {
                    Console.WriteLine("Data Found");
                    k = 1;
                    break;
                }
                else if (arr[mid] > sh)
                {
                    max = mid - 1;
                }
                else if (arr[mid] < sh)
                {
                    min = mid + 1;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Data Not Found");
            }
        }

        //wap to Sort Data in Array Using Bubble SOrt
        public void Bubble()
        {
            int i, j, temp = 0;
            int[] arr = new int[] { 25, 35, 65, 4, 98, 45, 35, 45, 7, 73, 44, 9, 78, 35, -4, 25 };
            int l = arr.Length;

            Console.WriteLine("Data Before Soring ");
            for (i = 0; i < l; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            for (i = 0; i < l - 1; i++)
            {
                for (j = 0; j < l - 1 - i; j++)
                {
                    if (arr[j] > arr[j +1])
                    {
                        temp = arr[j];//65
                        arr[j] = arr[j + 1];//65
                        arr[j + 1] = temp;//65
                    }
                }
            }
            Console.WriteLine("\n\n Data After Sorting ");
            for (i = 0; i < l; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

        //wap to Sort Data in Array Using Selection SOrt
        public void Selection()
        {
            int i, j, temp = 0;
            int[] arr = new int[] { 25, 35, 65, 4, 98, 45, 35, 45, 7, 73, 44, 9, 78, 35, -4, 25 };
            int l = arr.Length;

            Console.WriteLine("Data Before Soring \n\n");
            for (i = 0; i < l; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            for (i = 0; i < l - 1; i++)
            {
                for (j = i + 1; j < l; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];//65
                        arr[i] = arr[j];//65
                        arr[j] = temp;//65
                    }
                }
            }
            Console.WriteLine("\n\n Data After Sorting ");
            for (i = 0; i < l; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
            //wap to Sort Data in Array 
        public void ArraySort()
         {
                int i;
                int[] arr = new int[] { 25, 35, 65, 4, 98, 45, 35, 45, 7, 73, 44, 9, 78, 35, -4, 25 };
                int l = arr.Length;

                Console.WriteLine("Data Before Soring \n\n");
                for (i = 0; i < l; i++)
                {
                    Console.Write(arr[i] + "\t");
                }
                Array.Sort(arr);
                Console.WriteLine("\n\n Data After Sorting ");
                for (i = 0; i < l; i++)
                {
                    Console.Write(arr[i] + "\t");
                }
        }
        //wap to Sort Data in Array using foreach Loop 
        /*
           foreach (int i in arr){
            Console.WriteLine(i);
           }
             */
        public void ArrayForeach()
        {
            int[] arr = new int[] { 25, 35, 65, 4, 98, 45, 35, 45, 7, 73, 44, 9, 78, 35, -4, 25 };        
            Console.WriteLine("Data Before Soring \n\n");
            foreach (int a in arr)
                Console.Write(a + "\t");
            Array.Sort(arr);
            Console.WriteLine("\n\n Data After Sorting ");

            foreach (int a in arr)

                Console.Write(a + "\t");
            
        }
    }
}
