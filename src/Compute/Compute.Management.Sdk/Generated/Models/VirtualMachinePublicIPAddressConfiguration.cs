// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machines IP Configuration's PublicIPAddress
    /// configuration
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachinePublicIPAddressConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachinePublicIPAddressConfiguration class.
        /// </summary>
        public VirtualMachinePublicIPAddressConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachinePublicIPAddressConfiguration class.
        /// </summary>
        /// <param name="name">The publicIP address configuration name.</param>
        /// <param name="idleTimeoutInMinutes">The idle timeout of the public
        /// IP address.</param>
        /// <param name="deleteOption">Specify what happens to the public IP
        /// address when the VM is deleted. Possible values include: 'Delete',
        /// 'Detach'</param>
        /// <param name="dnsSettings">The dns settings to be applied on the
        /// publicIP addresses .</param>
        /// <param name="ipTags">The list of IP tags associated with the public
        /// IP address.</param>
        /// <param name="publicIPPrefix">The PublicIPPrefix from which to
        /// allocate publicIP addresses.</param>
        /// <param name="publicIPAddressVersion">Available from Api-Version
        /// 2019-07-01 onwards, it represents whether the specific
        /// ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'. Possible values include: 'IPv4',
        /// 'IPv6'</param>
        /// <param name="publicIPAllocationMethod">Specify the public IP
        /// allocation type. Possible values include: 'Dynamic',
        /// 'Static'</param>
        /// <param name="sku">Describes the public IP Sku. It can only be set
        /// with OrchestrationMode as Flexible.</param>
        public VirtualMachinePublicIPAddressConfiguration(string name, int? idleTimeoutInMinutes = default(int?), string deleteOption = default(string), VirtualMachinePublicIPAddressDnsSettingsConfiguration dnsSettings = default(VirtualMachinePublicIPAddressDnsSettingsConfiguration), IList<VirtualMachineIpTag> ipTags = default(IList<VirtualMachineIpTag>), SubResource publicIPPrefix = default(SubResource), string publicIPAddressVersion = default(string), string publicIPAllocationMethod = default(string), PublicIPAddressSku sku = default(PublicIPAddressSku))
        {
            Name = name;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            DeleteOption = deleteOption;
            DnsSettings = dnsSettings;
            IpTags = ipTags;
            PublicIPPrefix = publicIPPrefix;
            PublicIPAddressVersion = publicIPAddressVersion;
            PublicIPAllocationMethod = publicIPAllocationMethod;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the publicIP address configuration name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the idle timeout of the public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets specify what happens to the public IP address when the
        /// VM is deleted. Possible values include: 'Delete', 'Detach'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleteOption")]
        public string DeleteOption { get; set; }

        /// <summary>
        /// Gets or sets the dns settings to be applied on the publicIP
        /// addresses .
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public VirtualMachinePublicIPAddressDnsSettingsConfiguration DnsSettings { get; set; }

        /// <summary>
        /// Gets or sets the list of IP tags associated with the public IP
        /// address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipTags")]
        public IList<VirtualMachineIpTag> IpTags { get; set; }

        /// <summary>
        /// Gets or sets the PublicIPPrefix from which to allocate publicIP
        /// addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPPrefix")]
        public SubResource PublicIPPrefix { get; set; }

        /// <summary>
        /// Gets or sets available from Api-Version 2019-07-01 onwards, it
        /// represents whether the specific ipconfiguration is IPv4 or IPv6.
        /// Default is taken as IPv4. Possible values are: 'IPv4' and 'IPv6'.
        /// Possible values include: 'IPv4', 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddressVersion")]
        public string PublicIPAddressVersion { get; set; }

        /// <summary>
        /// Gets or sets specify the public IP allocation type. Possible values
        /// include: 'Dynamic', 'Static'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAllocationMethod")]
        public string PublicIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets describes the public IP Sku. It can only be set with
        /// OrchestrationMode as Flexible.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public PublicIPAddressSku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (DnsSettings != null)
            {
                DnsSettings.Validate();
            }
        }
    }
}
