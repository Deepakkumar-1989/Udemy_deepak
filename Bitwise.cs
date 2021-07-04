using System;
namespace CSharpeModule1
{
    public class Bitwise
    {
        //wap to demonstrate Bitwise and operator
        public void BitwiseAnd()
        {

            //    1      1   1   1   1   1  1   1   1   1   1
            //  1024    512 256 128 64  32  16  8   4   2   1            
            int i = 7; //  0111
            int j = 10; // 1010
            Console.WriteLine("Bitwise and Result is " + (i & j));
        }
        public void BitwiseOr()
        {

            //    1      1   1   1   1   1  1   1   1   1   1
            //  1024    512 256 128 64  32  16  8   4   2   1            
            int i = 7; //  0111
            int j = 10; // 1010
            Console.WriteLine("Bitwise and Result is " + (i | j));
        }
    }
}
