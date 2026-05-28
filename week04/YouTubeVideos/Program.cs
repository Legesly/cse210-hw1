using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn C# Basics", "Code Academy", 600);
        Video video2 = new Video("Object-Oriented Programming Explained", "Dev Tutor", 900);
        Video video3 = new Video("Understanding Abstraction", "BYU Pathway", 750);

        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("Bob", "Great explanation."));
        video1.AddComment(new Comment("Charlie", "Please make more videos!"));

        video2.AddComment(new Comment("Diana", "OOP finally makes sense."));
        video2.AddComment(new Comment("Ethan", "Loved the examples."));
        video2.AddComment(new Comment("Faith", "Can you cover inheritance next?"));

        video3.AddComment(new Comment("George", "This made abstraction easy."));
        video3.AddComment(new Comment("Hannah", "Very clear and simple."));
        video3.AddComment(new Comment("Isaac", "I like how you explained it."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video v in videos)
        {
            v.Display();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
