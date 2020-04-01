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
using NameConflicts.Models;

namespace NameConflicts
{
    internal partial class ServiceRestClient
    {
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;

        /// <summary> Initializes a new instance of ServiceRestClient. </summary>
        public ServiceRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        internal HttpMessage CreateOperationRequest(string request, string message, string scope, string uri, Class @class)
        {
            var message0 = pipeline.CreateMessage();
            var request0 = message0.Request;
            request0.Method = RequestMethod.Patch;
            var uri0 = new RawRequestUriBuilder();
            uri0.AppendRaw(host, false);
            uri0.AppendPath("/originalOperation", false);
            uri0.AppendQuery("request", request, true);
            uri0.AppendQuery("message", message, true);
            uri0.AppendQuery("scope", scope, true);
            uri0.AppendQuery("uri", uri, true);
            request0.Uri = uri0;
            request0.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(@class);
            request0.Content = content;
            return message0;
        }

        /// <param name="request"> The String to use. </param>
        /// <param name="message"> The String to use. </param>
        /// <param name="scope"> The String to use. </param>
        /// <param name="uri"> The String to use. </param>
        /// <param name="class"> The Class to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<Class>> OperationAsync(string request, string message, string scope, string uri, Class @class, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }
            if (@class == null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            using var scope0 = clientDiagnostics.CreateScope("ServiceClient.Operation");
            scope0.Start();
            try
            {
                using var message0 = CreateOperationRequest(request, message, scope, uri, @class);
                await pipeline.SendAsync(message0, cancellationToken).ConfigureAwait(false);
                switch (message0.Response.Status)
                {
                    case 200:
                        {
                            Class value = default;
                            using var document = await JsonDocument.ParseAsync(message0.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = Class.DeserializeClass(document.RootElement);
                            }
                            return Response.FromValue(value, message0.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message0.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <param name="request"> The String to use. </param>
        /// <param name="message"> The String to use. </param>
        /// <param name="scope"> The String to use. </param>
        /// <param name="uri"> The String to use. </param>
        /// <param name="class"> The Class to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Class> Operation(string request, string message, string scope, string uri, Class @class, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }
            if (@class == null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            using var scope0 = clientDiagnostics.CreateScope("ServiceClient.Operation");
            scope0.Start();
            try
            {
                using var message0 = CreateOperationRequest(request, message, scope, uri, @class);
                pipeline.Send(message0, cancellationToken);
                switch (message0.Response.Status)
                {
                    case 200:
                        {
                            Class value = default;
                            using var document = JsonDocument.Parse(message0.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = Class.DeserializeClass(document.RootElement);
                            }
                            return Response.FromValue(value, message0.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message0.Response);
                }
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
    }
}
