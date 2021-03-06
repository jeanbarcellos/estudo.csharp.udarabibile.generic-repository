using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GenericRepository.Models;
using GenericRepository.Services;

namespace GenericRepository.Controllers
{
    [ApiController]
    [Route("users")]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Book> GetAllBooks() =>
            _bookService.GetAllBooks();

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void InsertBook([FromBody] Book book) =>
            _bookService.InsertBook(book);

        [HttpGet]
        [Route("{id:guid}")]
        public Book GetBookById(Guid id) =>
            _bookService.GetBookById(id);

        [HttpPut]
        [Route("{id:guid}")]
        [AllowAnonymous]
        public void UpdateBook([FromBody] Book book) =>
            _bookService.UpdateBook(book);

        [HttpDelete]
        [Route("{id:guid}")]
        [AllowAnonymous]
        public void DeleteBook(Guid id) =>
            _bookService.DeleteBook(id);
    }
}