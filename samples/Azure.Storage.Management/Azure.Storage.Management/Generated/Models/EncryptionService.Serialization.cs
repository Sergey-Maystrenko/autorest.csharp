// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class EncryptionService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Enabled != null)
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (LastEnabledTime != null)
            {
                writer.WritePropertyName("lastEnabledTime");
                writer.WriteStringValue(LastEnabledTime.Value, "S");
            }
            if (KeyType != null)
            {
                writer.WritePropertyName("keyType");
                writer.WriteStringValue(KeyType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static EncryptionService DeserializeEncryptionService(JsonElement element)
        {
            bool? enabled = default;
            DateTimeOffset? lastEnabledTime = default;
            KeyType? keyType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enabled = null;
                    }
                    else
                    {
                        enabled = property.Value.GetBoolean();
                    }
                    continue;
                }
                if (property.NameEquals("lastEnabledTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastEnabledTime = null;
                    }
                    else
                    {
                        lastEnabledTime = property.Value.GetDateTimeOffset("S");
                    }
                    continue;
                }
                if (property.NameEquals("keyType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyType = null;
                    }
                    else
                    {
                        keyType = new KeyType(property.Value.GetString());
                    }
                    continue;
                }
            }
            return new EncryptionService(enabled, lastEnabledTime, keyType);
        }
    }
}
