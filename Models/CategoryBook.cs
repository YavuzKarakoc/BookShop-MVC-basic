using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopMvcBasic.Models
{
    public class CategoryBook
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Category Category { get; set; }

    }
}
