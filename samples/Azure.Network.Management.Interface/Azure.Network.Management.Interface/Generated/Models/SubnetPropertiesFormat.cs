// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Properties of the subnet. </summary>
    public partial class SubnetPropertiesFormat
    {
        /// <summary> The address prefix for the subnet. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> List of address prefixes for the subnet. </summary>
        public IList<string> AddressPrefixes { get; set; }
        /// <summary> The reference to the NetworkSecurityGroup resource. </summary>
        public NetworkSecurityGroup NetworkSecurityGroup { get; set; }
        /// <summary> The reference to the RouteTable resource. </summary>
        public RouteTable RouteTable { get; set; }
        /// <summary> Nat gateway associated with this subnet. </summary>
        public SubResource NatGateway { get; set; }
        /// <summary> An array of service endpoints. </summary>
        public IList<ServiceEndpointPropertiesFormat> ServiceEndpoints { get; set; }
        /// <summary> An array of service endpoint policies. </summary>
        public IList<ServiceEndpointPolicy> ServiceEndpointPolicies { get; set; }
        /// <summary> An array of references to private endpoints. </summary>
        public IList<PrivateEndpoint> PrivateEndpoints { get; internal set; }
        /// <summary> An array of references to the network interface IP configurations using subnet. </summary>
        public IList<IPConfiguration> IpConfigurations { get; internal set; }
        /// <summary> Array of IP configuration profiles which reference this subnet. </summary>
        public IList<IPConfigurationProfile> IpConfigurationProfiles { get; internal set; }
        /// <summary> An array of references to the external resources using subnet. </summary>
        public IList<ResourceNavigationLink> ResourceNavigationLinks { get; internal set; }
        /// <summary> An array of references to services injecting into this subnet. </summary>
        public IList<ServiceAssociationLink> ServiceAssociationLinks { get; internal set; }
        /// <summary> An array of references to the delegations on the subnet. </summary>
        public IList<Delegation> Delegations { get; set; }
        /// <summary> A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties. </summary>
        public string Purpose { get; internal set; }
        /// <summary> The provisioning state of the subnet resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> Enable or Disable apply network policies on private end point in the subnet. </summary>
        public string PrivateEndpointNetworkPolicies { get; set; }
        /// <summary> Enable or Disable apply network policies on private link service in the subnet. </summary>
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }
}