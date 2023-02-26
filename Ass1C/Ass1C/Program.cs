using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Transactions;

namespace Ass1C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Write a program that allows the user to enter a number then print it
            //   Console.WriteLine("PLz Enter Your NUmber :");
            //  int num = Convert.ToInt32(Console.ReadLine());
            //   Console.WriteLine("the used number is : " + num);
            //   
            #endregion

            #region Q2
            // Write a program that takes a number from the user then print yes
            // if that number can be divided by 3 and 4 otherwise print no
            //Console.Write("Enter The NUmber : ");
            //int Num = int.Parse(Console.ReadLine());
            //if (Num % 4 ==0  && Num % 3 == 0 )
            //{
            //    Console.WriteLine("yes");
            //}else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion

            #region Q3
            //Write a program that allows the user to insert 2 integers then print the max
            //int x, y ;
            //Console.WriteLine("Enetr the unmber You need");
            //int Num1 = int.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());
            //if (Num1 > Num2)
            //    Console.WriteLine(Num1);
            //else 
            //   Console.WriteLine(Num2);       
            #endregion

            #region Q4

            //Write a program that allows the user to
            //insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("Enter Your Number and make it fast:");
            //int Num = int.Parse(Console.ReadLine());
            //if (Num < 0)
            //{
            //    int Y = Num * -Num;
            //    Console.WriteLine(Y);
            //}else
            //{
            //    int Y = Num * -Num;
            //}
            #endregion

            #region Q5

            /*Write a program that takes 3 integers from
            the user then prints the max element and the min element*/

            //Console.WriteLine("Enter Your Number and make it fast:");
            //int[] array = { 0, 0, 0 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Max number Is :" +array.Max());
            //Console.WriteLine("Min Number is: " + array.Min());

            #endregion
            #region Q6
            /*Write a program that allows the user to insert an integer number then
             check If a number is even or odd*/

            //Console.WriteLine("Enter Your Number and make it fast:");
            //int Num = int.Parse(Console.ReadLine());

            //if (Num % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //    Console.WriteLine("odd");
            #endregion


            #region Q7

            //Console.WriteLine("Enter Your Letter :");
            //string input = Console.ReadLine();

            //if (input == "a" || input == "e" || input == "I" || input == "o" || input == "u") {
            //    Console.WriteLine("VOWL");
            //} else
            //    Console.WriteLine("consonant");
            #endregion

            #region Q8
            /*Write a program that allows user to insert integer
            then print all numbers between 1 to that’s number.*/

            //Console.WriteLine("Enter an integer:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Numbers between 1 and " + n + ":");
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region Q9
            /* Write a program that allows user to insert integer then print a multiplication table up to 12*/
            //Console.WriteLine("Enter an integer:");
            //int Num = int.Parse(Console.ReadLine());
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(Num * array[i]);
            //}
            #endregion

            #region Q10 
            //Console.WriteLine("enter your number : ");
            //int Num = int.Parse(Console.ReadLine());

            //for (int i = 0;i <= Num; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Q11

            /*Write a program that take two integers then print the power*/

            //Console.WriteLine("Enter the number ");
            //int Num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the power");
            //int Pow = int.Parse(Console.ReadLine());

            //int result = 1;
            //for (int i = 1; i <= Pow; i++)
            //{
            //     result *= Num;
            //}
            //Console.WriteLine(result);

            #endregion

            #region Q12
            /*Write a program to enter marks of five subjects and calculate total, average and percentag*/
            //Console.WriteLine("Enter Numbers:");

            //int result = 0;
            //int Avg = 0;
            //for (int i = 0; i <= 4; i++)
            //{

            //    int Num = int.Parse(Console.ReadLine());
            //    result += Num;
            //    Avg = result / 5;
            //}
            //Console.WriteLine(result);
            //Console.WriteLine(Avg);
            #endregion

            #region Q13

            //Console.WriteLine("Enter Month Number :");
            //int Mon = int.Parse(Console.ReadLine());
            //int Days = DateTime.DaysInMonth(2022 , Mon);
            //Console.WriteLine(Days);
            #endregion

            #region Q14
            /*.Write a program to input marks of five subject
             s Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade*/

            //string[] mark = {"Physics", "Chemistry", "Biology", "Mathematics", "Computer"};

            //Console.WriteLine("enter percantage: ");

            //for (int i = 0; i <= mark.Length; i++)
            //{
            //    double Percentage = int.Parse(Console.ReadLine());
            //    if (Percentage >= 90 )
            //    {
            //        Console.WriteLine("Grad A");

            //    }
            //    else if (Percentage >= 80)
            //    {
            //        Console.WriteLine("Grad B");
            //    }
            //    else if (Percentage >= 70)
            //    {
            //        Console.WriteLine("Grad C");
            //    }
            //    else if (Percentage >= 60)
            //    {
            //        Console.WriteLine("Grad D");
            //    }
            //    else if (Percentage >= 40)
            //    {
            //        Console.WriteLine("Grad E");
            //    }
            //    else if (Percentage < 40)
            //    {
            //        Console.WriteLine("Grad F");
            //    }
            //    else
            //    {
            //        Console.WriteLine("not correct");
            //    }

            //}
            #endregion
            #region Q15 
            /*Write a program to check whether a number is positive or negative or zero using Switch*/
            //Console.WriteLine("enter number: ");
            //int Num = int.Parse(Console.ReadLine());
            //switch (Num)
            //{
            //    case > 0:
            //        Console.WriteLine("Positive");
            //        break;
            //    case < 0:
            //        Console.WriteLine("negative");
            //        break;
            //    case  0:
            //        Console.WriteLine("equal 0");
            //        break;
            //}
            #endregion

            #region Q16
            /* Write a program to create a Simple Calculator using Switch*/
            //Console.WriteLine("Enter First Number : ");
            //int Num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Secound Number : ");
            //int Num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operator (+, -, *, /): ");
            //string op = Console.ReadLine();

            //double result = 0; 

            //    switch (op)
            //    {
            //        case "+" :
            //            Console.WriteLine(Num + Num2);
            //            break;
            //        case "*" :
            //            Console.WriteLine(Num * Num2);
            //            break;
            //        case "-": 
            //        Console.WriteLine(Num - Num2);
            //            break;
            //        case "/":
            //            Console.WriteLine(Num / Num2);
            //            break;
            //    }        

            #endregion

            #region Q17
            /* Write a program to allow user to enter string and print the REVERSED of it.*/

            Console.WriteLine("enter your String : ");
            string Enter = Console.ReadLine();
            string Enter2 = "";
            for (int i = Enter.Length; i > 0; i--)
            {
                Enter2 += Enter[i];
            }
            #endregion
        }
    }
}