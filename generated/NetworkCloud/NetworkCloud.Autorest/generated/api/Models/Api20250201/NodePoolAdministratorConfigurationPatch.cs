// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// NodePoolAdministratorConfigurationPatch represents the patching capabilities for the administrator configuration.
    /// </summary>
    public partial class NodePoolAdministratorConfigurationPatch :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.INodePoolAdministratorConfigurationPatch,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.INodePoolAdministratorConfigurationPatchInternal
    {

        /// <summary>Backing field for <see cref="SshPublicKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[] _sshPublicKey;

        /// <summary>
        /// SshPublicKey represents the public key used to authenticate with a resource through SSH.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[] SshPublicKey { get => this._sshPublicKey; set => this._sshPublicKey = value; }

        /// <summary>Creates an new <see cref="NodePoolAdministratorConfigurationPatch" /> instance.</summary>
        public NodePoolAdministratorConfigurationPatch()
        {

        }
    }
    /// NodePoolAdministratorConfigurationPatch represents the patching capabilities for the administrator configuration.
    public partial interface INodePoolAdministratorConfigurationPatch :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// SshPublicKey represents the public key used to authenticate with a resource through SSH.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SshPublicKey represents the public key used to authenticate with a resource through SSH.",
        SerializedName = @"sshPublicKeys",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[] SshPublicKey { get; set; }

    }
    /// NodePoolAdministratorConfigurationPatch represents the patching capabilities for the administrator configuration.
    internal partial interface INodePoolAdministratorConfigurationPatchInternal

    {
        /// <summary>
        /// SshPublicKey represents the public key used to authenticate with a resource through SSH.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ISshPublicKey[] SshPublicKey { get; set; }

    }
}