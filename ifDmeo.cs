using System;

namespace CSharpeModule1
{
   public class ifDmeo
    {
        //wap to accept a valid number and display message if age is valid
        public void check()
        {
            int age;
            Console.WriteLine("Enter your age");//System.out.println(); in Java
            age = Convert.ToInt32(Console.ReadLine());
            if(age<=0 || age >= 130)
            {
                Console.WriteLine("Your age is Invalid");
            }
            Console.WriteLine("Your age is " + age);
        }
    }
}
