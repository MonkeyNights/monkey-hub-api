using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonkeyHubApi.Models;
using MonkeyHubApi.Repositories;

namespace MonkeyHubApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TagsController : Controller
    {
        readonly ITagRepository _tagRepository;

        public TagsController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        // GET api/tags
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tags = await _tagRepository.GetTagAsync();
            return Ok(tags);
        }

        // GET api/tag/id
        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> GetById([FromQuery] string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return BadRequest();
            var tag = await _tagRepository.GetTagByIdAsync(id);
            if (tag == null) return NotFound();

            return Ok(tag);
        }
    }
}
