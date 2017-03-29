using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonkeyHubApi.Models;
using MonkeyHubApi.Repositories;

namespace MonkeyHubApi.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ContentController : Controller
    {
        readonly IContentRepository _contentRepository;

        public ContentController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        // GET api/content
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var contents = await _contentRepository.GetContentAsync();
            return Ok(contents);
        }

        // GET api/content/id
        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> GetById([FromQuery] string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return BadRequest();
            var content = await _contentRepository.GetContentByIdAsync(id);
            if (content == null) return NotFound();

            return Ok(content);
        }

        // GET api/content/tag
        [HttpGet]
        [Route("tag")]
        public async Task<IActionResult> GetByTagId([FromQuery] string tag)
        {
            if (string.IsNullOrWhiteSpace(tag)) return BadRequest();
            var contents = await _contentRepository.GetContentByTagIdAsync(tag);
            if (contents == null) return NotFound();

            return Ok(contents);
        }

        // GET api/content/search
        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> Search([FromQuery] string filter)
        {
            if (string.IsNullOrWhiteSpace(filter)) return BadRequest();
            var contents = await _contentRepository.SearchContentAsync(filter.ToLower());
            if (contents == null) return NotFound();

            return Ok(contents);
        }
    }
}
