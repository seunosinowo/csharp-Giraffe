using System;

namespace Giraffe
{
    internal class Classes_Object
    {
        
            public static void BookNew()
        {
            BookNew book1 = new BookNew("Harry Potter", "JK Rowling", 400);
            BookNew book2 = new BookNew("Lord of the Rings", "Tolkien", 700);
        
            book2.title = "The Hobbit";

            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}