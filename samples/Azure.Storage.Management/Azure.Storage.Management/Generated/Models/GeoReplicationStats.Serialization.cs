// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class GeoReplicationStats : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Status != null)
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (LastSyncTime != null)
            {
                writer.WritePropertyName("lastSyncTime");
                writer.WriteStringValue(LastSyncTime.Value, "S");
            }
            if (CanFailover != null)
            {
                writer.WritePropertyName("canFailover");
                writer.WriteBooleanValue(CanFailover.Value);
            }
            writer.WriteEndObject();
        }

        internal static GeoReplicationStats DeserializeGeoReplicationStats(JsonElement element)
        {
            GeoReplicationStatus? status = default;
            DateTimeOffset? lastSyncTime = default;
            bool? canFailover = default;
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
                        status = new GeoReplicationStatus(property.Value.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("lastSyncTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastSyncTime = null;
                    }
                    else
                    {
                        lastSyncTime = property.Value.GetDateTimeOffset("S");
                    }
                    continue;
                }
                if (property.NameEquals("canFailover"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        canFailover = null;
                    }
                    else
                    {
                        canFailover = property.Value.GetBoolean();
                    }
                    continue;
                }
            }
            return new GeoReplicationStats(status, lastSyncTime, canFailover);
        }
    }
}
