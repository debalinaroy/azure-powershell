// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for Zone Fault Simulation action.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Zone")]
    public partial class ZoneFaultSimulationContent : FaultSimulationContent
    {
        /// <summary>
        /// Initializes a new instance of the ZoneFaultSimulationContent class.
        /// </summary>
        public ZoneFaultSimulationContent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ZoneFaultSimulationContent class.
        /// </summary>

        /// <param name="force">Force the action to go through without any check on the cluster.
        /// </param>

        /// <param name="constraints">Constraints for Fault Simulation action.
        /// </param>

        /// <param name="zones">Indicates the zones of the fault simulation.
        /// </param>
        public ZoneFaultSimulationContent(bool? force = default(bool?), FaultSimulationConstraints constraints = default(FaultSimulationConstraints), System.Collections.Generic.IList<string> zones = default(System.Collections.Generic.IList<string>))

        : base(force, constraints)
        {
            this.Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates the zones of the fault simulation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "zones")]
        public System.Collections.Generic.IList<string> Zones {get; set; }
    }
}