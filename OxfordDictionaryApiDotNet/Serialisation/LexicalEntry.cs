using System.Collections.Generic;
using Newtonsoft.Json;
using OxfordDictionaryApiDotNet.Serialisation.LexicalEntries;

namespace OxfordDictionaryApiDotNet.Serialisation
{
    public class LexicalEntry
    {
        /// <summary>
        /// Contains entries such as etymologies, senses (definitions) and pronunciations.
        /// </summary>
        [JsonProperty("entries")]
        public List<Entry>? Entries { get; internal set; }

        /// <summary>
        /// The lexical category of this entry, such as 'verb'.
        /// </summary>
        [JsonProperty("lexicalCategory")]
        public LexicalCategory? LexicalCategory { get; internal set; }

        /// <summary>
        /// Contains phrasal verbs, such as for the word 'help', you will get 'help out'.
        /// </summary>
        [JsonProperty("phrasalVerbs")]
        public List<PhrasalVerb>? PhrasalVerbs { get; internal set; }

        /// <summary>
        /// Phrases that this entry can possibly have, such as 'a helping hand'.
        /// </summary>
        [JsonProperty("phrases")]
        public List<Phrase>? Phrases { get; internal set; }

        /// <summary>
        /// Usually the original word that has those phrases and entries.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; internal set; }
        
        /// <summary>
        /// The inflections of this entry. For example, 'getting' is an inflection of 'get'.
        /// This field does not always have a value if not using the Lemmas endpoint.
        /// </summary>
        [JsonProperty("inflectionOf")]
        public List<Inflection>? Inflections { get; internal set; }
    }
}
