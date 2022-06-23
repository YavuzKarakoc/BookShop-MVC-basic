using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopMvcBasic.Models
{
    public class Book
    {
        public Book()
        {
            Comments = new List<Comment>();
            
            
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public string ImgUrl { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
