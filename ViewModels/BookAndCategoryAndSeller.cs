using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShopMvcBasic.Models;

namespace BookShopMvcBasic.ViewModels
{
    public class BookAndCategoryAndSeller
    {
        public Book Book { get; set; }
        public Category Category { get; set; }
        public Seller Seller { get; set; }
        public CategoryBook CategoryBook { get; set; }
        public SellerBook  SellerBook { get; set; }

        public List<Category> Categories { get; set; }
        public List<Seller> Sellers { get; set; }
        public List<Book> Books { get; set; }
        public List<CategoryBook> CategoryBooks { get; set; }
        public List<SellerBook> SellerBooks { get; set; }

    }
}
