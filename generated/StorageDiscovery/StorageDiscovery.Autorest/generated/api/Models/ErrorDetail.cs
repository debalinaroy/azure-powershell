// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Extensions;

    /// <summary>The error detail.</summary>
    public partial class ErrorDetail :
        Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetail,
        Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetailInternal
    {

        /// <summary>Backing field for <see cref="AdditionalInfo" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo> _additionalInfo;

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo> AdditionalInfo { get => this._additionalInfo; }

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetail> _detail;

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetail> Detail { get => this._detail; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetailInternal.AdditionalInfo { get => this._additionalInfo; set { {_additionalInfo = value;} } }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetailInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetailInternal.Detail { get => this._detail; set { {_detail = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetailInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetailInternal.Target { get => this._target; set { {_target = value;} } }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.PropertyOrigin.Owned)]
        public string Target { get => this._target; }

        /// <summary>Creates an new <see cref="ErrorDetail" /> instance.</summary>
        public ErrorDetail()
        {

        }
    }
    /// The error detail.
    public partial interface IErrorDetail :
        Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo> AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetail> Detail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// The error detail.
    internal partial interface IErrorDetailInternal

    {
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo> AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorDetail> Detail { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

    }
}