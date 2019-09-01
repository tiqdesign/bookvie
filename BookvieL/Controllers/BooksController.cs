using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookvieL.Functions;
using BookvieL.Functions.Templates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookvieL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        BookFunctions _func = BookFunctions.getInstance();
        
        [HttpGet(ApiTemplates.BookTemplates.GetAllBooks)]
        public List<Books> GetAllBooks()
        {
            return _func.GetAllBooks();
        }

       

    }
}
