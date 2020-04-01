// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace header.Models
{
    public partial class Error
    {
        internal static Error DeserializeError(JsonElement element)
        {
            int? status = default;
            string message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        status = null;
                    }
                    else
                    {
                        status = property.Value.GetInt32();
                    }
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        message = null;
                    }
                    else
                    {
                        message = property.Value.GetString();
                    }
                    continue;
                }
            }
            return new Error(status, message);
        }
    }
}
