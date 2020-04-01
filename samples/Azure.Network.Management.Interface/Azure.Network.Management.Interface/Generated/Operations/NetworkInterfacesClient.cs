// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Network.Management.Interface.Models;

namespace Azure.Network.Management.Interface
{
    public partial class NetworkInterfacesClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal NetworkInterfacesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of NetworkInterfacesClient for mocking. </summary>
        protected NetworkInterfacesClient()
        {
        }
        /// <summary> Initializes a new instance of NetworkInterfacesClient. </summary>
        internal NetworkInterfacesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com", string apiVersion = "2019-11-01")
        {
            RestClient = new NetworkInterfacesRestClient(clientDiagnostics, pipeline, subscriptionId, host, apiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Gets information about the specified network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkInterface>> GetAsync(string resourceGroupName, string networkInterfaceName, string expand, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, networkInterfaceName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets information about the specified network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkInterface> Get(string resourceGroupName, string networkInterfaceName, string expand, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, networkInterfaceName, expand, cancellationToken);
        }

        /// <summary> Updates a network interface tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="parameters"> Parameters supplied to update network interface tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkInterface>> UpdateTagsAsync(string resourceGroupName, string networkInterfaceName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateTagsAsync(resourceGroupName, networkInterfaceName, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates a network interface tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="parameters"> Parameters supplied to update network interface tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkInterface> UpdateTags(string resourceGroupName, string networkInterfaceName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdateTags(resourceGroupName, networkInterfaceName, parameters, cancellationToken);
        }

        /// <summary> Gets all network interfaces in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkInterface> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkInterface>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<NetworkInterface>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network interfaces in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkInterface> ListAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkInterface> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListAll(cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<NetworkInterface> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network interfaces in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkInterface> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<NetworkInterface>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<NetworkInterface>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network interfaces in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkInterface> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<NetworkInterface> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(resourceGroupName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<NetworkInterface> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, resourceGroupName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified network interface. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Response> CreateDelete(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Delete, "NetworkInterfacesClient.Delete", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> Deletes the specified network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartDeleteAsync(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            var originalResponse = await RestClient.DeleteAsync(resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, networkInterfaceName));
        }

        /// <summary> Deletes the specified network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartDelete(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            var originalResponse = RestClient.Delete(resourceGroupName, networkInterfaceName, cancellationToken);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, networkInterfaceName));
        }

        /// <summary> Creates or updates a network interface. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<NetworkInterface> CreateCreateOrUpdate(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Put, "NetworkInterfacesClient.CreateOrUpdate", OperationFinalStateVia.AzureAsyncOperation, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return NetworkInterface.DeserializeNetworkInterface(document.RootElement);
                }
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return NetworkInterface.DeserializeNetworkInterface(document.RootElement);
                }
            });
        }

        /// <summary> Creates or updates a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network interface operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<NetworkInterface>> StartCreateOrUpdateAsync(string resourceGroupName, string networkInterfaceName, NetworkInterface parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, networkInterfaceName, parameters, cancellationToken).ConfigureAwait(false);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkInterfaceName, parameters));
        }

        /// <summary> Creates or updates a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network interface operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<NetworkInterface> StartCreateOrUpdate(string resourceGroupName, string networkInterfaceName, NetworkInterface parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, networkInterfaceName, parameters, cancellationToken);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, networkInterfaceName, parameters));
        }

        /// <summary> Gets all route tables applied to a network interface. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<EffectiveRouteListResult> CreateGetEffectiveRouteTable(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "NetworkInterfacesClient.GetEffectiveRouteTable", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return EffectiveRouteListResult.DeserializeEffectiveRouteListResult(document.RootElement);
                }
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return EffectiveRouteListResult.DeserializeEffectiveRouteListResult(document.RootElement);
                }
            });
        }

        /// <summary> Gets all route tables applied to a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<EffectiveRouteListResult>> StartGetEffectiveRouteTableAsync(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            var originalResponse = await RestClient.GetEffectiveRouteTableAsync(resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
            return CreateGetEffectiveRouteTable(originalResponse, () => RestClient.CreateGetEffectiveRouteTableRequest(resourceGroupName, networkInterfaceName));
        }

        /// <summary> Gets all route tables applied to a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<EffectiveRouteListResult> StartGetEffectiveRouteTable(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            var originalResponse = RestClient.GetEffectiveRouteTable(resourceGroupName, networkInterfaceName, cancellationToken);
            return CreateGetEffectiveRouteTable(originalResponse, () => RestClient.CreateGetEffectiveRouteTableRequest(resourceGroupName, networkInterfaceName));
        }

        /// <summary> Gets all network security groups applied to a network interface. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<EffectiveNetworkSecurityGroupListResult> CreateListEffectiveNetworkSecurityGroups(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "NetworkInterfacesClient.ListEffectiveNetworkSecurityGroups", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return EffectiveNetworkSecurityGroupListResult.DeserializeEffectiveNetworkSecurityGroupListResult(document.RootElement);
                }
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return EffectiveNetworkSecurityGroupListResult.DeserializeEffectiveNetworkSecurityGroupListResult(document.RootElement);
                }
            });
        }

        /// <summary> Gets all network security groups applied to a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<EffectiveNetworkSecurityGroupListResult>> StartListEffectiveNetworkSecurityGroupsAsync(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            var originalResponse = await RestClient.ListEffectiveNetworkSecurityGroupsAsync(resourceGroupName, networkInterfaceName, cancellationToken).ConfigureAwait(false);
            return CreateListEffectiveNetworkSecurityGroups(originalResponse, () => RestClient.CreateListEffectiveNetworkSecurityGroupsRequest(resourceGroupName, networkInterfaceName));
        }

        /// <summary> Gets all network security groups applied to a network interface. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<EffectiveNetworkSecurityGroupListResult> StartListEffectiveNetworkSecurityGroups(string resourceGroupName, string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }

            var originalResponse = RestClient.ListEffectiveNetworkSecurityGroups(resourceGroupName, networkInterfaceName, cancellationToken);
            return CreateListEffectiveNetworkSecurityGroups(originalResponse, () => RestClient.CreateListEffectiveNetworkSecurityGroupsRequest(resourceGroupName, networkInterfaceName));
        }
    }
}
