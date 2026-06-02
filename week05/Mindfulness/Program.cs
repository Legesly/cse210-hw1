using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity act = new BreathingActivity();
                act.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity act = new ReflectionActivity();
                act.Run();
            }
            else if (choice == 3)
            {
                ListingActivity act = new ListingActivity();
                act.Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
