
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ScaleRuleMetricDimension.
.Description
Create an in-memory object for ScaleRuleMetricDimension.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.ScaleRuleMetricDimension
.Link
https://learn.microsoft.com/powershell/module/Az.Monitor/new-AzAutoscaleScaleRuleMetricDimensionObject
#>
function New-AzAutoscaleScaleRuleMetricDimensionObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.ScaleRuleMetricDimension')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Name of the dimension.")]
        [string]
        $DimensionName,
        [Parameter(Mandatory, HelpMessage="the dimension operator. Only 'Equals' and 'NotEquals' are supported. 'Equals' being equal to any of the values. 'NotEquals' being not equal to all of the values.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.ScaleRuleMetricDimensionOperationType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Support.ScaleRuleMetricDimensionOperationType]
        $Operator,
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Runtime.ParameterBreakingChange("Value", "15.0.0", "7.0.0", "2025/11/03", OldParamaterType="Array", NewParameterType="List")]
        [Parameter(Mandatory, HelpMessage="list of dimension values. For example: [`"App1`",`"App2`"].")]
        [string[]]
        $Value
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Monitor.Autoscale.Models.Api20221001.ScaleRuleMetricDimension]::New()

        if ($PSBoundParameters.ContainsKey('DimensionName')) {
            $Object.DimensionName = $DimensionName
        }
        if ($PSBoundParameters.ContainsKey('Operator')) {
            $Object.Operator = $Operator
        }
        if ($PSBoundParameters.ContainsKey('Value')) {
            $Object.Value = $Value
        }
        return $Object
    }
}

