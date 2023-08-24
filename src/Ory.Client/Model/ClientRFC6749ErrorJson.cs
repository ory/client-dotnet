/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.50
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
    /// ClientRFC6749ErrorJson
    /// </summary>
    [DataContract(Name = "RFC6749ErrorJson")]
    public partial class ClientRFC6749ErrorJson : IEquatable<ClientRFC6749ErrorJson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRFC6749ErrorJson" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="errorDebug">errorDebug.</param>
        /// <param name="errorDescription">errorDescription.</param>
        /// <param name="errorHint">errorHint.</param>
        /// <param name="statusCode">statusCode.</param>
        public ClientRFC6749ErrorJson(string error = default(string), string errorDebug = default(string), string errorDescription = default(string), string errorHint = default(string), long statusCode = default(long))
        {
            this.Error = error;
            this.ErrorDebug = errorDebug;
            this.ErrorDescription = errorDescription;
            this.ErrorHint = errorHint;
            this.StatusCode = statusCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDebug
        /// </summary>
        [DataMember(Name = "error_debug", EmitDefaultValue = false)]
        public string ErrorDebug { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDescription
        /// </summary>
        [DataMember(Name = "error_description", EmitDefaultValue = false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or Sets ErrorHint
        /// </summary>
        [DataMember(Name = "error_hint", EmitDefaultValue = false)]
        public string ErrorHint { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        public long StatusCode { get; set; }

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
            sb.Append("class ClientRFC6749ErrorJson {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDebug: ").Append(ErrorDebug).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  ErrorHint: ").Append(ErrorHint).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
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
            return this.Equals(input as ClientRFC6749ErrorJson);
        }

        /// <summary>
        /// Returns true if ClientRFC6749ErrorJson instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientRFC6749ErrorJson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientRFC6749ErrorJson input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ErrorDebug == input.ErrorDebug ||
                    (this.ErrorDebug != null &&
                    this.ErrorDebug.Equals(input.ErrorDebug))
                ) && 
                (
                    this.ErrorDescription == input.ErrorDescription ||
                    (this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(input.ErrorDescription))
                ) && 
                (
                    this.ErrorHint == input.ErrorHint ||
                    (this.ErrorHint != null &&
                    this.ErrorHint.Equals(input.ErrorHint))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
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
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.ErrorDebug != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorDebug.GetHashCode();
                }
                if (this.ErrorDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorDescription.GetHashCode();
                }
                if (this.ErrorHint != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorHint.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
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
