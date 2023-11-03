using Newtonsoft.Json;

namespace OxfordDictionaryApiDotNet.Serialisation.LexicalEntries
{
    public class Phrase
    {
        /// <summary>
        /// The ID of this phrase.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; internal set; }

        /// <summary>
        /// Contains the phrase.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; internal set; }
    }
}
