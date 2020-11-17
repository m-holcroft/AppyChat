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
    public class ReactionController : Controller
    {
        private readonly ReactionRepository _reactionRepository;

        public ReactionController(ReactionRepository reactionRepository)
        {
            _reactionRepository = reactionRepository;
        }

        [HttpGet(Name = "get")]
        public ActionResult<List<Reaction>> Get()
        {
            return _reactionRepository.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetReaction")]
        public ActionResult<Reaction> GetReaction(string id)
        {
            var reaction = _reactionRepository.Get(id);

            if (reaction == null)
            {
                return NotFound();
            }

            return reaction;
        }

        [HttpPost]
        public ActionResult<Reaction> Create(Reaction reaction)
        {
            _reactionRepository.Create(reaction);

            return CreatedAtRoute("GetReaction", new { id = reaction.Id.ToString() }, reaction);
        }

        [HttpPatch("{id:length(24)}")]
        public IActionResult Update(string id, Reaction reactionIn)
        {
            var reaction = _reactionRepository.Get(id);

            if (reaction == null)
            {
                return NotFound();
            }

            _reactionRepository.Update(id, reactionIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var reaction = _reactionRepository.Get(id);

            if (reaction == null)
            {
                return NotFound();
            }

            _reactionRepository.Remove(reaction.Id);

            return NoContent();
        }
    }
}