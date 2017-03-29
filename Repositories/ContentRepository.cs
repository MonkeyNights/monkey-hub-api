using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyHubApi.Models;
using System.Linq;

namespace MonkeyHubApi.Repositories
{
    public interface IContentRepository
    {
        Task<List<Content>> GetContentAsync();
        Task<Content> GetContentByIdAsync(string id);
        Task<List<Content>> GetContentByTagIdAsync(string tagId);
        Task<List<Content>> SearchContentAsync(string filter);
    }

    public class ContentRepository : IContentRepository
    {

        #region [contents]
        List<Content> contents = new List<Content>
        {
            new Content {
                Id = "623d8b16-1192-11e7-93ae-92361f002671",
                Name = "Participe do Xamarin Summit 2017",
                Description="Nos dias 26 e 27 de Maio 2017 em São Paulo, vai rolar o maior encontro de desenvolvedores Xamarin da América Latina",
                Banner = "http://xamarinsummit.com.br/img/new_front.jpg",
                Url = "http://xamarinsummit.com.br/",
                Tag = new Tag {
                        Id="480d4e42-1192-11e7-93ae-92361f002671",
                        Name="Eventos",
                        Description="Eventos da comunidade Xamarin no Brasil",
                        Slug="eventos"
                }
            },

             new Content {
                Id = "623d9084-1192-11e7-93ae-92361f002671",
                Name = "Resolvendo o problema ‘Deployment failed because of an internal error: Failure [INSTALL_FAILED_UPDATE_INCOMPATIBLE]’",
                Description="Esse erro ocorreu pois eu compilei o app com uma versão do Xamarin Studio, atualizei a IDE, e tentei compilar novamente.",
                Banner = "http://res.cloudinary.com/https-xamarinbr-azurewebsites-net/image/upload/v1435031581/code-sharing-2_khe8vn.png",
                Url = "http://xamarinbr.azurewebsites.net/xamarin-android-resolvendo-o-problema-deployment-failed-because-of-an-internal-error-failure-install_failed_update_incompatible/",
                Tag = new Tag {
                        Id="380d52a2-1192-11e7-93ae-92361f002671",
                        Name="Xamarin Android",
                        Description="Aqui você vai encontrar ajuda relacionada a Xamarin.Android,",
                        Slug="xamarin-android"
                }
            },

             new Content {
                Id = "623d9232-1192-11e7-93ae-92361f002671",
                Name = "Criando um App iOS usando o Visual Studio e Xamarin",
                Description="Eu preciso de um Mac para criar um app para iOS? Como eu faço para usar o Xamarin dentro do Visual Studio?",
                Banner = "http://res.cloudinary.com/https-xamarinbr-azurewebsites-net/image/upload/v1435031581/code-sharing-2_khe8vn.png",
                Url = "http://xamarinbr.azurewebsites.net/criando-um-app-ios-usando-o-visual-studio-e-xamarin/",
                Tag = new Tag {
                        Id="280d52a2-1192-11e7-93ae-92361f002671",
                        Name="Xamarin iOS",
                        Description="Aqui você vai encontrar ajuda relacionada a Xamarin.iOS",
                        Slug="xamarin-ios"
                }
            },

             new Content {
                Id = "623d9232-1192-11e7-93ae-92361f002671",
                Name = "Tutorial: Facebook Login com Xamarin Forms",
                Description="Neste exemplo eu mostro como utilizar o login do Facebook com Xamarin Forms.",
                Banner = "http://frases-para-status.com/wp-content/uploads/2016/07/status-para-facebook-810x400.png",
                Url = "https://www.youtube.com/watch?v=cyq_ho4QflQ&index=9&list=PLNTCwkT5owTT0elAbegf6Akf1Mf0_HAbL",
                Tag = new Tag {
                        Id="180d52a2-1192-11e7-93ae-92361f002671",
                        Name="Xamarin.Forms",
                        Description="Aqui você vai encontrar ajuda relacionada a Xamarin.Forms",
                        Slug="xamarin-forms"
                }
            },

        };
        #endregion

        public async Task<List<Content>> GetContentAsync()
        {
            return await Task.FromResult(contents);
        }

        public async Task<Content> GetContentByIdAsync(string id)
        {
            return await Task.FromResult(contents.FirstOrDefault(c => c.Id.Equals(id)));
        }

        public async Task<List<Content>> GetContentByTagIdAsync(string tagId)
        {
            return await Task.FromResult(contents.Where(c => c.Tag.Id.Equals(tagId)).ToList());
        }

        public async Task<List<Content>> SearchContentAsync(string filter)
        {
            return await Task.FromResult(contents
                .Where(c => c.Description.ToLower().Contains(filter) || c.Name.ToLower().Contains(filter))
                .ToList());
        }
    }
}
