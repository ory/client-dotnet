/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.28
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
    /// ClientContinueWithVerificationUiFlow
    /// </summary>
    [DataContract(Name = "continueWithVerificationUiFlow")]
    public partial class ClientContinueWithVerificationUiFlow : IEquatable<ClientContinueWithVerificationUiFlow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWithVerificationUiFlow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientContinueWithVerificationUiFlow()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWithVerificationUiFlow" /> class.
        /// </summary>
        /// <param name="id">The ID of the verification flow (required).</param>
        /// <param name="url">The URL of the verification flow.</param>
        /// <param name="verifiableAddress">The address that should be verified in this flow (required).</param>
        public ClientContinueWithVerificationUiFlow(string id = default(string), string url = default(string), string verifiableAddress = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ClientContinueWithVerificationUiFlow and cannot be null");
            }
            this.Id = id;
            // to ensure "verifiableAddress" is required (not null)
            if (verifiableAddress == null) {
                throw new ArgumentNullException("verifiableAddress is a required property for ClientContinueWithVerificationUiFlow and cannot be null");
            }
            this.VerifiableAddress = verifiableAddress;
            this.Url = url;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of the verification flow
        /// </summary>
        /// <value>The ID of the verification flow</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The URL of the verification flow
        /// </summary>
        /// <value>The URL of the verification flow</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// The address that should be verified in this flow
        /// </summary>
        /// <value>The address that should be verified in this flow</value>
        [DataMember(Name = "verifiable_address", IsRequired = true, EmitDefaultValue = false)]
        public string VerifiableAddress { get; set; }

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
            sb.Append("class ClientContinueWithVerificationUiFlow {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  VerifiableAddress: ").Append(VerifiableAddress).Append("\n");
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
            return this.Equals(input as ClientContinueWithVerificationUiFlow);
        }

        /// <summary>
        /// Returns true if ClientContinueWithVerificationUiFlow instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientContinueWithVerificationUiFlow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientContinueWithVerificationUiFlow input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.VerifiableAddress == input.VerifiableAddress ||
                    (this.VerifiableAddress != null &&
                    this.VerifiableAddress.Equals(input.VerifiableAddress))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.VerifiableAddress != null)
                {
                    hashCode = (hashCode * 59) + this.VerifiableAddress.GetHashCode();
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
