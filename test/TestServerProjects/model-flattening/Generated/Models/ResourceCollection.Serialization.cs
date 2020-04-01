// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace model_flattening.Models
{
    public partial class ResourceCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Productresource != null)
            {
                writer.WritePropertyName("productresource");
                writer.WriteObjectValue(Productresource);
            }
            if (Arrayofresources != null)
            {
                writer.WritePropertyName("arrayofresources");
                writer.WriteStartArray();
                foreach (var item in Arrayofresources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Dictionaryofresources != null)
            {
                writer.WritePropertyName("dictionaryofresources");
                writer.WriteStartObject();
                foreach (var item in Dictionaryofresources)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ResourceCollection DeserializeResourceCollection(JsonElement element)
        {
            FlattenedProduct productresource = default;
            IList<FlattenedProduct> arrayofresources = default;
            IDictionary<string, FlattenedProduct> dictionaryofresources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productresource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        productresource = null;
                    }
                    else
                    {
                        productresource = FlattenedProduct.DeserializeFlattenedProduct(property.Value);
                    }
                    continue;
                }
                if (property.NameEquals("arrayofresources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        arrayofresources = null;
                    }
                    else
                    {
                        List<FlattenedProduct> array = new List<FlattenedProduct>();
                        foreach (var item in property.Value.EnumerateArray())
                        {
                            if (item.ValueKind == JsonValueKind.Null)
                            {
                                array.Add(null);
                            }
                            else
                            {
                                array.Add(FlattenedProduct.DeserializeFlattenedProduct(item));
                            }
                        }
                        arrayofresources = array;
                    }
                    continue;
                }
                if (property.NameEquals("dictionaryofresources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dictionaryofresources = null;
                    }
                    else
                    {
                        Dictionary<string, FlattenedProduct> dictionary = new Dictionary<string, FlattenedProduct>();
                        foreach (var property0 in property.Value.EnumerateObject())
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                dictionary.Add(property0.Name, null);
                            }
                            else
                            {
                                dictionary.Add(property0.Name, FlattenedProduct.DeserializeFlattenedProduct(property0.Value));
                            }
                        }
                        dictionaryofresources = dictionary;
                    }
                    continue;
                }
            }
            return new ResourceCollection(productresource, arrayofresources, dictionaryofresources);
        }
    }
}
