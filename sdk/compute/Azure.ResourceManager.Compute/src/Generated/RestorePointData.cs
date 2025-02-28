// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the RestorePoint data model.
    /// Restore Point details.
    /// </summary>
    public partial class RestorePointData : ResourceData
    {
        /// <summary> Initializes a new instance of RestorePointData. </summary>
        public RestorePointData()
        {
            ExcludeDisks = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of RestorePointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="excludeDisks"> List of disk resource ids that the customer wishes to exclude from the restore point. If no disks are specified, all disks will be included. </param>
        /// <param name="sourceMetadata"> Gets the details of the VM captured at the time of the restore point creation. </param>
        /// <param name="provisioningState"> Gets the provisioning state of the restore point. </param>
        /// <param name="consistencyMode"> ConsistencyMode of the RestorePoint. Can be specified in the input while creating a restore point. For now, only CrashConsistent is accepted as a valid input. Please refer to https://aka.ms/RestorePoints for more details. </param>
        /// <param name="timeCreated"> Gets the creation time of the restore point. </param>
        /// <param name="sourceRestorePoint"> Resource Id of the source restore point from which a copy needs to be created. </param>
        /// <param name="instanceView"> The restore point instance view. </param>
        internal RestorePointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<WritableSubResource> excludeDisks, RestorePointSourceMetadata sourceMetadata, string provisioningState, ConsistencyModeType? consistencyMode, DateTimeOffset? timeCreated, WritableSubResource sourceRestorePoint, RestorePointInstanceView instanceView) : base(id, name, resourceType, systemData)
        {
            ExcludeDisks = excludeDisks;
            SourceMetadata = sourceMetadata;
            ProvisioningState = provisioningState;
            ConsistencyMode = consistencyMode;
            TimeCreated = timeCreated;
            SourceRestorePoint = sourceRestorePoint;
            InstanceView = instanceView;
        }

        /// <summary> List of disk resource ids that the customer wishes to exclude from the restore point. If no disks are specified, all disks will be included. </summary>
        public IList<WritableSubResource> ExcludeDisks { get; }
        /// <summary> Gets the details of the VM captured at the time of the restore point creation. </summary>
        public RestorePointSourceMetadata SourceMetadata { get; set; }
        /// <summary> Gets the provisioning state of the restore point. </summary>
        public string ProvisioningState { get; }
        /// <summary> ConsistencyMode of the RestorePoint. Can be specified in the input while creating a restore point. For now, only CrashConsistent is accepted as a valid input. Please refer to https://aka.ms/RestorePoints for more details. </summary>
        public ConsistencyModeType? ConsistencyMode { get; set; }
        /// <summary> Gets the creation time of the restore point. </summary>
        public DateTimeOffset? TimeCreated { get; set; }
        /// <summary> Resource Id of the source restore point from which a copy needs to be created. </summary>
        internal WritableSubResource SourceRestorePoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SourceRestorePointId
        {
            get => SourceRestorePoint is null ? default : SourceRestorePoint.Id;
            set
            {
                if (SourceRestorePoint is null)
                    SourceRestorePoint = new WritableSubResource();
                SourceRestorePoint.Id = value;
            }
        }

        /// <summary> The restore point instance view. </summary>
        public RestorePointInstanceView InstanceView { get; }
    }
}
