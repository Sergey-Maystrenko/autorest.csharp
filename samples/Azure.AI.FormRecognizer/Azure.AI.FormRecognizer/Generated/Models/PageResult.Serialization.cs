// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class PageResult
    {
        internal static PageResult DeserializePageResult(JsonElement element)
        {
            int page = default;
            int? clusterId = default;
            IReadOnlyList<KeyValuePair> keyValuePairs = default;
            IReadOnlyList<DataTable> tables = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("page"))
                {
                    page = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("clusterId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clusterId = null;
                    }
                    else
                    {
                        clusterId = property.Value.GetInt32();
                    }
                    continue;
                }
                if (property.NameEquals("keyValuePairs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyValuePairs = null;
                    }
                    else
                    {
                        List<KeyValuePair> array = new List<KeyValuePair>();
                        foreach (var item in property.Value.EnumerateArray())
                        {
                            if (item.ValueKind == JsonValueKind.Null)
                            {
                                array.Add(null);
                            }
                            else
                            {
                                array.Add(KeyValuePair.DeserializeKeyValuePair(item));
                            }
                        }
                        keyValuePairs = array;
                    }
                    continue;
                }
                if (property.NameEquals("tables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tables = null;
                    }
                    else
                    {
                        List<DataTable> array = new List<DataTable>();
                        foreach (var item in property.Value.EnumerateArray())
                        {
                            if (item.ValueKind == JsonValueKind.Null)
                            {
                                array.Add(null);
                            }
                            else
                            {
                                array.Add(DataTable.DeserializeDataTable(item));
                            }
                        }
                        tables = array;
                    }
                    continue;
                }
            }
            return new PageResult(page, clusterId, keyValuePairs, tables);
        }
    }
}
