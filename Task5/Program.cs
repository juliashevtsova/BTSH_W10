using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            NameBook book1 = new NameBook();
            NameBook book2 = new NameBook();
                        
            book2.author = new AuthorBook();
            book1.author = new AuthorBook();

            book2.author.nameAuthor = "Scott Fotzgerald";
            book1.author.nameAuthor = "George Orwell";
            book1.name = "1984";
            book2.name = "The Great Gatsby";
            book1 = book2;
            book2.author.nameAuthor = "Jack London";
            book2.name = "The Game";

            Console.WriteLine(book1.author.nameAuthor +" - "+ book1.name); 
            Console.WriteLine(book2.author.nameAuthor +" - "+ book2.name);
        }
    }

    public struct NameBook
    {
        public string name;
        public AuthorBook author;
    }

    public class AuthorBook
    {
        public string nameAuthor;
    }   
}

