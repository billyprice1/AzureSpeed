﻿using Newtonsoft.Json;

namespace AzureSpeed.Common.Storage
{
    public class StorageAccount
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("endpointSuffix")]
        public string EndpointSuffix { get; set; }
    }
}