// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.SignalR.Models
{
    using System.Linq;

    /// <summary>
    /// Network ACLs for the resource
    /// </summary>
    public partial class SignalRNetworkACLs
    {
        /// <summary>
        /// Initializes a new instance of the SignalRNetworkACLs class.
        /// </summary>
        public SignalRNetworkACLs()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRNetworkACLs class.
        /// </summary>

        /// <param name="defaultAction">Default action when no other rule matches
        /// Possible values include: &#39;Allow&#39;, &#39;Deny&#39;</param>

        /// <param name="publicNetwork">ACL for requests from public network
        /// </param>

        /// <param name="privateEndpoints">ACLs for requests from private endpoints
        /// </param>
        public SignalRNetworkACLs(string defaultAction = default(string), NetworkACL publicNetwork = default(NetworkACL), System.Collections.Generic.IList<PrivateEndpointACL> privateEndpoints = default(System.Collections.Generic.IList<PrivateEndpointACL>))

        {
            this.DefaultAction = defaultAction;
            this.PublicNetwork = publicNetwork;
            this.PrivateEndpoints = privateEndpoints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets default action when no other rule matches Possible values include: &#39;Allow&#39;, &#39;Deny&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultAction")]
        public string DefaultAction {get; set; }

        /// <summary>
        /// Gets or sets aCL for requests from public network
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicNetwork")]
        public NetworkACL PublicNetwork {get; set; }

        /// <summary>
        /// Gets or sets aCLs for requests from private endpoints
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "privateEndpoints")]
        public System.Collections.Generic.IList<PrivateEndpointACL> PrivateEndpoints {get; set; }
    }
}