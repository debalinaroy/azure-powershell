---
external help file: Az.Synapse-help.xml
Module Name: Az.Synapse
online version: https://learn.microsoft.com/powershell/module/az.synapse/update-azsynapsekustopooldataconnection
schema: 2.0.0
---

# Update-AzSynapseKustoPoolDataConnection

## SYNOPSIS
Updates a data connection.

## SYNTAX

### UpdateExpandedEventHub (Default)
```
Update-AzSynapseKustoPoolDataConnection -DataConnectionName <String> -DatabaseName <String>
 -KustoPoolName <String> -ResourceGroupName <String> [-SubscriptionId <String>] -WorkspaceName <String>
 -Kind <DataConnectionKind> -ConsumerGroup <String> -Location <String> -EventHubResourceId <String>
 [-DataFormat <EventGridDataFormat>] [-EventSystemProperty <String[]>] [-MappingRuleName <String>]
 [-TableName <String>] [-Compression <Compression>] [-DefaultProfile <PSObject>] [-AsJob] [-Break]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateExpandedEventGrid
```
Update-AzSynapseKustoPoolDataConnection -DataConnectionName <String> -DatabaseName <String>
 -KustoPoolName <String> -ResourceGroupName <String> [-SubscriptionId <String>] -WorkspaceName <String>
 -Kind <DataConnectionKind> -ConsumerGroup <String> -Location <String> -EventHubResourceId <String>
 [-DataFormat <EventGridDataFormat>] [-MappingRuleName <String>] [-TableName <String>]
 -StorageAccountResourceId <String> [-BlobStorageEventType <BlobStorageEventType>] [-IgnoreFirstRecord]
 [-DefaultProfile <PSObject>] [-AsJob] [-Break] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateExpandedIotHub
```
Update-AzSynapseKustoPoolDataConnection -DataConnectionName <String> -DatabaseName <String>
 -KustoPoolName <String> -ResourceGroupName <String> [-SubscriptionId <String>] -WorkspaceName <String>
 -Kind <DataConnectionKind> -ConsumerGroup <String> -Location <String> [-DataFormat <EventGridDataFormat>]
 [-EventSystemProperty <String[]>] [-MappingRuleName <String>] [-TableName <String>] -IotHubResourceId <String>
 -SharedAccessPolicyName <String> [-DefaultProfile <PSObject>] [-AsJob] [-Break]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpandedEventHub
```
Update-AzSynapseKustoPoolDataConnection -InputObject <ISynapseIdentity> -Kind <DataConnectionKind>
 -ConsumerGroup <String> -Location <String> -EventHubResourceId <String> [-DataFormat <EventGridDataFormat>]
 [-EventSystemProperty <String[]>] [-MappingRuleName <String>] [-TableName <String>]
 [-Compression <Compression>] [-DefaultProfile <PSObject>] [-AsJob] [-Break]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpandedEventGrid
```
Update-AzSynapseKustoPoolDataConnection -InputObject <ISynapseIdentity> -Kind <DataConnectionKind>
 -ConsumerGroup <String> -Location <String> -EventHubResourceId <String> [-DataFormat <EventGridDataFormat>]
 [-MappingRuleName <String>] [-TableName <String>] -StorageAccountResourceId <String>
 [-BlobStorageEventType <BlobStorageEventType>] [-IgnoreFirstRecord] [-DefaultProfile <PSObject>] [-AsJob]
 [-Break] [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait]
 [-Proxy <Uri>] [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpandedIotHub
```
Update-AzSynapseKustoPoolDataConnection -InputObject <ISynapseIdentity> -Kind <DataConnectionKind>
 -ConsumerGroup <String> -Location <String> [-DataFormat <EventGridDataFormat>]
 [-EventSystemProperty <String[]>] [-MappingRuleName <String>] [-TableName <String>] -IotHubResourceId <String>
 -SharedAccessPolicyName <String> [-DefaultProfile <PSObject>] [-AsJob] [-Break]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-NoWait] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Updates a data connection.

## EXAMPLES

### Example 1: Update an existing EventHub data connection
```powershell
Update-AzSynapseKustoPoolDataConnection -ResourceGroupName testrg -WorkspaceName testws -KustoPoolName testkustopool -DatabaseName testdatabase -Name eventhubdc -Location eastus2 -Kind EventHub -EventHubResourceId "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg/providers/Microsoft.EventHub/namespaces/testeventhubns/eventhubs/testeventhub" -DataFormat "JSON" -ConsumerGroup '$Default' -Compression "None" -TableName "Events" -MappingRuleName "EventsMapping"
```

