// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// ClusterMetricsConfigurationPatchParameters represents the body of the request to patch the metrics configuration of cluster.
    /// </summary>
    public partial class ClusterMetricsConfigurationPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchParameters,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchParametersInternal
    {

        /// <summary>The interval in minutes by which metrics will be collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public long? CollectionInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchPropertiesInternal)Property).CollectionInterval; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchPropertiesInternal)Property).CollectionInterval = value ?? default(long); }

        /// <summary>
        /// The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Inlined)]
        public string[] EnabledMetric { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchPropertiesInternal)Property).EnabledMetric; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchPropertiesInternal)Property).EnabledMetric = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterMetricsConfigurationPatchProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchProperties _property;

        /// <summary>The list of the resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterMetricsConfigurationPatchProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchParametersTags _tag;

        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.ClusterMetricsConfigurationPatchParametersTags()); set => this._tag = value; }

        /// <summary>
        /// Creates an new <see cref="ClusterMetricsConfigurationPatchParameters" /> instance.
        /// </summary>
        public ClusterMetricsConfigurationPatchParameters()
        {

        }
    }
    /// ClusterMetricsConfigurationPatchParameters represents the body of the request to patch the metrics configuration of cluster.
    public partial interface IClusterMetricsConfigurationPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>The interval in minutes by which metrics will be collected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The interval in minutes by which metrics will be collected.",
        SerializedName = @"collectionInterval",
        PossibleTypes = new [] { typeof(long) })]
        long? CollectionInterval { get; set; }
        /// <summary>
        /// The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics.",
        SerializedName = @"enabledMetrics",
        PossibleTypes = new [] { typeof(string) })]
        string[] EnabledMetric { get; set; }
        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure resource tags that will replace the existing ones.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchParametersTags Tag { get; set; }

    }
    /// ClusterMetricsConfigurationPatchParameters represents the body of the request to patch the metrics configuration of cluster.
    internal partial interface IClusterMetricsConfigurationPatchParametersInternal

    {
        /// <summary>The interval in minutes by which metrics will be collected.</summary>
        long? CollectionInterval { get; set; }
        /// <summary>
        /// The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics.
        /// </summary>
        string[] EnabledMetric { get; set; }
        /// <summary>The list of the resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchProperties Property { get; set; }
        /// <summary>The Azure resource tags that will replace the existing ones.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IClusterMetricsConfigurationPatchParametersTags Tag { get; set; }

    }
}