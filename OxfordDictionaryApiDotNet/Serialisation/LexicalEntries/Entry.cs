using System.Collections.Generic;
using Newtonsoft.Json;
using OxfordDictionaryApiDotNet.Serialisation.LexicalEntries.Entries;

namespace OxfordDictionaryApiDotNet.Serialisation.LexicalEntries
{
    public class Entry
    {
        /// <summary>
        /// A list of etymologies this word may have.
        /// </summary>
        [JsonProperty("etymologies")]
        public List<string> Etymologies { get; internal set; }

        /// <summary>
        /// Grammatical features of this word.
        /// </summary>
        [JsonProperty("grammaticalFeatures")]
        public List<GrammaticalFeature> GrammaticalFeatures { get; internal set; }

        /// <summary>
        /// Contains audio file link and dialect information.
        /// </summary>
        [JsonProperty("pronunciations")]
        public List<Pronunciation> Pronunciations { get; internal set; }

        /// <summary>
        /// Contains defintions and examples.
        /// </summary>
        [JsonProperty("senses")]
        public List<Sense> Senses { get; internal set; }
    }
}

