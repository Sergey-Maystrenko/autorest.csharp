// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class InboundNatPool : IUtf8JsonSerializable
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
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (FrontendIPConfiguration != null)
            {
                writer.WritePropertyName("frontendIPConfiguration");
                writer.WriteObjectValue(FrontendIPConfiguration);
            }
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (FrontendPortRangeStart != null)
            {
                writer.WritePropertyName("frontendPortRangeStart");
                writer.WriteNumberValue(FrontendPortRangeStart.Value);
            }
            if (FrontendPortRangeEnd != null)
            {
                writer.WritePropertyName("frontendPortRangeEnd");
                writer.WriteNumberValue(FrontendPortRangeEnd.Value);
            }
            if (BackendPort != null)
            {
                writer.WritePropertyName("backendPort");
                writer.WriteNumberValue(BackendPort.Value);
            }
            if (IdleTimeoutInMinutes != null)
            {
                writer.WritePropertyName("idleTimeoutInMinutes");
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (EnableFloatingIP != null)
            {
                writer.WritePropertyName("enableFloatingIP");
                writer.WriteBooleanValue(EnableFloatingIP.Value);
            }
            if (EnableTcpReset != null)
            {
                writer.WritePropertyName("enableTcpReset");
                writer.WriteBooleanValue(EnableTcpReset.Value);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static InboundNatPool DeserializeInboundNatPool(JsonElement element)
        {
            string name = default;
            string etag = default;
            string type = default;
            string id = default;
            SubResource frontendIPConfiguration = default;
            TransportProtocol? protocol = default;
            int? frontendPortRangeStart = default;
            int? frontendPortRangeEnd = default;
            int? backendPort = default;
            int? idleTimeoutInMinutes = default;
            bool? enableFloatingIP = default;
            bool? enableTcpReset = default;
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
                        if (property0.NameEquals("frontendIPConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                frontendIPConfiguration = null;
                            }
                            else
                            {
                                frontendIPConfiguration = DeserializeSubResource(property0.Value);
                            }
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                protocol = null;
                            }
                            else
                            {
                                protocol = new TransportProtocol(property0.Value.GetString());
                            }
                            continue;
                        }
                        if (property0.NameEquals("frontendPortRangeStart"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                frontendPortRangeStart = null;
                            }
                            else
                            {
                                frontendPortRangeStart = property0.Value.GetInt32();
                            }
                            continue;
                        }
                        if (property0.NameEquals("frontendPortRangeEnd"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                frontendPortRangeEnd = null;
                            }
                            else
                            {
                                frontendPortRangeEnd = property0.Value.GetInt32();
                            }
                            continue;
                        }
                        if (property0.NameEquals("backendPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                backendPort = null;
                            }
                            else
                            {
                                backendPort = property0.Value.GetInt32();
                            }
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                idleTimeoutInMinutes = null;
                            }
                            else
                            {
                                idleTimeoutInMinutes = property0.Value.GetInt32();
                            }
                            continue;
                        }
                        if (property0.NameEquals("enableFloatingIP"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                enableFloatingIP = null;
                            }
                            else
                            {
                                enableFloatingIP = property0.Value.GetBoolean();
                            }
                            continue;
                        }
                        if (property0.NameEquals("enableTcpReset"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                enableTcpReset = null;
                            }
                            else
                            {
                                enableTcpReset = property0.Value.GetBoolean();
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
            return new InboundNatPool(id, name, etag, type, frontendIPConfiguration, protocol, frontendPortRangeStart, frontendPortRangeEnd, backendPort, idleTimeoutInMinutes, enableFloatingIP, enableTcpReset, provisioningState);
        }
    }
}
