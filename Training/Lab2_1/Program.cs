﻿using System;
using Lab2_1;

namespace CSharp_Net_module1_2_1_lab
{

    class Program
    {
        static void Main(string[] args)
        {
            // 8) declare 2 objects. Use default and paremeter constructors
            LibraryUser user1 = new LibraryUser(), user2 = new LibraryUser("Maria", "Ivanenko",2, "+38044777777");
            Console.WriteLine("User1 " + user1.FirstName + " " + user1.LastName + " " + user1.Phone + " " + user1.BookLimit);
            Console.WriteLine("User2 " + user2.FirstName + " " + user2.LastName + " " + user2.Phone + " " + user2.BookLimit);
            
            // 9) do operations with books for all users: run all methods for both objects
            Console.WriteLine("User 1: add Harry Potter");
            user1.AddBook("Harry Potter");
            Console.WriteLine("user1.BookInfo: " + user1.BookInfo());
            Console.WriteLine("User 2: add Sherlock Holmes");
            user2.AddBook("Sherlock Holmes");
            Console.WriteLine("user2.BookInfo: " + user2.BookInfo());
            Console.WriteLine("user1.BooksCount = " + user1.BooksCount() + "; user2.BooksCount " + user2.BooksCount());
            Console.WriteLine("user2 :");
            Console.WriteLine("Add Kobzar");
            user2.AddBook("Kobzar");
            Console.WriteLine("user2.BooksCount " + user2.BooksCount());
            Console.WriteLine("Add Dorian Gray");
            user2.AddBook("Dorian Gray");
            Console.WriteLine("user2.BookInfo: " + user2.BookInfo());
            Console.WriteLine("user2.BooksCount " + user2.BooksCount());
            Console.WriteLine("user2 books " + user2[0] + "\n" + user2[1]);
            Console.WriteLine("Remove Sherlock Holmes");
            user2.RemoveBook("Sherlock Holmes");
            Console.WriteLine("user2.BooksCount " + user2.BooksCount());

            Console.ReadKey();
        }
    }
}
