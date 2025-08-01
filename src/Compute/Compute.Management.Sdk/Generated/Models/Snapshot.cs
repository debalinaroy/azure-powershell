// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Snapshot resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Snapshot : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        public Snapshot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="creationData">Disk source information. CreationData
        /// information cannot be changed after the disk has been
        /// created.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="timeCreated">The time when the snapshot was
        /// created.</param>
        /// <param name="osType">The Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="hyperVGeneration">The hypervisor generation of the
        /// Virtual Machine. Applicable to OS disks only. Possible values
        /// include: 'V1', 'V2'</param>
        /// <param name="purchasePlan">Purchase plan information for the image
        /// from which the source disk for the snapshot was originally
        /// created.</param>
        /// <param name="supportedCapabilities">List of supported capabilities
        /// for the image from which the source disk from the snapshot was
        /// originally created.</param>
        /// <param name="diskSizeGB">If creationData.createOption is Empty,
        /// this field is mandatory and it indicates the size of the disk to
        /// create. If this field is present for updates or creation with other
        /// options, it indicates a resize. Resizes are only allowed if the
        /// disk is not attached to a running VM, and can only increase the
        /// disk's size.</param>
        /// <param name="diskSizeBytes">The size of the disk in bytes. This
        /// field is read only.</param>
        /// <param name="diskState">The state of the snapshot. Possible values
        /// include: 'Unattached', 'Attached', 'Reserved', 'Frozen',
        /// 'ActiveSAS', 'ActiveSASFrozen', 'ReadyToUpload',
        /// 'ActiveUpload'</param>
        /// <param name="uniqueId">Unique Guid identifying the
        /// resource.</param>
        /// <param name="encryptionSettingsCollection">Encryption settings
        /// collection used be Azure Disk Encryption, can contain multiple
        /// encryption settings per disk or snapshot.</param>
        /// <param name="provisioningState">The disk provisioning
        /// state.</param>
        /// <param name="incremental">Whether a snapshot is incremental.
        /// Incremental snapshots on the same disk occupy less space than full
        /// snapshots and can be diffed.</param>
        /// <param name="incrementalSnapshotFamilyId">Incremental snapshots for
        /// a disk share an incremental snapshot family id. The Get Page Range
        /// Diff API can only be called on incremental snapshots with the same
        /// family id.</param>
        /// <param name="encryption">Encryption property can be used to encrypt
        /// data at rest with customer managed keys or platform managed
        /// keys.</param>
        /// <param name="networkAccessPolicy">Policy for accessing the disk via
        /// network. Possible values include: 'AllowAll', 'AllowPrivate',
        /// 'DenyAll'</param>
        /// <param name="diskAccessId">ARM id of the DiskAccess resource for
        /// using private endpoints on disks.</param>
        /// <param name="securityProfile">Contains the security related
        /// information for the resource.</param>
        /// <param name="supportsHibernation">Indicates the OS on a snapshot
        /// supports hibernation.</param>
        /// <param name="publicNetworkAccess">Policy for controlling export on
        /// the disk. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="completionPercent">Percentage complete for the
        /// background copy when a resource is created via the CopyStart
        /// operation.</param>
        /// <param name="copyCompletionError">Indicates the error details if
        /// the background copy of a resource created via the CopyStart
        /// operation fails.</param>
        /// <param name="dataAccessAuthMode">Additional authentication
        /// requirements when exporting or uploading to a disk or snapshot.
        /// Possible values include: 'AzureActiveDirectory', 'None'</param>
        /// <param name="snapshotAccessState">The state of snapshot which
        /// determines the access availability of the snapshot. Possible values
        /// include: 'Unknown', 'Pending', 'Available', 'InstantAccess',
        /// 'AvailableWithInstantAccess'</param>
        /// <param name="managedBy">Unused. Always Null.</param>
        /// <param name="sku">The snapshots sku name. Can be Standard_LRS,
        /// Premium_LRS, or Standard_ZRS. This is an optional parameter for
        /// incremental snapshot and the default behavior is the SKU will be
        /// set to the same sku as the previous snapshot</param>
        /// <param name="extendedLocation">The extended location where the
        /// snapshot will be created. Extended location cannot be
        /// changed.</param>
        public Snapshot(string location, CreationData creationData, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? timeCreated = default(System.DateTime?), OperatingSystemTypes? osType = default(OperatingSystemTypes?), string hyperVGeneration = default(string), PurchasePlan purchasePlan = default(PurchasePlan), SupportedCapabilities supportedCapabilities = default(SupportedCapabilities), int? diskSizeGB = default(int?), long? diskSizeBytes = default(long?), string diskState = default(string), string uniqueId = default(string), EncryptionSettingsCollection encryptionSettingsCollection = default(EncryptionSettingsCollection), string provisioningState = default(string), bool? incremental = default(bool?), string incrementalSnapshotFamilyId = default(string), Encryption encryption = default(Encryption), string networkAccessPolicy = default(string), string diskAccessId = default(string), DiskSecurityProfile securityProfile = default(DiskSecurityProfile), bool? supportsHibernation = default(bool?), string publicNetworkAccess = default(string), double? completionPercent = default(double?), CopyCompletionError copyCompletionError = default(CopyCompletionError), string dataAccessAuthMode = default(string), string snapshotAccessState = default(string), string managedBy = default(string), SnapshotSku sku = default(SnapshotSku), ExtendedLocation extendedLocation = default(ExtendedLocation))
            : base(location, id, name, type, tags)
        {
            TimeCreated = timeCreated;
            OsType = osType;
            HyperVGeneration = hyperVGeneration;
            PurchasePlan = purchasePlan;
            SupportedCapabilities = supportedCapabilities;
            CreationData = creationData;
            DiskSizeGB = diskSizeGB;
            DiskSizeBytes = diskSizeBytes;
            DiskState = diskState;
            UniqueId = uniqueId;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            ProvisioningState = provisioningState;
            Incremental = incremental;
            IncrementalSnapshotFamilyId = incrementalSnapshotFamilyId;
            Encryption = encryption;
            NetworkAccessPolicy = networkAccessPolicy;
            DiskAccessId = diskAccessId;
            SecurityProfile = securityProfile;
            SupportsHibernation = supportsHibernation;
            PublicNetworkAccess = publicNetworkAccess;
            CompletionPercent = completionPercent;
            CopyCompletionError = copyCompletionError;
            DataAccessAuthMode = dataAccessAuthMode;
            SnapshotAccessState = snapshotAccessState;
            ManagedBy = managedBy;
            Sku = sku;
            ExtendedLocation = extendedLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the time when the snapshot was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeCreated")]
        public System.DateTime? TimeCreated { get; private set; }

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets the hypervisor generation of the Virtual Machine.
        /// Applicable to OS disks only. Possible values include: 'V1', 'V2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hyperVGeneration")]
        public string HyperVGeneration { get; set; }

        /// <summary>
        /// Gets or sets purchase plan information for the image from which the
        /// source disk for the snapshot was originally created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.purchasePlan")]
        public PurchasePlan PurchasePlan { get; set; }

        /// <summary>
        /// Gets or sets list of supported capabilities for the image from
        /// which the source disk from the snapshot was originally created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportedCapabilities")]
        public SupportedCapabilities SupportedCapabilities { get; set; }

        /// <summary>
        /// Gets or sets disk source information. CreationData information
        /// cannot be changed after the disk has been created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationData")]
        public CreationData CreationData { get; set; }

        /// <summary>
        /// Gets or sets if creationData.createOption is Empty, this field is
        /// mandatory and it indicates the size of the disk to create. If this
        /// field is present for updates or creation with other options, it
        /// indicates a resize. Resizes are only allowed if the disk is not
        /// attached to a running VM, and can only increase the disk's size.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets the size of the disk in bytes. This field is read only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskSizeBytes")]
        public long? DiskSizeBytes { get; private set; }

        /// <summary>
        /// Gets the state of the snapshot. Possible values include:
        /// 'Unattached', 'Attached', 'Reserved', 'Frozen', 'ActiveSAS',
        /// 'ActiveSASFrozen', 'ReadyToUpload', 'ActiveUpload'
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskState")]
        public string DiskState { get; private set; }

        /// <summary>
        /// Gets unique Guid identifying the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueId")]
        public string UniqueId { get; private set; }

        /// <summary>
        /// Gets or sets encryption settings collection used be Azure Disk
        /// Encryption, can contain multiple encryption settings per disk or
        /// snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionSettingsCollection")]
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }

        /// <summary>
        /// Gets the disk provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets whether a snapshot is incremental. Incremental
        /// snapshots on the same disk occupy less space than full snapshots
        /// and can be diffed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.incremental")]
        public bool? Incremental { get; set; }

        /// <summary>
        /// Gets incremental snapshots for a disk share an incremental snapshot
        /// family id. The Get Page Range Diff API can only be called on
        /// incremental snapshots with the same family id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.incrementalSnapshotFamilyId")]
        public string IncrementalSnapshotFamilyId { get; private set; }

        /// <summary>
        /// Gets or sets encryption property can be used to encrypt data at
        /// rest with customer managed keys or platform managed keys.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets policy for accessing the disk via network. Possible
        /// values include: 'AllowAll', 'AllowPrivate', 'DenyAll'
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAccessPolicy")]
        public string NetworkAccessPolicy { get; set; }

        /// <summary>
        /// Gets or sets ARM id of the DiskAccess resource for using private
        /// endpoints on disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskAccessId")]
        public string DiskAccessId { get; set; }

        /// <summary>
        /// Gets or sets contains the security related information for the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityProfile")]
        public DiskSecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets indicates the OS on a snapshot supports hibernation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsHibernation")]
        public bool? SupportsHibernation { get; set; }

        /// <summary>
        /// Gets or sets policy for controlling export on the disk. Possible
        /// values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets percentage complete for the background copy when a
        /// resource is created via the CopyStart operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.completionPercent")]
        public double? CompletionPercent { get; set; }

        /// <summary>
        /// Gets or sets indicates the error details if the background copy of
        /// a resource created via the CopyStart operation fails.
        /// </summary>
        [JsonProperty(PropertyName = "properties.copyCompletionError")]
        public CopyCompletionError CopyCompletionError { get; set; }

        /// <summary>
        /// Gets or sets additional authentication requirements when exporting
        /// or uploading to a disk or snapshot. Possible values include:
        /// 'AzureActiveDirectory', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataAccessAuthMode")]
        public string DataAccessAuthMode { get; set; }

        /// <summary>
        /// Gets the state of snapshot which determines the access availability
        /// of the snapshot. Possible values include: 'Unknown', 'Pending',
        /// 'Available', 'InstantAccess', 'AvailableWithInstantAccess'
        /// </summary>
        [JsonProperty(PropertyName = "properties.snapshotAccessState")]
        public string SnapshotAccessState { get; private set; }

        /// <summary>
        /// Gets unused. Always Null.
        /// </summary>
        [JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; private set; }

        /// <summary>
        /// Gets or sets the snapshots sku name. Can be Standard_LRS,
        /// Premium_LRS, or Standard_ZRS. This is an optional parameter for
        /// incremental snapshot and the default behavior is the SKU will be
        /// set to the same sku as the previous snapshot
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SnapshotSku Sku { get; set; }

        /// <summary>
        /// Gets or sets the extended location where the snapshot will be
        /// created. Extended location cannot be changed.
        /// </summary>
        [JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (CreationData == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreationData");
            }
            if (PurchasePlan != null)
            {
                PurchasePlan.Validate();
            }
            if (CreationData != null)
            {
                CreationData.Validate();
            }
            if (EncryptionSettingsCollection != null)
            {
                EncryptionSettingsCollection.Validate();
            }
            if (CopyCompletionError != null)
            {
                CopyCompletionError.Validate();
            }
        }
    }
}
