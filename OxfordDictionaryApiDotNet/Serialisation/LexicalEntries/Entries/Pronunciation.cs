using System.Collections.Generic;
using Newtonsoft.Json;

namespace OxfordDictionaryApiDotNet.Serialisation.LexicalEntries.Entries
{
    public class Pronunciation
    {
        /// <summary>
        /// Link to the audio file.
        /// </summary>
        [JsonProperty("audioFile")]
        public string AudioFile { get; internal set; }

        /// <summary>
        /// The dialects of this audio piece. Usually one dialect is given.
        /// </summary>
        [JsonProperty("dialects")]
        public List<string> Dialects { get; internal set; }

        /// <summary>
        /// The phonetic notation of this pronunciation, such as 'IPA'.
        /// </summary>
        [JsonProperty("phoneticNotation")]
        public string PhoneticNotation { get; internal set; }

        /// <summary>
        /// The phonetic spelling of this pronunciation.
        /// </summary>
        [JsonProperty("phoneticSpelling")]
        public string PhoneticSpelling { get; internal set; }
    }
}
