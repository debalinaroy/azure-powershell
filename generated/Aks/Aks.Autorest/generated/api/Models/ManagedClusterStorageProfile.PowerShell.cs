// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.PowerShell;

    /// <summary>Storage profile for the container service cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterStorageProfileTypeConverter))]
    public partial class ManagedClusterStorageProfile
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedClusterStorageProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedClusterStorageProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedClusterStorageProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedClusterStorageProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedClusterStorageProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskCsiDriver"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).DiskCsiDriver = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileDiskCsiDriver) content.GetValueForProperty("DiskCsiDriver",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).DiskCsiDriver, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfileDiskCsiDriverTypeConverter.ConvertFrom);
            }
            if (content.Contains("FileCsiDriver"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).FileCsiDriver = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileFileCsiDriver) content.GetValueForProperty("FileCsiDriver",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).FileCsiDriver, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfileFileCsiDriverTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotController"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).SnapshotController = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileSnapshotController) content.GetValueForProperty("SnapshotController",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).SnapshotController, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfileSnapshotControllerTypeConverter.ConvertFrom);
            }
            if (content.Contains("BlobCsiDriver"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).BlobCsiDriver = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileBlobCsiDriver) content.GetValueForProperty("BlobCsiDriver",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).BlobCsiDriver, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfileBlobCsiDriverTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskCsiDriverEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).DiskCsiDriverEnabled = (bool?) content.GetValueForProperty("DiskCsiDriverEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).DiskCsiDriverEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("FileCsiDriverEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).FileCsiDriverEnabled = (bool?) content.GetValueForProperty("FileCsiDriverEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).FileCsiDriverEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotControllerEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).SnapshotControllerEnabled = (bool?) content.GetValueForProperty("SnapshotControllerEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).SnapshotControllerEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("BlobCsiDriverEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).BlobCsiDriverEnabled = (bool?) content.GetValueForProperty("BlobCsiDriverEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).BlobCsiDriverEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedClusterStorageProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiskCsiDriver"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).DiskCsiDriver = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileDiskCsiDriver) content.GetValueForProperty("DiskCsiDriver",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).DiskCsiDriver, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfileDiskCsiDriverTypeConverter.ConvertFrom);
            }
            if (content.Contains("FileCsiDriver"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).FileCsiDriver = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileFileCsiDriver) content.GetValueForProperty("FileCsiDriver",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).FileCsiDriver, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfileFileCsiDriverTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotController"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).SnapshotController = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileSnapshotController) content.GetValueForProperty("SnapshotController",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).SnapshotController, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfileSnapshotControllerTypeConverter.ConvertFrom);
            }
            if (content.Contains("BlobCsiDriver"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).BlobCsiDriver = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileBlobCsiDriver) content.GetValueForProperty("BlobCsiDriver",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).BlobCsiDriver, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.ManagedClusterStorageProfileBlobCsiDriverTypeConverter.ConvertFrom);
            }
            if (content.Contains("DiskCsiDriverEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).DiskCsiDriverEnabled = (bool?) content.GetValueForProperty("DiskCsiDriverEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).DiskCsiDriverEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("FileCsiDriverEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).FileCsiDriverEnabled = (bool?) content.GetValueForProperty("FileCsiDriverEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).FileCsiDriverEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotControllerEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).SnapshotControllerEnabled = (bool?) content.GetValueForProperty("SnapshotControllerEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).SnapshotControllerEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("BlobCsiDriverEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).BlobCsiDriverEnabled = (bool?) content.GetValueForProperty("BlobCsiDriverEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterStorageProfileInternal)this).BlobCsiDriverEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Storage profile for the container service cluster.
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterStorageProfileTypeConverter))]
    public partial interface IManagedClusterStorageProfile

    {

    }
}