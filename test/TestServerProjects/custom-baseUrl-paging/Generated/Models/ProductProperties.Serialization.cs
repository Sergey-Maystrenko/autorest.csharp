// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace custom_baseUrl_paging.Models
{
    public partial class ProductProperties
    {
        internal static ProductProperties DeserializeProductProperties(JsonElement element)
        {
            int? id = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                    }
                    else
                    {
                        id = property.Value.GetInt32();
                    }
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                    }
                    else
                    {
                        name = property.Value.GetString();
                    }
                    continue;
                }
            }
            return new ProductProperties(id, name);
        }
    }
}
