// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class DocumentLinkedEntities
    {
        internal static DocumentLinkedEntities DeserializeDocumentLinkedEntities(JsonElement element)
        {
            string id = default;
            IReadOnlyList<LinkedEntity> entities = default;
            DocumentStatistics statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entities"))
                {
                    List<LinkedEntity> array = new List<LinkedEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(LinkedEntity.DeserializeLinkedEntity(item));
                        }
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statistics = null;
                    }
                    else
                    {
                        statistics = DocumentStatistics.DeserializeDocumentStatistics(property.Value);
                    }
                    continue;
                }
            }
            return new DocumentLinkedEntities(id, entities, statistics);
        }
    }
}
