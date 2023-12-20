using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FPTBook.Controllers
{
    public class AdminController : Controller
    {
        //private readonly FptbookContext _context;
        //private readonly IBookRepository _bookRepository;

        //public AdminController(FptbookContext context, IBookRepository bookRepository)
        //{
        //    _context = context;
        //    _bookRepository = bookRepository;
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageCustomer()
        {
            return View();
        }

        public IActionResult ManageBook()
        {
            return View();
        }        
    }
}
