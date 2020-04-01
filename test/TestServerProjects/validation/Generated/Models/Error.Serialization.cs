// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace validation.Models
{
    public partial class Error
    {
        internal static Error DeserializeError(JsonElement element)
        {
            int? code = default;
            string message = default;
            string fields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        code = null;
                    }
                    else
                    {
                        code = property.Value.GetInt32();
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
                if (property.NameEquals("fields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fields = null;
                    }
                    else
                    {
                        fields = property.Value.GetString();
                    }
                    continue;
                }
            }
            return new Error(code, message, fields);
        }
    }
}
