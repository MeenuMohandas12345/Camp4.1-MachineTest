using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    // Class representing a Book
    public class Book
    {
        public int Id { get; }
        public string Name { get; }
        public string Category { get; }

        public Book(int id, string name, string category)
        {
            Id = id;
            Name = name;
            Category = category;
        }

        public string GetBookDetails()
        {
            return $"ID: {Id}  \nName: {Name} \nCategory: {Category}";
        }
    }

    // Interface for managing books
    public interface IBooks
    {
        void AddBook(int id, string name, string category);
        void GetDetails();
    }

    // Class implementing the IBooks interface
    public class Books : IBooks
    {
        private List<Book> bookList = new List<Book>();

        // Method to add book details
        public void AddBook(int id, string name, string category)
        {


            try
            {
                if (bookList.Exists(book => book.Id == id))
                {
                    Console.WriteLine("Book with the same ID already exists.");
                }
                else
                {
                    Book newBook = new Book(id, name, category);
                    bookList.Add(newBook);
                    Console.WriteLine("Book added successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            
        }

        // Method to retrieve book details
        public void GetDetails()
        {
            if (bookList.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("Book Details");
            Console.WriteLine("--------------");
            foreach (var book in bookList)
            {
                Console.WriteLine(book.GetBookDetails());
            }
        }

        // Method to search for a book by ID
        public void SearchBookById(int id)
        {
            try
            {
                var foundBook = bookList.Find(book => book.Id == id);
                if (foundBook != null)
                {
                    Console.WriteLine($"Book found with ID {id}:");
                    Console.WriteLine($"ID: {foundBook.Id}, Name: {foundBook.Name}, Category: {foundBook.Category}");
                }
                else
                {
                    Console.WriteLine($"No book found with ID {id}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            
        }
    }



}



