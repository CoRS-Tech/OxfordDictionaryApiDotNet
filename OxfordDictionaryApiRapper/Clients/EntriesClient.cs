using System.Threading.Tasks;
using OxfordDictionaryApiRapper.Api;
using OxfordDictionaryApiRapper.Serialisation;

namespace OxfordDictionaryApiRapper.Clients
{
    /// <summary>
    /// Standalone entries client. Can be used to retrieve definitions, examples, etymologies, etc. Requires AppId and ApiKey.
    /// </summary>
    public class EntriesClient
    {
        private readonly string _appId;
        private readonly string _appKey;

        public EntriesClient(string appId, string appKey)
        {
            _appId = appId;
            _appKey = appKey;
        }

        public async Task<Request> FindEntryAsync(string query)
        {
            return await ApiRequests.RequestEntryAsync(query, _appId, _appKey);
        }
    }
}
