using Microsoft.AspNetCore.Mvc;
using BookShopMvcBasic;
using BookShopMvcBasic.Data;
using BookShopMvcBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookShopMvcBasic.ViewModels;

namespace BookShopMvcBasic.Controllers
{
    public class BookController : Controller
    {
        private readonly BookContext _context;

        public BookController(BookContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            BookAndCategoryAndSeller bookAndCategoryAndSeller = new BookAndCategoryAndSeller();
            //bookAndCategoryAndSeller.Categories = _context.Categories.ToList();
            //bookAndCategoryAndSeller.Sellers = _context.Sellers.ToList();
            bookAndCategoryAndSeller.Books = _context.Books.ToList();
            bookAndCategoryAndSeller.CategoryBooks = _context.CategoryBooks.ToList();
            bookAndCategoryAndSeller.SellerBooks = _context.SellerBooks.ToList();

            //bookAndCategoryAndSeller.Book = _context.Books
            //                                .Include(b => b.Comments)
            //                                .FirstOrDefault();


            var Categories = _context.CategoryBooks
                                            .Include(c => c.Category)
                                            .Select(bm => bm.Category).ToList();
            var catbook = _context.CategoryBooks
                                            .Include(c => c.Book)
                                            .Select(bm => bm.Book);

            var Sellers = _context.SellerBooks
                                            .Include(s => s.Seller)
                                            .Select(bm => bm.Seller);

            ViewBag.Categories = Categories;
            ViewBag.catbook = catbook;
            ViewBag.Sellers = Sellers;


            return View(bookAndCategoryAndSeller);

        }

        public IActionResult Detail(int id)
        {
            //// Bu kodlar yorumlar eklenmeden önceki detay sayfası gösterimidir
            //var detailBook = _context.Books
            //                       .SingleOrDefault(m => m.Id == id);
            //ViewBag.Book = detailBook;
            //return View();

            //BookAndCategoryAndSeller bookAndCategoryAndSeller = new BookAndCategoryAndSeller();
            SaveCommentViewModel saveCommentViewModel = new SaveCommentViewModel();

            var bookAndComments = _context.Books.Where(c => c.Id == id)
                                               .Include(c => c.Comments)
                                               .Select(c =>
                                               new Book()
                                               {
                                                   Id = c.Id,
                                                   Name = c.Name,
                                                   AuthorName=c.AuthorName,
                                                   Price=c.Price,
                                                   ImgUrl = c.ImgUrl,
                                                   Comments = c.Comments
                                                   
                                               })
                                               .FirstOrDefault();


            var Categories = _context.CategoryBooks
                                            .Where(c => c.Book.Id == id)
                                            .Include(c => c.Category)
                                            .Select(bm => bm.Category).ToList();

            var Sellers = _context.SellerBooks
                                             .Where(s => s.Book.Id == id)
                                             .Include(s => s.Seller)
                                             .Select(sb => sb.Seller).ToList();

            ViewBag.Categories = Categories;
            ViewBag.Sellers = Sellers;
            ViewBag.Book = bookAndComments;
            return View();
        }

        [HttpPost]
        public IActionResult SaveComment(SaveCommentViewModel saveComment)
        {
            
            //return View();
            Comment comment = new Comment();
            comment.text = saveComment.Comment;
            comment.Book = _context.Books.SingleOrDefault(m => m.Id == saveComment.BookId);

            if (comment.text!=null)
            {
                _context.Comments.Add(comment);
            }

            
            _context.SaveChanges();
            return RedirectToAction("Detail", new { Id = saveComment.BookId });
        }

        public IActionResult CommentDelete(Comment comment)
        {

            var deletedcomment = _context.Comments
                                   .Where(b => b.Id == comment.Id).Include(c => c.Book).FirstOrDefault();
            var Id = deletedcomment.Book.Id;

            _context.Comments.Remove(deletedcomment);
            _context.SaveChanges();
            return RedirectToAction("Detail", new { Id });

        }

        public IActionResult Create()
        {
            CategorySellerBook categorySellerBook = new CategorySellerBook();
            var Categories = _context.Categories.ToList();
            var Sellers = _context.Sellers.ToList();
            ViewBag.categories = Categories;
            ViewBag.sellers = Sellers;


            return View(categorySellerBook);
        }

