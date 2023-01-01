using RESTFulSense.Clients;
using System.Threading.Tasks;

namespace BlazorApps.Brokers.API
{
    public class ApiBroker : IApiBroker
    {
        private readonly IRESTFulApiFactoryClient _apiClient;

        public ApiBroker(IRESTFulApiFactoryClient apiClient)
        {
            _apiClient = apiClient;
        }
        private async ValueTask<T> GetAsync<T>(string relativeUrl)
        {
            return await _apiClient.GetContentAsync<T>(relativeUrl);
        }
        private async ValueTask<T> PostAsync<T>(string relativeUrl, T content)
        {
            return await _apiClient.PostContentAsync<T>(relativeUrl, content);
        }
        private async ValueTask<T> PutAsync<T>(string relativeUrl, T content)
        {
            return await _apiClient.PutContentAsync<T>(relativeUrl, content);
        }
        private async ValueTask<T> DeleteAsync<T>(string relativeUrl)
        {
            return await _apiClient.DeleteContentAsync<T>(relativeUrl);
        }
    }
}
