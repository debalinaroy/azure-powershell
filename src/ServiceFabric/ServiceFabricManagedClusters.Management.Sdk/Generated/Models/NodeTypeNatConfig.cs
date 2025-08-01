// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// Provides information about NAT configuration on the default public Load
    /// Balancer for the node type.
    /// </summary>
    public partial class NodeTypeNatConfig
    {
        /// <summary>
        /// Initializes a new instance of the NodeTypeNatConfig class.
        /// </summary>
        public NodeTypeNatConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeTypeNatConfig class.
        /// </summary>

        /// <param name="backendPort">The internal port for the NAT configuration.
        /// </param>

        /// <param name="frontendPortRangeStart">The port range start for the external endpoint.
        /// </param>

        /// <param name="frontendPortRangeEnd">The port range end for the external endpoint.
        /// </param>
        public NodeTypeNatConfig(int? backendPort = default(int?), int? frontendPortRangeStart = default(int?), int? frontendPortRangeEnd = default(int?))

        {
            this.BackendPort = backendPort;
            this.FrontendPortRangeStart = frontendPortRangeStart;
            this.FrontendPortRangeEnd = frontendPortRangeEnd;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the internal port for the NAT configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backendPort")]
        public int? BackendPort {get; set; }

        /// <summary>
        /// Gets or sets the port range start for the external endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "frontendPortRangeStart")]
        public int? FrontendPortRangeStart {get; set; }

        /// <summary>
        /// Gets or sets the port range end for the external endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "frontendPortRangeEnd")]
        public int? FrontendPortRangeEnd {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.BackendPort != null)
            {
                if (this.BackendPort > 65535)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "BackendPort", 65535);
                }
                if (this.BackendPort < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "BackendPort", 1);
                }
            }
            if (this.FrontendPortRangeStart != null)
            {
                if (this.FrontendPortRangeStart > 65534)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "FrontendPortRangeStart", 65534);
                }
                if (this.FrontendPortRangeStart < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "FrontendPortRangeStart", 1);
                }
            }
            if (this.FrontendPortRangeEnd != null)
            {
                if (this.FrontendPortRangeEnd > 65534)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "FrontendPortRangeEnd", 65534);
                }
                if (this.FrontendPortRangeEnd < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "FrontendPortRangeEnd", 1);
                }
            }
        }
    }
}