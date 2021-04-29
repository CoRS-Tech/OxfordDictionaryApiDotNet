using System.Collections.Generic;
using Newtonsoft.Json;

namespace OxfordDictionaryApiRapper.Serialisation
{
    public class Result
    {
        [JsonProperty("id")]
        public string Id { get; internal set; }

        [JsonProperty("language")]
        public string LanguageCode { get; internal set; }

        /// <summary>
        /// Contains lexical (linguistic) entries, such as etymologies, senses (definitions) and pronunciations.
        /// </summary>
        [JsonProperty("lexicalEntries")]
        public List<LexicalEntry> LexicalEntries { get; internal set; }

        [JsonProperty("word")]
        public string Word { get; internal set; }
    }
}
