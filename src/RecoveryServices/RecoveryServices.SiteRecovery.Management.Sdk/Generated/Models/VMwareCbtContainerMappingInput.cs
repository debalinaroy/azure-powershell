// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// VMwareCbt container mapping input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareCbt")]
    public partial class VMwareCbtContainerMappingInput : ReplicationProviderSpecificContainerMappingInput
    {
        /// <summary>
        /// Initializes a new instance of the VMwareCbtContainerMappingInput class.
        /// </summary>
        public VMwareCbtContainerMappingInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareCbtContainerMappingInput class.
        /// </summary>

        /// <param name="keyVaultId">The target key vault ARM Id.
        /// </param>

        /// <param name="keyVaultUri">The target key vault URL.
        /// </param>

        /// <param name="storageAccountId">The storage account ARM Id.
        /// </param>

        /// <param name="storageAccountSasSecretName">The secret name of the storage account.
        /// </param>

        /// <param name="serviceBusConnectionStringSecretName">The secret name of the service bus connection string.
        /// </param>

        /// <param name="targetLocation">The target location.
        /// </param>
        public VMwareCbtContainerMappingInput(string storageAccountId, string targetLocation, string keyVaultId = default(string), string keyVaultUri = default(string), string storageAccountSasSecretName = default(string), string serviceBusConnectionStringSecretName = default(string))

        {
            this.KeyVaultId = keyVaultId;
            this.KeyVaultUri = keyVaultUri;
            this.StorageAccountId = storageAccountId;
            this.StorageAccountSasSecretName = storageAccountSasSecretName;
            this.ServiceBusConnectionStringSecretName = serviceBusConnectionStringSecretName;
            this.TargetLocation = targetLocation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the target key vault ARM Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultId")]
        public string KeyVaultId {get; set; }

        /// <summary>
        /// Gets or sets the target key vault URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultUri")]
        public string KeyVaultUri {get; set; }

        /// <summary>
        /// Gets or sets the storage account ARM Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId {get; set; }

        /// <summary>
        /// Gets or sets the secret name of the storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccountSasSecretName")]
        public string StorageAccountSasSecretName {get; set; }

        /// <summary>
        /// Gets or sets the secret name of the service bus connection string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceBusConnectionStringSecretName")]
        public string ServiceBusConnectionStringSecretName {get; set; }

        /// <summary>
        /// Gets or sets the target location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetLocation")]
        public string TargetLocation {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.StorageAccountId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "StorageAccountId");
            }
            if (this.TargetLocation == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TargetLocation");
            }






        }
    }
}