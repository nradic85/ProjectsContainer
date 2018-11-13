using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.Write a C# Sharp program to print Hello and your name in a separate line
            //System.Console.WriteLine("Hello:");
            //System.Console.WriteLine("Nikola Radić");

            ////2.Write a C# Sharp program to print the sum of two numbers
            //int a = 5;
            //int b = 10;
            //System.Console.WriteLine(a+b);

            ////3.Write a C# Sharp program to print the result of dividing two numbers
            //System.Console.WriteLine(b/a);

            ////4.Write a C# Sharp program to print the result of the specified operations. Go to the editor
            ////Test data:

            ////-1 + 4 * 6
            ////(35 + 5) % 7
            ////14 + -4 * 6 / 11
            ////2 + 15 / 6 * 1 - 7 % 2

            //System.Console.WriteLine((-1) + 4 * 6);
            //System.Console.WriteLine((35+5)/7);
            //System.Console.WriteLine(14+(-4)*6/11);
            //System.Console.WriteLine(2+15/6*1-7/2);

            ////5.Write a C# Sharp program to swap two numbers. Go to the editor
            ////Test Data:
            ////Input the First Number : 5
            ////Input the Second Number : 6
            ////Expected Output: 
            ////After Swapping :
            ////First Number : 6
            ////Second Number : 5

            //int number1, number2, temp;
            //Console.WriteLine("\nInput first number: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nInput second number: ");
            //number2 = int.Parse(Console.ReadLine());
            //temp = number1;
            //number1 = number2;
            //number2 = temp;
            //Console.Write("\nAfter Swapping: ");
            //Console.Write("\nFirst number: "+number1);
            //Console.Write("\nSecond number: "+number2);
            ////Console.Read();

            ////6.Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor
            ////Test Data:
            ////Input the first number to multiply: 2
            ////Input the second number to multiply: 3
            ////Input the third number to multiply: 6
            ////Expected Output:
            ////2 x 3 x 6 = 36

            //int firstNumberMultiply, secondNumberMultiply, thirdNUmberMultiply;
            //Console.WriteLine("\nInput the first number to multiply:");
            //firstNumberMultiply = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nInput the second number to multiply:");
            //secondNumberMultiply = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nInput the third number to multiply:");
            //thirdNUmberMultiply = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nOutput of multiplication of three numbers which will be entered is "+(firstNumberMultiply*secondNumberMultiply*thirdNUmberMultiply));

            ////7.Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
            ////Test Data:
            ////Input the first number: 25
            ////Input the second number: 4
            ////Expected Output:
            ////25 + 4 = 29
            ////25 - 4 = 21
            ////25 x 4 = 100
            ////25 / 4 = 6
            ////25 mod 4 = 1
            //int firstNumberMod, secondNumberMod;
            //Console.WriteLine("\nInsert first number (mod): ");
            //firstNumberMod = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nInsert second number (mod): ");
            //secondNumberMod = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n" + firstNumberMod + " + " + secondNumberMod + " = " + (firstNumberMod + secondNumberMod));
            //Console.WriteLine("\n" + firstNumberMod + " - " + secondNumberMod + " = " + (firstNumberMod - secondNumberMod));
            //Console.WriteLine("\n" + firstNumberMod + " x " + secondNumberMod + " = " + (firstNumberMod * secondNumberMod));
            //Console.WriteLine("\n" + firstNumberMod + " / " + secondNumberMod + " = " + (firstNumberMod / secondNumberMod));
            //Console.WriteLine("\n" + firstNumberMod + " % " + secondNumberMod + " = " + (firstNumberMod % secondNumberMod));
            ////Console.Read();

            ////8.Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
            ////Test Data:
            ////Enter the number: 5
            ////Expected Output:
            ////5 * 0 = 0
            ////5 * 1 = 5
            ////5 * 2 = 10
            ////5 * 3 = 15
            ////....
            ////5 * 10 = 50

            //int num, x = 10;
            //Console.WriteLine("\nInsert a number: ");
            //num = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= x; i++)
            //{
            //    Console.WriteLine("\n " + num + " * " + i + " = " + (num * i));
            //}
            ////Console.Read();

            ////9.Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
            ////Test Data:
            ////Enter the First number: 10
            ////Enter the Second number: 15
            ////Enter the third number: 20
            ////Enter the four number: 30

            ////Expected Output:
            ////The average of 10 , 15 , 20 , 30 is: 18
            ////Click me to see the solution

            //Console.WriteLine("\nInsert a number for average: ");
            //int insertNumer = int.Parse(Console.ReadLine());
            //int temp1 = 0, temp2;
            //List<int> enteredNumber = new List<int>();
            //for (int j = 1; j <= insertNumer; j++)
            //{
            //    Console.WriteLine("\nEnter the "+ j +". number: ");
            //    temp2 = int.Parse(Console.ReadLine());
            //    enteredNumber.Add(temp2);
            //    temp1 += temp2;
            //}
            //Console.WriteLine("\nAverage numer is: " + temp1/insertNumer);
            ////Console.Read();

            ////10.Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
            ////Test Data:
            ////Enter first number - 5
            ////Enter second number - 6
            ////Enter third number - 7

            ////Expected Output:
            ////Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72

            //int number1, number2, number3;
            //Console.WriteLine("\nInsert first number: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nInsert second number: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nInsert third number: ");
            //number3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n("+number1+" + "+number2+") * "+number3+" = "+(number1+number2)*number3);
            //Console.WriteLine("\n(" + number1 + " * " + number2 + ") + ("+ number2 + " * " + number3 + ") = " + ((number1 * number2)+(number2*number3)));
            ////Console.Read();

            ////11.Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". Go to the editor
            ////Test Data:
            ////Enter your age - 25
            ////Expected Output:
            ////You look older than 25

            //Console.WriteLine("\nInsert number of your age: ");
            //int ageNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("\nYou look older than "+ageNumber+" !");
            //Console.Read();

            //14.Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. Go to the editor
            //Test Data:
            //Enter the amount of celsius: 30
            //Expected Output:
            //Kelvin = 303
            //Fahrenheit = 86

            int celsius;
            Console.WriteLine("Enter the amount of celsius: ");
            celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin: "+(celsius+273.15));
            Console.WriteLine("Fahrenheit: "+((celsius*1.8)+32));
            Console.Read();
        }
    }
}
