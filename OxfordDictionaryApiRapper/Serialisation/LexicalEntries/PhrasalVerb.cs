using Newtonsoft.Json;

namespace OxfordDictionaryApiRapper.Serialisation.LexicalEntries
{
    public class PhrasalVerb
    {
        /// <summary>
        /// The ID of this phrasal verb.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; internal set; }

        /// <summary>
        /// Contains the phrasal verb.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; internal set; }
    }
}
