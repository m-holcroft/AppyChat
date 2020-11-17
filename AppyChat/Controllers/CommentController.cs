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
    public class CommentController : Controller
    {
        private readonly CommentRepository _commentRepository;

        public CommentController(CommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        [HttpGet(Name = "get")]
        public ActionResult<List<Comment>> Get()
        {
            return _commentRepository.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetComment")]
        public ActionResult<Comment> GetComment(string id)
        {
            var comment = _commentRepository.Get(id);

            if (comment == null)
            {
                return NotFound();
            }

            return comment;
        }

        [HttpPost]
        public ActionResult<Comment> Create(Comment comment)
        {
            _commentRepository.Create(comment);

            return CreatedAtRoute("GetComment", new { id = comment.Id.ToString() }, comment);
        }

        [HttpPatch("{id:length(24)}")]
        public IActionResult Update(string id, Comment commentIn)
        {
            var comment = _commentRepository.Get(id);

            if (comment == null)
            {
                return NotFound();
            }

            _commentRepository.Update(id, commentIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var comment = _commentRepository.Get(id);

            if (comment == null)
            {
                return NotFound();
            }

            _commentRepository.Remove(comment.Id);

            return NoContent();
        }
    }
}