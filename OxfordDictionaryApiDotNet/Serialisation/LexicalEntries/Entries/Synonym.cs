using Newtonsoft.Json;

namespace OxfordDictionaryApiDotNet.Serialisation.LexicalEntries.Entries
{
    public class Synonym
    {
        /// <summary>
        /// The language of this synonym. It mostly matches the language of the original word.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; internal set; }

        /// <summary>
        /// The synonym.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; internal set; }
    }
}
