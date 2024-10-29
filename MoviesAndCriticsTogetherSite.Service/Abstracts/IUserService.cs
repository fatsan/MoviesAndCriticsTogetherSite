using Core.Responses;
using MoviesAndCriticsTogetherSite.Models.Dtos.Users.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Users.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAndCriticsTogetherSite.Service.Abstracts;

public interface IUserService
{
    ReturnModel<List<UserResponseDto>> GetAll();
    ReturnModel<UserResponseDto> GetById(Guid Id);
    ReturnModel<UserResponseDto> Add(CreateUserRequest user);

}
