// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> LUN to expose the Azure Managed Disk. </summary>
    public partial class ManagedDiskIscsiLun
    {
        /// <summary> Initializes a new instance of ManagedDiskIscsiLun. </summary>
        /// <param name="name"> User defined name for iSCSI LUN; example: "lun0". </param>
        /// <param name="managedDiskAzureResourceId"> Azure Resource ID of the Managed Disk. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="managedDiskAzureResourceId"/> is null. </exception>
        public ManagedDiskIscsiLun(string name, ResourceIdentifier managedDiskAzureResourceId)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(managedDiskAzureResourceId, nameof(managedDiskAzureResourceId));

            Name = name;
            ManagedDiskAzureResourceId = managedDiskAzureResourceId;
        }

        /// <summary> Initializes a new instance of ManagedDiskIscsiLun. </summary>
        /// <param name="name"> User defined name for iSCSI LUN; example: "lun0". </param>
        /// <param name="managedDiskAzureResourceId"> Azure Resource ID of the Managed Disk. </param>
        /// <param name="lun"> Specifies the Logical Unit Number of the iSCSI LUN. </param>
        internal ManagedDiskIscsiLun(string name, ResourceIdentifier managedDiskAzureResourceId, int? lun)
        {
            Name = name;
            ManagedDiskAzureResourceId = managedDiskAzureResourceId;
            Lun = lun;
        }

        /// <summary> User defined name for iSCSI LUN; example: "lun0". </summary>
        public string Name { get; set; }
        /// <summary> Azure Resource ID of the Managed Disk. </summary>
        public ResourceIdentifier ManagedDiskAzureResourceId { get; set; }
        /// <summary> Specifies the Logical Unit Number of the iSCSI LUN. </summary>
        public int? Lun { get; }
    }
}