        [HttpPost]
        public IActionResult Create(CategorySellerBook newbook)
        {
            Book book = new Book();
            book.Name = newbook.Name;
            book.AuthorName = newbook.AuthorName;
            book.Price = newbook.Price;
            book.ImgUrl = newbook.ImgUrl;
            _context.Books.Add(book);

            newbook.CategoryIds.ForEach(category =>
            {
                CategoryBook categoryBook = new CategoryBook();
                categoryBook.Book = book;
                categoryBook.Category = _context.Categories.FirstOrDefault(c => c.Id == category);

                _context.CategoryBooks.Add(categoryBook);
            });

            newbook.SellerIds.ForEach(seller =>
            {
                SellerBook sellerBook = new SellerBook();
                sellerBook.Book = book;
                sellerBook.Seller = _context.Sellers.FirstOrDefault(c => c.Id == seller);

                _context.SellerBooks.Add(sellerBook);
            });



            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            var updateBook = _context.Books
                                   .SingleOrDefault(m => m.Id == id);

            CategorySellerBook categorySellerBook = new CategorySellerBook();
            categorySellerBook.Id = updateBook.Id;
            categorySellerBook.Name = updateBook.Name;
            categorySellerBook.AuthorName = updateBook.AuthorName;
            categorySellerBook.Price = updateBook.Price;
            categorySellerBook.ImgUrl = updateBook.ImgUrl;

            categorySellerBook.CategoryIds = _context.CategoryBooks
                .Where(cm => cm.Book.Id == id)
                .Include(cm => cm.Category)
                .Select(cm => cm.Category.Id)
                .ToList();

            categorySellerBook.SellerIds = _context.SellerBooks
                .Where(cm => cm.Book.Id == id)
                .Include(cm => cm.Seller)
                .Select(cm => cm.Seller.Id)
                .ToList();


            var Categories = _context.Categories.ToList();
            var Sellers = _context.Sellers.ToList();
            ViewBag.Book = updateBook;
            ViewBag.categories = Categories;
            ViewBag.sellers = Sellers;
            return View(categorySellerBook);
        }

        [HttpPost]
        public IActionResult Update(CategorySellerBook book)
        {
            var updatedBook = _context.Books
                                    .SingleOrDefault(m => m.Id == book.Id);
            updatedBook.Id = book.Id;
            updatedBook.Name = book.Name;
            updatedBook.AuthorName = book.AuthorName;
            updatedBook.Price = book.Price;
            updatedBook.ImgUrl = book.ImgUrl;

            var categorylist = _context.CategoryBooks.Where(cb => cb.Book.Id == book.Id)
                                    .Select(cb => cb.Category.Id).ToList();
            var deletedCategory = categorylist.Except(book.CategoryIds).ToList();

            deletedCategory.ForEach(item =>
            {
                var deletedBookCategory = _context.CategoryBooks.FirstOrDefault(c => c.Category.Id == item);
                 _context.CategoryBooks.Remove(deletedBookCategory);
            });
            _context.SaveChanges();

            var addedCategory = book.CategoryIds.Except(categorylist).ToList();
            addedCategory.ForEach(category =>
            {
                CategoryBook categoryBook = new CategoryBook();
                categoryBook.Book = updatedBook;
                categoryBook.Category = _context.Categories.FirstOrDefault(c => c.Id == category);

                _context.CategoryBooks.Add(categoryBook);
            });


            var sellerList = _context.SellerBooks.Where(sb => sb.Book.Id == book.Id)
                                .Select(sb => sb.Seller.Id).ToList();

            var deletedSeller = sellerList.Except(book.SellerIds).ToList();

            deletedSeller.ForEach(item =>
            {
                var deletedBookSeller = _context.SellerBooks.FirstOrDefault(s => s.Seller.Id == item);
                var delete = _context.SellerBooks.Remove(deletedBookSeller);
            });

            _context.SaveChanges();

            var addedSeller = book.SellerIds.Except(sellerList).ToList();
            addedSeller.ForEach(seller =>
            {
                SellerBook sellerBook = new SellerBook();
                sellerBook.Book = updatedBook;
                sellerBook.Seller = _context.Sellers.FirstOrDefault(s => s.Id == seller);

                _context.SellerBooks.Add(sellerBook);

            });

            _context.Books.Update(updatedBook);
            _context.SaveChanges();
            return RedirectToAction("Index");

            
        }


        public IActionResult Delete(int id)
        {
            var deletedCategoryBook = _context.CategoryBooks.Where(c => c.Book.Id == id);
            _context.CategoryBooks.RemoveRange(deletedCategoryBook);

            var deletedSellerBook = _context.SellerBooks.Where(s => s.Book.Id == id);
            _context.SellerBooks.RemoveRange(deletedSellerBook);

            var deletedComment = _context.Comments.Where(c => c.Book.Id == id);
            _context.Comments.RemoveRange(deletedComment);

            var deletedBook = _context.Books
                                   .SingleOrDefault(m => m.Id == id);
            _context.Books.Remove(deletedBook);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Create");
        }

        [HttpPost]
        public IActionResult CreateSeller(Seller seller)
        {
            _context.Sellers.Add(seller);
            _context.SaveChanges();
            return RedirectToAction("Create");
        }

        public IActionResult CreateCategoryAndSeller()
        {

            return View("CreateCategoryAndSeller");
        }

    }
}
