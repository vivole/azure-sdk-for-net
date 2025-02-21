// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The list Kusto database principals operation response. </summary>
    internal partial class SynapseFollowerDatabaseListResult
    {
        /// <summary> Initializes a new instance of SynapseFollowerDatabaseListResult. </summary>
        internal SynapseFollowerDatabaseListResult()
        {
            Value = new ChangeTrackingList<SynapseFollowerDatabaseDefinition>();
        }

        /// <summary> Initializes a new instance of SynapseFollowerDatabaseListResult. </summary>
        /// <param name="value"> The list of follower database result. </param>
        internal SynapseFollowerDatabaseListResult(IReadOnlyList<SynapseFollowerDatabaseDefinition> value)
        {
            Value = value;
        }

        /// <summary> The list of follower database result. </summary>
        public IReadOnlyList<SynapseFollowerDatabaseDefinition> Value { get; }
    }
}
