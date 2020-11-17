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
    public class RepliesController : Controller
    {
        private readonly RepliesRepository _repliesRepository;

        public RepliesController(RepliesRepository replyRepository)
        {
            _repliesRepository = replyRepository;
        }

        [HttpGet(Name = "get")]
        public ActionResult<List<Reply>> Get()
        {
            return _repliesRepository.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetReply")]
        public ActionResult<Reply> GetReply(string id)
        {
            var reply = _repliesRepository.Get(id);

            if (reply == null)
            {
                return NotFound();
            }

            return reply;
        }

        [HttpPost]
        public ActionResult<Reply> Create(Reply reply)
        {
            _repliesRepository.Create(reply);

            return CreatedAtRoute("GetReply", new { id = reply.Id.ToString() }, reply);
        }

        [HttpPatch("{id:length(24)}")]
        public IActionResult Update(string id, Reply replyIn)
        {
            var reply = _repliesRepository.Get(id);

            if (reply == null)
            {
                return NotFound();
            }

            _repliesRepository.Update(id, replyIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var reply = _repliesRepository.Get(id);

            if (reply == null)
            {
                return NotFound();
            }

            _repliesRepository.Remove(reply.Id);

            return NoContent();
        }
    }
}