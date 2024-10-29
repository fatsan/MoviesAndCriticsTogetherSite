
using AutoMapper;
using MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Artists.Responses;
using MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Responses;
using MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Request;
using MoviesAndCriticsTogetherSite.Models.Dtos.Movies.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;

namespace MoviesAndCriticsTogetherSite.Service.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateMovieRequest, Movie>();
        CreateMap<Movie, MovieResponseDto>();

        CreateMap<CreateArtistRequest, Artist>();
        CreateMap<Artist, ArtistResponseDto>();

        CreateMap<CreateCommentRequest, Comment>();
        CreateMap<Comment, CommentResponseDto>();

        //CreateMap<Artist, CreateArtistRequest>()
        //    .ForMember(dest => dest.Birthday,
        //               opt => opt.MapFrom(src => src.Birthday.ToString("dd-MM-yyyy")));


    }
}
