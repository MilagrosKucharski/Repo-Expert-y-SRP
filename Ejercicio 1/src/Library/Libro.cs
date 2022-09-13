using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }


        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        
        /*el metodo para cumplir con el srp deberia estar en otra clase, no se pudo implementar correctamente el program
        
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */
    }
}
