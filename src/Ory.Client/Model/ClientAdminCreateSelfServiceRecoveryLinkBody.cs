/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.40
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
    /// ClientAdminCreateSelfServiceRecoveryLinkBody
    /// </summary>
    [DataContract(Name = "adminCreateSelfServiceRecoveryLinkBody")]
    public partial class ClientAdminCreateSelfServiceRecoveryLinkBody : IEquatable<ClientAdminCreateSelfServiceRecoveryLinkBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateSelfServiceRecoveryLinkBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientAdminCreateSelfServiceRecoveryLinkBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateSelfServiceRecoveryLinkBody" /> class.
        /// </summary>
        /// <param name="expiresIn">Link Expires In  The recovery link will expire at that point in time. Defaults to the configuration value of &#x60;selfservice.flows.recovery.request_lifespan&#x60;..</param>
        /// <param name="identityId">identityId (required).</param>
        public ClientAdminCreateSelfServiceRecoveryLinkBody(string expiresIn = default(string), string identityId = default(string))
        {
            // to ensure "identityId" is required (not null)
            if (identityId == null) {
                throw new ArgumentNullException("identityId is a required property for ClientAdminCreateSelfServiceRecoveryLinkBody and cannot be null");
            }
            this.IdentityId = identityId;
            this.ExpiresIn = expiresIn;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Link Expires In  The recovery link will expire at that point in time. Defaults to the configuration value of &#x60;selfservice.flows.recovery.request_lifespan&#x60;.
        /// </summary>
        /// <value>Link Expires In  The recovery link will expire at that point in time. Defaults to the configuration value of &#x60;selfservice.flows.recovery.request_lifespan&#x60;.</value>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets IdentityId
        /// </summary>
        [DataMember(Name = "identity_id", IsRequired = true, EmitDefaultValue = false)]
        public string IdentityId { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class ClientAdminCreateSelfServiceRecoveryLinkBody {\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  IdentityId: ").Append(IdentityId).Append("\n");
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
            return this.Equals(input as ClientAdminCreateSelfServiceRecoveryLinkBody);
        }

        /// <summary>
        /// Returns true if ClientAdminCreateSelfServiceRecoveryLinkBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAdminCreateSelfServiceRecoveryLinkBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAdminCreateSelfServiceRecoveryLinkBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.IdentityId == input.IdentityId ||
                    (this.IdentityId != null &&
                    this.IdentityId.Equals(input.IdentityId))
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
                if (this.ExpiresIn != null)
                    hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.IdentityId != null)
                    hashCode = hashCode * 59 + this.IdentityId.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ExpiresIn (string) pattern
            Regex regexExpiresIn = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
            if (false == regexExpiresIn.Match(this.ExpiresIn).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiresIn, must match a pattern of " + regexExpiresIn, new [] { "ExpiresIn" });
            }

            yield break;
        }
    }

}
