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
    public class MoviesController : ControllerBase
    {
        private MovieFunctions _func = MovieFunctions.getInstance();

        [HttpGet(ApiTemplates.MovieTemplates.GetMovieByBookId)]
        public Movies GetMovieByBookId(int bookid) 
        {
            return _func.GetMovieWithBookID(bookid);
        }
    }
}
