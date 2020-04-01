// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class PatternTokenizer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Pattern != null)
            {
                writer.WritePropertyName("pattern");
                writer.WriteStringValue(Pattern);
            }
            if (Flags != null)
            {
                writer.WritePropertyName("flags");
                writer.WriteStringValue(Flags.Value.ToString());
            }
            if (Group != null)
            {
                writer.WritePropertyName("group");
                writer.WriteNumberValue(Group.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static PatternTokenizer DeserializePatternTokenizer(JsonElement element)
        {
            string pattern = default;
            RegexFlags? flags = default;
            int? group = default;
            string odatatype = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pattern"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pattern = null;
                    }
                    else
                    {
                        pattern = property.Value.GetString();
                    }
                    continue;
                }
                if (property.NameEquals("flags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        flags = null;
                    }
                    else
                    {
                        flags = new RegexFlags(property.Value.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("group"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        group = null;
                    }
                    else
                    {
                        group = property.Value.GetInt32();
                    }
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odatatype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PatternTokenizer(odatatype, name, pattern, flags, group);
        }
    }
}