```output
Kind     Location  Name                                            
----     --------  ----                                            
EventHub East US 2 testws/testkustopool/testdatabase/eventhubdc
```

The above command updates the existing EventHub data connection named "eventhubdc" for the database "testdatabase" in the kusto pool "testkustopool".

### Example 2: Update an existing EventGrid data connection
```powershell
Update-AzSynapseKustoPoolDataConnection -ResourceGroupName testrg -WorkspaceName testws -KustoPoolName testkustopool -DatabaseName testdatabase -Name eventgriddc -Location eastus2 -Kind EventGrid -EventHubResourceId "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg/providers/Microsoft.EventHub/namespaces/testeventhubns/eventhubs/testeventhub" -StorageAccountResourceId "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg/providers/Microsoft.Storage/storageAccounts/teststorage" -DataFormat "JSON" -ConsumerGroup '$Default' -TableName "Events" -MappingRuleName "EventsMapping"
```

```output
Kind      Location  Name
----      --------  ----                                              
EventGrid East US 2 testws/testkustopool/testdatabase/eventgriddc
```

The above command updates the existing EventGrid data connection named "eventgriddc" for the database "testdatabase" in the kusto pool "testkustopool".

### Example 3: Update an existing IotHub data connection
```powershell
Update-AzSynapseKustoPoolDataConnection -ResourceGroupName testrg -WorkspaceName testws -KustoPoolName testkustopool -DatabaseName testdatabase -Name iothubdc -Location eastus2 -Kind IotHub -IotHubResourceId "/subscriptions/051ddeca-1ed6-4d8b-ba6f-1ff561e5f3b3/resourceGroups/ywtest/providers/Microsoft.Devices/IotHubs/ywtestiothub" -SharedAccessPolicyName registryRead -DataFormat "JSON" -ConsumerGroup '$Default' -TableName "Events" -MappingRuleName "EventsMapping"
```

```output
Kind   Location  Name 
----   --------  ----                                           
IotHub East US 2 testws/testkustopool/testdatabase/iothubdc
```

The above command updates the existing IotHub data connection named "iothubdc" for the database "testdatabase" in the kusto pool "testkustopool".

### Example 4: Update an existing EventHub data connection via identity
```powershell
$dataConnection = Get-AzSynapseKustoPoolDataConnection -ResourceGroupName testrg -WorkspaceName testws -KustoPoolName testkustopool -DatabaseName testdatabase -Name eventhubdc
Update-AzSynapseKustoPoolDataConnection -InputObject $dataConnection -Location eastus2 -Kind EventHub -EventHubResourceId "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg/providers/Microsoft.EventHub/namespaces/testeventhubns/eventhubs/testeventhub" -DataFormat "JSON" -ConsumerGroup '$Default' -Compression "None" -TableName "Events" -MappingRuleName "EventsMapping"
```

```output
Kind     Location  Name                                            
----     --------  ----                                            
EventHub East US 2 testws/testkustopool/testdatabase/eventhubdc
```

The above command updates the existing EventHub data connection named "eventhubdc" for the database "testdatabase" in the kusto pool "testkustopool".

### Example 5: Update an existing EventGrid data connection via identity
```powershell
$dataConnection = Get-AzSynapseKustoPoolDataConnection -ResourceGroupName testrg -WorkspaceName testws -KustoPoolName testkustopool -DatabaseName testdatabase -Name eventgriddc
Update-AzSynapseKustoPoolDataConnection -InputObject $dataConnection -Location eastus2 -Kind EventGrid -EventHubResourceId "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg/providers/Microsoft.EventHub/namespaces/testeventhubns/eventhubs/testeventhub" -StorageAccountResourceId "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testrg/providers/Microsoft.Storage/storageAccounts/teststorage" -DataFormat "JSON" -ConsumerGroup '$Default' -TableName "Events" -MappingRuleName "EventsMapping"
```

```output
Kind      Location  Name
----      --------  ----                                              
EventGrid East US 2 testws/testkustopool/testdatabase/eventgriddc
```

The above command updates the existing EventGrid data connection named "eventgriddc" for the database "testdatabase" in the kusto pool "testkustopool".

