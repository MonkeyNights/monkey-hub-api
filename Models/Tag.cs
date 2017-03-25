using System;

namespace MonkeyHubApi.Models
{
    /// <summary>
    /// Tag.
    /// </summary>
    public class Tag : BaseModel
    {
        /// <summary>
        /// Obtém ou define o nome.
        /// </summary>
        /// <value>O nome.</value>
        public string Name { get; set; }

        /// <summary>
        /// https://pt.wikipedia.org/wiki/Slug_(programa%C3%A7%C3%A3o)
        /// </summary>
        /// <value>O Slug.</value>
        public string Slug { get; set; }

        /// <summary>
        ///  Obtém ou define a descrição
        /// </summary>
        /// <value>A descrição.</value>
        public string Description { get; set; }
    }
}
