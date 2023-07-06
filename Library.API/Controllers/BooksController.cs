using Library.BLL.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _bookService;
        private IBookAuthorService _bookAuthorService;

        public BooksController(IBookService bookService, IBookAuthorService bookAuthorService)
        {
            _bookService = bookService;
            _bookAuthorService = bookAuthorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _bookService.GetBooks();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int? id)
        {
            if (id == null) return BadRequest();

            var result = await _bookService.GetBook(id);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [Route("CreateRelation")]
        public async Task<IActionResult> CreateBookAuthorRelation(int bookId, int authorId)
        {
            await _bookAuthorService.CreateRelationAsync(bookId, authorId);

            return Ok();
        }
    }
}
