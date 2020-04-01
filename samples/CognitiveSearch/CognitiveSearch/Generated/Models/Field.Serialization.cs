// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Field : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            if (Key != null)
            {
                writer.WritePropertyName("key");
                writer.WriteBooleanValue(Key.Value);
            }
            if (Retrievable != null)
            {
                writer.WritePropertyName("retrievable");
                writer.WriteBooleanValue(Retrievable.Value);
            }
            if (Searchable != null)
            {
                writer.WritePropertyName("searchable");
                writer.WriteBooleanValue(Searchable.Value);
            }
            if (Filterable != null)
            {
                writer.WritePropertyName("filterable");
                writer.WriteBooleanValue(Filterable.Value);
            }
            if (Sortable != null)
            {
                writer.WritePropertyName("sortable");
                writer.WriteBooleanValue(Sortable.Value);
            }
            if (Facetable != null)
            {
                writer.WritePropertyName("facetable");
                writer.WriteBooleanValue(Facetable.Value);
            }
            if (Analyzer != null)
            {
                writer.WritePropertyName("analyzer");
                writer.WriteStringValue(Analyzer.Value.ToString());
            }
            if (SearchAnalyzer != null)
            {
                writer.WritePropertyName("searchAnalyzer");
                writer.WriteStringValue(SearchAnalyzer.Value.ToString());
            }
            if (IndexAnalyzer != null)
            {
                writer.WritePropertyName("indexAnalyzer");
                writer.WriteStringValue(IndexAnalyzer.Value.ToString());
            }
            if (SynonymMaps != null)
            {
                writer.WritePropertyName("synonymMaps");
                writer.WriteStartArray();
                foreach (var item in SynonymMaps)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Fields != null)
            {
                writer.WritePropertyName("fields");
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Field DeserializeField(JsonElement element)
        {
            string name = default;
            DataType type = default;
            bool? key = default;
            bool? retrievable = default;
            bool? searchable = default;
            bool? filterable = default;
            bool? sortable = default;
            bool? facetable = default;
            AnalyzerName? analyzer = default;
            AnalyzerName? searchAnalyzer = default;
            AnalyzerName? indexAnalyzer = default;
            IList<string> synonymMaps = default;
            IList<Field> fields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new DataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        key = null;
                    }
                    else
                    {
                        key = property.Value.GetBoolean();
                    }
                    continue;
                }
                if (property.NameEquals("retrievable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        retrievable = null;
                    }
                    else
                    {
                        retrievable = property.Value.GetBoolean();
                    }
                    continue;
                }
                if (property.NameEquals("searchable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchable = null;
                    }
                    else
                    {
                        searchable = property.Value.GetBoolean();
                    }
                    continue;
                }
                if (property.NameEquals("filterable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        filterable = null;
                    }
                    else
                    {
                        filterable = property.Value.GetBoolean();
                    }
                    continue;
                }
                if (property.NameEquals("sortable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sortable = null;
                    }
                    else
                    {
                        sortable = property.Value.GetBoolean();
                    }
                    continue;
                }
                if (property.NameEquals("facetable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        facetable = null;
                    }
                    else
                    {
                        facetable = property.Value.GetBoolean();
                    }
                    continue;
                }
                if (property.NameEquals("analyzer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        analyzer = null;
                    }
                    else
                    {
                        analyzer = new AnalyzerName(property.Value.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("searchAnalyzer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchAnalyzer = null;
                    }
                    else
                    {
                        searchAnalyzer = new AnalyzerName(property.Value.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("indexAnalyzer"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        indexAnalyzer = null;
                    }
                    else
                    {
                        indexAnalyzer = new AnalyzerName(property.Value.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("synonymMaps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        synonymMaps = null;
                    }
                    else
                    {
                        List<string> array = new List<string>();
                        foreach (var item in property.Value.EnumerateArray())
                        {
                            if (item.ValueKind == JsonValueKind.Null)
                            {
                                array.Add(null);
                            }
                            else
                            {
                                array.Add(item.GetString());
                            }
                        }
                        synonymMaps = array;
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
                        List<Field> array = new List<Field>();
                        foreach (var item in property.Value.EnumerateArray())
                        {
                            if (item.ValueKind == JsonValueKind.Null)
                            {
                                array.Add(null);
                            }
                            else
                            {
                                array.Add(DeserializeField(item));
                            }
                        }
                        fields = array;
                    }
                    continue;
                }
            }
            return new Field(name, type, key, retrievable, searchable, filterable, sortable, facetable, analyzer, searchAnalyzer, indexAnalyzer, synonymMaps, fields);
        }
    }
}
