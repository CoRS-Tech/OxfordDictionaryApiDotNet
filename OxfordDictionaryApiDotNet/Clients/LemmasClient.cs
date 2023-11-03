using System.Threading.Tasks;
using OxfordDictionaryApiDotNet.Api;
using OxfordDictionaryApiDotNet.Serialisation;

namespace OxfordDictionaryApiDotNet.Clients
{
    /// <summary>
    /// Standalone lemmas client. Can be used to retrieve the original form of an inflected word.
    /// For example, 'getting' is an inflection of the word 'get'.
    /// </summary>
    public class LemmasClient
    {
        private readonly string _appId;
        private readonly string _appKey;

        public LemmasClient(string appId, string appKey)
        {
            _appId = appId;
            _appKey = appKey;
        }

        public async Task<Request> FindLemmaAsync(string query)
        {
            return await ApiRequests.RequestLemmaAsync(query, _appId, _appKey);
        }
    }
}
