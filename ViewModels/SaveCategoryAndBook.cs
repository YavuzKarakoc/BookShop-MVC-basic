using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShopMvcBasic.Models;

namespace BookShopMvcBasic.ViewModels
{
    public class SaveCategoryAndBook
    {
        public SaveCategoryAndBook()
        {
            Categories = new List<Category>();
        }

        public Book Book { get; set; }
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}