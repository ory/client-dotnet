/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.140
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
    /// ClientSelfServiceRecoveryLink
    /// </summary>
    [DataContract(Name = "selfServiceRecoveryLink")]
    public partial class ClientSelfServiceRecoveryLink : IEquatable<ClientSelfServiceRecoveryLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSelfServiceRecoveryLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSelfServiceRecoveryLink()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSelfServiceRecoveryLink" /> class.
        /// </summary>
        /// <param name="expiresAt">Recovery Link Expires At  The timestamp when the recovery link expires..</param>
        /// <param name="recoveryLink">Recovery Link  This link can be used to recover the account. (required).</param>
        public ClientSelfServiceRecoveryLink(DateTime expiresAt = default(DateTime), string recoveryLink = default(string))
        {
            // to ensure "recoveryLink" is required (not null)
            if (recoveryLink == null) {
                throw new ArgumentNullException("recoveryLink is a required property for ClientSelfServiceRecoveryLink and cannot be null");
            }
            this.RecoveryLink = recoveryLink;
            this.ExpiresAt = expiresAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Recovery Link Expires At  The timestamp when the recovery link expires.
        /// </summary>
        /// <value>Recovery Link Expires At  The timestamp when the recovery link expires.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Recovery Link  This link can be used to recover the account.
        /// </summary>
        /// <value>Recovery Link  This link can be used to recover the account.</value>
        [DataMember(Name = "recovery_link", IsRequired = true, EmitDefaultValue = false)]
        public string RecoveryLink { get; set; }

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
            sb.Append("class ClientSelfServiceRecoveryLink {\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  RecoveryLink: ").Append(RecoveryLink).Append("\n");
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
            return this.Equals(input as ClientSelfServiceRecoveryLink);
        }

        /// <summary>
        /// Returns true if ClientSelfServiceRecoveryLink instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSelfServiceRecoveryLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSelfServiceRecoveryLink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.RecoveryLink == input.RecoveryLink ||
                    (this.RecoveryLink != null &&
                    this.RecoveryLink.Equals(input.RecoveryLink))
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
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                if (this.RecoveryLink != null)
                {
                    hashCode = (hashCode * 59) + this.RecoveryLink.GetHashCode();
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
