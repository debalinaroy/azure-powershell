// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.PowerShell;

    /// <summary>Properties of the partner namespace.</summary>
    [System.ComponentModel.TypeConverter(typeof(PartnerNamespacePropertiesTypeConverter))]
    public partial class PartnerNamespaceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.PartnerNamespaceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespaceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespaceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PartnerNamespaceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.PartnerNamespaceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespaceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespaceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PartnerNamespaceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PartnerNamespaceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PartnerNamespaceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespaceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.PartnerNamespaceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PartnerNamespaceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerRegistrationFullyQualifiedId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PartnerRegistrationFullyQualifiedId = (string) content.GetValueForProperty("PartnerRegistrationFullyQualifiedId",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PartnerRegistrationFullyQualifiedId, global::System.Convert.ToString);
            }
            if (content.Contains("MinimumTlsVersionAllowed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).MinimumTlsVersionAllowed = (string) content.GetValueForProperty("MinimumTlsVersionAllowed",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).MinimumTlsVersionAllowed, global::System.Convert.ToString);
            }
            if (content.Contains("Endpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).Endpoint = (string) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).Endpoint, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("InboundIPRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).InboundIPRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IInboundIPRule>) content.GetValueForProperty("InboundIPRule",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).InboundIPRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IInboundIPRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.InboundIPRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("DisableLocalAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PartnerTopicRoutingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PartnerTopicRoutingMode = (string) content.GetValueForProperty("PartnerTopicRoutingMode",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PartnerTopicRoutingMode, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.PartnerNamespaceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PartnerNamespaceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerRegistrationFullyQualifiedId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PartnerRegistrationFullyQualifiedId = (string) content.GetValueForProperty("PartnerRegistrationFullyQualifiedId",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PartnerRegistrationFullyQualifiedId, global::System.Convert.ToString);
            }
            if (content.Contains("MinimumTlsVersionAllowed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).MinimumTlsVersionAllowed = (string) content.GetValueForProperty("MinimumTlsVersionAllowed",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).MinimumTlsVersionAllowed, global::System.Convert.ToString);
            }
            if (content.Contains("Endpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).Endpoint = (string) content.GetValueForProperty("Endpoint",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).Endpoint, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("InboundIPRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).InboundIPRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IInboundIPRule>) content.GetValueForProperty("InboundIPRule",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).InboundIPRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IInboundIPRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.InboundIPRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("DisableLocalAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PartnerTopicRoutingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PartnerTopicRoutingMode = (string) content.GetValueForProperty("PartnerTopicRoutingMode",((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerNamespacePropertiesInternal)this).PartnerTopicRoutingMode, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties of the partner namespace.
    [System.ComponentModel.TypeConverter(typeof(PartnerNamespacePropertiesTypeConverter))]
    public partial interface IPartnerNamespaceProperties

    {

    }
}