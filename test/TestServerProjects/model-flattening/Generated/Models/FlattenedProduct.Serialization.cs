// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace model_flattening.Models
{
    public partial class FlattenedProduct : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
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
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PName))
            {
                writer.WritePropertyName("p.name");
                writer.WriteStringValue(PName);
            }
            if (Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypePropertiesType);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FlattenedProduct DeserializeFlattenedProduct(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> type = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> location = default;
            Optional<string> name = default;
            Optional<string> pName = default;
            Optional<string> type0 = default;
            Optional<FlattenedProductPropertiesProvisioningStateValues> provisioningStateValues = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("p.name"))
                        {
                            pName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningStateValues"))
                        {
                            provisioningStateValues = new FlattenedProductPropertiesProvisioningStateValues(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FlattenedProduct(id.Value, type.Value, Optional.ToDictionary(tags), location.Value, name.Value, pName.Value, type0.Value, Optional.ToNullable(provisioningStateValues), provisioningState.Value);
        }
    }
}
