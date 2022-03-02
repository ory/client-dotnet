/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.111
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
    /// nolint:deadcode,unused
    /// </summary>
    [DataContract(Name = "submitSelfServiceSettingsFlowWithProfileMethodBody")]
    public partial class ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody : IEquatable<ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody" /> class.
        /// </summary>
        /// <param name="csrfToken">The Anti-CSRF Token  This token is only required when performing browser flows..</param>
        /// <param name="method">Method  Should be set to profile when trying to update a profile. (required).</param>
        /// <param name="traits">Traits contains all of the identity&#39;s traits. (required).</param>
        public ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody(string csrfToken = default(string), string method = default(string), Object traits = default(Object))
        {
            // to ensure "method" is required (not null)
            if (method == null) {
                throw new ArgumentNullException("method is a required property for ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody and cannot be null");
            }
            this.Method = method;
            // to ensure "traits" is required (not null)
            if (traits == null) {
                throw new ArgumentNullException("traits is a required property for ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody and cannot be null");
            }
            this.Traits = traits;
            this.CsrfToken = csrfToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Anti-CSRF Token  This token is only required when performing browser flows.
        /// </summary>
        /// <value>The Anti-CSRF Token  This token is only required when performing browser flows.</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// Method  Should be set to profile when trying to update a profile.
        /// </summary>
        /// <value>Method  Should be set to profile when trying to update a profile.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Traits contains all of the identity&#39;s traits.
        /// </summary>
        /// <value>Traits contains all of the identity&#39;s traits.</value>
        [DataMember(Name = "traits", IsRequired = true, EmitDefaultValue = false)]
        public Object Traits { get; set; }

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
            sb.Append("class ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
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
            return this.Equals(input as ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody);
        }

        /// <summary>
        /// Returns true if ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSubmitSelfServiceSettingsFlowWithProfileMethodBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CsrfToken == input.CsrfToken ||
                    (this.CsrfToken != null &&
                    this.CsrfToken.Equals(input.CsrfToken))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Traits == input.Traits ||
                    (this.Traits != null &&
                    this.Traits.Equals(input.Traits))
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
                if (this.CsrfToken != null)
                {
                    hashCode = (hashCode * 59) + this.CsrfToken.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Traits != null)
                {
                    hashCode = (hashCode * 59) + this.Traits.GetHashCode();
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
