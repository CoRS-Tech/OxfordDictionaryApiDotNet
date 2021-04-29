﻿using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;
using OxfordDictionaryApiRapper.Serialisation;

namespace OxfordDictionaryApiRapper.Api
{
    internal static class ApiRequests
    {
        internal static async Task<HttpContent> InternalRequestAsync(string url, string appId, string appKey, string query)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add(Defaults.AppId, appId);
            client.DefaultRequestHeaders.Add(Defaults.AppKey, appKey);

            var req = await client.GetAsync(url);

            if (!req.IsSuccessStatusCode)
                return default;

            return req.Content;
        }

        internal static async Task<Request> RequestEntryAsync(string query, string appId, string appKey)
        {
            var url = Path.Combine(Defaults.EntriesEndpoint, query);
            var req = await InternalRequestAsync(url, appId, appKey, query);

            if (req == default)
                return default;

            var content = await req.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Request>(content);
        }

        internal static async Task<Request> RequestLemmaAsync(string query, string appId, string appKey)
        {
            var url = Path.Combine(Defaults.LemmasEndpoint, query);
            var req = await InternalRequestAsync(url, appId, appKey, query);

            if (req == default)
                return default;

            var content = await req.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Request>(content);
        }
    }
}
