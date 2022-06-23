using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShopMvcBasic.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string text { get; set; }
        public Book Book { get; set; }

    }
}
