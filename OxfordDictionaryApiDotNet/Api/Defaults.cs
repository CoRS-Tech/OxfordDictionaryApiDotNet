

using System.IO;

namespace OxfordDictionaryApiDotNet.Api
{
    internal static class Defaults
    {
        private const string ServiceUrl = "https://od-api.oxforddictionaries.com:443/";

        private const string BaseUrl = "api/v2/";

        private const string Entries = "entries";

        private const string Lemmas = "lemmas";

        internal const string AppId = "app_id";

        internal const string AppKey = "app_key";

        internal const string NotFound = "Not found.";

        private const string Slash = "/";

        private const string DefaultLanguageCode = "en-gb/";

        private static string ApiUrl => Path.Combine(ServiceUrl, BaseUrl);

        internal static string EntriesEndpoint => Path.Combine(ApiUrl, Entries + Slash, DefaultLanguageCode);

        internal static string LemmasEndpoint => Path.Combine(ApiUrl, Lemmas + Slash, DefaultLanguageCode);

        internal const string NoDefinitions = "No definitions";

        internal const string NoExamples = "No examples.";
        
        internal const string NoInflection = "No inflections.";
    }
}
