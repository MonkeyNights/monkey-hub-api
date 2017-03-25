using System;

namespace MonkeyHubApi.Models
{
    /// <summary>
    /// Conteúdo
    /// </summary>
    public class Content : BaseModel
    {
        /// <summary>
        /// Obtém ou define o nome.
        /// </summary>
        /// <value>O nome.</value>
        public string Name { get; set; }

        /// <summary>
        ///  Obtém ou define a descrição.
        /// </summary>
        /// <value>A descrição.</value>
        public string Description { get; set; }

        /// <summary>
        /// Obtém ou define a tag do conteúdo.
        /// </summary>
        /// <value>A tag.</value>
        public Tag Tag { get; set; }

        /// <summary>
        /// Obtém ou define a imagem de banner do conteúdo.
        /// </summary>
        /// <value>O banner.</value>
        public string Banner { get; set; }

        /// <summary>
        /// Obtém ou define a url conteúdo.
        /// </summary>
        /// <value>A URL.</value>
        public string Url { get; set; }
    }
}
