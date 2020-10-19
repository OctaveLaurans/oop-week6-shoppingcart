using System;

namespace OOP_Online_Class_19_10
{
    class Program
    {
        static void WithInterface()
        {
            int apple = 0;
            int orange = 0;
            int rep;
            do
            {
                Console.WriteLine(" What de you wand to do :\n"
                    + "1 Add an Apple to your order\n"
                    + "2 Add an Orange to your order\n"
                    + "3 Finish your order\n");
                rep = Convert.ToInt32(Console.ReadLine());

                switch (rep)
                {
                    case 1:
                        apple++;
                        break;
                    case 2:
                        orange++;
                        break;
                    case 3:
                        double bill = apple * 0.65 + orange * 0.25;
                        Console.WriteLine("You will have to pay £" + bill);
                        break;
                    default:
                        break;
                }
            }
            while (rep != 3);
            Console.WriteLine("Thank you for ordering here!");
            Console.ReadKey();
        }

        static void WithoutInterface()
        {
            Console.WriteLine("How many apples do you want ?");
            int apple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many oranges do you want ?");
            int orange = Convert.ToInt32(Console.ReadLine());

            double bill = apple * 0.65 + orange * 0.25;
            Console.WriteLine("You have to pay £" + bill);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose how you want to order in our shop:\n"
                    + "1 One item by one\n"
                    + "2 All item at the same time\n"
                    + "3 Leave the shop\n");
            int res = Convert.ToInt32(Console.ReadLine());
            switch(res)
            {
                case 1:
                    WithInterface();
                    break;
                case 2:
                    WithoutInterface();
                    break;
                default:
                    Console.WriteLine("You left the shop by being hesitant");
                    break;
            }
            Console.ReadKey();
        }
    }
}
