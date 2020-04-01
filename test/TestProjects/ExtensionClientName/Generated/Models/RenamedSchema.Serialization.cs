// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ExtensionClientName.Models
{
    public partial class RenamedSchema : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (RenamedProperty != null)
            {
                writer.WritePropertyName("originalProperty");
                writer.WriteStartObject();
                foreach (var item in RenamedProperty)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (RenamedPropertyString != null)
            {
                writer.WritePropertyName("originalPropertyString");
                writer.WriteStringValue(RenamedPropertyString);
            }
            writer.WriteEndObject();
        }

        internal static RenamedSchema DeserializeRenamedSchema(JsonElement element)
        {
            IDictionary<string, string> originalProperty = default;
            string originalPropertyString = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("originalProperty"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        originalProperty = null;
                    }
                    else
                    {
                        Dictionary<string, string> dictionary = new Dictionary<string, string>();
                        foreach (var property0 in property.Value.EnumerateObject())
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                dictionary.Add(property0.Name, null);
                            }
                            else
                            {
                                dictionary.Add(property0.Name, property0.Value.GetString());
                            }
                        }
                        originalProperty = dictionary;
                    }
                    continue;
                }
                if (property.NameEquals("originalPropertyString"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        originalPropertyString = null;
                    }
                    else
                    {
                        originalPropertyString = property.Value.GetString();
                    }
                    continue;
                }
            }
            return new RenamedSchema(originalProperty, originalPropertyString);
        }
    }
}
