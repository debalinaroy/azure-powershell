﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Microsoft.Azure.Management.Network.Models;
using Microsoft.WindowsAzure.Commands.Common.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSApplicationGatewayWebApplicationFirewallPolicy : PSTopLevelResource
    {
        public List<PSApplicationGatewayFirewallCustomRule> CustomRules { get; set; }

        public PSApplicationGatewayFirewallPolicySettings PolicySettings { get; set; }

        public PSApplicationGatewayFirewallPolicyManagedRules ManagedRules { get; set; }

        // CustomBlockResponse fields to be mapped from inside the policy settings
        // to be shown as response in PS (Feature parity with AFD WAF Policy)
        public int? CustomBlockResponseStatusCode { get; set; }

        public string CustomBlockResponseBody { get; set; }

        public System.Collections.Generic.IList<ApplicationGateway> ApplicationGateways { get; set; }

        public System.Collections.Generic.IList<ApplicationGatewayForContainersReferenceDefinition> ApplicationGatewayForContainers { get; set; }
    }
}