### Example 6: Update an existing IotHub data connection via identity
```powershell
$dataConnection = Get-AzSynapseKustoPoolDataConnection -ResourceGroupName testrg -WorkspaceName testws -KustoPoolName testkustopool -DatabaseName testdatabase -Name iothubdc
Update-AzSynapseKustoPoolDataConnection -InputObject $dataConnection -Location eastus2 -Kind IotHub -IotHubResourceId "/subscriptions/051ddeca-1ed6-4d8b-ba6f-1ff561e5f3b3/resourceGroups/ywtest/providers/Microsoft.Devices/IotHubs/ywtestiothub" -SharedAccessPolicyName registryRead -DataFormat "JSON" -ConsumerGroup '$Default' -TableName "Events" -MappingRuleName "EventsMapping"
```

```output
Kind   Location  Name 
----   --------  ----                                           
IotHub East US 2 testws/testkustopool/testdatabase/iothubdc
```

The above command updates the existing IotHub data connection named "iothubdc" for the database "testdatabase" in the kusto pool "testkustopool".

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlobStorageEventType
The name of blob storage event type to process.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.BlobStorageEventType
Parameter Sets: UpdateExpandedEventGrid, UpdateViaIdentityExpandedEventGrid
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Break
Wait for .NET debugger to attach

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Compression
The event hub messages compression type.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.Compression
Parameter Sets: UpdateExpandedEventHub, UpdateViaIdentityExpandedEventHub
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConsumerGroup
The event/iot hub consumer group.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseName
The name of the database in the Kusto pool.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedEventHub, UpdateExpandedEventGrid, UpdateExpandedIotHub
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DataConnectionName
The name of the data connection.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedEventHub, UpdateExpandedEventGrid, UpdateExpandedIotHub
Aliases: Name

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DataFormat
The data format of the message.
Optionally the data format can be added to each message.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.EventGridDataFormat
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventHubResourceId
The resource ID of the event hub to be used to create a data connection / event grid is configured to send events.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedEventHub, UpdateExpandedEventGrid, UpdateViaIdentityExpandedEventHub, UpdateViaIdentityExpandedEventGrid
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventSystemProperty
System properties of the event/iot hub.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpandedEventHub, UpdateExpandedIotHub, UpdateViaIdentityExpandedEventHub, UpdateViaIdentityExpandedIotHub
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HttpPipelineAppend
SendAsync Pipeline Steps to be appended to the front of the pipeline

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.SendAsyncStep[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HttpPipelinePrepend
SendAsync Pipeline Steps to be prepended to the front of the pipeline

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.SendAsyncStep[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IgnoreFirstRecord
If set to true, indicates that ingestion should ignore the first record of every file.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpandedEventGrid, UpdateViaIdentityExpandedEventGrid
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity
Parameter Sets: UpdateViaIdentityExpandedEventHub, UpdateViaIdentityExpandedEventGrid, UpdateViaIdentityExpandedIotHub
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IotHubResourceId
The resource ID of the Iot hub to be used to create a data connection.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedIotHub, UpdateViaIdentityExpandedIotHub
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Kind
Kind of the endpoint for the data connection

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.DataConnectionKind
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KustoPoolName
The name of the Kusto pool.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedEventHub, UpdateExpandedEventGrid, UpdateExpandedIotHub
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
Resource location.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MappingRuleName
The mapping rule to be used to ingest the data.
Optionally the mapping information can be added to each message.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Proxy
The URI for the proxy server to use

```yaml
Type: System.Uri
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyCredential
Credentials for a proxy server to use for the remote call

```yaml
Type: System.Management.Automation.PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyUseDefaultCredentials
Use the default credentials for the proxy

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedEventHub, UpdateExpandedEventGrid, UpdateExpandedIotHub
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedAccessPolicyName
The name of the share access policy.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedIotHub, UpdateViaIdentityExpandedIotHub
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageAccountResourceId
The resource ID of the storage account where the data resides.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedEventGrid, UpdateViaIdentityExpandedEventGrid
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: UpdateExpandedEventHub, UpdateExpandedEventGrid, UpdateExpandedIotHub
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -TableName
The table where the data should be ingested.
Optionally the table information can be added to each message.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceName
The name of the workspace

```yaml
Type: System.String
Parameter Sets: UpdateExpandedEventHub, UpdateExpandedEventGrid, UpdateExpandedIotHub
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDataConnection

## NOTES

## RELATED LINKS
