using Microsoft.AspNetCore.Mvc;

namespace FPTBook.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private readonly FptbookContext _context;
        //private readonly IBookRepository _bookRepository;

        //public CustomerController(FptbookContext context, IBookRepository bookRepository)
        //{
        //    _context = context;
        //    _bookRepository = bookRepository;
        //}

        // GET: CustomerController1
        public async Task<IActionResult> Index(int id)
        {
            //var books = await _bookRepository.GetAll();
            //return View(books);
            return View();
        }

        

        public async Task<IActionResult> Profile(int id)
        {
            //if (id == null || _context.Users == null)
            //{
            //    return NotFound();
            //}
            //var user = await _context.Users
            //    .FirstOrDefaultAsync(u => u.UserId == id);
            //if (user == null)
            //{
            //    return NotFound();
            //}
            //return View(user);
            return View();
        }      

        // POST: CustomerController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
