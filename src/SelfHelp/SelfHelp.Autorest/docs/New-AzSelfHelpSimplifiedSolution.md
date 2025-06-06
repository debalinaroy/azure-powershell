---
external help file:
Module Name: Az.SelfHelp
online version: https://learn.microsoft.com/powershell/module/az.selfhelp/new-azselfhelpsimplifiedsolution
schema: 2.0.0
---

# New-AzSelfHelpSimplifiedSolution

## SYNOPSIS
create a simplified Solutions for the specific Azure resource or subscription using the inputs ‘solutionId and requiredInputs’ from discovery solutions.
In the absence of the ‘Parameters’ it is likely that some of the simplified Solutions might fail execution, and you might see an empty response.
\<br/\>\<br/\> \<b\>Note:\</b\>  \<br/\>1.
‘requiredInputs’ from Discovery solutions response must be passed via ‘parameters’ in the request body of simplified Solutions API.
\<br/\>

## SYNTAX

### CreateExpanded (Default)
```
New-AzSelfHelpSimplifiedSolution -Scope <String> -SResourceName <String> [-Parameter <Hashtable>]
 [-SolutionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzSelfHelpSimplifiedSolution -InputObject <ISelfHelpIdentity> [-Parameter <Hashtable>]
 [-SolutionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaJsonFilePath
```
New-AzSelfHelpSimplifiedSolution -Scope <String> -SResourceName <String> -JsonFilePath <String>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaJsonString
```
New-AzSelfHelpSimplifiedSolution -Scope <String> -SResourceName <String> -JsonString <String>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
create a simplified Solutions for the specific Azure resource or subscription using the inputs ‘solutionId and requiredInputs’ from discovery solutions.
In the absence of the ‘Parameters’ it is likely that some of the simplified Solutions might fail execution, and you might see an empty response.
\<br/\>\<br/\> \<b\>Note:\</b\>  \<br/\>1.
‘requiredInputs’ from Discovery solutions response must be passed via ‘parameters’ in the request body of simplified Solutions API.
\<br/\>

## EXAMPLES

### Example 1: Create a new simplified solution for a resource
```powershell
$resourceName = "sampleRName"
$solutionId = "9004345-7759"
$parameters = [ordered]@{ 

    "SearchText" = "Billing" 
} 
New-AzSelfHelpSimplifiedSolution -Scope "/subscriptions/6bded6d5-a6af-43e1-96d3-bf71f6f5f8ba/resourceGroups/aits-data-inestion/providers/Microsoft.KeyVault/vaults/kv-akshayko519290291381" -SResourceName $resourceName -SolutionId $solutionId -Parameter $parameters
```

```output
Name        SystemDataCreatedAt SystemDataCreatedBy SystemDataCreatedByType SystemDataLastModifiedAt SystemDataLastModifiedBy SystemDataLastModifiedByType ResourceGroupName
----        ------------------- ------------------- ----------------------- ------------------------ ------------------------ ---------------------------- -----------------
sampleRName    

```

Creates Simplified Solutions for an Azure subscription using 'solutionId' from Discovery Solutions as the input.

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
Type: Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISelfHelpIdentity
Parameter Sets: CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonString
Aliases:

Required: True
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

### -Parameter
Client input parameters to run Simplified Solutions

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scope
scope = resourceUri of affected resource.\<br/\> For example: /subscriptions/0d0fcd2e-c4fd-4349-8497-200edb3923c6/resourcegroups/myresourceGroup/providers/Microsoft.KeyVault/vaults/test-keyvault-non-read

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SolutionId
Solution Id to identify single Simplified Solution.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SResourceName
Simplified Solutions Resource Name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases: SimplifiedSolutionsResourceName

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

### Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISelfHelpIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResource

## NOTES

## RELATED LINKS

