// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>Defines how to identify a parameter for a specific purpose e.g. expires</summary>
    [System.ComponentModel.TypeConverter(typeof(UrlSigningParamIdentifierTypeConverter))]
    public partial class UrlSigningParamIdentifier
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UrlSigningParamIdentifier"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UrlSigningParamIdentifier(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UrlSigningParamIdentifier"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UrlSigningParamIdentifier(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UrlSigningParamIdentifier" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UrlSigningParamIdentifier" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifier FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UrlSigningParamIdentifier"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UrlSigningParamIdentifier(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ParamIndicator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifierInternal)this).ParamIndicator = (string) content.GetValueForProperty("ParamIndicator",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifierInternal)this).ParamIndicator, global::System.Convert.ToString);
            }
            if (content.Contains("ParamName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifierInternal)this).ParamName = (string) content.GetValueForProperty("ParamName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifierInternal)this).ParamName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UrlSigningParamIdentifier"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UrlSigningParamIdentifier(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ParamIndicator"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifierInternal)this).ParamIndicator = (string) content.GetValueForProperty("ParamIndicator",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifierInternal)this).ParamIndicator, global::System.Convert.ToString);
            }
            if (content.Contains("ParamName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifierInternal)this).ParamName = (string) content.GetValueForProperty("ParamName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUrlSigningParamIdentifierInternal)this).ParamName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Defines how to identify a parameter for a specific purpose e.g. expires
    [System.ComponentModel.TypeConverter(typeof(UrlSigningParamIdentifierTypeConverter))]
    public partial interface IUrlSigningParamIdentifier

    {

    }
}