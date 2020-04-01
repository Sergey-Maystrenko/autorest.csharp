// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class EffectiveNetworkSecurityGroup
    {
        internal static EffectiveNetworkSecurityGroup DeserializeEffectiveNetworkSecurityGroup(JsonElement element)
        {
            SubResource networkSecurityGroup = default;
            EffectiveNetworkSecurityGroupAssociation association = default;
            IReadOnlyList<EffectiveNetworkSecurityRule> effectiveSecurityRules = default;
            string tagMap = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSecurityGroup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        networkSecurityGroup = null;
                    }
                    else
                    {
                        networkSecurityGroup = SubResource.DeserializeSubResource(property.Value);
                    }
                    continue;
                }
                if (property.NameEquals("association"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        association = null;
                    }
                    else
                    {
                        association = EffectiveNetworkSecurityGroupAssociation.DeserializeEffectiveNetworkSecurityGroupAssociation(property.Value);
                    }
                    continue;
                }
                if (property.NameEquals("effectiveSecurityRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        effectiveSecurityRules = null;
                    }
                    else
                    {
                        List<EffectiveNetworkSecurityRule> array = new List<EffectiveNetworkSecurityRule>();
                        foreach (var item in property.Value.EnumerateArray())
                        {
                            if (item.ValueKind == JsonValueKind.Null)
                            {
                                array.Add(null);
                            }
                            else
                            {
                                array.Add(EffectiveNetworkSecurityRule.DeserializeEffectiveNetworkSecurityRule(item));
                            }
                        }
                        effectiveSecurityRules = array;
                    }
                    continue;
                }
                if (property.NameEquals("tagMap"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tagMap = null;
                    }
                    else
                    {
                        tagMap = property.Value.GetString();
                    }
                    continue;
                }
            }
            return new EffectiveNetworkSecurityGroup(networkSecurityGroup, association, effectiveSecurityRules, tagMap);
        }
    }
}
