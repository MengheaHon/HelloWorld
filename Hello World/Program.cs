using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstFriend = "Alex";
            string SecondFriend = "Menghea";
            Console.WriteLine($"My Friend are {FirstFriend} and {SecondFriend}" );
            Console.WriteLine();
            // Find Length string
            Console.WriteLine($"The name: {FirstFriend} has {FirstFriend.Length} letters.");
            Console.WriteLine($"The name: {SecondFriend} has {SecondFriend.Length} letters.");
        }
    }
}
