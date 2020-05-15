// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage;

namespace Azure.Management.Storage
{
    /// <summary> Storage service management client. </summary>
    public class StorageManagementClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly string _subscriptionId;
        private readonly Uri _endpoint;

        /// <summary> Initializes a new instance of StorageManagementClient for mocking. </summary>
        protected StorageManagementClient()
        {
        }

        /// <summary> Initializes a new instance of StorageManagementClient. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public StorageManagementClient(string subscriptionId, TokenCredential tokenCredential, StorageManagementClientOptions options = null) : this(subscriptionId, null, tokenCredential, options)
        {
        }
        /// <summary> Initializes a new instance of StorageManagementClient. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public StorageManagementClient(string subscriptionId, Uri endpoint, TokenCredential tokenCredential, StorageManagementClientOptions options = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            options ??= new StorageManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, endpoint, options);
            _subscriptionId = subscriptionId;
            _endpoint = endpoint;
        }

        /// <summary> Creates a new instance of BlobServicesClient. </summary>
        public virtual BlobServicesClient GetBlobServicesClient()
        {
            return new BlobServicesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of BlobContainersClient. </summary>
        public virtual BlobContainersClient GetBlobContainersClient()
        {
            return new BlobContainersClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of FileServicesClient. </summary>
        public virtual FileServicesClient GetFileServicesClient()
        {
            return new FileServicesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of FileSharesClient. </summary>
        public virtual FileSharesClient GetFileSharesClient()
        {
            return new FileSharesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of OperationsClient. </summary>
        public virtual OperationsClient GetOperationsClient()
        {
            return new OperationsClient(_clientDiagnostics, _pipeline, _endpoint);
        }

        /// <summary> Creates a new instance of SkusClient. </summary>
        public virtual SkusClient GetSkusClient()
        {
            return new SkusClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of StorageAccountsClient. </summary>
        public virtual StorageAccountsClient GetStorageAccountsClient()
        {
            return new StorageAccountsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of UsagesClient. </summary>
        public virtual UsagesClient GetUsagesClient()
        {
            return new UsagesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ManagementPoliciesClient. </summary>
        public virtual ManagementPoliciesClient GetManagementPoliciesClient()
        {
            return new ManagementPoliciesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of PrivateEndpointConnectionsClient. </summary>
        public virtual PrivateEndpointConnectionsClient GetPrivateEndpointConnectionsClient()
        {
            return new PrivateEndpointConnectionsClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of PrivateLinkResourcesClient. </summary>
        public virtual PrivateLinkResourcesClient GetPrivateLinkResourcesClient()
        {
            return new PrivateLinkResourcesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of ObjectReplicationPoliciesClient. </summary>
        public virtual ObjectReplicationPoliciesClient GetObjectReplicationPoliciesClient()
        {
            return new ObjectReplicationPoliciesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }

        /// <summary> Creates a new instance of EncryptionScopesClient. </summary>
        public virtual EncryptionScopesClient GetEncryptionScopesClient()
        {
            return new EncryptionScopesClient(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
        }
    }
}
