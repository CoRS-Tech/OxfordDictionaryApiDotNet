using Newtonsoft.Json;

namespace OxfordDictionaryApiDotNet.Serialisation.LexicalEntries
{
    public class Inflection
    {
        /// <summary>
        /// The ID of this inflection.
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; internal set; }

        /// <summary>
        /// It is the inflection. It is not always different from the original word.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; internal set; }
    }
}
