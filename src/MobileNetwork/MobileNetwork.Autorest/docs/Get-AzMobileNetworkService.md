---
external help file:
Module Name: Az.MobileNetwork
online version: https://learn.microsoft.com/powershell/module/az.mobilenetwork/get-azmobilenetworkservice
schema: 2.0.0
---

# Get-AzMobileNetworkService

## SYNOPSIS
Gets information about the specified service.

## SYNTAX

### List (Default)
```
Get-AzMobileNetworkService -MobileNetworkName <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzMobileNetworkService -MobileNetworkName <String> -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzMobileNetworkService -InputObject <IMobileNetworkIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### GetViaIdentityMobileNetwork
```
Get-AzMobileNetworkService -MobileNetworkInputObject <IMobileNetworkIdentity> -Name <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Gets information about the specified service.

## EXAMPLES

### Example 1: List information about the specified service by MobileNetwork Name.
```powershell
Get-AzMobileNetworkService -MobileNetworkName azps-mn -ResourceGroupName azps_test_group
```

```output
Location Name            ResourceGroupName ProvisioningState Precedence MaximumBitRateDownlink MaximumBitRateUplink QoPolicyAllocationAndRetentionPriorityLevel QoPolicyFiveQi
-------- ----            ----------------- ----------------- ---------- ---------------------- -------------------- ------------------------------------------- --------------
eastus   azps-mn-service azps_test_group   Succeeded         0          1 Gbps                 500 Mbps             9                                           9
```

List information about the specified service by MobileNetwork Name.

### Example 2: Get information about the specified service.
```powershell
Get-AzMobileNetworkService -MobileNetworkName azps-mn -ResourceGroupName azps_test_group -Name azps-mn-service
```

```output
Location Name            ResourceGroupName ProvisioningState Precedence MaximumBitRateDownlink MaximumBitRateUplink QoPolicyAllocationAndRetentionPriorityLevel QoPolicyFiveQi
-------- ----            ----------------- ----------------- ---------- ---------------------- -------------------- ------------------------------------------- --------------
eastus   azps-mn-service azps_test_group   Succeeded         0          1 Gbps                 500 Mbps             9                                           9
```

Get information about the specified service.

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

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

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MobileNetworkInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkIdentity
Parameter Sets: GetViaIdentityMobileNetwork
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MobileNetworkName
The name of the mobile network.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the service.
You must not use any of the following reserved strings - 'default', 'requested' or 'service'

```yaml
Type: System.String
Parameter Sets: Get, GetViaIdentityMobileNetwork
Aliases: ServiceName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Get, List
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
Type: System.String[]
Parameter Sets: Get, List
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IService

## NOTES

## RELATED LINKS

