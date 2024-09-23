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
    /// Includes information about the supported verifiable credentials.
    /// </summary>
    [DataContract(Name = "credentialSupportedDraft00")]
    public partial class ClientCredentialSupportedDraft00 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCredentialSupportedDraft00" /> class.
        /// </summary>
        /// <param name="cryptographicBindingMethodsSupported">OpenID Connect Verifiable Credentials Cryptographic Binding Methods Supported  Contains a list of cryptographic binding methods supported for signing the proof..</param>
        /// <param name="cryptographicSuitesSupported">OpenID Connect Verifiable Credentials Cryptographic Suites Supported  Contains a list of cryptographic suites methods supported for signing the proof..</param>
        /// <param name="format">OpenID Connect Verifiable Credentials Format  Contains the format that is supported by this authorization server..</param>
        /// <param name="types">OpenID Connect Verifiable Credentials Types  Contains the types of verifiable credentials supported..</param>
        public ClientCredentialSupportedDraft00(List<string> cryptographicBindingMethodsSupported = default(List<string>), List<string> cryptographicSuitesSupported = default(List<string>), string format = default(string), List<string> types = default(List<string>))
        {
            this.CryptographicBindingMethodsSupported = cryptographicBindingMethodsSupported;
            this.CryptographicSuitesSupported = cryptographicSuitesSupported;
            this.Format = format;
            this.Types = types;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// OpenID Connect Verifiable Credentials Cryptographic Binding Methods Supported  Contains a list of cryptographic binding methods supported for signing the proof.
        /// </summary>
        /// <value>OpenID Connect Verifiable Credentials Cryptographic Binding Methods Supported  Contains a list of cryptographic binding methods supported for signing the proof.</value>
        [DataMember(Name = "cryptographic_binding_methods_supported", EmitDefaultValue = false)]
        public List<string> CryptographicBindingMethodsSupported { get; set; }

        /// <summary>
        /// OpenID Connect Verifiable Credentials Cryptographic Suites Supported  Contains a list of cryptographic suites methods supported for signing the proof.
        /// </summary>
        /// <value>OpenID Connect Verifiable Credentials Cryptographic Suites Supported  Contains a list of cryptographic suites methods supported for signing the proof.</value>
        [DataMember(Name = "cryptographic_suites_supported", EmitDefaultValue = false)]
        public List<string> CryptographicSuitesSupported { get; set; }

        /// <summary>
        /// OpenID Connect Verifiable Credentials Format  Contains the format that is supported by this authorization server.
        /// </summary>
        /// <value>OpenID Connect Verifiable Credentials Format  Contains the format that is supported by this authorization server.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public string Format { get; set; }

        /// <summary>
        /// OpenID Connect Verifiable Credentials Types  Contains the types of verifiable credentials supported.
        /// </summary>
        /// <value>OpenID Connect Verifiable Credentials Types  Contains the types of verifiable credentials supported.</value>
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
            sb.Append("class ClientCredentialSupportedDraft00 {\n");
            sb.Append("  CryptographicBindingMethodsSupported: ").Append(CryptographicBindingMethodsSupported).Append("\n");
            sb.Append("  CryptographicSuitesSupported: ").Append(CryptographicSuitesSupported).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
