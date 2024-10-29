
using AutoMapper;
using Core.Responses;
using MoviesAndCriticsTogetherSite.DataAccess.Abstracts;
using MoviesAndCriticsTogetherSite.DataAccess.Concretes;
using MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Requests;
using MoviesAndCriticsTogetherSite.Models.Dtos.Comments.Responses;
using MoviesAndCriticsTogetherSite.Models.Entities;
using MoviesAndCriticsTogetherSite.Service.Abstracts;

namespace MoviesAndCriticsTogetherSite.Service.Concretes;

public class CommentService : ICommentService
{
    private readonly ICommentRepository _commentRepository;
    private readonly IMapper _mapper;

    public CommentService(ICommentRepository commentRepository, IMapper mapper)
    {
        _commentRepository = commentRepository;
        _mapper = mapper;
    }

    public ReturnModel<CommentResponseDto> Add(CreateCommentRequest comment)
    {
        var created = _mapper.Map<Comment>(comment);
        _commentRepository.Add(created);

        var response = _mapper.Map<CommentResponseDto>(created);

        return new ReturnModel<CommentResponseDto>
        {
            Data = response,
            Message = "Your comment has been added.",
            StatusCode = 201,
            Success = true
        };
    }

    public ReturnModel<List<CommentResponseDto>> GetAll()
    {
        var list = _commentRepository.GetAll();
        var responses = _mapper.Map<List<CommentResponseDto>>(list);

        return new ReturnModel<List<CommentResponseDto>>
        {
            Data = responses,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }

    public ReturnModel<CommentResponseDto> GetById(Guid id)
    {
        var comment = _commentRepository.GetById(id);
        var response = _mapper.Map<CommentResponseDto>(comment);

        return new ReturnModel<CommentResponseDto>
        {
            Data = response,
            Message = $"Here, the comment that you looking for by Id:{id} ",
            StatusCode = 200,
            Success = true
        };
    }
}
