// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the CosmosDBFirewallRule data model.
    /// Represents a mongo cluster firewall rule.
    /// </summary>
    public partial class CosmosDBFirewallRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of CosmosDBFirewallRuleData. </summary>
        /// <param name="startIPAddress"> The start IP address of the mongo cluster firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the mongo cluster firewall rule. Must be IPv4 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startIPAddress"/> or <paramref name="endIPAddress"/> is null. </exception>
        public CosmosDBFirewallRuleData(string startIPAddress, string endIPAddress)
        {
            Argument.AssertNotNull(startIPAddress, nameof(startIPAddress));
            Argument.AssertNotNull(endIPAddress, nameof(endIPAddress));

            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> Initializes a new instance of CosmosDBFirewallRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the firewall rule. </param>
        /// <param name="startIPAddress"> The start IP address of the mongo cluster firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the mongo cluster firewall rule. Must be IPv4 format. </param>
        internal CosmosDBFirewallRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CosmosDBProvisioningState? provisioningState, string startIPAddress, string endIPAddress) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
        }

        /// <summary> The provisioning state of the firewall rule. </summary>
        public CosmosDBProvisioningState? ProvisioningState { get; }
        /// <summary> The start IP address of the mongo cluster firewall rule. Must be IPv4 format. </summary>
        public string StartIPAddress { get; set; }
        /// <summary> The end IP address of the mongo cluster firewall rule. Must be IPv4 format. </summary>
        public string EndIPAddress { get; set; }
    }
}
