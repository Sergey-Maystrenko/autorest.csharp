// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    /// <summary> Truncates the terms to a specific length. This token filter is implemented using Apache Lucene. </summary>
    public partial class TruncateTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of TruncateTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        public TruncateTokenFilter(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            OdataType = "#Microsoft.Azure.Search.TruncateTokenFilter";
        }

        /// <summary> Initializes a new instance of TruncateTokenFilter. </summary>
        /// <param name="length"> The length at which terms will be truncated. Default and maximum is 300. </param>
        /// <param name="odataType"> . </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal TruncateTokenFilter(int? length, string odataType, string name) : base(odataType, name)
        {
            Length = length;
            OdataType = odataType ?? "#Microsoft.Azure.Search.TruncateTokenFilter";
        }

        /// <summary> The length at which terms will be truncated. Default and maximum is 300. </summary>
        public int? Length { get; set; }
    }
}
