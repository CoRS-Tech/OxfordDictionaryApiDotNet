using Newtonsoft.Json;

namespace OxfordDictionaryApiRapper.Serialisation.LexicalEntries.Entries
{
    public class GrammaticalFeature
    {
        /// <summary>
        /// The ID of this grammatical feature.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The text of this grammatical feature.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; internal set; }

        /// <summary>
        /// The type of this grammatical feature.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; internal set; }
    }
}
