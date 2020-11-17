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
        private readonly PostRepository _postRepository;
        public PostsController(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        [HttpGet(Name = "get")]
        public ActionResult<List<Post>> Get()
        {
            return _postRepository.Get();
        }
        [HttpGet("{id:length(24)}", Name = "GetPost")]
        public ActionResult<Post> GetPost(string id)
        {
            var post = _postRepository.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }
        [HttpPost]
        public ActionResult<Post> Create(Post post)
        {
            _postRepository.Create(post);

            return CreatedAtRoute("GetPost", new { id = post.Id.ToString() }, post);
        }
        [HttpPatch("{id:length(24)}")]
        public IActionResult Update(string id, Post postIn)
        {
            var post = _postRepository.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            _postRepository.Update(id, postIn);

            return NoContent();
        }
        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var post = _postRepository.Get(id);

            if (post == null)
            {
                return NotFound();
            }

            _postRepository.Remove(post.Id);

            return NoContent();
        }
    }
}
