
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
Create an in-memory object for ConfigurationServiceGitRepository.
.Description
Create an in-memory object for ConfigurationServiceGitRepository.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ConfigurationServiceGitRepository
.Link
https://learn.microsoft.com/powershell/module/Az.SpringCloud/new-azspringcloudconfigurationservicegitrepositoryobject
#>
function New-AzSpringCloudConfigurationServiceGitRepositoryObject {
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.CmdletBreakingChange("19.3.0", "0.3.2", "2028/03/31", ChangeDescription = "Azure Spring Apps, including the Standard consumption and dedicated (currently in Public Preview only), Basic, Standard, and Enterprise plans, will be retired, please see details on https://aka.ms/asaretirement.")]
    [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ConfigurationServiceGitRepository')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Public sshKey of git repository.")]
        [string]
        $HostKey,
        [Parameter(HelpMessage="SshKey algorithm of git repository.")]
        [string]
        $HostKeyAlgorithm,
        [Parameter(Mandatory, HelpMessage="Label of the repository.")]
        [string]
        $Label,
        [Parameter(Mandatory, HelpMessage="Name of the repository.")]
        [string]
        $Name,
        [Parameter(HelpMessage="Password of git repository basic auth.")]
        [string]
        $Password,
        [Parameter(Mandatory, HelpMessage="Collection of patterns of the repository.")]
        [string[]]
        $Pattern,
        [Parameter(HelpMessage="Private sshKey algorithm of git repository.")]
        [string]
        $PrivateKey,
        [Parameter(HelpMessage="Searching path of the repository.")]
        [string[]]
        $SearchPath,
        [Parameter(HelpMessage="Strict host key checking or not.")]
        [bool]
        $StrictHostKeyChecking,
        [Parameter(Mandatory, HelpMessage="URI of the repository.")]
        [string]
        $Uri,
        [Parameter(HelpMessage="Username of git repository basic auth.")]
        [string]
        $Username
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ConfigurationServiceGitRepository]::New()

        if ($PSBoundParameters.ContainsKey('HostKey')) {
            $Object.HostKey = $HostKey
        }
        if ($PSBoundParameters.ContainsKey('HostKeyAlgorithm')) {
            $Object.HostKeyAlgorithm = $HostKeyAlgorithm
        }
        if ($PSBoundParameters.ContainsKey('Label')) {
            $Object.Label = $Label
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        if ($PSBoundParameters.ContainsKey('Password')) {
            $Object.Password = $Password
        }
        if ($PSBoundParameters.ContainsKey('Pattern')) {
            $Object.Pattern = $Pattern
        }
        if ($PSBoundParameters.ContainsKey('PrivateKey')) {
            $Object.PrivateKey = $PrivateKey
        }
        if ($PSBoundParameters.ContainsKey('SearchPath')) {
            $Object.SearchPath = $SearchPath
        }
        if ($PSBoundParameters.ContainsKey('StrictHostKeyChecking')) {
            $Object.StrictHostKeyChecking = $StrictHostKeyChecking
        }
        if ($PSBoundParameters.ContainsKey('Uri')) {
            $Object.Uri = $Uri
        }
        if ($PSBoundParameters.ContainsKey('Username')) {
            $Object.Username = $Username
        }
        return $Object
    }
}

