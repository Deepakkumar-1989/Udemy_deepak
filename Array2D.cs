using System;

namespace CSharpeModule1
{
    public class Array2D
    {
        /*
                 Java                Vs              C# 

        int[][] arr=new int[3][4];       int[,] arr=new int[3,4];

             */
        public void DataDisplay()
        {
            int[,] arr = new int[3, 4];
            int i, j;
            Console.WriteLine("Enter Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Data for row "+(i+1));
                for (j = 0; j < 4; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());// arr[i][j]=sc.nextInt();
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Stored Data in 2D Array");
            for (i = 0; i < 3; i++)
            {      
                for (j = 0; j < 4; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
        //wap to store string in 2D array and display it.
        public void DataDetails_String()
        {
            String[,] arr = new String[3, 4];
            int i, j;
            Console.WriteLine("Enter Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Name, Age, Address & Qualification " + (i + 1));
                for (j = 0; j < 4; j++)
                {
                    arr[i, j] = Console.ReadLine();// arr[i][j]=sc.nextInt();
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Stored Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //wap to store Character in 2D array and display it.
        public void DataDetails_Character()
        {
            char[,] arr = new char[3, 4];
            int i, j;
            Console.WriteLine("Enter Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter 4 Characters " + (i + 1));
                for (j = 0; j < 4; j++)
                {
                    arr[i, j] = Convert.ToChar(Console.ReadLine()); // arr[i][j]=sc.nextInt();
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Stored Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //wap to store numbers in array and display only even number
        public void EvenNumber()
        {
            int[,] arr = new int[3, 4];
            int i, j;
            Console.WriteLine("Enter Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Data for row " + (i + 1));
                for (j = 0; j < 4; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());// arr[i][j]=sc.nextInt();
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Stored Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("_" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
        //wap to store numbers in array and display sum of each row elements 
        public void SumRow()
        {
            int[,] arr = new int[3, 4];
            int sum = 0;
            int i, j;
            Console.WriteLine("Enter Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Data for row " + (i + 1));
                for (j = 0; j < 4; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());// arr[i][j]=sc.nextInt();
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Stored Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                        Console.Write(arr[i, j] + "\t");
                    sum += arr[i, j];//sum =sum+arr[i,j];
                }
                Console.WriteLine(sum+"\t");
                sum = 0;
            }
        }
        //wap to store numbers in array and display sum of each row elements 
        public void SumCol()
        {
            int[,] arr = new int[3, 4];
            
            int[] sum = new int[4];
            int i, j,res=0;
            Console.WriteLine("Enter Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Data for row " + (i + 1));
                for (j = 0; j < 4; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());// arr[i][j]=sc.nextInt();
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Stored Data in 2D Array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine(sum + "\t");
                for(int k = 0; k < 4; k++)
                {
                    res += arr[k,i];
                }
                sum[i] = res;
                res = 0;
            }
            foreach(int p in sum)
            {
                Console.WriteLine(p + "\t");
            }
        }
    }
}
/*
 1. wap to store numbers in an array and display only prime no
 2 WAP to display sum of each row of an array and display it
     */