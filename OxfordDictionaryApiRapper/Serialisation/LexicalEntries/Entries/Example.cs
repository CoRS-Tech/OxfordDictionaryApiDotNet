using Newtonsoft.Json;
using System.Collections.Generic;

namespace OxfordDictionaryApiRapper.Serialisation.LexicalEntries.Entries
{
    public class Example
    {
        /// <summary>
        /// The example.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; internal set; }

        /// <summary>
        /// Notes this example may have.
        /// </summary>
        [JsonProperty("notes")]
        public List<ExampleNote> Notes { get; internal set; }
    }
}