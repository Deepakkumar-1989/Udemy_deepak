using System;
namespace CSharpeModule1
{
   public class DoWhile
    {
        //wap to display your name 10 times using do-while loop
        public void Message()
        {
            int i = 1;
            do
            {
                Console.WriteLine("Jay Prakash");
                i++;
            } while (i <= 10);
        }
        //wap to accept a number and check whether it is Armstrong or NOt
        public void Reverse()
        {
            int num, res = 0, rem;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine()); //3650 =563
            do
            {
                rem = num % 10;// 3650%10=0 |365%10=5|36%10=6 |3%10=3
                res = res * 10 + rem;//0*10+0=0 |0*10+5=5|5*10+6=56 |56*10+3=563
                num = num / 10; //3650/10=365 |365/10=36|36/10=3 |3/10=0
            } while (num != 0);// 3650 |365 |36|3
            Console.WriteLine("After Reversing Number " + res);
        }
        public void DecimalToBinary()
        {
            int num,rem;
            String s="";
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Converted Binary Number is ");
            do
            {
                rem = num % 2;//1 | 0 |0|1|1
                s = rem + s;//1 |11001
                num = num / 2;//12 |6 |3|1|0
            } while (num > 0);//25 | 12 |6 |3|1
            Console.Write(s);//11001
        }
    }
}
