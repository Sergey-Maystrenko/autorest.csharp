// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ResourceCounter
    {
        internal static ResourceCounter DeserializeResourceCounter(JsonElement element)
        {
            long usage = default;
            long? quota = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usage"))
                {
                    usage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("quota"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        quota = null;
                    }
                    else
                    {
                        quota = property.Value.GetInt64();
                    }
                    continue;
                }
            }
            return new ResourceCounter(usage, quota);
        }
    }
}
