﻿using EmrysSerenAPI.Models;
using EmrysSerenShared;
using Microsoft.AspNetCore.Mvc;

namespace EmrysSerenAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CommentPostController : Controller
    {
        private readonly ICommentPostRepository _commentPostRepository;

        public CommentPostController(ICommentPostRepository commentPostRepository)
        {
            _commentPostRepository = commentPostRepository;
        }

        [HttpGet]
        public IActionResult GetCommentPosts()
        {
            return Ok(_commentPostRepository.GetAllCommentPosts());
        }

        [HttpGet("{blogid}")]
        public IActionResult GetCommentPostsByBlogId(BlogPost blogid)
        {
            return Ok(_commentPostRepository.GetCommentPostsByBlogId(blogid));
        }

        [HttpGet("{userid}")]
        public IActionResult GetCommentPostsByUserId(User userid)
        {
            return Ok(_commentPostRepository.GetCommentPostsByUserId(userid));
        }
    }
}