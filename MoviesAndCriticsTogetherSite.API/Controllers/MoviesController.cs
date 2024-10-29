using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Request;
using MoviesAndCriticsTogetherSite.Service.Abstracts;

namespace MoviesAndCriticsTogetherSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController(IMovieService _movieService) : ControllerBase
    {
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _movieService.GetAll();
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody]CreateMovieRequest request) 
        {
            var result = _movieService.Add(request);
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById([FromBody]Guid id)
        {
            var result = _movieService.GetById(id);
            return Ok(result);
        }
    }
}
