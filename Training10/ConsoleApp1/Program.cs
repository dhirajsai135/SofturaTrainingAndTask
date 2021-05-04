using System;

namespace ConsoleApp1
{
    class Program
    {
        static int num1, num2;
        static void InputUser()
        {
            Console.WriteLine("enter the values of num1 and num2");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
        }
        static void Iteration()
        {
            //Console.WriteLine("Enter the range");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<10;i++)
            //{
            //    Console.WriteLine(" "+num+" X  "+i+"  =  "+(num*i));
            //    Console.WriteLine("_________________");
            //}
            int flag = 0, sum = 0;

            do
            {
                Console.WriteLine("The final sum " + sum);
            }
            while (flag >=0)
            {
                sum += flag;
                Console.WriteLine("Enter the values");
                flag = Convert.ToInt32(Console.ReadLine());
            }
            
            
        }
        static void FirstMethod()
        {
            //Console.WriteLine("Enter value for string");
            //string str = Console.ReadLine();
            //Console.WriteLine("You have entered " + str);
            //Console.WriteLine("Enter the value of num1");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the value of num2");
            //int num2 = Int32.Parse(Console.ReadLine());
            //int sum = num1 + num2;
            //int sub = num1 - num2;
            //int mul = num2 * num1;
            //int div = num1 / num2;
            //Console.WriteLine("Addition= " + sum + " Subtraction= " + sub + " Multiplication= " + mul + " Division= " + div);
            InputUser();
            if(num1>num2)
            {
                Console.WriteLine("Num1 {0} is greater",num1);
            }
            else
            {
                Console.WriteLine("Num2 {0} is greater", num2);
            }
        }
        static void WeekOrEnd()
        {
            Console.WriteLine("Enter the day");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "WednesDay":
                case "Thursday":
                    Console.WriteLine("It is WeekDay Goback to work");
                    break;
                case "Friday":
                    Console.WriteLine("From tommorrow it is weekend");
                    break;
                case "saturday":
                    Console.WriteLine("Only one day left for holiday ");
                    break;
                case "Sunday":
                    Console.WriteLine("Tommorrow will be Monday again LOL!!");
                    break;

                default:
                    Console.WriteLine("Enter the Days which are in the week");
                    break;
            }
        }
        static void Main(string[] args)
        {
            //FirstMethod();
            //WeekOrEnd();
            Iteration();
        }
    }
}
