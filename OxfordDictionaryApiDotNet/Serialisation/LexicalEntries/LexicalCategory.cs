using Newtonsoft.Json;

namespace OxfordDictionaryApiDotNet.Serialisation.LexicalEntries
{
    public class LexicalCategory
    {
        /// <summary>
        /// The ID of this lexical category.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The name or text of this lexical category.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; internal set; }
    }
}
