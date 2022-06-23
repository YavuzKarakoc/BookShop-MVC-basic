using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShopMvcBasic.Models;

namespace BookShopMvcBasic.ViewModels
{
    public class CategorySellerBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public string ImgUrl { get; set; }
        public List<int> CategoryIds { get; set; } = new List<int>();
        public List<int> SellerIds { get; set; } = new List<int>();
    }
}
