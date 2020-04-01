// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class Delegation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ServiceName != null)
            {
                writer.WritePropertyName("serviceName");
                writer.WriteStringValue(ServiceName);
            }
            if (Actions != null)
            {
                writer.WritePropertyName("actions");
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Delegation DeserializeDelegation(JsonElement element)
        {
            string name = default;
            string etag = default;
            string id = default;
            string serviceName = default;
            IList<string> actions = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        etag = null;
                    }
                    else
                    {
                        etag = property.Value.GetString();
                    }
                    continue;
                }
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                serviceName = null;
                            }
                            else
                            {
                                serviceName = property0.Value.GetString();
                            }
                            continue;
                        }
                        if (property0.NameEquals("actions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                actions = null;
                            }
                            else
                            {
                                List<string> array = new List<string>();
                                foreach (var item in property0.Value.EnumerateArray())
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
                                actions = array;
                            }
                            continue;
                        }
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
                                provisioningState = new ProvisioningState(property0.Value.GetString());
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Delegation(id, name, etag, serviceName, actions, provisioningState);
        }
    }
}
