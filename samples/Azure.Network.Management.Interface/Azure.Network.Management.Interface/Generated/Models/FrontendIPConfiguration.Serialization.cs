// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class FrontendIPConfiguration : IUtf8JsonSerializable
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
            if (Zones != null)
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (InboundNatRules != null)
            {
                writer.WritePropertyName("inboundNatRules");
                writer.WriteStartArray();
                foreach (var item in InboundNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (InboundNatPools != null)
            {
                writer.WritePropertyName("inboundNatPools");
                writer.WriteStartArray();
                foreach (var item in InboundNatPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OutboundRules != null)
            {
                writer.WritePropertyName("outboundRules");
                writer.WriteStartArray();
                foreach (var item in OutboundRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (LoadBalancingRules != null)
            {
                writer.WritePropertyName("loadBalancingRules");
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (PrivateIPAddress != null)
            {
                writer.WritePropertyName("privateIPAddress");
                writer.WriteStringValue(PrivateIPAddress);
            }
            if (PrivateIPAllocationMethod != null)
            {
                writer.WritePropertyName("privateIPAllocationMethod");
                writer.WriteStringValue(PrivateIPAllocationMethod.Value.ToString());
            }
            if (PrivateIPAddressVersion != null)
            {
                writer.WritePropertyName("privateIPAddressVersion");
                writer.WriteStringValue(PrivateIPAddressVersion.Value.ToString());
            }
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet");
                writer.WriteObjectValue(Subnet);
            }
            if (PublicIPAddress != null)
            {
                writer.WritePropertyName("publicIPAddress");
                writer.WriteObjectValue(PublicIPAddress);
            }
            if (PublicIPPrefix != null)
            {
                writer.WritePropertyName("publicIPPrefix");
                writer.WriteObjectValue(PublicIPPrefix);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FrontendIPConfiguration DeserializeFrontendIPConfiguration(JsonElement element)
        {
            string name = default;
            string etag = default;
            string type = default;
            IList<string> zones = default;
            string id = default;
            IList<SubResource> inboundNatRules = default;
            IList<SubResource> inboundNatPools = default;
            IList<SubResource> outboundRules = default;
            IList<SubResource> loadBalancingRules = default;
            string privateIPAddress = default;
            IPAllocationMethod? privateIPAllocationMethod = default;
            IPVersion? privateIPAddressVersion = default;
            Subnet subnet = default;
            PublicIPAddress publicIPAddress = default;
            SubResource publicIPPrefix = default;
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
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        zones = null;
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
                        zones = array;
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
                        if (property0.NameEquals("inboundNatRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                inboundNatRules = null;
                            }
                            else
                            {
                                List<SubResource> array = new List<SubResource>();
                                foreach (var item in property0.Value.EnumerateArray())
                                {
                                    if (item.ValueKind == JsonValueKind.Null)
                                    {
                                        array.Add(null);
                                    }
                                    else
                                    {
                                        array.Add(DeserializeSubResource(item));
                                    }
                                }
                                inboundNatRules = array;
                            }
                            continue;
                        }
                        if (property0.NameEquals("inboundNatPools"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                inboundNatPools = null;
                            }
                            else
                            {
                                List<SubResource> array = new List<SubResource>();
                                foreach (var item in property0.Value.EnumerateArray())
                                {
                                    if (item.ValueKind == JsonValueKind.Null)
                                    {
                                        array.Add(null);
                                    }
                                    else
                                    {
                                        array.Add(DeserializeSubResource(item));
                                    }
                                }
                                inboundNatPools = array;
                            }
                            continue;
                        }
                        if (property0.NameEquals("outboundRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                outboundRules = null;
                            }
                            else
                            {
                                List<SubResource> array = new List<SubResource>();
                                foreach (var item in property0.Value.EnumerateArray())
                                {
                                    if (item.ValueKind == JsonValueKind.Null)
                                    {
                                        array.Add(null);
                                    }
                                    else
                                    {
                                        array.Add(DeserializeSubResource(item));
                                    }
                                }
                                outboundRules = array;
                            }
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                loadBalancingRules = null;
                            }
                            else
                            {
                                List<SubResource> array = new List<SubResource>();
                                foreach (var item in property0.Value.EnumerateArray())
                                {
                                    if (item.ValueKind == JsonValueKind.Null)
                                    {
                                        array.Add(null);
                                    }
                                    else
                                    {
                                        array.Add(DeserializeSubResource(item));
                                    }
                                }
                                loadBalancingRules = array;
                            }
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateIPAddress = null;
                            }
                            else
                            {
                                privateIPAddress = property0.Value.GetString();
                            }
                            continue;
                        }
                        if (property0.NameEquals("privateIPAllocationMethod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateIPAllocationMethod = null;
                            }
                            else
                            {
                                privateIPAllocationMethod = new IPAllocationMethod(property0.Value.GetString());
                            }
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddressVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                privateIPAddressVersion = null;
                            }
                            else
                            {
                                privateIPAddressVersion = new IPVersion(property0.Value.GetString());
                            }
                            continue;
                        }
                        if (property0.NameEquals("subnet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                subnet = null;
                            }
                            else
                            {
                                subnet = Subnet.DeserializeSubnet(property0.Value);
                            }
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                publicIPAddress = null;
                            }
                            else
                            {
                                publicIPAddress = PublicIPAddress.DeserializePublicIPAddress(property0.Value);
                            }
                            continue;
                        }
                        if (property0.NameEquals("publicIPPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                publicIPPrefix = null;
                            }
                            else
                            {
                                publicIPPrefix = DeserializeSubResource(property0.Value);
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
            return new FrontendIPConfiguration(id, name, etag, type, zones, inboundNatRules, inboundNatPools, outboundRules, loadBalancingRules, privateIPAddress, privateIPAllocationMethod, privateIPAddressVersion, subnet, publicIPAddress, publicIPPrefix, provisioningState);
        }
    }
}
