using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Dtos.Comment;

namespace Backend.Services.CommentService
{
    public interface ICommentService
    {
        Task<ServiceResponse<List<GetCommentDto>>> GetAllComments(int postId);
        Task<ServiceResponse<List<GetCommentDto>>> AddComment(AddCommentDto newComment, int postId);
        Task<ServiceResponse<GetCommentDto>> UpdateComment(int commentId,UpdateCommentDto updatedComment);
        Task<ServiceResponse<List<GetCommentDto>>> DeleteComment(int commentId);
    }
}