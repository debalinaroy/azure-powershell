---
external help file: Az.ConnectedNetwork-help.xml
Module Name: Az.ConnectedNetwork
online version: https://learn.microsoft.com/powershell/module/Az.ConnectedNetwork/new-azconnectednetworkfunctionvendorconfigurationobject
schema: 2.0.0
---

# New-AzConnectedNetworkFunctionVendorConfigurationObject

## SYNOPSIS
Create an in-memory object for NetworkFunctionVendorConfiguration.

## SYNTAX

```
New-AzConnectedNetworkFunctionVendorConfigurationObject [-NetworkInterface <INetworkInterface[]>]
 [-OSProfileAdminUsername <String>] [-OSProfileCustomData <String>] [-OSProfileCustomDataRequired <Boolean>]
 [-RoleName <String>] [-SshPublicKey <ISshPublicKey[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for NetworkFunctionVendorConfiguration.

## EXAMPLES

### Example 1: New-AzConnectedNetworkFunctionVendorConfigurationObject
```powershell
$ipconf1 = New-AzConnectedNetworkInterfaceIPConfigurationObject -IPAllocationMethod "Dynamic" -IPVersion "IPv4"
$ipconf2 = New-AzConnectedNetworkInterfaceIPConfigurationObject -IPAllocationMethod "Dynamic" -IPVersion "IPv4"
$ip1 = New-AzConnectedNetworkInterfaceObject -IPConfiguration $ipconf1 -Name "mrmmanagementnic1" -VMSwitchType "Management"
$ip2 = New-AzConnectedNetworkInterfaceObject -IPConfiguration $ipconf2 -Name "mrmlannic1" -VMSwitchType "Lan"
$keyData = @{keyData = "ssh-rsa\AAAAB3NzaC1yc2EAAAADAQABAAABAQCyMpVbBgu0kftv1k+z1c3NtcB5CVDoo/X9X1LE2JUjlLlo0luEkFGJk61i53BhiTSTeRmQXN8hAZ7sn4MDUmZK7fWcHouZ2fsJo+ehses3wQPLubWBFw2L/hoSTyXifXMbEBu9SxHgqf1CEKQcvdNiWf4U7npXwjweXW9DtsF5E7h4kxhKJKFI4sNFTIX0IwUB15QEVHoBs92kDwH3fBH3kZZCMBJE/u6kT+XB22crRKkIGlp3a9gcogtOCvP+3xmsP7hjw5+nHxMUwkc/6kYyfTeLwvfI4xrTWpnB5xufts5LW5/U5GOXVg97ix9EXgiV0czThowG5K2xQ649UlJb redmond\userk@n1-azuredev1"; path = $Null}
$keys = @{ }
$key += $keyData
$vendorconf = New-AzConnectedNetworkFunctionVendorConfigurationObject -NetworkInterface $ip1,$ip2 -RoleName hpehss -OSProfileAdminUsername MecUser -OSProfileCustomData $customData -OSProfileCustomDataRequired $True -SshPublicKey $key
```

Creating network interfaces with dynamic method allocation and ip version to IPv4.
And using these to create two network configuration objects with vm switch type.
Creating a ssh key identity, Then using those to create vendor configuration object with role name hpehss, custom data, keyData and network interface array, which will be used in vendor NF creation.

## PARAMETERS

### -NetworkInterface
The network interface configurations.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.INetworkInterface[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OSProfileAdminUsername
Specifies the name of the administrator account.


 **Windows-only restriction:** Cannot end in "." 

 **Disallowed values:** "administrator", "admin", "user", "user1", "test", "user2", "test1", "user3", "admin1", "1", "123", "a", "actuser", "adm", "admin2", "aspnet", "backup", "console", "david", "guest", "john", "owner", "root", "server", "sql", "support", "support_388945a0", "sys", "test2", "test3", "user4", "user5".


 **Minimum-length (Linux):** 1  character 

 **Max-length (Linux):** 64 characters 

 **Max-length (Windows):** 20 characters

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

### -OSProfileCustomData
Specifies a base-64 encoded string of custom data.
The base-64 encoded string is decoded to a binary array that is saved as a file on the virtual machine.
The maximum length of the binary array is 65535 bytes.


 **Note: Do not pass any secrets or passwords in customData property** 

 This property cannot be updated after the VM is created.


 customData is passed to the VM to be saved as a file.
For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/)

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

### -OSProfileCustomDataRequired
Indicates if custom data is required to deploy this role.

```yaml
Type: System.Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleName
The name of the vendor network function role.

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

### -SshPublicKey
The list of SSH public keys used to authenticate with linux based VMs.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.NetworkFunctionVendorConfiguration

## NOTES

## RELATED LINKS
