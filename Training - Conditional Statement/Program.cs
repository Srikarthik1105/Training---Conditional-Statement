using System;

namespace Training
{
    class Conditional_Statement
    {

// Sum of Two Numbers
        public void Sumoftwonumber()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine("The Sum of Two Numbers is : {0}", result);

            Console.ReadLine();
        }

// Subraction of Two Numbers
        public void Subraction()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 - number2;
            Console.WriteLine("The Subraction of Two Numbers is : {0}", result);

            Console.ReadLine();
        }

// Multiplication of Two Numbers
        public void Multiplication()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2;
            Console.WriteLine("The Multiple of Two Numbers is : {0}", result);

            Console.ReadLine();
        }

// Division of Two Numbers
        public void Divison()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 / number2;
            Console.WriteLine("The Division of Two Numbers is : {0}", result);

            Console.ReadLine();
        }

// WAP for Largest Of Two Numbers
        public void Largest_of_two_number()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("The Lagest Number of Two Numbers is : {0}", number1);
            }
            else
            {
                Console.WriteLine("The Lagest Number of Two Numbers is : {0}", number2);
            }

            Console.ReadLine();

        }

// WAP for Largest Of Three Numbers
        public void Largest_of_three_number()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Third Number : ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("The Lagest Number of Three Numbers is : {0}", number1);
            }
            else if (number2 > number3 && number2 > number1)
            {
                Console.WriteLine("The Lagest Number of Three Numbers is : {0}", number2);
            }
            else
            {
                Console.WriteLine("The Lagest Number of Three Numbers is : {0}", number3);
            }

            Console.ReadLine();
        }

// WAP To Find Even Number
        public void Find_even_number()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("{0} is Even Numbers", number1);
            }
            else
            {
                Console.WriteLine("{0} is Odd Numbers", number1);
            }

            Console.ReadLine();
        }

// WAP To Find the Number is Divisible by 5 and 10
        public void Divible_by_five_ten()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 % 10 == 0)
            {
                Console.WriteLine("{0} is Divisible by 10", number1);
            }
            else if (number1 % 5 == 0)
            {
                Console.WriteLine("{0} is Divisible by 5", number1);
            }
            else
            {
                Console.WriteLine("{0} is Not Divisible by 5 and 10", number1);
            }

            Console.ReadLine();

        }

// WAP If Sum Of Two Number is Greater than 100 or not
        public void Greaterthanhundred()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the First Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            if (sum >= 100)
            {
                Console.WriteLine("True, It is Greater Than 100");
            }
            else
            {
                Console.WriteLine("False, It is not Greater Than 100");
            }

            Console.ReadLine();

        }

// WAP If Multiplication Of Two Number is Greater than 200
        public void Greaterthantwohundred()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the First Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int Multiply = number1 * number2;

            if (Multiply > 200)
            {
                Console.WriteLine("True, It is Greater Than 200");
            }
            else
            {
                Console.WriteLine("False, It is Not Greater Than 200");
            }

            Console.ReadLine();

        }

// WAP The example of modulas operator
        public void Modulas()
        {
            Console.Write("Enter the First Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 % number2;
            Console.WriteLine("Remainder : {0}", result);

            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conditional_Statement cs = new Conditional_Statement();

            Console.WriteLine(" (1) SUM OF TWO NUMBERS");
            Console.WriteLine(" (2) SUBRACTION OF TWO NUMBERS");
            Console.WriteLine(" (3) MULTIPLICATION OF TWO NUMBERS");
            Console.WriteLine(" (4) DIVISION OF TWO NUMBERS");
            Console.WriteLine(" (5) LARGEST NUMBER OF TWO NUMBER");
            Console.WriteLine(" (6) LARGEST NUMBER BETWEEN THREE NUMBER");
            Console.WriteLine(" (7) FIND THE EVEN NUMBER");
            Console.WriteLine(" (8) FIND THE NUMBER IS DIVISIBLE BY 5 AND 10");
            Console.WriteLine(" (9) IF SUM OF TWO NUMBER IS GREATER THAN 100 OR NOT");
            Console.WriteLine("(10) IF MULTIPLICATION OF TWO NUMBER IS GREATER THAN 200");
            Console.WriteLine("(11) EXAMPLE OF MODULAS OPERATOR");
            Console.WriteLine();

            L:Console.Write("SELECT THE NUMBER : ");

            int select = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (select)
            {
                case 1:
                    cs.Sumoftwonumber();
                    break;

                case 2:
                    cs.Subraction();
                    break;

                case 3:
                    cs.Multiplication();
                    break;

                case 4:
                    cs.Divison();
                    break;

                case 5:
                    cs.Largest_of_two_number();
                    break;

                case 6:
                    cs.Largest_of_three_number();
                    break;

                case 7:
                    cs.Find_even_number();
                    break;

                case 8:
                    cs.Divible_by_five_ten();
                    break;

                case 9:
                    cs.Greaterthanhundred();
                    break;

                case 10:
                    cs.Greaterthantwohundred();
                    break;

                case 11:
                    cs.Modulas();
                    break;

                default:
                    Console.WriteLine("------INVAILD INPUT-----");
                    Console.WriteLine();
                    goto L;
            }
        }
    }
}
