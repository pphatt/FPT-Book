using FPTBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FPTBook.Controllers
{
    public class BookController : Controller
    {
        //private readonly FptbookContext _context;

        //public BookController(FptbookContext context)
        //{
        //    _context = context;
        //}
        public async Task<IActionResult> Detail(int id)
        {
            //if (id == null || _context.Books == null)
            //{
            //    return NotFound();
            //}
            //var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            //if (book == null)
            //{
            //    return NotFound();
            //}
            //return View(book);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            //ViewData["PublisherId"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName");

            return View();
        }

        //    [HttpPost]
        //    public async Task<IActionResult> Create(AddProductViewModel bookVM)
        //    {
        //        var images = "";

        //        if (ModelState.IsValid)
        //        {
        //            if (bookVM.Image!=null)
        //            {
        //                String uploadfolder = Path.Combine(_env.WebRootPath, "images");

        //                var filename = Guid.NewGuid().ToString() + Path.GetExtension(bookVM.Image.FileName);

        //                var filepath = Path.Combine(uploadfolder, filename);

        //                try
        //                {
        //                    using (var fileStream = new FileStream(filepath, FileMode.Create))
        //                    {
        //                        await bookVM.Image.CopyToAsync(fileStream);
        //                    }

        //                    images = filename;
        //                }
        //                catch (Exception ex)
        //                {
        //                    Console.WriteLine($"Error copying file: {ex.Message}");
        //                    return View("Error");
        //                }
        //            }
        //            var books = new Book
        //            {
        //                BookTitle = bookVM.BookTitle,
        //                BookPrice = bookVM.BookPrice,
        //                BookNumber = bookVM.BookNumber,
        //                BookDetails = bookVM.BookDetails,
        //                PublisherId = bookVM.PublisherId,
        //                ImageBooks = new List<ImageBook>() { new ImageBook { BookImage = images } }


        //        _bookRepository.Add(books);
        //            return RedirectToAction("Index");
        //        };
        //    }


        //    ViewData["PublisherId"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
        //        return View(bookVM);
        //}

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            //var book = await _bookRepository.GetByIdAsync(id);
            //if (book == null) return View("Error");
            //var bookVM = new EditProductViewModel
            //{
            //    BookTitle = book.BookTitle,
            //    BookPrice = book.BookPrice,
            //    BookNumber = book.BookNumber,
            //    BookDetails = book.BookDetails,
            //    PublisherId = book.PublisherId,
            //    URL = book.ImageBook.BookImage,
            //};
            //return View(bookVM);
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> EditProduct(int id, EditProductViewModel bookVM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "Failed to edit club");
        //        return View("Edit", bookVM);
        //    }


        //    //_bookRepository.DeleteImages(bookVM.BookId);

        //    if (bookVM.Image != null && bookVM.Image.Length > 0)
        //    {
        //        String uploadfolder = Path.Combine(_env.WebRootPath, "images");
        //        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(bookVM.Image.FileName);
        //        var filePath = Path.Combine(uploadfolder, fileName);

        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await bookVM.Image.CopyToAsync(fileStream);
        //        }

        //        var imageBook = new ImageBook
        //        {
        //            BookId = bookVM.BookId,
        //            BookImage = fileName,
        //        };

        //        _context.ImageBooks.Add(imageBook);
        //        await _context.SaveChangesAsync();
        //    }
        //    var books = new Book
        //    {
        //        BookTitle = bookVM.BookTitle,
        //        BookPrice = bookVM.BookPrice,
        //        BookNumber = bookVM.BookNumber,
        //        BookDetails = bookVM.BookDetails,
        //        PublisherId = bookVM.PublisherId,
        //    };

        //    _bookRepository.Update(books);
        //    return RedirectToAction("Index");
        //}
    }
}
