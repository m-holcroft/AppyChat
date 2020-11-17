using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppyChat.Models;
using AppyChat.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AppyChat.Controllers
{
    [Route("[controller]")]
    public class PostsController : Controller
    {
        private readonly AppyChatRepository _appyChatRepository;

        public PostsController(AppyChatRepository postRepository)
        {
            _appyChatRepository = postRepository;
        }

        [HttpGet(Name = "get")]
        public ActionResult<List<Post>> Get()
        {
            return _appyChatRepository.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetPost")]
        public ActionResult<Post> GetPost(string id)
        {
            var post = _appyChatRepository.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        [HttpPost]
        public ActionResult<Post> Create(Post post)
        {
            _appyChatRepository.Create(post);

            return CreatedAtRoute("GetPost", new { id = post.Id.ToString() }, post);
        }

        [HttpPatch("{id:length(24)}")]
        public IActionResult Update(string id, Post postIn)
        {
            var post = _appyChatRepository.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            _appyChatRepository.Update(id, postIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var post = _appyChatRepository.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            _appyChatRepository.Remove(post.Id);

            return NoContent();
        }

        [HttpGet("{postid:length(24)}/reactions", Name = "GetPostReactions")]
        public ActionResult<List<Reaction>> GetPostReactions([FromRoute] string postId)
        {
            return _appyChatRepository.GetPostReactions(postId);
        }

        [HttpGet("{postid:length(24)}/comments", Name = "GetPostComments")]
        public ActionResult<List<Comment>> GetPostComments([FromRoute] string postId)
        {
            return _appyChatRepository.GetPostComments(postId);
        }
    }
}