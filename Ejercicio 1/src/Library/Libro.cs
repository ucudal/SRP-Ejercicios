using System;
using System.Collections;

namespace SRP
{
    /*Se ha creado dos clases distintas, una para asignar la información sobre el libro y otra para asignar su ubicación (esta se hizo aprte ya que puede llegar el caso que se cmabie la forma de almacenacmiento de los libros).

    */
    public class Book
    {
        // Se  cran las Properties.
        public string Title { get; }
        public string Author { get; }
        public string Code { get; }
        public ArrayList Localizacion { get; set; }


        // Constructor.
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;

        }

        // Metodo para mostar la informacion de los libros.
        // Se asigno esta tarea a esta clase ya que es la cual posee toda la inforación necesaria.
        public void MostrarInfo()
        {
            Console.WriteLine($"\nTitulo: {this.Title}\nAutor: {this.Author}\nCodigo: {this.Code}\nSector Libreria: {this.Localizacion[0].ToString()}\nNumero Estante: {this.Localizacion[1].ToString()}\n");
        }

    }

    // Clase encargada de Asignar la ubicación de los libros.
    public class ShelveBook
    {

        public static void AsignarShelveBook(Book libro, string sector, string shelve)
        {
            // Inicializacion de la lista.
            libro.Localizacion = new ArrayList();

            // Añadiendo los vlaores a la lista.
            libro.Localizacion.Add(sector);
            libro.Localizacion.Add(shelve);
        }
    }
}
