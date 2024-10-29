using Core.Responses;
using MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAndCriticsTogetherSite.Service.Abstracts;

public interface ICommentService
{
    ReturnModel<List<CommentResponseDto>> GetAll();
    ReturnModel<CommentResponseDto> GetById(Guid Id);
    ReturnModel<CommentResponseDto> Add(CreateCommentRequest comment);
}
