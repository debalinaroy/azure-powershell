// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>SSH configuration for Linux based VMs running on Azure</summary>
    public partial class SshConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshConfigurationInternal
    {

        /// <summary>Backing field for <see cref="PublicKey" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey> _publicKey;

        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey> PublicKey { get => this._publicKey; set => this._publicKey = value; }

        /// <summary>Creates an new <see cref="SshConfiguration" /> instance.</summary>
        public SshConfiguration()
        {

        }
    }
    /// SSH configuration for Linux based VMs running on Azure
    public partial interface ISshConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of SSH public keys used to authenticate with linux based VMs.",
        SerializedName = @"publicKeys",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey> PublicKey { get; set; }

    }
    /// SSH configuration for Linux based VMs running on Azure
    internal partial interface ISshConfigurationInternal

    {
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey> PublicKey { get; set; }

    }
}