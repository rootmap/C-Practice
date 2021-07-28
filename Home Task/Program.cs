using System;

namespace Home_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteResult();
        }

        static void ExecuteResult()
        {
            String a = "Fail";
            String b = "Pass";
            String c = "Merit";
            String d = "Distinction";
            int userInput = 0;

            Console.WriteLine("Please enter your score?");
            
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput >= 0 && userInput <= 39)
                {
                    Console.WriteLine("Your Result is : " + a);

                }
                else if (userInput >= 40 && userInput <= 59)
                {
                    Console.WriteLine("Your Result is : " + b);
                }
                else if (userInput >= 60 && userInput <= 69)
                {
                    Console.WriteLine("Your Result is : " + c);
                }
                else if (userInput >= 70 && userInput <= 100)
                {
                    Console.WriteLine("Your Result is : " + d);
                }
                else
                {
                    Console.WriteLine("Invalid Input Range, Please enter a valid score.");
                }

                Console.WriteLine("Would you like to continue check your next result using score?");
                String userOpinion = Convert.ToString(Console.ReadLine());
                switch (userOpinion)
                {
                    case "Yes":
                        Console.WriteLine("Re-Generating.....");
                        ExecuteResult();
                        break;
                    case "Y":
                        Console.WriteLine("Re-Generating.....");
                        ExecuteResult();
                        break;
                    case "No":
                        Console.WriteLine("Closing the console app");
                        break;
                    default:
                        Console.WriteLine("Closing the console app");
                        break;

                }

                
            }
            catch(Exception e)
            {
                //Console.WriteLine("Your Input is wrong. Please type numaric data"+e);
                Console.WriteLine("Your Input is wrong. Please type numaric data");
            }
            finally
            {
                Console.WriteLine("Re-try with a different number.");
            }

            

            
        }
    }
}
