/*SET -1

Create an application to manage a library.The application will 
have an interface Ibooks that has the methods AddBooks and GetDetails
A class Books that has the methods AddBooks()to add the details
of the book like id, name and category  and GetBookDetails() to
retrieve the details of the books. This class should implement
from IBooks .The AddBooks and GetBookDetails should be a choice 
get from the user.Retrieve the details of the books into a suitable 
collection Handle all exceptions at runtime.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Library Management System");
            Books library = new Books();

            while (true)
            {
                
                Console.WriteLine("\n1. Add Book");
                Console.WriteLine("2. Get All Book Details");
                Console.WriteLine("3. Search Book by ID");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice (1-4): ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Book ID: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.Write("Enter Book Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Book Category: ");
                            string category = Console.ReadLine();

                            library.AddBook(id, name, category);
                            break;

                        case 2:
                            library.GetDetails();
                            break;

                        case 3:
                            Console.Write("Enter Book ID to search: ");
                            int searchId = int.Parse(Console.ReadLine());
                            library.SearchBookById(searchId);
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.WriteLine("Exiting the program");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }

}













          

















































