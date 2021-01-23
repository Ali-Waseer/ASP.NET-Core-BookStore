using AliBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            { 
                new BookModel(){Id=1, Title="MVC Core", Author="Ali"},
                 new BookModel(){Id=2, Title="MVC", Author="Imran"},
                  new BookModel(){Id=3, Title="C#", Author="Khan"},
                   new BookModel(){Id=4, Title="Java", Author="Waseer"},
                    new BookModel(){Id=5, Title="C++", Author="Ali"},

            };
        }
    }
}
