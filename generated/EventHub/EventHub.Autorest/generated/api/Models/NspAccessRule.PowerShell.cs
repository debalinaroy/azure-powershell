// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.PowerShell;

    /// <summary>Information of Access Rule in Network Profile</summary>
    [System.ComponentModel.TypeConverter(typeof(NspAccessRuleTypeConverter))]
    public partial class NspAccessRule
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NspAccessRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NspAccessRule(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NspAccessRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NspAccessRule(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NspAccessRule" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NspAccessRule" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRule FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NspAccessRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NspAccessRule(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NspAccessRulePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Direction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Direction = (string) content.GetValueForProperty("Direction",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Direction, global::System.Convert.ToString);
            }
            if (content.Contains("AddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).AddressPrefix = (System.Collections.Generic.List<string>) content.GetValueForProperty("AddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).AddressPrefix, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Subscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Subscription = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRulePropertiesSubscriptionsItem>) content.GetValueForProperty("Subscription",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Subscription, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRulePropertiesSubscriptionsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NspAccessRulePropertiesSubscriptionsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkSecurityPerimeter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).NetworkSecurityPerimeter = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeter>) content.GetValueForProperty("NetworkSecurityPerimeter",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).NetworkSecurityPerimeter, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeter>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NetworkSecurityPerimeterTypeConverter.ConvertFrom));
            }
            if (content.Contains("FullyQualifiedDomainName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).FullyQualifiedDomainName = (System.Collections.Generic.List<string>) content.GetValueForProperty("FullyQualifiedDomainName",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).FullyQualifiedDomainName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NspAccessRule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NspAccessRule(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NspAccessRulePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Direction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Direction = (string) content.GetValueForProperty("Direction",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Direction, global::System.Convert.ToString);
            }
            if (content.Contains("AddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).AddressPrefix = (System.Collections.Generic.List<string>) content.GetValueForProperty("AddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).AddressPrefix, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Subscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Subscription = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRulePropertiesSubscriptionsItem>) content.GetValueForProperty("Subscription",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).Subscription, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRulePropertiesSubscriptionsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NspAccessRulePropertiesSubscriptionsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkSecurityPerimeter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).NetworkSecurityPerimeter = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeter>) content.GetValueForProperty("NetworkSecurityPerimeter",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).NetworkSecurityPerimeter, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INetworkSecurityPerimeter>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.NetworkSecurityPerimeterTypeConverter.ConvertFrom));
            }
            if (content.Contains("FullyQualifiedDomainName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).FullyQualifiedDomainName = (System.Collections.Generic.List<string>) content.GetValueForProperty("FullyQualifiedDomainName",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.INspAccessRuleInternal)this).FullyQualifiedDomainName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Information of Access Rule in Network Profile
    [System.ComponentModel.TypeConverter(typeof(NspAccessRuleTypeConverter))]
    public partial interface INspAccessRule

    {

    }
}