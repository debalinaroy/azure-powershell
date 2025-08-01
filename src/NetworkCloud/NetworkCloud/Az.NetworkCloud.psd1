#
# Module manifest for module 'Az.NetworkCloud'
#
# Generated by: Microsoft Corporation
#
# Generated on: 06/27/2025
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '1.1.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'c1da95ce-b8cb-46c5-bb1c-80e3132dbb72'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell: NetworkCloud cmdlets'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '4.2.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'NetworkCloud.Autorest/bin/Az.NetworkCloud.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'NetworkCloud.Autorest/Az.NetworkCloud.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('NetworkCloud.Autorest/Az.NetworkCloud.psm1')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Deploy-AzNetworkCloudCluster',
               'Disable-AzNetworkCloudStorageApplianceRemoteVendorManagement',
               'Enable-AzNetworkCloudStorageApplianceRemoteVendorManagement',
               'Get-AzNetworkCloudAgentPool', 'Get-AzNetworkCloudBareMetalMachine',
               'Get-AzNetworkCloudBareMetalMachineKeySet',
               'Get-AzNetworkCloudBmcKeySet', 'Get-AzNetworkCloudCluster',
               'Get-AzNetworkCloudClusterManager', 'Get-AzNetworkCloudConsole',
               'Get-AzNetworkCloudKubernetesCluster',
               'Get-AzNetworkCloudKubernetesClusterFeature',
               'Get-AzNetworkCloudL2Network', 'Get-AzNetworkCloudL3Network',
               'Get-AzNetworkCloudMetricsConfiguration', 'Get-AzNetworkCloudRack',
               'Get-AzNetworkCloudRackSku', 'Get-AzNetworkCloudServicesNetwork',
               'Get-AzNetworkCloudStorageAppliance',
               'Get-AzNetworkCloudTrunkedNetwork',
               'Get-AzNetworkCloudVirtualMachine', 'Get-AzNetworkCloudVolume',
               'Invoke-AzNetworkCloudBareMetalMachineCordon',
               'Invoke-AzNetworkCloudBareMetalMachineDataExtract',
               'Invoke-AzNetworkCloudBareMetalMachineReimage',
               'Invoke-AzNetworkCloudBareMetalMachineReplace',
               'Invoke-AzNetworkCloudBareMetalMachineRunCommand',
               'Invoke-AzNetworkCloudBareMetalMachineRunReadCommand',
               'Invoke-AzNetworkCloudBareMetalMachineUncordon',
               'Invoke-AzNetworkCloudClusterContinueVersionUpdate',
               'Invoke-AzNetworkCloudClusterVersionUpdate',
               'Invoke-AzNetworkCloudScanClusterRuntime',
               'Invoke-AzNetworkCloudVirtualMachineReimage',
               'New-AzNetworkCloudAgentPool',
               'New-AzNetworkCloudBareMetalMachineConfigurationDataObject',
               'New-AzNetworkCloudBareMetalMachineKeySet',
               'New-AzNetworkCloudBgpAdvertisementObject',
               'New-AzNetworkCloudBgpServiceLoadBalancerConfigurationObject',
               'New-AzNetworkCloudBmcKeySet', 'New-AzNetworkCloudCluster',
               'New-AzNetworkCloudClusterManager', 'New-AzNetworkCloudConsole',
               'New-AzNetworkCloudControlPlaneNodeConfigurationObject',
               'New-AzNetworkCloudEgressEndpointObject',
               'New-AzNetworkCloudEndpointDependencyObject',
               'New-AzNetworkCloudInitialAgentPoolConfigurationObject',
               'New-AzNetworkCloudIpAddressPoolObject',
               'New-AzNetworkCloudKeySetUserObject',
               'New-AzNetworkCloudKubernetesCluster',
               'New-AzNetworkCloudKubernetesClusterFeature',
               'New-AzNetworkCloudL2Network', 'New-AzNetworkCloudL3Network',
               'New-AzNetworkCloudL3NetworkAttachmentConfigurationObject',
               'New-AzNetworkCloudMetricsConfiguration',
               'New-AzNetworkCloudNetworkAttachmentObject',
               'New-AzNetworkCloudRackDefinitionObject',
               'New-AzNetworkCloudServiceLoadBalancerBgpPeerObject',
               'New-AzNetworkCloudServicesNetwork',
               'New-AzNetworkCloudStorageApplianceConfigurationDataObject',
               'New-AzNetworkCloudTrunkedNetwork',
               'New-AzNetworkCloudVirtualMachine',
               'New-AzNetworkCloudVirtualMachinePlacementHintObject',
               'New-AzNetworkCloudVolume', 'Remove-AzNetworkCloudAgentPool',
               'Remove-AzNetworkCloudBareMetalMachineKeySet',
               'Remove-AzNetworkCloudBmcKeySet', 'Remove-AzNetworkCloudCluster',
               'Remove-AzNetworkCloudClusterManager',
               'Remove-AzNetworkCloudConsole',
               'Remove-AzNetworkCloudKubernetesCluster',
               'Remove-AzNetworkCloudKubernetesClusterFeature',
               'Remove-AzNetworkCloudL2Network', 'Remove-AzNetworkCloudL3Network',
               'Remove-AzNetworkCloudMetricsConfiguration',
               'Remove-AzNetworkCloudServicesNetwork',
               'Remove-AzNetworkCloudTrunkedNetwork',
               'Remove-AzNetworkCloudVirtualMachine',
               'Remove-AzNetworkCloudVolume',
               'Restart-AzNetworkCloudBareMetalMachine',
               'Restart-AzNetworkCloudKubernetesClusterNode',
               'Restart-AzNetworkCloudVirtualMachine',
               'Start-AzNetworkCloudBareMetalMachine',
               'Start-AzNetworkCloudVirtualMachine',
               'Stop-AzNetworkCloudBareMetalMachine',
               'Stop-AzNetworkCloudVirtualMachine',
               'Update-AzNetworkCloudAgentPool',
               'Update-AzNetworkCloudBareMetalMachine',
               'Update-AzNetworkCloudBareMetalMachineKeySet',
               'Update-AzNetworkCloudBmcKeySet', 'Update-AzNetworkCloudCluster',
               'Update-AzNetworkCloudClusterManager',
               'Update-AzNetworkCloudConsole',
               'Update-AzNetworkCloudKubernetesCluster',
               'Update-AzNetworkCloudKubernetesClusterFeature',
               'Update-AzNetworkCloudL2Network', 'Update-AzNetworkCloudL3Network',
               'Update-AzNetworkCloudMetricsConfiguration',
               'Update-AzNetworkCloudRack', 'Update-AzNetworkCloudServicesNetwork',
               'Update-AzNetworkCloudStorageAppliance',
               'Update-AzNetworkCloudTrunkedNetwork',
               'Update-AzNetworkCloudVirtualMachine',
               'Update-AzNetworkCloudVolume'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'NetworkCloud'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Upgraded nuget package to signed package.
* Upgraded API version to 2024-07-01'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

