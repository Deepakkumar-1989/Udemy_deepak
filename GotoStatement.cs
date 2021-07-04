using System;
namespace CSharpeModule1
{
    class GotoStatement
    {
        //wap to display your name 10 times without using loop 
        /*
         abc:
             statements ;
             if(condition)
                goto abc;
             */
        public void username()
        {
            int i = 1;
            msg:
                Console.WriteLine("Jay Prakash");
                i++;
            if (i <= 10)
                goto msg;

        }
        //wap to display first 10 natural number 17 8 
        public void Prime()
        {
            int num,k=0;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());// num=17
            int i = 2; 
        check:
            if (num % i == 0)//17/5
            {
                k = 1;
            }
            i++;
            if (i <= num/2)//i=5<=8
                goto check;
            if (k == 0)
            {
                Console.WriteLine("Prime No");
            }
            else
            {
                Console.WriteLine("Not Prime No");
            }

        }

        //wap to display all Prime Number between 1 - 100 Nested goto Statement
        public void Prime1_100()
        {
            int  k=0;
            Console.WriteLine("All Prime Number between 1- 100");
            int i;
            int j=1;
        num:
            i = 2;
        check:
            if (j==i)
            {
                Console.Write(j + "\t");
            }
            if (j % i == 0)
            {
                k = 1;
            }
            i++;
            if (i < j )
                goto check;
            if (k == 0)
            {
                Console.Write(j+"\t");
            }
            k = 0;
            j++;
            if (j < 100)
                goto num;
        }

    }
}
//Program based on goto statements 
/*
    1. WAP to accept a number and reverse it.
    2. WAP to accept a number and Display sum of its digit
    3. WAP to accept a number and Display Product of its digit
    4. WAP to accept a number and Check whether it is Palindrom number or not (121,15651,1331)
    5. WAP to accept a number and Check whether it is armstrong number or not (153,370,371,407)
    3. WAP to Display fabonice Serice upto n terms, (0,1,1,2,3,5,8,13,21,34,55,89....)
     */
