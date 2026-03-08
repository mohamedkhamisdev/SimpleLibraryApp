using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
	public class BookController : Controller
	{
		private readonly ApplicationDbContext _context;

		public BookController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: Book
		public async Task<IActionResult> Index()
		{
			var books = await _context.Books
				.Include(b => b.Category)
				.ToListAsync();
			return View(books);
		}

		// GET: Book/Create
		public IActionResult Create()
		{
			PopulateCategorySelectList();
			return View();
		}

		// POST: Book/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Book book)
		{
			if (ModelState.IsValid)
			{
				_context.Books.Add(book);
				await _context.SaveChangesAsync();
				TempData["successData"] = "New book was added successfully";
				return RedirectToAction(nameof(Index));
			}

			// إذا فشل التحقق، نعرض رسالة خطأ
			TempData["errorData"] = "Please correct the errors and try again.";
			PopulateCategorySelectList(book.CategoryId);
			return View(book);
		}

		// GET: Book/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || id == 0)
				return NotFound();

			var book = await _context.Books.FindAsync(id);
			if (book == null)
				return NotFound();

			PopulateCategorySelectList(book.CategoryId);
			return View(book);
		}

		// POST: Book/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(Book book)
		{
			if (!ModelState.IsValid)
			{
				TempData["errorData"] = "Please correct the errors and try again.";
				PopulateCategorySelectList(book.CategoryId);
				return View(book);
			}

			var existingBook = await _context.Books.FindAsync(book.Id);
			if (existingBook == null)
				return NotFound();

			existingBook.Title = book.Title;
			existingBook.Author = book.Author;
			existingBook.ISBN = book.ISBN;
			existingBook.Description = book.Description;
			existingBook.CategoryId = book.CategoryId;

			await _context.SaveChangesAsync();
			TempData["successData"] = "Book updated successfully";
			return RedirectToAction(nameof(Index));
		}

		// GET: Book/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null) return NotFound();
			var book = await _context.Books
				.Include(b => b.Category)
				.FirstOrDefaultAsync(b => b.Id == id);
			if (book == null) return NotFound();
			return View(book);
		}

		// POST: Book/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var book = await _context.Books.FindAsync(id);
			if (book == null)
				return NotFound();

			_context.Books.Remove(book);
			await _context.SaveChangesAsync();
			TempData["successData"] = "Book deleted successfully";
			return RedirectToAction(nameof(Index));
		}

		private void PopulateCategorySelectList(object selectedCategory = null)
		{
			var categories = _context.Categories.ToList();
			ViewBag.CategoryList = new SelectList(categories, "Id", "Name", selectedCategory);
		}

		public async Task<IActionResult> Search(string query)
		{
			if (string.IsNullOrWhiteSpace(query))
			{
				return RedirectToAction(nameof(Index));
			}

			var books = await _context.Books
				.Include(b => b.Category)
				.Where(b => b.Title.Contains(query) || b.Author.Contains(query) || b.ISBN.Contains(query))
				.ToListAsync();

			return View("Index", books);
		}
	}
}