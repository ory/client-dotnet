/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.40
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
    /// Patch Identities Body
    /// </summary>
    [DataContract(Name = "patchIdentitiesBody")]
    public partial class ClientPatchIdentitiesBody : IEquatable<ClientPatchIdentitiesBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPatchIdentitiesBody" /> class.
        /// </summary>
        /// <param name="identities">Identities holds the list of patches to apply  required.</param>
        public ClientPatchIdentitiesBody(List<ClientIdentityPatch> identities = default(List<ClientIdentityPatch>))
        {
            this.Identities = identities;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Identities holds the list of patches to apply  required
        /// </summary>
        /// <value>Identities holds the list of patches to apply  required</value>
        [DataMember(Name = "identities", EmitDefaultValue = false)]
        public List<ClientIdentityPatch> Identities { get; set; }

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
            sb.Append("class ClientPatchIdentitiesBody {\n");
            sb.Append("  Identities: ").Append(Identities).Append("\n");
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
            return this.Equals(input as ClientPatchIdentitiesBody);
        }

        /// <summary>
        /// Returns true if ClientPatchIdentitiesBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientPatchIdentitiesBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientPatchIdentitiesBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identities == input.Identities ||
                    this.Identities != null &&
                    input.Identities != null &&
                    this.Identities.SequenceEqual(input.Identities)
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
                if (this.Identities != null)
                {
                    hashCode = (hashCode * 59) + this.Identities.GetHashCode();
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
