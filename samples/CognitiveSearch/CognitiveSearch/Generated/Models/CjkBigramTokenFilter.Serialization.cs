// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class CjkBigramTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (IgnoreScripts != null)
            {
                writer.WritePropertyName("ignoreScripts");
                writer.WriteStartArray();
                foreach (var item in IgnoreScripts)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (OutputUnigrams != null)
            {
                writer.WritePropertyName("outputUnigrams");
                writer.WriteBooleanValue(OutputUnigrams.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static CjkBigramTokenFilter DeserializeCjkBigramTokenFilter(JsonElement element)
        {
            IList<CjkBigramTokenFilterScripts> ignoreScripts = default;
            bool? outputUnigrams = default;
            string odatatype = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ignoreScripts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        ignoreScripts = null;
                    }
                    else
                    {
                        List<CjkBigramTokenFilterScripts> array = new List<CjkBigramTokenFilterScripts>();
                        foreach (var item in property.Value.EnumerateArray())
                        {
                            array.Add(item.GetString().ToCjkBigramTokenFilterScripts());
                        }
                        ignoreScripts = array;
                    }
                    continue;
                }
                if (property.NameEquals("outputUnigrams"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        outputUnigrams = null;
                    }
                    else
                    {
                        outputUnigrams = property.Value.GetBoolean();
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
            return new CjkBigramTokenFilter(odatatype, name, ignoreScripts, outputUnigrams);
        }
    }
}
