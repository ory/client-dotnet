/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.3
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
    /// ClientVerifiableCredentialProof
    /// </summary>
    [DataContract(Name = "VerifiableCredentialProof")]
    public partial class ClientVerifiableCredentialProof : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientVerifiableCredentialProof" /> class.
        /// </summary>
        /// <param name="jwt">jwt.</param>
        /// <param name="proofType">proofType.</param>
        public ClientVerifiableCredentialProof(string jwt = default(string), string proofType = default(string))
        {
            this.Jwt = jwt;
            this.ProofType = proofType;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Jwt
        /// </summary>
        [DataMember(Name = "jwt", EmitDefaultValue = false)]
        public string Jwt { get; set; }

        /// <summary>
        /// Gets or Sets ProofType
        /// </summary>
        [DataMember(Name = "proof_type", EmitDefaultValue = false)]
        public string ProofType { get; set; }

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
            sb.Append("class ClientVerifiableCredentialProof {\n");
            sb.Append("  Jwt: ").Append(Jwt).Append("\n");
            sb.Append("  ProofType: ").Append(ProofType).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
