// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for describing any cognitive service resource attached to a skillset.
    /// Please note <see cref="CognitiveServicesAccount"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CognitiveServicesAccountKey"/> and <see cref="DefaultCognitiveServicesAccount"/>.
    /// </summary>
    public partial class CognitiveServicesAccount
    {
        /// <summary> Initializes a new instance of CognitiveServicesAccount. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the cognitive service resource attached to a skillset. </param>
        /// <param name="description"> Description of the cognitive service resource attached to a skillset. </param>
        internal CognitiveServicesAccount(string oDataType, string description)
        {
            ODataType = oDataType;
            Description = description;
        }

        /// <summary> Identifies the concrete type of the cognitive service resource attached to a skillset. </summary>
        internal string ODataType { get; set; }
        /// <summary> Description of the cognitive service resource attached to a skillset. </summary>
        public string Description { get; set; }
    }
}
