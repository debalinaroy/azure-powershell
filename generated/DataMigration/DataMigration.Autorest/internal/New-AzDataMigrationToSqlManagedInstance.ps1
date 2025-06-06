
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
Create a new database migration to a given SQL Managed Instance.
.Description
Create a new database migration to a given SQL Managed Instance.
.Example
$sourcePassword = ConvertTo-SecureString -String $password -AsPlainText -Force
$filesharePassword = ConvertTo-SecureString -String $password -AsPlainText -Force
New-AzDataMigrationToSqlManagedInstance -ResourceGroupName "MyResourceGroup" -ManagedInstanceName "MyManagedInstance" -TargetDbName "MyDb" -Kind "SqlMI" -Scope "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.Sql/managedInstances/MyManagedInstance" -MigrationService "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyRG/providers/Microsoft.DataMigration/SqlMigrationServices/MySqlMigrationService" -StorageAccountResourceId "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.Storage/storageAccounts/MyStorageAccount" -StorageAccountKey "aaaaacccccoouunntkkkkeeeyyy" -FileSharePath "\\filesharepath.com\SharedBackup\MyBackUps" -FileShareUsername "filesharepath\User" -FileSharePassword $filesharePassword -SourceSqlConnectionAuthentication "SqlAuthentication" -SourceSqlConnectionDataSource "LabServer.database.net" -SourceSqlConnectionUserName "User" -SourceSqlConnectionPassword $sourcePassword -SourceDatabaseName "AdventureWorks"
.Example
New-AzDataMigrationToSqlManagedInstance -ResourceGroupName "MyResourceGroup" -ManagedInstanceName "MyManagedInstance" -TargetDbName "MyDb" -Kind "SqlMI" -Scope "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.Sql/managedInstances/MyManagedInstance" -MigrationService "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyRG/providers/Microsoft.DataMigration/SqlMigrationServices/MySqlMigrationService" -AzureBlobAuthType "ManagedIdentity" -AzureBlobIdentityType "SystemAssigned" -AzureBlobStorageAccountResourceId "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.Storage/storageAccounts/MyStorageAccount" -AzureBlobContainerName "container"
.Example
New-AzDataMigrationToSqlManagedInstance -ResourceGroupName "MyResourceGroup" -ManagedInstanceName "MyManagedInstance" -TargetDbName "MyDb" -Kind "SqlMI" -Scope "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.Sql/managedInstances/MyManagedInstance" -MigrationService "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyRG/providers/Microsoft.DataMigration/SqlMigrationServices/MySqlMigrationService" -AzureBlobAuthType "ManagedIdentity" -AzureBlobIdentityType "UserAssigned" -AzureBlobUserAssignedIdentity "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.ManagedIdentity/userAssignedIdentities/MyUserAssignedIdentity" -AzureBlobStorageAccountResourceId "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.Storage/storageAccounts/MyStorageAccount" -AzureBlobContainerName "container"
.Example
New-AzDataMigrationToSqlManagedInstance -ResourceGroupName "MyResourceGroup" -ManagedInstanceName "MyManagedInstance" -TargetDbName "MyDb" -Kind "SqlMI" -Scope "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.Sql/managedInstances/MyManagedInstance" -MigrationService "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyRG/providers/Microsoft.DataMigration/SqlMigrationServices/MySqlMigrationService" -AzureBlobStorageAccountResourceId "/subscriptions/0000-1111-2222-3333-4444/resourceGroups/MyResourceGroup/providers/Microsoft.Storage/storageAccounts/MyStorageAccount" -AzureBlobContainerName "container" -AzureBlobAccountKey "accountKey"

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IDatabaseMigrationSqlMi
.Link
https://learn.microsoft.com/powershell/module/az.datamigration/new-azdatamigrationtosqlmanagedinstance
#>
function New-AzDataMigrationToSqlManagedInstance {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IDatabaseMigrationSqlMi])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Path')]
    [System.String]
    # .
    ${ManagedInstanceName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Path')]
    [System.String]
    # Name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Path')]
    [System.String]
    # The name of the target database.
    ${TargetDbName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription ID that identifies an Azure subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Storage Account Key.
    ${AzureBlobAccountKey},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.AuthType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.AuthType]
    # Authentication type used for accessing Azure Blob Storage.
    ${AzureBlobAuthType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Blob container name where backups are stored.
    ${AzureBlobContainerName},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.ManagedServiceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.ManagedServiceIdentityType]
    # Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
    ${AzureBlobIdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Resource Id of the storage account where backups are stored.
    ${AzureBlobStorageAccountResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.Security.SecureString]
    # Password for username to access file share location.
    ${FileSharePassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Location as SMB share or local drive where backups are placed.
    ${FileSharePath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Username to access the file share location for backups.
    ${FileShareUsername},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api60.IManagedServiceIdentityUserAssignedIdentities]))]
    [System.Collections.Hashtable]
    # The set of user assigned identities associated with the resource.
    # The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
    # The dictionary values can be empty objects ({}) in requests.
    ${IdentityUserAssignedIdentity},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.ResourceType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.ResourceType]
    # .
    ${Kind},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Resource Id of the Migration Service.
    ${MigrationService},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Offline migration
    ${Offline},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Last backup name for offline migration.
    # This is optional for migrations from file share.
    # If it is not provided, then the service will determine the last backup file name based on latest backup files present in file share.
    ${OfflineConfigurationLastBackupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Resource Id of the target resource.
    ${Scope},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Name of the source database.
    ${SourceDatabaseName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Authentication type.
    ${SourceSqlConnectionAuthentication},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Data source.
    ${SourceSqlConnectionDataSource},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether to encrypt connection or not.
    ${SourceSqlConnectionEncryptConnection},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.Security.SecureString]
    # Password to connect to source SQL.
    ${SourceSqlConnectionPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether to trust server certificate or not.
    ${SourceSqlConnectionTrustServerCertificate},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # User name to connect to source SQL.
    ${SourceSqlConnectionUserName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Storage Account Key.
    ${StorageAccountKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Resource Id of the storage account copying backups.
    ${StorageAccountResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Body')]
    [System.String]
    # Database collation to be used for the target database.
    ${TargetDatabaseCollation},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            CreateExpanded = 'Az.DataMigration.private\New-AzDataMigrationToSqlManagedInstance_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
