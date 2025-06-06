// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Extensions;

    /// <summary>List of carbon emission results</summary>
    public partial class CarbonEmissionDataListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionDataListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionDataListResultInternal
    {

        /// <summary>Backing field for <see cref="SkipToken" /> property.</summary>
        private string _skipToken;

        /// <summary>
        /// The pagination token to fetch next page data, it's null or empty if it doesn't have next page data
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Origin(Microsoft.Azure.PowerShell.Cmdlets.Carbon.PropertyOrigin.Owned)]
        public string SkipToken { get => this._skipToken; set => this._skipToken = value; }

        /// <summary>Backing field for <see cref="SubscriptionAccessDecisionList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ISubscriptionAccessDecision> _subscriptionAccessDecisionList;

        /// <summary>The access decision list for each input subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Origin(Microsoft.Azure.PowerShell.Cmdlets.Carbon.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ISubscriptionAccessDecision> SubscriptionAccessDecisionList { get => this._subscriptionAccessDecisionList; set => this._subscriptionAccessDecisionList = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionData> _value;

        /// <summary>The CarbonEmissionData items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Origin(Microsoft.Azure.PowerShell.Cmdlets.Carbon.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionData> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="CarbonEmissionDataListResult" /> instance.</summary>
        public CarbonEmissionDataListResult()
        {

        }
    }
    /// List of carbon emission results
    public partial interface ICarbonEmissionDataListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The pagination token to fetch next page data, it's null or empty if it doesn't have next page data
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The pagination token to fetch next page data, it's null or empty if it doesn't have next page data",
        SerializedName = @"skipToken",
        PossibleTypes = new [] { typeof(string) })]
        string SkipToken { get; set; }
        /// <summary>The access decision list for each input subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The access decision list for each input subscription ",
        SerializedName = @"subscriptionAccessDecisionList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ISubscriptionAccessDecision) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ISubscriptionAccessDecision> SubscriptionAccessDecisionList { get; set; }
        /// <summary>The CarbonEmissionData items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The CarbonEmissionData items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionData) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionData> Value { get; set; }

    }
    /// List of carbon emission results
    internal partial interface ICarbonEmissionDataListResultInternal

    {
        /// <summary>
        /// The pagination token to fetch next page data, it's null or empty if it doesn't have next page data
        /// </summary>
        string SkipToken { get; set; }
        /// <summary>The access decision list for each input subscription</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ISubscriptionAccessDecision> SubscriptionAccessDecisionList { get; set; }
        /// <summary>The CarbonEmissionData items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ICarbonEmissionData> Value { get; set; }

    }
}