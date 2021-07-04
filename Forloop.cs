using System;
namespace CSharpeModule1
{
   public class Forloop
    {
        public void Message()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("UdeshaTechWorld");
            }
        }
        //wap to accept binary number and convert to decimal number

            //  1   1   1   1   1   1   1
            //  64  32  16  8   4   2   1
         public void BinaryToDecimal()
        {
            int num, rem,b=1;
            double res =0;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());//1
            Console.WriteLine("Converted Decimal Number is ");
            for (; num > 0; num = num / 10) {
                rem = num % 10;//1
                res = res + rem*b; //0+1*1=1 |1+0*2=1 |1+0*4=1|1+1*8=9|9+1*16=25
                b = b * 2; //1*2=2|2*2=4|4*2=8|8*2=16|16*2=32

            } 
            Console.Write(res);

        }
    }
}
