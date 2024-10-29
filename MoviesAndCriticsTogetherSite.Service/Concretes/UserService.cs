
using AutoMapper;
using Core.Responses;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.DataAccess.Concretes;
using MoviesAndCriticsTogetherSite.Models.Dtos.Users.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Users.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;
using MoviesAndCriticsTogetherSite.Service.Abstracts;

namespace MoviesAndCriticsTogetherSite.Service.Concretes;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService( IUserRepository userRepository,IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public ReturnModel<UserResponseDto> Add(CreateUserRequest user)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<List<UserResponseDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public ReturnModel<UserResponseDto> GetById(Guid Id)
    {
        throw new NotImplementedException();
    }
}
