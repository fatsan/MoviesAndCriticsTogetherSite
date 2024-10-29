

using Core.Responses;
using MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.Service.Abstracts;

public interface IArtistService 
{
    ReturnModel<List<ArtistResponseDto>>  GetAll();
    ReturnModel<ArtistResponseDto> GetById(Guid Id);
    ReturnModel<ArtistResponseDto> Add(CreateArtistRequest Artist);
}
