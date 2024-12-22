using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int phy, math, urdu, english = 0;
            Console.WriteLine("Enter the Physics Mark");
            phy = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the Math Mark");
            math = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the English Mark");
            english = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the Urdu Mark");
            urdu = Convert.ToInt16(Console.ReadLine());

            int totalMark = 350;

            int totalObtainMark = phy + math + english + urdu;

            float percentage = totalObtainMark * 100 / totalMark;

            Console.WriteLine("Total Obtain Mark\n"+totalObtainMark);

            Console.WriteLine("Percentage:\n"+percentage+"%");

            if (percentage > 80)
            {
                Console.WriteLine("Grade A+");
            }
            else if (percentage > 70)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage > 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage > 50)
            {
                Console.WriteLine("Grade C");
            }
            else if (percentage > 40)
            {
                Console.WriteLine("Grade D");
            }
            else {
                Console.WriteLine("Fail");

            }


            switch (percentage)
            {
                case >=80:
                    Console.WriteLine("Grade A+");
                    break;
                case >= 70:
                    Console.WriteLine("Grade A");
                    break;
                case >= 60:
                    Console.WriteLine("Grade B");
                    break;
                case >= 50:
                    Console.WriteLine("Grade C");
                    break;
                case >= 40:
                    Console.WriteLine("Grade D");
                    break;
                case >= 30:
                    Console.WriteLine("Fail");
                    break;
            }
        }
    }
}
