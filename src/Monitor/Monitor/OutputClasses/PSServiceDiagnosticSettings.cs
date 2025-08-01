﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.Monitor.Models;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Insights.OutputClasses
{
    /// <summary>
    /// Wraps around the DiagnosticSettings
    /// </summary>
    public class PSServiceDiagnosticSettings : DiagnosticSettingsResource
    {
        /// <summary>
        /// Sets or gets the Location of the Diagnostic Setting
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Sets or gets the Tags of the Diagnostic Setting
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }

        //public new string Id { get; set; }

        //public new string Name { get; set; } = "service";

        public PSServiceDiagnosticSettings() { }

        public PSServiceDiagnosticSettings(string id = default(string), string name = default(string)) : base(id, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PSServiceDiagnosticSettings class.
        /// </summary>
        public PSServiceDiagnosticSettings(DiagnosticSettingsResource serviceDiagnosticSettings)
            : base(
                name: serviceDiagnosticSettings?.Name,
                id: serviceDiagnosticSettings?.Id,
                type: serviceDiagnosticSettings?.Type,
                metrics: serviceDiagnosticSettings?.Metrics,
                logs: serviceDiagnosticSettings?.Logs)
        {
            if (serviceDiagnosticSettings != null)
            {
                this.StorageAccountId = serviceDiagnosticSettings.StorageAccountId;
                this.EventHubName = serviceDiagnosticSettings.EventHubName;
                this.ServiceBusRuleId = serviceDiagnosticSettings.ServiceBusRuleId;
                this.EventHubAuthorizationRuleId = serviceDiagnosticSettings.EventHubAuthorizationRuleId;

                if (serviceDiagnosticSettings.Metrics != null)
                {
                    this.Metrics = new List<MetricSettings>();
                    foreach (MetricSettings metricSettings in serviceDiagnosticSettings.Metrics)
                    {
                        this.Metrics.Add(metricSettings);
                    }
                }

                if (serviceDiagnosticSettings.Logs != null)
                {
                    this.Logs = new List<LogSettings>();
                    foreach (LogSettings logSettings in serviceDiagnosticSettings.Logs)
                    {
                        this.Logs.Add(logSettings);
                    }
                }

                this.WorkspaceId = serviceDiagnosticSettings.WorkspaceId;
                this.LogAnalyticsDestinationType = serviceDiagnosticSettings.LogAnalyticsDestinationType;
            }
        }
    }
}
