// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace lro.Models
{
    public partial class Product : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            if (ProvisioningStateValues != null)
            {
                writer.WritePropertyName("provisioningStateValues");
                writer.WriteStringValue(ProvisioningStateValues.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Product DeserializeProduct(JsonElement element)
        {
            string id = default;
            string type = default;
            IDictionary<string, string> tags = default;
            string location = default;
            string name = default;
            string provisioningState = default;
            ProductPropertiesProvisioningStateValues? provisioningStateValues = default;
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
                        id = property.Value.GetString();
                    }
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        type = null;
                    }
                    else
                    {
                        type = property.Value.GetString();
                    }
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                        tags = dictionary;
                    }
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        location = null;
                    }
                    else
                    {
                        location = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                provisioningState = null;
                            }
                            else
                            {
                                provisioningState = property0.Value.GetString();
                            }
                            continue;
                        }
                        if (property0.NameEquals("provisioningStateValues"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                provisioningStateValues = null;
                            }
                            else
                            {
                                provisioningStateValues = new ProductPropertiesProvisioningStateValues(property0.Value.GetString());
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Product(id, type, tags, location, name, provisioningState, provisioningStateValues);
        }
    }
}
