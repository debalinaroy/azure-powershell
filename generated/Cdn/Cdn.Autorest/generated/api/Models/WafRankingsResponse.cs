// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Waf Rankings Response</summary>
    public partial class WafRankingsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafRankingsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafRankingsResponseInternal
    {

        /// <summary>Backing field for <see cref="Data" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafRankingsResponseDataItem> _data;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafRankingsResponseDataItem> Data { get => this._data; set => this._data = value; }

        /// <summary>Backing field for <see cref="DateTimeBegin" /> property.</summary>
        private global::System.DateTime? _dateTimeBegin;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public global::System.DateTime? DateTimeBegin { get => this._dateTimeBegin; set => this._dateTimeBegin = value; }

        /// <summary>Backing field for <see cref="DateTimeEnd" /> property.</summary>
        private global::System.DateTime? _dateTimeEnd;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public global::System.DateTime? DateTimeEnd { get => this._dateTimeEnd; set => this._dateTimeEnd = value; }

        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private System.Collections.Generic.List<string> _group;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Group { get => this._group; set => this._group = value; }

        /// <summary>Creates an new <see cref="WafRankingsResponse" /> instance.</summary>
        public WafRankingsResponse()
        {

        }
    }
    /// Waf Rankings Response
    public partial interface IWafRankingsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"data",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafRankingsResponseDataItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafRankingsResponseDataItem> Data { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"dateTimeBegin",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DateTimeBegin { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"dateTimeEnd",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DateTimeEnd { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Group { get; set; }

    }
    /// Waf Rankings Response
    internal partial interface IWafRankingsResponseInternal

    {
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IWafRankingsResponseDataItem> Data { get; set; }

        global::System.DateTime? DateTimeBegin { get; set; }

        global::System.DateTime? DateTimeEnd { get; set; }

        System.Collections.Generic.List<string> Group { get; set; }

    }
}