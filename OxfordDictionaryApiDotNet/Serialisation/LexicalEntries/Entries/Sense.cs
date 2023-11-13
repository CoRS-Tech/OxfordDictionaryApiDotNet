using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using OxfordDictionaryApiDotNet.Api;

namespace OxfordDictionaryApiDotNet.Serialisation.LexicalEntries.Entries
{
    public class Sense
    {
        /// <summary>
        /// Contains one or multiple definitions this sense may have.
        /// </summary>
        [JsonProperty("definitions")]
        public List<string>? Definitions { get; internal set; }

        /// <summary>
        /// Contains one or multiple examples this sense may have.
        /// </summary>
        [JsonProperty("examples")]
        public List<Example>? Examples { get; internal set; } = new();

        /// <summary>
        /// Short definitions with no examples.
        /// </summary>
        [JsonProperty("shortDefinitions")]
        public List<string>? ShortDefinitions { get; internal set; }

        /// <summary>
        /// More senses.
        /// </summary>
        [JsonProperty("subsenses")]
        public List<Sense>? Subsenses { get; internal set; }
        
        /// <summary>
        /// Gets the first definition of this sense.
        /// </summary>
        /// <returns>Returns the definition.</returns>
        public string? GetFirstDefinition()
            => Definitions != null && Definitions.Any()
                ? Definitions.FirstOrDefault() 
                : Defaults.NoDefinitions;

        /// <summary>
        /// Gets the first example of this sense.
        /// </summary>
        /// <returns>Returns the example.</returns>
        public Example? GetFirstExample()
            => Examples != null && Examples.Any()
                ? Examples.FirstOrDefault()
                : new Example 
                { 
                    Text = Defaults.NoExamples, 
                    Notes = Enumerable.Empty<ExampleNote>().ToList() 
                };
    }
}
