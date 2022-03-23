/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.146
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
    /// ClientCnameSettings
    /// </summary>
    [DataContract(Name = "cnameSettings")]
    public partial class ClientCnameSettings : IEquatable<ClientCnameSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCnameSettings" /> class.
        /// </summary>
        /// <param name="cookieDomain">cookieDomain.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="hostname">hostname.</param>
        /// <param name="id">id.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="verificationErrors">verificationErrors.</param>
        /// <param name="verificationStatus">CustomHostnameStatus is the enumeration of valid state values in the CustomHostnameSSL.</param>
        public ClientCnameSettings(string cookieDomain = default(string), DateTime createdAt = default(DateTime), string hostname = default(string), string id = default(string), DateTime updatedAt = default(DateTime), List<string> verificationErrors = default(List<string>), string verificationStatus = default(string))
        {
            this.CookieDomain = cookieDomain;
            this.CreatedAt = createdAt;
            this.Hostname = hostname;
            this.Id = id;
            this.UpdatedAt = updatedAt;
            this.VerificationErrors = verificationErrors;
            this.VerificationStatus = verificationStatus;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets CookieDomain
        /// </summary>
        [DataMember(Name = "cookie_domain", EmitDefaultValue = false)]
        public string CookieDomain { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name = "hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets VerificationErrors
        /// </summary>
        [DataMember(Name = "verification_errors", EmitDefaultValue = false)]
        public List<string> VerificationErrors { get; set; }

        /// <summary>
        /// CustomHostnameStatus is the enumeration of valid state values in the CustomHostnameSSL
        /// </summary>
        /// <value>CustomHostnameStatus is the enumeration of valid state values in the CustomHostnameSSL</value>
        [DataMember(Name = "verification_status", EmitDefaultValue = false)]
        public string VerificationStatus { get; set; }

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
            sb.Append("class ClientCnameSettings {\n");
            sb.Append("  CookieDomain: ").Append(CookieDomain).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  VerificationErrors: ").Append(VerificationErrors).Append("\n");
            sb.Append("  VerificationStatus: ").Append(VerificationStatus).Append("\n");
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
            return this.Equals(input as ClientCnameSettings);
        }

        /// <summary>
        /// Returns true if ClientCnameSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCnameSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCnameSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CookieDomain == input.CookieDomain ||
                    (this.CookieDomain != null &&
                    this.CookieDomain.Equals(input.CookieDomain))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.VerificationErrors == input.VerificationErrors ||
                    this.VerificationErrors != null &&
                    input.VerificationErrors != null &&
                    this.VerificationErrors.SequenceEqual(input.VerificationErrors)
                ) && 
                (
                    this.VerificationStatus == input.VerificationStatus ||
                    (this.VerificationStatus != null &&
                    this.VerificationStatus.Equals(input.VerificationStatus))
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
                if (this.CookieDomain != null)
                {
                    hashCode = (hashCode * 59) + this.CookieDomain.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Hostname != null)
                {
                    hashCode = (hashCode * 59) + this.Hostname.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.VerificationErrors != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationErrors.GetHashCode();
                }
                if (this.VerificationStatus != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationStatus.GetHashCode();
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
