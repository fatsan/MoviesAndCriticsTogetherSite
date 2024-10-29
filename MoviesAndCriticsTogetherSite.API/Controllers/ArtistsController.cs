using Core.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Responses;
using MoviesAndCriticsTogetherSite.Service.Abstracts;

namespace MoviesAndCriticsTogetherSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController(IArtistService _artistService) : ControllerBase
    {
        [HttpGet("getall")]
        public IActionResult GetAll()

        {
            var artists = _artistService.GetAll();
            return Ok(artists);
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateArtistRequest artist)
        {
            var result = _artistService.Add(artist);
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(Guid id)
        {
            var result = _artistService.GetById(id);
            return Ok(result);
        }

    }
}
