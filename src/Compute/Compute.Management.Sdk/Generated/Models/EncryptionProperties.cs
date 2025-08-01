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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Configuration of key for data encryption
    /// </summary>
    public partial class EncryptionProperties
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionProperties class.
        /// </summary>
        public EncryptionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionProperties class.
        /// </summary>
        /// <param name="status">Indicates whether or not the encryption is
        /// enabled for container registry. Possible values include: 'enabled',
        /// 'disabled'</param>
        /// <param name="keyVaultProperties">Key vault properties.</param>
        public EncryptionProperties(string status = default(string), KeyVaultProperties keyVaultProperties = default(KeyVaultProperties))
        {
            Status = status;
            KeyVaultProperties = keyVaultProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether or not the encryption is enabled for
        /// container registry. Possible values include: 'enabled', 'disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets key vault properties.
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultProperties")]
        public KeyVaultProperties KeyVaultProperties { get; set; }

    }
}
