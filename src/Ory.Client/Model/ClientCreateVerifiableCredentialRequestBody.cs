/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.6.2
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
    /// ClientCreateVerifiableCredentialRequestBody
    /// </summary>
    [DataContract(Name = "CreateVerifiableCredentialRequestBody")]
    public partial class ClientCreateVerifiableCredentialRequestBody : IEquatable<ClientCreateVerifiableCredentialRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateVerifiableCredentialRequestBody" /> class.
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="proof">proof.</param>
        /// <param name="types">types.</param>
        public ClientCreateVerifiableCredentialRequestBody(string format = default(string), ClientVerifiableCredentialProof proof = default(ClientVerifiableCredentialProof), List<string> types = default(List<string>))
        {
            this.Format = format;
            this.Proof = proof;
            this.Types = types;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets Proof
        /// </summary>
        [DataMember(Name = "proof", EmitDefaultValue = false)]
        public ClientVerifiableCredentialProof Proof { get; set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public List<string> Types { get; set; }

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
            sb.Append("class ClientCreateVerifiableCredentialRequestBody {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
            return this.Equals(input as ClientCreateVerifiableCredentialRequestBody);
        }

        /// <summary>
        /// Returns true if ClientCreateVerifiableCredentialRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCreateVerifiableCredentialRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCreateVerifiableCredentialRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Proof == input.Proof ||
                    (this.Proof != null &&
                    this.Proof.Equals(input.Proof))
                ) && 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
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
                if (this.Format != null)
                {
                    hashCode = (hashCode * 59) + this.Format.GetHashCode();
                }
                if (this.Proof != null)
                {
                    hashCode = (hashCode * 59) + this.Proof.GetHashCode();
                }
                if (this.Types != null)
                {
                    hashCode = (hashCode * 59) + this.Types.GetHashCode();
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
