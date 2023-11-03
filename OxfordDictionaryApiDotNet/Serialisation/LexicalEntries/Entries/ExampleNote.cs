using Newtonsoft.Json;

namespace OxfordDictionaryApiDotNet.Serialisation.LexicalEntries.Entries
{
    public class ExampleNote
    {
        /// <summary>
        /// The text of this example note.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; internal set; }

        /// <summary>
        /// The type of this example note.
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; internal set; }
    }
}