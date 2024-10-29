

using AutoMapper;
using Core.Responses;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Request;
using MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;
using MoviesAndCriticsTogetherSite.Service.Abstracts;

namespace MoviesAndCriticsTogetherSite.Service.Concretes;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public MovieService(IMovieRepository movieRepository,IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }

    public ReturnModel<MovieResponseDto> Add(CreateMovieRequest movie)
    {
        Movie movieCreated = _mapper.Map<Movie>(movie);
        movieCreated.Id = Guid.NewGuid();
        //movieCreated.CreatedDate = DateTime.Now;

        _movieRepository.Add(movieCreated);

        MovieResponseDto movieResponseDto = _mapper.Map<MovieResponseDto>(movieCreated);
        return new ReturnModel<MovieResponseDto>
        {
            Data = movieResponseDto,
            Message = "Your movie has been uploaded.",
            StatusCode = 201,
            Success = true
        };
        
    }

    public ReturnModel<List<MovieResponseDto>> GetAll()
    {
        List<Movie> movies = _movieRepository.GetAll();
        List<MovieResponseDto> responses = _mapper.Map<List<MovieResponseDto>>(movies);
        return new ReturnModel<List<MovieResponseDto>>
        {
            Data = responses,
            Message = "Here, your movie list.",  //string.Empty
            StatusCode = 200,
            Success = true
        };
    }

    public ReturnModel<MovieResponseDto> GetById(Guid id)
    {
        Movie movie = _movieRepository.GetById(id);
        MovieResponseDto response = _mapper.Map<MovieResponseDto>(movie);

        return new ReturnModel<MovieResponseDto>
        {
            Data = response,
            Message = $"Here, Your move by your given id({id}).",
            StatusCode = 200,
            Success = true
        };

        
    }
}
