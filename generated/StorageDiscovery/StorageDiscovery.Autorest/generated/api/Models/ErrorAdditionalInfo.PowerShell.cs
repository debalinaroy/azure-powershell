// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.PowerShell;

    /// <summary>The resource management error additional info.</summary>
    [System.ComponentModel.TypeConverter(typeof(ErrorAdditionalInfoTypeConverter))]
    public partial class ErrorAdditionalInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ErrorAdditionalInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ErrorAdditionalInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ErrorAdditionalInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ErrorAdditionalInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ErrorAdditionalInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ErrorAdditionalInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfoInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfoInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Info"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfoInternal)this).Info = (Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IAny) content.GetValueForProperty("Info",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfoInternal)this).Info, Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.AnyTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.ErrorAdditionalInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ErrorAdditionalInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfoInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfoInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Info"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfoInternal)this).Info = (Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IAny) content.GetValueForProperty("Info",((Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfoInternal)this).Info, Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.AnyTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ErrorAdditionalInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ErrorAdditionalInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Models.IErrorAdditionalInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageDiscovery.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The resource management error additional info.
    [System.ComponentModel.TypeConverter(typeof(ErrorAdditionalInfoTypeConverter))]
    public partial interface IErrorAdditionalInfo

    {

    }
}