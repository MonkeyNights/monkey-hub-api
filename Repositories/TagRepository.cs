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
        Task<Tag> GetTagByIdAsync(string id);
    }

    public class TagRepository : ITagRepository
    {
        IContentRepository _contentRepository;

        public TagRepository(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public async Task<List<Tag>> GetTagAsync()
        {
            var content = await _contentRepository.GetContentAsync();
            return await Task.Run(() => content.Select(c => c.Tag).ToList());
        }

        public async Task<Tag> GetTagByIdAsync(string id)
        {
            var content = await _contentRepository.GetContentAsync();
            return await Task.Run(() => content.Where(c => c.Tag.Id.Equals(id)).Select(c => c.Tag).FirstOrDefault());
        }
    }
}
