using System;

namespace MonkeyHubApi.Models
{
    public class BaseModel
    {
        public string Id { get; set; }

        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
