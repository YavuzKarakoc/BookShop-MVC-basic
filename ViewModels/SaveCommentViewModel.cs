using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShopMvcBasic.Models;

namespace BookShopMvcBasic.ViewModels
{
    public class SaveCommentViewModel
    {
        public int BookId { get; set; }
        public string Comment { get; set; }
    }
}
