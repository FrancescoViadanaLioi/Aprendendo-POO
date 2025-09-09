using System;
using System.Security.Cryptography;
using EX17.Entities;

class Program
{
    static void Main(string[] args)
    {
        Comment c1 = new Comment("This new game looks sick, bro!");
        Comment c2 = new Comment("Can't wait to play this. Mine will arrive on next tuesday :(");
        Post post1 = new Post(
            DateTime.Parse("09/09/2025 11:06:57"),
            "The new Lego Batman is amazing!",
            "Just bought it on Steam, it's amazing! It's like Batman Arkham but Lego.",
            250);
        post1.AddComment(c1);
        post1.AddComment(c2);

        Console.WriteLine(post1.ToString());
    }
}