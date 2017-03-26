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
    public class TagsController : Controller
    {
        ITagRepository tagRepository;

        public TagsController()
        {
            tagRepository = new TagRepository();
        }

        // GET api/tags
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tags = await tagRepository.GetTagAsync();
            return Ok(tags);
        }
    }
}
