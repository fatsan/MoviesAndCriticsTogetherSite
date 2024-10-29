
using Core.Responses;
using MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Request;
using MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.Service.Abstracts;

public interface IMovieService
{
    ReturnModel<List<MovieResponseDto>> GetAll();
    ReturnModel<MovieResponseDto> GetById(Guid id);
    ReturnModel<MovieResponseDto> Add(CreateMovieRequest movie);
    //Movie Delete(Guid id);

}
