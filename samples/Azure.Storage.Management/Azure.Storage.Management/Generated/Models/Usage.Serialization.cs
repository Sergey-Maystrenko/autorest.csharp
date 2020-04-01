// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class Usage
    {
        internal static Usage DeserializeUsage(JsonElement element)
        {
            UsageUnit? unit = default;
            int? currentValue = default;
            int? limit = default;
            UsageName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        unit = null;
                    }
                    else
                    {
                        unit = property.Value.GetString().ToUsageUnit();
                    }
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        currentValue = null;
                    }
                    else
                    {
                        currentValue = property.Value.GetInt32();
                    }
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limit = null;
                    }
                    else
                    {
                        limit = property.Value.GetInt32();
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
                        name = UsageName.DeserializeUsageName(property.Value);
                    }
                    continue;
                }
            }
            return new Usage(unit, currentValue, limit, name);
        }
    }
}
