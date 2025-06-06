// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties of the origin.</summary>
    public partial class AfdOriginUpdatePropertiesParameters
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject into a new instance of <see cref="AfdOriginUpdatePropertiesParameters" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AfdOriginUpdatePropertiesParameters(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_azureOrigin = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject>("azureOrigin"), out var __jsonAzureOrigin) ? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ResourceReference.FromJson(__jsonAzureOrigin) : _azureOrigin;}
            {_sharedPrivateLinkResource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject>("sharedPrivateLinkResource"), out var __jsonSharedPrivateLinkResource) ? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.SharedPrivateLinkResourceProperties.FromJson(__jsonSharedPrivateLinkResource) : _sharedPrivateLinkResource;}
            {_originGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("originGroupName"), out var __jsonOriginGroupName) ? (string)__jsonOriginGroupName : (string)_originGroupName;}
            {_hostName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("hostName"), out var __jsonHostName) ? (string)__jsonHostName : (string)_hostName;}
            {_httpPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber>("httpPort"), out var __jsonHttpPort) ? (int?)__jsonHttpPort : _httpPort;}
            {_httpsPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber>("httpsPort"), out var __jsonHttpsPort) ? (int?)__jsonHttpsPort : _httpsPort;}
            {_originHostHeader = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("originHostHeader"), out var __jsonOriginHostHeader) ? (string)__jsonOriginHostHeader : (string)_originHostHeader;}
            {_priority = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber>("priority"), out var __jsonPriority) ? (int?)__jsonPriority : _priority;}
            {_weight = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber>("weight"), out var __jsonWeight) ? (int?)__jsonWeight : _weight;}
            {_enabledState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString>("enabledState"), out var __jsonEnabledState) ? (string)__jsonEnabledState : (string)_enabledState;}
            {_enforceCertificateNameCheck = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonBoolean>("enforceCertificateNameCheck"), out var __jsonEnforceCertificateNameCheck) ? (bool?)__jsonEnforceCertificateNameCheck : _enforceCertificateNameCheck;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginUpdatePropertiesParameters.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginUpdatePropertiesParameters.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdOriginUpdatePropertiesParameters FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject json ? new AfdOriginUpdatePropertiesParameters(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AfdOriginUpdatePropertiesParameters" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AfdOriginUpdatePropertiesParameters" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._azureOrigin ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) this._azureOrigin.ToJson(null,serializationMode) : null, "azureOrigin" ,container.Add );
            AddIf( null != this._sharedPrivateLinkResource ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) this._sharedPrivateLinkResource.ToJson(null,serializationMode) : null, "sharedPrivateLinkResource" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._originGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._originGroupName.ToString()) : null, "originGroupName" ,container.Add );
            }
            AddIf( null != (((object)this._hostName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._hostName.ToString()) : null, "hostName" ,container.Add );
            AddIf( null != this._httpPort ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber((int)this._httpPort) : null, "httpPort" ,container.Add );
            AddIf( null != this._httpsPort ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber((int)this._httpsPort) : null, "httpsPort" ,container.Add );
            AddIf( null != (((object)this._originHostHeader)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._originHostHeader.ToString()) : null, "originHostHeader" ,container.Add );
            AddIf( null != this._priority ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber((int)this._priority) : null, "priority" ,container.Add );
            AddIf( null != this._weight ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNumber((int)this._weight) : null, "weight" ,container.Add );
            AddIf( null != (((object)this._enabledState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonString(this._enabledState.ToString()) : null, "enabledState" ,container.Add );
            AddIf( null != this._enforceCertificateNameCheck ? (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonBoolean((bool)this._enforceCertificateNameCheck) : null, "enforceCertificateNameCheck" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}