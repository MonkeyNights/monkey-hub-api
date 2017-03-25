using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyHubApi.Models;
using System.Linq;

namespace MonkeyHubApi.Repositories
{
    public interface ITagRepository
    {
        Task<List<Tag>> GetTagAsync();
    }

    public class TagRepository : ITagRepository
    {
        IContentRepository contentRepository;

        public TagRepository()
        {
            contentRepository = new ContentRepository();
        }

        public async Task<List<Tag>> GetTagAsync()
        {
            var content = await contentRepository.GetContentAsync();

            return await Task.Run(() => content.Select(c => c.Tag).ToList());
        }
    }
}
