class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
        }
    }
}
