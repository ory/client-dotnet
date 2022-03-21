/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.141
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientAdminCreateIdentityBody
    /// </summary>
    [DataContract(Name = "adminCreateIdentityBody")]
    public partial class ClientAdminCreateIdentityBody : IEquatable<ClientAdminCreateIdentityBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateIdentityBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientAdminCreateIdentityBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateIdentityBody" /> class.
        /// </summary>
        /// <param name="credentials">credentials.</param>
        /// <param name="recoveryAddresses">RecoveryAddresses contains all the addresses that can be used to recover an identity.  Use this structure to import recovery addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update..</param>
        /// <param name="schemaId">SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. (required).</param>
        /// <param name="state">state.</param>
        /// <param name="traits">Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;. (required).</param>
        /// <param name="verifiableAddresses">VerifiableAddresses contains all the addresses that can be verified by the user.  Use this structure to import verified addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update..</param>
        public ClientAdminCreateIdentityBody(ClientAdminIdentityImportCredentials credentials = default(ClientAdminIdentityImportCredentials), List<ClientRecoveryAddress> recoveryAddresses = default(List<ClientRecoveryAddress>), string schemaId = default(string), ClientIdentityState state = default(ClientIdentityState), Object traits = default(Object), List<ClientVerifiableIdentityAddress> verifiableAddresses = default(List<ClientVerifiableIdentityAddress>))
        {
            // to ensure "schemaId" is required (not null)
            if (schemaId == null) {
                throw new ArgumentNullException("schemaId is a required property for ClientAdminCreateIdentityBody and cannot be null");
            }
            this.SchemaId = schemaId;
            // to ensure "traits" is required (not null)
            if (traits == null) {
                throw new ArgumentNullException("traits is a required property for ClientAdminCreateIdentityBody and cannot be null");
            }
            this.Traits = traits;
            this.Credentials = credentials;
            this.RecoveryAddresses = recoveryAddresses;
            this.State = state;
            this.VerifiableAddresses = verifiableAddresses;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public ClientAdminIdentityImportCredentials Credentials { get; set; }

        /// <summary>
        /// RecoveryAddresses contains all the addresses that can be used to recover an identity.  Use this structure to import recovery addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.
        /// </summary>
        /// <value>RecoveryAddresses contains all the addresses that can be used to recover an identity.  Use this structure to import recovery addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.</value>
        [DataMember(Name = "recovery_addresses", EmitDefaultValue = false)]
        public List<ClientRecoveryAddress> RecoveryAddresses { get; set; }

        /// <summary>
        /// SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits.
        /// </summary>
        /// <value>SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits.</value>
        [DataMember(Name = "schema_id", IsRequired = true, EmitDefaultValue = false)]
        public string SchemaId { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public ClientIdentityState State { get; set; }

        /// <summary>
        /// Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;.
        /// </summary>
        /// <value>Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;.</value>
        [DataMember(Name = "traits", IsRequired = true, EmitDefaultValue = false)]
        public Object Traits { get; set; }

        /// <summary>
        /// VerifiableAddresses contains all the addresses that can be verified by the user.  Use this structure to import verified addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.
        /// </summary>
        /// <value>VerifiableAddresses contains all the addresses that can be verified by the user.  Use this structure to import verified addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.</value>
        [DataMember(Name = "verifiable_addresses", EmitDefaultValue = false)]
        public List<ClientVerifiableIdentityAddress> VerifiableAddresses { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientAdminCreateIdentityBody {\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  RecoveryAddresses: ").Append(RecoveryAddresses).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  VerifiableAddresses: ").Append(VerifiableAddresses).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientAdminCreateIdentityBody);
        }

        /// <summary>
        /// Returns true if ClientAdminCreateIdentityBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAdminCreateIdentityBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAdminCreateIdentityBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.RecoveryAddresses == input.RecoveryAddresses ||
                    this.RecoveryAddresses != null &&
                    input.RecoveryAddresses != null &&
                    this.RecoveryAddresses.SequenceEqual(input.RecoveryAddresses)
                ) && 
                (
                    this.SchemaId == input.SchemaId ||
                    (this.SchemaId != null &&
                    this.SchemaId.Equals(input.SchemaId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Traits == input.Traits ||
                    (this.Traits != null &&
                    this.Traits.Equals(input.Traits))
                ) && 
                (
                    this.VerifiableAddresses == input.VerifiableAddresses ||
                    this.VerifiableAddresses != null &&
                    input.VerifiableAddresses != null &&
                    this.VerifiableAddresses.SequenceEqual(input.VerifiableAddresses)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                if (this.RecoveryAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.RecoveryAddresses.GetHashCode();
                }
                if (this.SchemaId != null)
                {
                    hashCode = (hashCode * 59) + this.SchemaId.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Traits != null)
                {
                    hashCode = (hashCode * 59) + this.Traits.GetHashCode();
                }
                if (this.VerifiableAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.VerifiableAddresses.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
