// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An update request for an Azure SQL Database managed instance. </summary>
    public partial class ManagedInstancePatch
    {
        /// <summary> Initializes a new instance of ManagedInstancePatch. </summary>
        public ManagedInstancePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<ManagedInstancePecProperty>();
        }

        /// <summary> Managed instance sku. </summary>
        public SqlSku Sku { get; set; }
        /// <summary> Managed instance identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets the provisioning state. </summary>
        public ManagedInstancePropertiesProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// Specifies the mode of database creation.
        ///
        /// Default: Regular instance creation.
        ///
        /// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
        /// </summary>
        public ManagedServerCreateMode? ManagedInstanceCreateMode { get; set; }
        /// <summary> The fully qualified domain name of the managed instance. </summary>
        public string FullyQualifiedDomainName { get; }
        /// <summary> Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation). </summary>
        public string AdministratorLogin { get; set; }
        /// <summary> The administrator login password (required for managed instance creation). </summary>
        public string AdministratorLoginPassword { get; set; }
        /// <summary> Subnet resource ID for the managed instance. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> The state of the managed instance. </summary>
        public string State { get; }
        /// <summary> The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses). </summary>
        public ManagedInstanceLicenseType? LicenseType { get; set; }
        /// <summary> The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80. </summary>
        public int? VCores { get; set; }
        /// <summary> Storage size in GB. Minimum value: 32. Maximum value: 16384. Increments of 32 GB allowed only. Maximum value depends on the selected hardware family and number of vCores. </summary>
        public int? StorageSizeInGB { get; set; }
        /// <summary> Collation of the managed instance. </summary>
        public string Collation { get; set; }
        /// <summary> The Dns Zone that the managed instance is in. </summary>
        public string DnsZone { get; }
        /// <summary> The resource id of another managed instance whose DNS zone this managed instance will share after creation. </summary>
        public ResourceIdentifier ManagedDnsZonePartner { get; set; }
        /// <summary> Whether or not the public data endpoint is enabled. </summary>
        public bool? IsPublicDataEndpointEnabled { get; set; }
        /// <summary> The resource identifier of the source managed instance associated with create operation of this instance. </summary>
        public ResourceIdentifier SourceManagedInstanceId { get; set; }
        /// <summary> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </summary>
        public DateTimeOffset? RestorePointInTime { get; set; }
        /// <summary> Connection type used for connecting to the instance. </summary>
        public ManagedInstanceProxyOverride? ProxyOverride { get; set; }
        /// <summary>
        /// Id of the timezone. Allowed values are timezones supported by Windows.
        /// Windows keeps details on supported timezones, including the id, in registry under
        /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
        /// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
        /// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
        /// </summary>
        public string TimezoneId { get; set; }
        /// <summary> The Id of the instance pool this managed server belongs to. </summary>
        public ResourceIdentifier InstancePoolId { get; set; }
        /// <summary> Specifies maintenance configuration id to apply to this managed instance. </summary>
        public ResourceIdentifier MaintenanceConfigurationId { get; set; }
        /// <summary> List of private endpoint connections on a managed instance. </summary>
        public IReadOnlyList<ManagedInstancePecProperty> PrivateEndpointConnections { get; }
        /// <summary> Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'. </summary>
        public string MinimalTlsVersion { get; set; }
        /// <summary> The storage account type used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </summary>
        public SqlBackupStorageRedundancy? CurrentBackupStorageRedundancy { get; }
        /// <summary> The storage account type to be used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </summary>
        public SqlBackupStorageRedundancy? RequestedBackupStorageRedundancy { get; set; }
        /// <summary> Whether or not the multi-az is enabled. </summary>
        public bool? IsZoneRedundant { get; set; }
        /// <summary> The resource id of a user assigned identity to be used by default. </summary>
        public ResourceIdentifier PrimaryUserAssignedIdentityId { get; set; }
        /// <summary> A CMK URI of the key to use for encryption. </summary>
        public Uri KeyId { get; set; }
        /// <summary> The Azure Active Directory administrator of the instance. This can only be used at instance create time. If used for instance update, it will be ignored or it will result in an error. For updates individual APIs will need to be used. </summary>
        public ManagedInstanceExternalAdministrator Administrators { get; set; }
        /// <summary> The managed instance's service principal. </summary>
        public SqlServicePrincipal ServicePrincipal { get; set; }
    }
}
