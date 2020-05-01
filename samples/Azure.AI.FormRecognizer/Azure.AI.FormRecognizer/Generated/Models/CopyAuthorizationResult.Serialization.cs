// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class CopyAuthorizationResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("modelId");
            writer.WriteStringValue(ModelId);
            writer.WritePropertyName("accessToken");
            writer.WriteStringValue(AccessToken);
            writer.WritePropertyName("expirationDateTimeTicks");
            writer.WriteNumberValue(ExpirationDateTimeTicks);
            writer.WriteEndObject();
        }

        internal static CopyAuthorizationResult DeserializeCopyAuthorizationResult(JsonElement element)
        {
            string modelId = default;
            string accessToken = default;
            long expirationDateTimeTicks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessToken"))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDateTimeTicks"))
                {
                    expirationDateTimeTicks = property.Value.GetInt64();
                    continue;
                }
            }
            return new CopyAuthorizationResult(modelId, accessToken, expirationDateTimeTicks);
        }
    }
}
