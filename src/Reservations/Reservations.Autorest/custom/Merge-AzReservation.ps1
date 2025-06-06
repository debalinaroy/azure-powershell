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
.Synopsis
Merge two reservations into one reservation within the same reservation order.
.Description
Merge two reservations into one reservation within the same reservation order.
#>
function Merge-AzReservation {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationResponse])]
    [CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory, HelpMessage='Reservation Order Id.')]
        [ValidateNotNull()]
        [Alias('ReservationOrderId')]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
        [System.String]
        # Reservation Order Id.
        ${OrderId},
    
        [Parameter(Mandatory, HelpMessage='Reservation Ids.')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Body')]
        [System.String[]]
        # Reservation Ids.
        ${ReservationId},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        try {
            $arr = @()
            foreach ($id in $PSBoundParameters['ReservationId'])
            {
                $re = "\/(?i)\bproviders\/Microsoft.Capacity\/reservationOrders\/[a-zA-Z0-9_-]*\/reservations\/[a-zA-Z0-9_-]*\b"
                if ((-not ($id -match $re)) -AND (-not [guid]::TryParse($id, $([ref][guid]::Empty)))) {
                    Write-Error "One or more IDs in ReservationId array does not match one of these forms:
                                1. /providers/Microsoft.Capacity/reservationOrders/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/reservations/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx
                                2. xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"
                    throw
                }
                if((-not ($id -match $re))) {
                    $arr += '/providers/Microsoft.Capacity/reservationOrders/' + $PSBoundParameters['OrderId'] + '/reservations/' + $id
                } else {
                    $arr += $id
                }
            }
            $PSBoundParameters['ReservationId'] = $arr
            Az.Reservations.internal\Merge-AzReservation @PSBoundParameters
          } catch {
              throw
          }
    }
}
