// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.PowerShell;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemDataTypeConverter))]
    public partial class SystemData
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.SystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemData" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemData DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemData(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.SystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemData" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemData DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemData(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemData" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SystemData" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemData FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.SystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemData(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedBy = (string) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedByType = (string) content.GetValueForProperty("CreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedBy = (string) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedByType = (string) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.SystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemData(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedBy = (string) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedByType = (string) content.GetValueForProperty("CreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedBy = (string) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedByType = (string) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ISystemDataInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Metadata pertaining to creation and last modification of the resource.
    [System.ComponentModel.TypeConverter(typeof(SystemDataTypeConverter))]
    public partial interface ISystemData

    {

    }
}