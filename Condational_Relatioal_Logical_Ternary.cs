using System;
namespace CSharpeModule1
{
    class Condational_Relatioal_Logical_Ternary
    {
        //wap to accept age of a person and check whether he/she can vote or not 
            public void check_age()
            {
                int age;
                string res;
                Console.WriteLine("Enter Your age");
                age = Convert.ToInt32(Console.ReadLine());

                //syntax of ternary opeator (condition) ? true:false;

                res = (age<1)?"Pls enter Valid age":(age >= 18) ? "You can Vote" : "You cant vote";
                Console.WriteLine("Result is " + res);

            }
        //wap to accept three number and display greater 1
        public void Greater()
        {
            int num1, num2,num3, res;
            Console.WriteLine("Enter two number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            res = ((num1 > num2) &&(num1>num3))? num1 :((num2>num1) &&( num2>num3))?num2:num3;
            Console.WriteLine("Greater Number is " + res);
        }
        //wap to accept three number and display greater 1 when two number are equal
        public void GreaterEqual()
        {
            int num1, num2, num3, res;
            Console.WriteLine("Enter two number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            res = ((num1 == num2) && (num1 > num3)) ? num1 : ((num2 == num3) && (num2 > num1)) ? num2 : ((num1==num3) && (num3>num2))?num3:(num1>num2 && num1>num3)?num1:(num2>num1 && num2>num3)?num2:num3;
            Console.WriteLine("Greater Number is " + res);
        }
        //wap to accept Experience and salary of a person and give promotion on the basis of experience and salary 

        public void Promotion()
        {
            int experience;
            double salary;
            Console.WriteLine("Enter Your Experience and Salary");
            experience = Convert.ToInt32(Console.ReadLine());
            salary = Convert.ToDouble(Console.ReadLine());
            double newsalary = (experience >= 5 && salary >= 45000) ? salary * 1.35 : (experience >= 6 && salary >= 60000) ? salary * 1.7 : salary * 1.2;
            Console.WriteLine("New Salary is " + newsalary);
        }
    }
}
