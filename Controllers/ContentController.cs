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
    public class ContentController : Controller
    {
        IContentRepository contentRepository;

        public ContentController()
        {
            contentRepository = new ContentRepository();
        }

        // GET api/content
        [HttpGet]
        public async Task<List<Content>> Get()
        {
            return await contentRepository.GetContentAsync();
        }
    }
}
