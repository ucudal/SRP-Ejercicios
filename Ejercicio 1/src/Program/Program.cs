using System;


namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            ShelveBook.AsignarShelveBook(book1,"A", "7");
            ShelveBook.AsignarShelveBook(book2,"B","3");
            book1.MostrarInfo();
            book2.MostrarInfo();

        }
    }
}