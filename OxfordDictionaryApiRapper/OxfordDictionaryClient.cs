using OxfordDictionaryApiRapper.Clients;

namespace OxfordDictionaryApiRapper
{
    public class OxfordDictionaryClient
    {
        private readonly OxfordDictionaryClientConfig _config;

        public OxfordDictionaryClient(OxfordDictionaryClientConfig config)
        {
            _config = config;
            SetupClients();
        }

        private void SetupClients()
        {
            Entries = new EntriesClient(_config.AppId, _config.AppKey);
            Lemmas = new LemmasClient(_config.AppId, _config.AppKey);
        }

        public EntriesClient Entries { get; private set; }

        public LemmasClient Lemmas { get; private set; }
    }
}
