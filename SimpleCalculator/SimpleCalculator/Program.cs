using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("მოგესალმებით მარტივ კალკულატორში!");

            Console.Write("შეიყვანეთ პირველი რიცხვი: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("შეიყვანეთ მეორე რიცხვი: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("აირჩიეთ ოპერაცია:");
            Console.WriteLine("1 - მიმატება");
            Console.WriteLine("2 - გამოკლება");
            Console.WriteLine("3 - გამრავლება");
            Console.WriteLine("4 - გაყოფა");

            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                        Console.WriteLine("გაყოფა ნულზე შეუძლებელია!");
                    break;
                default:
                    Console.WriteLine("არასწორი არჩევანი!");
                    return;
            }

            Console.WriteLine("შედეგი: " + result);
        }
    }
}
