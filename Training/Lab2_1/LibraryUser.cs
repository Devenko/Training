using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2_1
{
    // 1) declare interface ILibraryUser
    public interface IlibraryUser
    {
        void AddBook(string bookName);
        void RemoveBook(string bookName);
        string BookInfo();
        int BooksCount();

    }

    // declare method's signature for methods of class LibraryUser
    class LibraryUser : IlibraryUser
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        static public int Id = 0;
        public string Phone { get; set; }
        public int BookLimit { get; private set; }
        private string[] BookList = new string[Id];

        public LibraryUser(string firstName = "", string lastName = "", int bookLimit = 5, string phone = "")
        {
            FirstName = firstName;
            LastName = lastName;
            BookLimit = bookLimit;
            Phone = phone;
        }

        //public string phone(string phone )
        //{
        //    Match match = Regex.Match(phone, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");
        //    return string.Format("({0}) {1}-{2}", match.Groups[1], match.Groups[2], match.Groups[3]);
        //}

        public string this[int index]
        {
            get
            {
                string temp;
                if (index >= 0 && index <= Id-1)
                {
                    temp = BookList[index];
                }
                else
                {
                    temp = "";
                }

                return temp;
            }
            set
            {
                if (index >= 0 && index < BookLimit)
                {
                    BookList[index] = value;
                    ++Id;
                }
            }
        }

        public void AddBook(string bookName)
        {
            if (BookList.Length + 1 <= BookLimit)
            {
                ++Id;
                Array.Resize(ref BookList, Id);
                BookList[Id - 1] = bookName;
            }
            else
            {
                Console.WriteLine("You have reached the limit of books");
            }
        }

        public void RemoveBook(string bookName)
        {
            int j = 0;
            string[] temp = new string[BookLimit];
            for (int i = 0; i <= Id; i++)
            {
                if (BookList[i] == bookName)
                {
                    BookList[i] = null;
                    --Id;
                }
                else
                {
                    temp[j] = BookList[i];
                    BookList[i] = null;
                    j++;
                }
            }

            for (int i = 0; i <= Id; i++)
            {
                BookList[i] = temp[i];
            }
        }

        public string BookInfo()
        {
            string s;
            s = $"User {FirstName} {LastName} has thee following books: \n";
            foreach (string VARIABLE in BookList)
            {
                if (VARIABLE != null)
                {
                    s += new string(' ', 4) + VARIABLE + "\n";
                }
            }
            return s;
        }

        public int BooksCount()
        {
            return BookList.Length;
        }
    }


    // 2) declare class LibraryUser, it implements ILibraryUser


    // 3) declare properties: FirstName (read only), LastName (read only), 
    // Id (read only), Phone (get and set), BookLimit (read only)

    // 4) declare field (bookList) as a string array


    // 5) declare indexer BookList for array bookList

    // 6) declare constructors: default and parameter

    // 7) declare methods: 

    //AddBook() – add new book to array bookList

    //RemoveBook() – remove book from array bookList

    //BookInfo() – returns book info by index

    //BooksCout() – returns current count of books



}
