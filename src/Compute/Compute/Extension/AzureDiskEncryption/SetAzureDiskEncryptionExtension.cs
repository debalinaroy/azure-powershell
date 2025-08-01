﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using AutoMapper;
using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Commands.Compute.Extension.AzureVMBackup;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Azure.Commands.Compute.Properties;
using Microsoft.Rest.Azure;
using System;
using System.Collections;
using System.Globalization;
using System.Management.Automation;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Compute.Extension.AzureDiskEncryption
{
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VMDiskEncryptionExtension", SupportsShouldProcess = true, DefaultParameterSetName = AzureDiskEncryptionExtensionConstants.singlePassParameterSet)]
    [OutputType(typeof(PSAzureOperationResponse))]
    public class SetAzureDiskEncryptionExtensionCommand : VirtualMachineExtensionBaseCmdlet
    {
        [Parameter(
           Mandatory = true,
           Position = 0,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The resource group name to which the VM belongs to")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            Position = 1,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Name of the virtual machine")]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachines", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public string VMName { get; set; }

        [Parameter(
           Mandatory = true,
           Position = 2,
           ValueFromPipelineByPropertyName = true,
           ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientSecretParameterSet,
           HelpMessage = "Client ID of Microsoft Entra app with permissions to write secrets to KeyVault")]
        [Parameter(
           Mandatory = true,
           Position = 2,
           ValueFromPipelineByPropertyName = true,
           ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientCertParameterSet,
           HelpMessage = "Client ID of Microsoft Entra app with permissions to write secrets to KeyVault")]
        public string AadClientID { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 3,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientSecretParameterSet,
            HelpMessage = "Client Secret of Microsoft Entra app with permissions to write secrets to KeyVault")]
        [ValidateNotNullOrEmpty]
        public string AadClientSecret { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 3,
            ValueFromPipelineByPropertyName = true,
             ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientCertParameterSet,
            HelpMessage = "Thumbprint of Microsoft Entra app certificate with permissions to write secrets to KeyVault")]
        [ValidateNotNullOrEmpty]
        public string AadClientCertThumbprint { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 4,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientSecretParameterSet,
            HelpMessage = "URL of the KeyVault where generated encryption key will be placed to")]
        [Parameter(
            Mandatory = true,
            Position = 4,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientCertParameterSet,
            HelpMessage = "URL of the KeyVault where generated encryption key will be placed to")]
        [Parameter(
            Mandatory = true,
            Position = 4,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.singlePassParameterSet,
            HelpMessage = "URL of the KeyVault where generated encryption key will be placed to")]
        public string DiskEncryptionKeyVaultUrl { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 5,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientSecretParameterSet,
            HelpMessage = "ResourceID of the KeyVault where generated encryption key will be placed to")]
        [Parameter(
            Mandatory = true,
            Position = 5,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientCertParameterSet,
            HelpMessage = "ResourceID of the KeyVault where generated encryption key will be placed to")]
        [Parameter(
            Mandatory = true,
            Position = 5,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.singlePassParameterSet,
            HelpMessage = "ResourceID of the KeyVault where generated encryption key will be placed to")]
        public string DiskEncryptionKeyVaultId { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientSecretParameterSet,
            HelpMessage = "Versioned KeyVault URL of the KeyEncryptionKey used to encrypt the disk encryption key")]
        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientCertParameterSet,
            HelpMessage = "Versioned KeyVault URL of the KeyEncryptionKey used to encrypt the disk encryption key")]
        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.singlePassParameterSet,
            HelpMessage = "Versioned KeyVault URL of the KeyEncryptionKey used to encrypt the disk encryption key")]
        [ValidateNotNullOrEmpty]
        public string KeyEncryptionKeyUrl { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientSecretParameterSet,
            HelpMessage = "ResourceID of the KeyVault containing the KeyEncryptionKey used to encrypt the disk encryption key")]
        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.aadClientCertParameterSet,
            HelpMessage = "ResourceID of the KeyVault containing the KeyEncryptionKey used to encrypt the disk encryption key")]
        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.singlePassParameterSet,
            HelpMessage = "ResourceID of the KeyVault containing the KeyEncryptionKey used to encrypt the disk encryption key")]
        [ValidateNotNullOrEmpty]
        public string KeyEncryptionKeyVaultId { get; set; }

        [Parameter(
           Mandatory = false,
           ValueFromPipelineByPropertyName = true,
           ParameterSetName = AzureDiskEncryptionExtensionConstants.singlePassParameterSet,
           HelpMessage = "ResourceID of the managed identity with access to keyvault for Azure Disk Encryption operations.")]
        [ValidateNotNullOrEmpty]
        public string EncryptionIdentity { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "KeyEncryption Algorithm used to encrypt the volume encryption key")]
        [ValidateSet("RSA-OAEP", "RSA1_5")]
        public string KeyEncryptionAlgorithm { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Type of the volume (OS, Data, or All) to encrypt")]
        [ValidateSet(
            AzureDiskEncryptionExtensionContext.VolumeTypeOS,
            AzureDiskEncryptionExtensionContext.VolumeTypeData,
            AzureDiskEncryptionExtensionContext.VolumeTypeAll)]
        public string VolumeType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Sequence version of encryption operation. This must be incremented to perform repeated encryption operations on the same VM")]
        [ValidateNotNullOrEmpty]
        public string SequenceVersion { get; set; }

        [Alias("HandlerVersion", "Version")]
        [Parameter(
            Mandatory = false,
            Position = 11,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The type handler version.")]
        [ValidateNotNullOrEmpty]
        public string TypeHandlerVersion { get; set; }

        [Alias("ExtensionName")]
        [Parameter(
            Mandatory = false,
            Position = 12,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The extension name. If this parameter is not specified, default values used are AzureDiskEncryption for windows VMs and AzureDiskEncryptionForLinux for Linux VMs")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 13,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The passphrase specified in parameters. This parameter only works for Linux VM.")]
        [ValidateNotNullOrEmpty]
        public string Passphrase { get; set; }

        [Parameter(HelpMessage = "To force enabling encryption on the virtual machine.")]
        [ValidateNotNullOrEmpty]
        public SwitchParameter Force { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 14,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Disable auto-upgrade of minor version")]
        public SwitchParameter DisableAutoUpgradeMinorVersion { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 15,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Skip backup creation for Linux VMs")]
        public SwitchParameter SkipVmBackup { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The extension type. Specify this parameter to override its default value of \"AzureDiskEncryption\" for Windows VMs and \"AzureDiskEncryptionForLinux\" for Linux VMs.")]
        [ValidateNotNullOrEmpty]
        public string ExtensionType { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The extension publisher name. Specify this parameter only to override the default value of \"Microsoft.Azure.Security\".")]
        [ValidateNotNullOrEmpty]
        public string ExtensionPublisherName { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Encrypt-Format all data drives that are not already encrypted")]
        public SwitchParameter EncryptFormatAll { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.migrateAdeVersionParameterSet,
            HelpMessage = "Migrate VM to newer version of ADE. Specify this parameter only to migrate from ADE with Microsoft Entra credentials to ADE without Microsoft Entra credentials.")]
        public SwitchParameter Migrate { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = AzureDiskEncryptionExtensionConstants.migrateAdeVersionRecoveryParameterSet,
            HelpMessage = "MigrationRecovery flag in case of dual pass to single pass migration failures. Specify this parameter only if the migration to single pass was not successful.")]
        public SwitchParameter MigrationRecovery { get; set; }

        private OperatingSystemTypes? currentOSType = null;

        private void ValidateInputParameters()
        {
            if (false == Uri.IsWellFormedUriString(DiskEncryptionKeyVaultId, UriKind.Absolute))
            {
                ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, "Invalid DiskEncryptionKeyVaultUrl. Please provide a valid KeyVault URI for DiskEncryptionKeyVaultUrl")),
                                                      "InvalidArgument",
                                                      ErrorCategory.InvalidArgument,
                                                      null));
            }
            if (string.IsNullOrWhiteSpace(KeyEncryptionKeyUrl) == false)
            {
                if (false == Uri.IsWellFormedUriString(DiskEncryptionKeyVaultId, UriKind.Absolute))
                {
                    ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, "Invalid KeyEncryptionKeyUrl. Please provide a valid KeyVault URI for KeyEncryptionKeyUrl")),
                                                          "InvalidArgument",
                                                          ErrorCategory.InvalidArgument,
                                                          null));
                }
            }
        }

        private string GetExtensionStatusMessage()
        {
            AzureOperationResponse<VirtualMachineExtension> extensionResult = this.VirtualMachineExtensionClient.GetWithInstanceView(this.ResourceGroupName, this.VMName, this.Name);
            if (extensionResult == null)
            {
                ThrowTerminatingError(new ErrorRecord(new ApplicationFailedException(string.Format(CultureInfo.CurrentUICulture, "Failed to retrieve extension status")),
                                                      "InvalidResult",
                                                      ErrorCategory.InvalidResult,
                                                      null));
            }

            PSVirtualMachineExtension returnedExtension = extensionResult.ToPSVirtualMachineExtension(
                this.ResourceGroupName, this.VMName);

            if ((returnedExtension == null) ||
                (string.IsNullOrWhiteSpace(returnedExtension.Publisher)) ||
                (string.IsNullOrWhiteSpace(returnedExtension.ExtensionType)))
            {
                ThrowTerminatingError(new ErrorRecord(new ApplicationFailedException(string.Format(CultureInfo.CurrentUICulture, "Missing extension publisher and type info")),
                                                      "InvalidResult",
                                                      ErrorCategory.InvalidResult,
                                                      null));
            }
            bool publisherMatch = false;
            if (OperatingSystemTypes.Linux.Equals(currentOSType))
            {
                this.ExtensionPublisherName = this.ExtensionPublisherName ?? AzureDiskEncryptionExtensionContext.LinuxExtensionDefaultPublisher;
                this.ExtensionType = this.ExtensionType ?? AzureDiskEncryptionExtensionContext.LinuxExtensionDefaultType;
                if (returnedExtension.Publisher.Equals(this.ExtensionPublisherName, StringComparison.InvariantCultureIgnoreCase) &&
                    returnedExtension.ExtensionType.Equals(this.ExtensionType, StringComparison.InvariantCultureIgnoreCase))
                {
                    publisherMatch = true;
                }
            }
            else if (OperatingSystemTypes.Windows.Equals(currentOSType))
            {
                this.ExtensionPublisherName = this.ExtensionPublisherName ?? AzureDiskEncryptionExtensionContext.ExtensionDefaultPublisher;
                this.ExtensionType = this.ExtensionType ?? AzureDiskEncryptionExtensionContext.ExtensionDefaultType;
                if (returnedExtension.Publisher.Equals(this.ExtensionPublisherName, StringComparison.InvariantCultureIgnoreCase) &&
                    returnedExtension.ExtensionType.Equals(this.ExtensionType, StringComparison.InvariantCultureIgnoreCase))
                {
                    publisherMatch = true;
                }
            }
            if (publisherMatch)
            {
                AzureDiskEncryptionExtensionContext context = new AzureDiskEncryptionExtensionContext(returnedExtension);
                if ((context == null) ||
                    (context.Statuses == null) ||
                    (context.Statuses.Count < 1) ||
                    (string.IsNullOrWhiteSpace(context.Statuses[0].Message)))
                {
                    ThrowTerminatingError(new ErrorRecord(new ApplicationFailedException(string.Format(CultureInfo.CurrentUICulture, "Invalid extension status")),
                                                          "InvalidResult",
                                                          ErrorCategory.InvalidResult,
                                                          null));
                }
                return context.Statuses[0].Message;
            }
            else
            {
                ThrowTerminatingError(new ErrorRecord(new ApplicationFailedException(string.Format(CultureInfo.CurrentUICulture, "Extension publisher and type mismatched")),
                                                      "InvalidResult",
                                                      ErrorCategory.InvalidResult,
                                                      null));
            }
            return null;
        }

        /// <summary>
        /// This function gets the VM model, fills in the OSDisk properties with encryptionSettings and does an UpdateVM
        /// </summary>
        private AzureOperationResponse<VirtualMachine, VirtualMachinesCreateOrUpdateHeaders> UpdateVmEncryptionSettings(DiskEncryptionSettings encryptionSettingsBackup)
        {
            string statusMessage = GetExtensionStatusMessage();

            var vmParameters = (this.ComputeClient.ComputeManagementClient.VirtualMachines.Get(
                this.ResourceGroupName, this.VMName));
            if ((vmParameters == null) ||
                (vmParameters.StorageProfile == null) ||
                (vmParameters.StorageProfile.OsDisk == null))
            {
                //VM should have been created and have valid storageProfile and OSDisk by now
                ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture, "Set-AzDiskEncryptionExtension can enable encryption only on a VM that was already created and has appropriate storageProfile and OS disk")),
                                                      "InvalidResult",
                                                      ErrorCategory.InvalidResult,
                                                      null));
            }
            //encryption settings object to clear out encryption settings before updating
            DiskEncryptionSettings resetEncryptionSettings = new DiskEncryptionSettings();
            resetEncryptionSettings.Enabled = false;
            resetEncryptionSettings.DiskEncryptionKey = null;
            resetEncryptionSettings.KeyEncryptionKey = null;

            DiskEncryptionSettings encryptionSettings = new DiskEncryptionSettings();
            encryptionSettings.Enabled = true;
            encryptionSettings.DiskEncryptionKey = new KeyVaultSecretReference();
            encryptionSettings.DiskEncryptionKey.SourceVault = new SubResource(this.DiskEncryptionKeyVaultId);
            encryptionSettings.DiskEncryptionKey.SecretUrl = statusMessage;
            if (this.KeyEncryptionKeyUrl != null)
            {
                encryptionSettings.KeyEncryptionKey = new KeyVaultKeyReference();
                encryptionSettings.KeyEncryptionKey.SourceVault = new SubResource(this.KeyEncryptionKeyVaultId);
                encryptionSettings.KeyEncryptionKey.KeyUrl = this.KeyEncryptionKeyUrl;
            }

            vmParameters.StorageProfile.OsDisk.EncryptionSettings = encryptionSettings;
            var parameters = new VirtualMachine
            {
                DiagnosticsProfile = vmParameters.DiagnosticsProfile,
                HardwareProfile = vmParameters.HardwareProfile,
                StorageProfile = vmParameters.StorageProfile,
                NetworkProfile = vmParameters.NetworkProfile,
                OsProfile = vmParameters.OsProfile,
                Plan = vmParameters.Plan,
                AvailabilitySet = vmParameters.AvailabilitySet,
                Location = vmParameters.Location,
                Tags = vmParameters.Tags
            };

            AzureOperationResponse<VirtualMachine, VirtualMachinesCreateOrUpdateHeaders> updateResult = null;

            // The 2nd pass. TODO: If something goes wrong here, try to revert to encryptionSettingsBackup.
            if (encryptionSettingsBackup.Enabled != true)
            {
                updateResult = this.ComputeClient.ComputeManagementClient.VirtualMachines.CreateOrUpdateWithHttpMessagesAsync(
                    this.ResourceGroupName,
                    vmParameters.Name,
                    parameters).GetAwaiter().GetResult();
            }
            else
            {
                // stop-clear-update-start
                // stop vm
                this.ComputeClient.ComputeManagementClient.VirtualMachines
                    .DeallocateWithHttpMessagesAsync(this.ResourceGroupName, this.VMName).GetAwaiter()
                    .GetResult();

                // first update vm call to clear encryption settings
                vmParameters = (this.ComputeClient.ComputeManagementClient.VirtualMachines.Get(
                this.ResourceGroupName, this.VMName));
                vmParameters.StorageProfile.OsDisk.EncryptionSettings = resetEncryptionSettings;
                parameters = new VirtualMachine
                {
                    DiagnosticsProfile = vmParameters.DiagnosticsProfile,
                    HardwareProfile = vmParameters.HardwareProfile,
                    StorageProfile = vmParameters.StorageProfile,
                    NetworkProfile = vmParameters.NetworkProfile,
                    OsProfile = vmParameters.OsProfile,
                    Plan = vmParameters.Plan,
                    AvailabilitySet = vmParameters.AvailabilitySet,
                    Location = vmParameters.Location,
                    Tags = vmParameters.Tags
                };

                updateResult = this.ComputeClient.ComputeManagementClient.VirtualMachines.CreateOrUpdateWithHttpMessagesAsync(
                    this.ResourceGroupName,
                    vmParameters.Name,
                    parameters).GetAwaiter().GetResult();

                // second update vm call to set new encryption settings
                vmParameters = (this.ComputeClient.ComputeManagementClient.VirtualMachines.Get(
                this.ResourceGroupName, this.VMName));
                vmParameters.StorageProfile.OsDisk.EncryptionSettings = encryptionSettings;
                parameters = new VirtualMachine
                {
                    DiagnosticsProfile = vmParameters.DiagnosticsProfile,
                    HardwareProfile = vmParameters.HardwareProfile,
                    StorageProfile = vmParameters.StorageProfile,
                    NetworkProfile = vmParameters.NetworkProfile,
                    OsProfile = vmParameters.OsProfile,
                    Plan = vmParameters.Plan,
                    AvailabilitySet = vmParameters.AvailabilitySet,
                    Location = vmParameters.Location,
                    Tags = vmParameters.Tags
                };

                updateResult = this.ComputeClient.ComputeManagementClient.VirtualMachines.CreateOrUpdateWithHttpMessagesAsync(
                    this.ResourceGroupName,
                    vmParameters.Name,
                    parameters).GetAwaiter().GetResult();

                // start vm
                this.ComputeClient.ComputeManagementClient.VirtualMachines
                    .StartWithHttpMessagesAsync(ResourceGroupName, this.VMName).GetAwaiter().GetResult();
            }

            return updateResult;
        }

        private AzureOperationResponse<VirtualMachine, VirtualMachinesCreateOrUpdateHeaders> UpdateVmEncryptionSettingsForMigration()
        {
            var vmParameters = (this.ComputeClient.ComputeManagementClient.VirtualMachines.Get(
                this.ResourceGroupName, this.VMName));

            DiskEncryptionSettings resetEncryptionSettings = new DiskEncryptionSettings();
            resetEncryptionSettings.Enabled = false;
            vmParameters.StorageProfile.OsDisk.EncryptionSettings = resetEncryptionSettings;

            // update VM
            AzureOperationResponse<VirtualMachine, VirtualMachinesCreateOrUpdateHeaders> setEncryptionEnabledFalse = null;
            setEncryptionEnabledFalse = this.ComputeClient.ComputeManagementClient.VirtualMachines.CreateOrUpdateWithHttpMessagesAsync(
                    this.ResourceGroupName,
                    vmParameters.Name,
                    vmParameters).GetAwaiter().GetResult();

            return setEncryptionEnabledFalse;
        }

        private bool UpdateVmEncryptionIdentity()
        {
            bool updateVm = false;
            var vmParameters = (this.ComputeClient.ComputeManagementClient.VirtualMachines.Get(
                this.ResourceGroupName, this.VMName));

            if (vmParameters.Identity == null || vmParameters.Identity.UserAssignedIdentities == null || 
                !vmParameters.Identity.UserAssignedIdentities.ContainsKey(this.EncryptionIdentity))
                ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture,
                    "Encryption Identity should be an ARM Resource ID of one of the user assigned identities associated to the resource")),
                    "InvalidResult",ErrorCategory.InvalidResult,null));


            if (vmParameters.SecurityProfile == null)
            {
                vmParameters.SecurityProfile = new SecurityProfile();
            }

            if (vmParameters.SecurityProfile.EncryptionIdentity == null)
            {
                vmParameters.SecurityProfile.EncryptionIdentity = new EncryptionIdentity();
            }

            if (String.IsNullOrEmpty(vmParameters.SecurityProfile.EncryptionIdentity.UserAssignedIdentityResourceId) || !vmParameters.SecurityProfile.EncryptionIdentity.UserAssignedIdentityResourceId.Equals(this.EncryptionIdentity, StringComparison.OrdinalIgnoreCase))
            {
                vmParameters.SecurityProfile.EncryptionIdentity.UserAssignedIdentityResourceId = this.EncryptionIdentity;
                updateVm = true;
            }

            if (updateVm)
            {
                // update VM
                AzureOperationResponse<VirtualMachine, VirtualMachinesCreateOrUpdateHeaders> updateEncryptionIdentity = null;
                updateEncryptionIdentity = this.ComputeClient.ComputeManagementClient.
                    VirtualMachines.CreateOrUpdateWithHttpMessagesAsync(
                        this.ResourceGroupName,
                        vmParameters.Name,
                        vmParameters).GetAwaiter().GetResult();

                if (!updateEncryptionIdentity.Response.IsSuccessStatusCode)
                {
                    ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture,
                        "Failed to update encryption identity on VM",updateEncryptionIdentity.Response.Content.ReadAsStringAsync().GetAwaiter().GetResult())),
                        "InvalidResult",ErrorCategory.InvalidResult,null));
                }
                else
                {
                    this.WriteObject(ComputeAutoMapperProfile.Mapper.Map<PSAzureOperationResponse>(updateEncryptionIdentity));
                    return true;
                }
                return false;
            }
            return true;
        }

        private AzureOperationResponse<VirtualMachine, VirtualMachinesCreateOrUpdateHeaders> ClearVmEncryptionSettingsForMigration()
        {
            var vmParameters = (this.ComputeClient.ComputeManagementClient.VirtualMachines.Get(
                this.ResourceGroupName, this.VMName));
            vmParameters.StorageProfile.OsDisk.EncryptionSettings = null;

            // update VM
            AzureOperationResponse<VirtualMachine, VirtualMachinesCreateOrUpdateHeaders> clearEncryptionSettings = null;
            clearEncryptionSettings = this.ComputeClient.ComputeManagementClient.VirtualMachines.CreateOrUpdateWithHttpMessagesAsync(
                    this.ResourceGroupName,
                    vmParameters.Name,
                    vmParameters).GetAwaiter().GetResult();

            return clearEncryptionSettings;
        }

        private Hashtable GetExtensionPublicSettings()
        {
            Hashtable publicSettings = new Hashtable();
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.aadClientIDKey, AadClientID ?? String.Empty);
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.aadClientCertThumbprintKey, AadClientCertThumbprint ?? String.Empty);
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.keyVaultResourceIdKey, DiskEncryptionKeyVaultId ?? string.Empty);
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.keyVaultUrlKey, DiskEncryptionKeyVaultUrl ?? String.Empty);
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.kekVaultResourceIdKey, KeyEncryptionKeyVaultId ?? string.Empty);
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.keyEncryptionKeyUrlKey, KeyEncryptionKeyUrl ?? String.Empty);
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.volumeTypeKey, VolumeType ?? String.Empty);
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.sequenceVersionKey, SequenceVersion ?? String.Empty);

            if (Migrate.IsPresent)
            {
                publicSettings.Add(AzureDiskEncryptionExtensionConstants.migrateAdeOperationKey, AzureDiskEncryptionExtensionConstants.migrateAdeOperationValue);
            }
            else if (EncryptFormatAll.IsPresent)
            {
                publicSettings.Add(AzureDiskEncryptionExtensionConstants.encryptionOperationKey, AzureDiskEncryptionExtensionConstants.enableEncryptionFormatAllOperation);
            }
            else
            {
                publicSettings.Add(AzureDiskEncryptionExtensionConstants.encryptionOperationKey, AzureDiskEncryptionExtensionConstants.enableEncryptionOperation);
            }

            string keyEncryptAlgorithm = string.Empty;
            if (!string.IsNullOrEmpty(this.KeyEncryptionKeyUrl))
            {
                if (!string.IsNullOrEmpty(KeyEncryptionAlgorithm))
                {
                    keyEncryptAlgorithm = KeyEncryptionAlgorithm;
                }
                else
                {
                    keyEncryptAlgorithm = AzureDiskEncryptionExtensionConstants.defaultKeyEncryptionAlgorithm;
                }
            }
            publicSettings.Add(AzureDiskEncryptionExtensionConstants.keyEncryptionAlgorithmKey, keyEncryptAlgorithm);

            return publicSettings;
        }

        private Hashtable GetExtensionProtectedSettings()
        {
            Hashtable protectedSettings = new Hashtable();
            protectedSettings.Add(AzureDiskEncryptionExtensionConstants.aadClientSecretKey, AadClientSecret ?? String.Empty);
            if (OperatingSystemTypes.Linux.Equals(currentOSType))
            {
                protectedSettings.Add(AzureDiskEncryptionExtensionConstants.passphraseKey, Passphrase ?? null);
            }
            return protectedSettings;
        }

        private VirtualMachineExtension GetVmExtensionParameters(VirtualMachine vmParameters)
        {
            Hashtable SettingString = GetExtensionPublicSettings();
            Hashtable ProtectedSettingString = GetExtensionProtectedSettings();
            string typeHandlerDefaultVersion;  // determined by parameter set and VM operating system type

            if (vmParameters == null)
            {
                ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture, "Set-AzDiskEncryptionExtension can enable encryption only on a VM that was already created ")),
                                                      "InvalidResult",
                                                      ErrorCategory.InvalidResult,
                                                      null));
            }

            VirtualMachineExtension vmExtensionParameters = null;

            if (OperatingSystemTypes.Windows.Equals(currentOSType))
            {
                this.Name = this.Name ?? AzureDiskEncryptionExtensionContext.ExtensionDefaultName;

                if (this.ParameterSetName.Equals(AzureDiskEncryptionExtensionConstants.singlePassParameterSet))
                {
                    typeHandlerDefaultVersion = AzureDiskEncryptionExtensionContext.ExtensionSinglePassVersion;
                }
                else
                {
                    typeHandlerDefaultVersion = AzureDiskEncryptionExtensionContext.ExtensionDefaultVersion;
                }
                vmExtensionParameters = new VirtualMachineExtension
                {
                    Location = vmParameters.Location,
                    Publisher = this.ExtensionPublisherName ?? AzureDiskEncryptionExtensionContext.ExtensionDefaultPublisher,
                    VirtualMachineExtensionType = this.ExtensionType ?? AzureDiskEncryptionExtensionContext.ExtensionDefaultType,
                    TypeHandlerVersion = this.TypeHandlerVersion ?? typeHandlerDefaultVersion,
                    Settings = SettingString,
                    ProtectedSettings = ProtectedSettingString,
                    AutoUpgradeMinorVersion = !DisableAutoUpgradeMinorVersion.IsPresent
                };
            }
            else if (OperatingSystemTypes.Linux.Equals(currentOSType))
            {
                this.Name = this.Name ?? AzureDiskEncryptionExtensionContext.LinuxExtensionDefaultName;
                if (this.ParameterSetName.Equals(AzureDiskEncryptionExtensionConstants.singlePassParameterSet))
                {
                    typeHandlerDefaultVersion = AzureDiskEncryptionExtensionContext.LinuxExtensionSinglePassVersion;
                }
                else
                {
                    typeHandlerDefaultVersion = AzureDiskEncryptionExtensionContext.LinuxExtensionDefaultVersion;
                }
                vmExtensionParameters = new VirtualMachineExtension
                {
                    Location = vmParameters.Location,
                    Publisher = this.ExtensionPublisherName ?? AzureDiskEncryptionExtensionContext.LinuxExtensionDefaultPublisher,
                    VirtualMachineExtensionType = this.ExtensionType ?? AzureDiskEncryptionExtensionContext.LinuxExtensionDefaultType,
                    TypeHandlerVersion = this.TypeHandlerVersion ?? typeHandlerDefaultVersion,
                    Settings = SettingString,
                    ProtectedSettings = ProtectedSettingString,
                    AutoUpgradeMinorVersion = !DisableAutoUpgradeMinorVersion.IsPresent
                };
            }

            return vmExtensionParameters;
        }

        private void CreateVMBackupForLinx()
        {
            try
            {
                AzureVMBackupExtensionUtil azureBackupExtensionUtil = new AzureVMBackupExtensionUtil();
                AzureVMBackupConfig vmConfig = new AzureVMBackupConfig();
                vmConfig.ResourceGroupName = ResourceGroupName;
                vmConfig.VMName = VMName;
                vmConfig.VirtualMachineExtensionType = VirtualMachineExtensionType;
                string tag = string.Format("{0}{1}", "AzureEnc", Guid.NewGuid().ToString());
                // this would create snapshot only for Linux box. and we should wait for the snapshot found.
                azureBackupExtensionUtil.CreateSnapshotForDisks(vmConfig, tag, this);
                WriteWarning(string.Format("one snapshot for disks are created with tag,{0}, you can use {1}-{2} to remove it.", tag, VerbsCommon.Remove,
    ProfileNouns.AzureVMBackup));
            }
            catch (AzureVMBackupException e)
            {
                ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture, e.ToString())),
                                                      "InvalidResult",
                                                      ErrorCategory.InvalidResult,
                                                      null));
            }
        }

        private PSVirtualMachineExtension GetADEExtensionInstanceView()
        {
            // Get the public settings used for encrypting the VM from ADE extension properties.
            AzureOperationResponse<VirtualMachineExtension> vmGetADEExtensionResponse = this.VirtualMachineExtensionClient.GetWithInstanceView(this.ResourceGroupName,
                        this.VMName, this.Name);
            var vmADEExtension = vmGetADEExtensionResponse.ToPSVirtualMachineExtension(
                this.ResourceGroupName, this.VMName);
            return vmADEExtension;
        }

        private void ValidateMigrationPrereqs(VirtualMachine virtualMachineResponse, VirtualMachineExtension vmExtensionParameters)
        {
            if (this.MigrationRecovery.IsPresent)
            {
                if ((virtualMachineResponse.StorageProfile.OsDisk.EncryptionSettings == null) || (virtualMachineResponse.StorageProfile.OsDisk.EncryptionSettings.Enabled != false))
                {
                    // -migrationRecovery is an invalid parameter for this scenario
                    ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Resources.EnableDiskEncryptionInvalidMigrateRecoveryParameter)),
                                                  "InvalidArgument",
                                                  ErrorCategory.InvalidArgument,
                                                  null));
                }
                return;
            }

            // error handling for unsupported migration scenarios
            if (virtualMachineResponse.StorageProfile.OsDisk.EncryptionSettings == null)
            {
                // -migrate is an invalid parameter for VMs using single pass ADE.
                ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Resources.EnableDiskEncryptionInvalidMigrateParameterForSinglePass)),
                                              "InvalidArgument",
                                              ErrorCategory.InvalidArgument,
                                              null));
            }

            if ((virtualMachineResponse.StorageProfile.OsDisk.EncryptionSettings.Enabled == null) ||
                (virtualMachineResponse.StorageProfile.OsDisk.EncryptionSettings.Enabled == false))
            {
                // -migrate is an invalid parameter for VMs in which 2 pass ADE has been disabled.
                ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Resources.EnableDiskEncryptionInvalidMigrateParameterForDisable)),
                                              "InvalidArgument",
                                              ErrorCategory.InvalidArgument,
                                              null));
            }

            if ((OperatingSystemTypes.Linux.Equals(currentOSType)) && (vmExtensionParameters.TypeHandlerVersion.StartsWith("1.")))
            {
                // Single pass extension is installed on the VM. VM cannot be migrated.
                ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Resources.EnableDiskEncryptionInvalidMigrateParameterForSinglePass)),
                                              "InvalidArgument",
                                              ErrorCategory.InvalidArgument,
                                              null));
            }

            if ((OperatingSystemTypes.Windows.Equals(currentOSType)) && (vmExtensionParameters.TypeHandlerVersion.StartsWith("2.")))
            {
                // Single pass extension is installed on the VM. VM cannot be migrated.
                ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Resources.EnableDiskEncryptionInvalidMigrateParameterForSinglePass)),
                                              "InvalidArgument",
                                              ErrorCategory.InvalidArgument,
                                              null));
            }
        }

        private void VerifyKeyVaultProperties(VirtualMachine virtualMachineResponse, Hashtable vmPublicSettings)
        {
            // Verify that KeyVaultResourceId and KekVaultResourceId are present in vmPublicSettings
            // They can be missing if VM was first encrypted using CLI as CLI does not add these properties to VM Extension Instance View
            if (!vmPublicSettings.ContainsKey(AzureDiskEncryptionExtensionConstants.keyVaultResourceIdKey))
            {
                vmPublicSettings.Add(AzureDiskEncryptionExtensionConstants.keyVaultResourceIdKey, virtualMachineResponse.StorageProfile.OsDisk.EncryptionSettings.DiskEncryptionKey.SourceVault.Id);
            }
            if (!vmPublicSettings.ContainsKey(AzureDiskEncryptionExtensionConstants.kekVaultResourceIdKey))
            {
                String kekUrl = (String)vmPublicSettings[AzureDiskEncryptionExtensionConstants.keyEncryptionKeyUrlKey];
                if (kekUrl != null && kekUrl.Length > 0)
                {
                    vmPublicSettings.Add(AzureDiskEncryptionExtensionConstants.kekVaultResourceIdKey, virtualMachineResponse.StorageProfile.OsDisk.EncryptionSettings.KeyEncryptionKey.SourceVault.Id);
                }
                else
                {
                    vmPublicSettings.Add(AzureDiskEncryptionExtensionConstants.kekVaultResourceIdKey, "");
                }
            }
        }

        private void EnableDualPassADEForMigration(PSVirtualMachineExtension adeExtensionInstanceView, Hashtable vmPublicSettings)
        {
            this.WriteObject("Running ADE extension (with AAD) for -Migrate..");
            VirtualMachineExtension vmExtensionParameters = new VirtualMachineExtension
            {
                Location = adeExtensionInstanceView.Location,
                Publisher = adeExtensionInstanceView.Publisher,
                VirtualMachineExtensionType = adeExtensionInstanceView.ExtensionType,
                TypeHandlerVersion = adeExtensionInstanceView.TypeHandlerVersion,
                Settings = vmPublicSettings,
                ProtectedSettings = adeExtensionInstanceView.ProtectedSettings,
                AutoUpgradeMinorVersion = adeExtensionInstanceView.AutoUpgradeMinorVersion,
            };

            AzureOperationResponse<VirtualMachineExtension, VirtualMachineExtensionsCreateOrUpdateHeaders> configureVMforMigrate = this.VirtualMachineExtensionClient.CreateOrUpdateWithHttpMessagesAsync(
            this.ResourceGroupName,
            this.VMName,
            adeExtensionInstanceView.Name,
            vmExtensionParameters).GetAwaiter().GetResult();

            if (!configureVMforMigrate.Response.IsSuccessStatusCode)
            {
                ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture,
                                                                                "Migration failed while installing Azure Disk Encryption extension (with Microsoft Entra ID). Error {0}",
                                                                                configureVMforMigrate.Response.Content.ReadAsStringAsync().GetAwaiter().GetResult())),
                                                        "InvalidResult",
                                                        ErrorCategory.InvalidResult,
                                                        null));
            }

            // Update EncryptionSettings.Enabled to False
            this.WriteObject("ADE extension (with Microsoft Entra ID) is now complete. Updating VM model..");
            var setEncryptionEnabledFalse = UpdateVmEncryptionSettingsForMigration();
            if (!setEncryptionEnabledFalse.Response.IsSuccessStatusCode)
            {
                ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture, "Migration failed while setting EncryptionSettings.Enabled to false.")),
                                                        "InvalidResult",
                                                        ErrorCategory.InvalidResult,
                                                        null));
            }
        }

        private void EnableSinglePassADEForMigration(PSVirtualMachineExtension adeExtensionInstanceView, Hashtable vmPublicSettings)
        {
            this.WriteObject("Running ADE extension (without Microsoft Entra ID) for -Migrate..");
            string typeHandlerVersionForMigration;
            if (OperatingSystemTypes.Linux.Equals(currentOSType))
            {
                typeHandlerVersionForMigration = AzureDiskEncryptionExtensionContext.LinuxExtensionSinglePassVersion;
            }
            else
            {
                typeHandlerVersionForMigration = AzureDiskEncryptionExtensionContext.ExtensionSinglePassVersion;
            }

            vmPublicSettings.Remove(AzureDiskEncryptionExtensionConstants.aadClientIDKey);
            vmPublicSettings.Remove(AzureDiskEncryptionExtensionConstants.aadClientCertThumbprintKey);
            VirtualMachineExtension vmSinglePassExtensionParameters = new VirtualMachineExtension
            {
                Location = adeExtensionInstanceView.Location,
                Publisher = adeExtensionInstanceView.Publisher,
                VirtualMachineExtensionType = adeExtensionInstanceView.ExtensionType,
                TypeHandlerVersion = typeHandlerVersionForMigration,
                Settings = vmPublicSettings,
                AutoUpgradeMinorVersion = adeExtensionInstanceView.AutoUpgradeMinorVersion,
            };

            AzureOperationResponse<VirtualMachineExtension, VirtualMachineExtensionsCreateOrUpdateHeaders> UpdateToSinglePass = this.VirtualMachineExtensionClient.CreateOrUpdateWithHttpMessagesAsync(
                    this.ResourceGroupName,
                    this.VMName,
                    adeExtensionInstanceView.Name,
                    vmSinglePassExtensionParameters).GetAwaiter().GetResult();

            if (!UpdateToSinglePass.Response.IsSuccessStatusCode)
            {
                ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture,
                                                                            "Migration failed while installing Azure Disk Encryption extension (without AAD). Error {0}",
                                                                            UpdateToSinglePass.Response.Content.ReadAsStringAsync().GetAwaiter().GetResult())),
                                                    "InvalidResult",
                                                    ErrorCategory.InvalidResult,
                                                    null));
            }

            // Clear 2 pass encryption settings from VM model
            this.WriteObject("ADE extension (without AAD) is now complete. Clearing VM model..");
            var clearEncryptionSettings = ClearVmEncryptionSettingsForMigration();
            WriteObject(ComputeAutoMapperProfile.Mapper.Map<PSAzureOperationResponse>(clearEncryptionSettings));
        }

        private Hashtable GetVmPublicSettingsForMigration(VirtualMachine virtualMachineResponse, PSVirtualMachineExtension adeExtensionInstanceView)
        {
            Hashtable vmPublicSettings = JsonConvert.DeserializeObject<Hashtable>(adeExtensionInstanceView.PublicSettings);
            VerifyKeyVaultProperties(virtualMachineResponse, vmPublicSettings);

            //Add Migrate Flag only if its not present on the vmPublicSettings already
            if (!vmPublicSettings.Contains(AzureDiskEncryptionExtensionConstants.migrateAdeOperationKey))
            {
                vmPublicSettings.Add(AzureDiskEncryptionExtensionConstants.migrateAdeOperationKey, AzureDiskEncryptionExtensionConstants.migrateAdeOperationValue);
            }

            string publicSettingsForOutput = "Azure Disk Encryption Extension Public Settings \n";
            foreach (DictionaryEntry entry in vmPublicSettings)
            {
                publicSettingsForOutput += string.Format("\"{0}\": {1} \n", entry.Key, entry.Value);
            }
            this.WriteObject(publicSettingsForOutput);

            return vmPublicSettings;
        }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            ExecuteClientAction(() =>
            {
                if (this.ShouldProcess(VMName, Properties.Resources.EnableDiskEncryptionAction)
                && (this.Force.IsPresent || ((this.Migrate.IsPresent || this.MigrationRecovery.IsPresent) ? this.ShouldContinue(Properties.Resources.MigrateAzureDiskEncryptionConfirmation, Properties.Resources.MigrateAzureDiskEncryptionCaption)
                                    : this.ShouldContinue(Properties.Resources.EnableAzureDiskEncryptionConfirmation, Properties.Resources.EnableAzureDiskEncryptionCaption))))
                {
                    VirtualMachine virtualMachineResponse = this.ComputeClient.ComputeManagementClient.VirtualMachines.GetWithInstanceView(
                        this.ResourceGroupName, VMName).Body;

                    currentOSType = virtualMachineResponse.StorageProfile.OsDisk.OsType;

                    var vmParameters = (this.ComputeClient.ComputeManagementClient.VirtualMachines.Get(
                        this.ResourceGroupName, VMName));

                    VirtualMachineExtension parameters = GetVmExtensionParameters(virtualMachineResponse);

                    if (this.Migrate.IsPresent && this.MigrationRecovery.IsPresent)
                    {
                        ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Resources.InvalidMigrateAndMigrateRecoveryParameters)),
                                              "InvalidArgument",
                                              ErrorCategory.InvalidArgument,
                                              null));
                    }

                    if (this.Migrate.IsPresent || this.MigrationRecovery.IsPresent) // migrate from dual pass to single pass ADE
                    {
                        ValidateMigrationPrereqs(virtualMachineResponse, parameters);
                        var adeExtensionInstanceView = GetADEExtensionInstanceView(); // Get ADE extension instance view. ADE public settings are fetched from the extension instance view.
                        Hashtable vmPublicSettings = GetVmPublicSettingsForMigration(virtualMachineResponse, adeExtensionInstanceView);
                        if (!this.MigrationRecovery.IsPresent)
                        {
                            EnableDualPassADEForMigration(adeExtensionInstanceView, vmPublicSettings); // Enable 2 pass ADE with -migrate flag
                        }
                        EnableSinglePassADEForMigration(adeExtensionInstanceView, vmPublicSettings); // Enable 1 pass ADE with -migrate flag
                    }
                    else
                    {
                        DiskEncryptionSettings encryptionSettingsBackup = virtualMachineResponse.StorageProfile.OsDisk.EncryptionSettings ??
                                                                      new DiskEncryptionSettings { Enabled = false };
                        if (OperatingSystemTypes.Linux.Equals(currentOSType) && !SkipVmBackup)
                        {
                            if (vmParameters.StorageProfile.OsDisk.ManagedDisk != null)
                            {
                                ThrowTerminatingError(new ErrorRecord(new ArgumentException(string.Format(CultureInfo.CurrentUICulture, Resources.EnableDiskEncryptionMissingSkipVmBackup)),
                                                              "InvalidArgument",
                                                              ErrorCategory.InvalidArgument,
                                                              null));
                            }
                            else
                            {
                                CreateVMBackupForLinx();
                            }
                        }

                        if (this.EncryptionIdentity != null)
                        {
                            bool updateEncryptionIdentity = UpdateVmEncryptionIdentity();
                            if (updateEncryptionIdentity)
                            {
                                this.WriteObject("Encryption identity updated successfully on VM.");
                            }
                        }
                        // Single Pass
                        //      newer model, supported by newer extension versions and host functionality
                        //      if SinglePassParameterSet is used, cmdlet will default to newer extension version
                        //      [first and only pass]
                        //          only one enable extension call will be issued from the cmdlet n
                        //          No AD identity information or protected settings will be passed to the extension
                        //          Host performs the necessary key vault operations and vm model updates
                        // Dual Pass
                        //      older model, supported by older extension versions
                        //      if an AD ParameterSet is used, cmdlet will default to older extension version
                        //      [first pass]
                        //          AD identity information is passed into the VM via protected settings of the extension
                        //          VM uses the AD identity to authenticate and perform key vault operations
                        //          VM returns result of key vault operation to caller via the extension status message
                        //      [second pass]
                        //          powershell reads extension status message returned from first pass
                        //          updates VM model with encryption settings
                        //          updates VM

                        // First Pass
                        AzureOperationResponse<VirtualMachineExtension, VirtualMachineExtensionsCreateOrUpdateHeaders> firstPass = this.VirtualMachineExtensionClient.CreateOrUpdateWithHttpMessagesAsync(
                            this.ResourceGroupName,
                            this.VMName,
                            this.Name,
                            parameters).GetAwaiter().GetResult();

                        if (!firstPass.Response.IsSuccessStatusCode)
                        {
                            ThrowTerminatingError(new ErrorRecord(new ApplicationException(string.Format(CultureInfo.CurrentUICulture,
                                                                                            "Installation failed for extension {0} with error {1}",
                                                                                            parameters.VirtualMachineExtensionType,
                                                                                            firstPass.Response.Content.ReadAsStringAsync().GetAwaiter().GetResult())),
                                                                    "InvalidResult",
                                                                    ErrorCategory.InvalidResult,
                                                                    null));
                        }

                        if (this.ParameterSetName.Equals(AzureDiskEncryptionExtensionConstants.singlePassParameterSet))
                        {
                            WriteObject(ComputeAutoMapperProfile.Mapper.Map<PSAzureOperationResponse>(firstPass));
                        }
                        else
                        {
                            // Second pass
                            var secondPass = UpdateVmEncryptionSettings(encryptionSettingsBackup);
                            WriteObject(ComputeAutoMapperProfile.Mapper.Map<PSAzureOperationResponse>(secondPass));
                        }
                    }
                }
            });
        }
    }
}
