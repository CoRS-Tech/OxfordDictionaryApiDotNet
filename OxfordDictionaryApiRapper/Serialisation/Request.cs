using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using OxfordDictionaryApiRapper.Api;
using OxfordDictionaryApiRapper.Serialisation.LexicalEntries.Entries;

namespace OxfordDictionaryApiRapper.Serialisation
{
    public class Request
    {
        [JsonProperty("id")]
        public string Id { get; internal set; }

        /// <summary>
        /// The results of the request that was made. This contains all the definitions and examples
        /// sorted into a list of categories called lexical categories, where each category has entries,
        /// and each entries has senses. These senses have their definitions and examples respectively.
        /// </summary>
        [JsonProperty("results")]
        public List<Result> Results { get; internal set; } = new();
        
        /// <summary>
        /// Attempts to find the first definition if found. Returns 'No definitions' on failure.
        /// </summary>
        /// <returns></returns>
        public string FindFirstDefinition()
        {
            return !TryFindFirst(out var sense) ? Defaults.NoDefinitions : sense.GetFirstDefinition();
        }

        /// <summary>
        /// Attempts to find the first example if found. Returns 'No examples' on failure.
        /// </summary>
        /// <returns></returns>
        public Example FindFirstExample()
        {
            return !TryFindFirst(out var sense) ? new Example { Text = Defaults.NoExamples, Notes = new List<ExampleNote>() } : sense.GetFirstExample();
        }

        /// <summary>
        /// Attempts to find the first inflection if found. Returns 'No inflections' on failure.
        /// </summary>
        /// <returns></returns>
        public string FindFirstInflection()
        {
            if (!Results.Any())
                return Defaults.NoInflection;

            var result = Results.FirstOrDefault();

            if (result != null && !result.LexicalEntries.Any())
                return Defaults.NoInflection;

            var lexEntry = result?.LexicalEntries.FirstOrDefault();

            var inflections = lexEntry.Inflections;

            if (lexEntry.Inflections != null && !inflections.Any())
                return Defaults.NoInflection;

            return lexEntry?.Inflections.FirstOrDefault().Text;
        }

        private bool TryFindFirst(out Sense sense)
        {
            sense = default;

            if (!Results.Any())
                return false;

            var result = Results.FirstOrDefault();

            if (result != null && !result.LexicalEntries.Any())
                return false;

            var lexEntry = result?.LexicalEntries.FirstOrDefault();

            if (lexEntry != null && !lexEntry.Entries.Any())
                return false;

            var entry = lexEntry?.Entries.FirstOrDefault();

            if (entry != null && !entry.Senses.Any())
                return false;

            sense = entry?.Senses.FirstOrDefault();
            return true;
        }
    }
}
