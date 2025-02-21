// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The metric dimension. </summary>
    public partial class DataBoxEdgeMetricDimension
    {
        /// <summary> Initializes a new instance of DataBoxEdgeMetricDimension. </summary>
        /// <param name="sourceType"> The dimension type. </param>
        /// <param name="sourceName"> The dimension value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceType"/> or <paramref name="sourceName"/> is null. </exception>
        public DataBoxEdgeMetricDimension(string sourceType, string sourceName)
        {
            Argument.AssertNotNull(sourceType, nameof(sourceType));
            Argument.AssertNotNull(sourceName, nameof(sourceName));

            SourceType = sourceType;
            SourceName = sourceName;
        }

        /// <summary> The dimension type. </summary>
        public string SourceType { get; set; }
        /// <summary> The dimension value. </summary>
        public string SourceName { get; set; }
    }
}
