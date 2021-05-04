using System;

namespace Task28Apr
{
    class Program
    {
        static void EvenorOdd()
        {

            int num1 = Convert.ToInt32(Console.ReadLine());
            if(num1%2==0)
            {
                Console.WriteLine("Number you have entered is Even "+num1);
            }
            else if(num1%2==1)
            {
                Console.WriteLine("Number you have entered is Odd " + num1);
            }
        }
        static void Divisible7Sum()
        {
            
            int flag = 0, sum = 0;
            while(flag>=0)
            {
                Console.WriteLine("Enter the number");
                flag = Convert.ToInt32(Console.ReadLine());
                if(flag%7==0)
                {
                    sum += flag;
                }
            }
            Console.WriteLine("Sum of numbers which are divisble by 7 is "+sum);
        }
        static void PrimeBtwnRange()
        {
            Console.WriteLine("Enter the low Range Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the High Range Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int flag;

            Console.WriteLine("\nPrime numbers between {0} and {1} are: " ,num1,num2);

            for(int i=num1;i<=num2;i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
        static void CheckUnPass()
        {
            int counter = 0;
            for(int i=1;i<=3;i++)
            {
                Console.WriteLine("Enter the username :");
                String UserName = Console.ReadLine();
                Console.WriteLine("Enter the Password :");
                String Password = Console.ReadLine();

                if (UserName != "Ramu" && Password != "1234")
                {
                    Console.WriteLine("You have logged is Failed Please Re-Enter");
                    counter++;
                }
                else
                    break;
            }
            if (counter >= 3)
                Console.WriteLine("Your Account has been Blocked");
            else
                Console.WriteLine("Login successful");
        }
        static void Calculator() {
            Console.WriteLine("Enter number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter which operation to be performed ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "add":
                    Console.WriteLine("Sum of two numbers is "+(num1+num2));
                    break;
                case "subtract":
                    Console.WriteLine("Subtraction of two numbers is " + (num1 - num2));
                    break;
                case "multiply":
                    Console.WriteLine("Multiplication of two numbers is " + (num1 * num2));
                    break;
                case "divide":
                    Console.WriteLine("Division of two numbers " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Operation cannot be performed");
                    break;
            }

        }
        static void Main(string[] args)
        {
            //EvenorOdd();
            //Divisible7Sum();
            //PrimeBtwnRange();
            //CheckUnPass();
            Calculator();
        }
    }
}
