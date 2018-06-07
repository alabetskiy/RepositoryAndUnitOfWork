using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer;
using BusinessLogicLayer.BusinessModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET api/home/allposts
        [HttpGet]
        public IActionResult Get()
        {
           var result = _unitOfWork.Posts.GetAll();
           return Ok(result);
        }
        // api/home/posts/users? pageIndex = 2 & pageSize = 10
        [HttpGet("posts/users")]
        public IActionResult GetPostsWithUsers(int pageIndex, int pageSize)
        {
            var result = _unitOfWork.Posts.GetPostsWithUsers(pageIndex, pageSize);
            return Ok(result);
        }

        [HttpPost("posts/")]
        public IActionResult AddPost()
        {
            var post = new Post();
            post.Name = "Introduction to ReactJS";
            post.Description = "Quick ReactJS overview";
            post.Level = 1;
            post.UserId = 22;

            _unitOfWork.Posts.Add(post);
            _unitOfWork.Complete();
            return Ok();
        }

    }
}