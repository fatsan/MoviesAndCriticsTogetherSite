
using AutoMapper;
using Core.Responses;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.DataAccess.Concretes;
using MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;
using MoviesAndCriticsTogetherSite.Service.Abstracts;

namespace MoviesAndCriticsTogetherSite.Service.Concretes;

public class ArtistService : IArtistService
{
    private readonly IArtistRepository _artistRepository;
    private readonly IMapper _mapper;

    public ArtistService(IArtistRepository artistRepository, IMapper mapper)
    {

        _artistRepository = artistRepository;
        _mapper = mapper;
    }

    public ReturnModel<ArtistResponseDto> Add(CreateArtistRequest artist)
    {
        Artist artist1 = _mapper.Map<Artist>(artist);
        artist1.Id = Guid.NewGuid();
        //artist1.CreatedDate = DateTime.Now;

        _artistRepository.Add(artist1);
        var response = _mapper.Map<ArtistResponseDto>(artist1);
        return new ReturnModel<ArtistResponseDto>
        {
            Data = response,
            Message = $"Your Artist {artist.FullName} has been added.",
            StatusCode = 201,
            Success = true
        };

    }

    public ReturnModel<List<ArtistResponseDto>> GetAll()
    {
        List<Artist> artists = _artistRepository.GetAll();
        var responses = _mapper.Map<List<ArtistResponseDto>>(artists);

        return new ReturnModel<List<ArtistResponseDto>>
        {
            Data = responses,
            Message = "Here, your artists list:",
            StatusCode = 200,
            Success = true
        };

    }

    public ReturnModel<ArtistResponseDto> GetById(Guid Id)
    {
        var artist = _artistRepository.GetById(Id);
        var response = _mapper.Map<ArtistResponseDto>(artist);

        return new ReturnModel<ArtistResponseDto>
        {
            Data = response,
            Message = $"Here is Your Artist by your Id:{Id}",
            StatusCode = 200,
            Success = true
            
        };
    }
}
