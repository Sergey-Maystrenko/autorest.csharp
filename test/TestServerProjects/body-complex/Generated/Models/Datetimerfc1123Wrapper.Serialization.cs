// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class Datetimerfc1123Wrapper : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Field != null)
            {
                writer.WritePropertyName("field");
                writer.WriteStringValue(Field.Value, "R");
            }
            if (Now != null)
            {
                writer.WritePropertyName("now");
                writer.WriteStringValue(Now.Value, "R");
            }
            writer.WriteEndObject();
        }

        internal static Datetimerfc1123Wrapper DeserializeDatetimerfc1123Wrapper(JsonElement element)
        {
            DateTimeOffset? field = default;
            DateTimeOffset? now = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        field = null;
                    }
                    else
                    {
                        field = property.Value.GetDateTimeOffset("R");
                    }
                    continue;
                }
                if (property.NameEquals("now"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        now = null;
                    }
                    else
                    {
                        now = property.Value.GetDateTimeOffset("R");
                    }
                    continue;
                }
            }
            return new Datetimerfc1123Wrapper(field, now);
        }
    }
}
