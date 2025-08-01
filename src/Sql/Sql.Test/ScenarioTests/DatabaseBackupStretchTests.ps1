# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
	.SYNOPSIS
	Test getting restore points from stretch databases
#>
function Test-ListStretchDatabaseRestorePoints
{
	# Setup
	$serverVersion = "12.0";
	$location = Get-Location "Microsoft.Sql" "servers" "west europe"
	$rg = Get-AzResourceGroup -ResourceGroupName "powershell-test-rg"
	$server = Get-AzSqlServer -ServerName "powershell-test-server" -ResourceGroupName $rg.ResourceGroupName


	# Create stretch database with all parameters.
	$databaseName = "powershell-test-db-stretch-db"
	$stretchdb = New-AzSqlDatabase -ResourceGroupName $rg.ResourceGroupName -ServerName $server.ServerName -DatabaseName $databaseName `
		-Edition Stretch -RequestedServiceObjectiveName DS100

	# Get restore points from stretch database.
	$restorePoints = Get-AzSqlDatabaseRestorePoint -ResourceGroupName $rg.ResourceGroupName -ServerName $server.ServerName -DatabaseName $stretchdb.DatabaseName
	Assert-Null $restorePoints # Since the stretch database has just been created, it should not have any discrete restore points.
	
}