// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft Azure Powershell - Trusted Signing")]
[assembly: AssemblyCompany(Microsoft.WindowsAzure.Commands.Common.AzurePowerShell.AssemblyCompany)]
[assembly: AssemblyProduct(Microsoft.WindowsAzure.Commands.Common.AzurePowerShell.AssemblyProduct)]
[assembly: AssemblyCopyright(Microsoft.WindowsAzure.Commands.Common.AzurePowerShell.AssemblyCopyright)]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]

[assembly: Guid("accceef6-8113-453a-a31c-4f2ce57893d6")]
[assembly: AssemblyVersion("0.1.1")]
[assembly: AssemblyFileVersion("0.1.1")]
#if !SIGN
[assembly: InternalsVisibleTo("Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Test")]
#endif
