/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.142
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
    /// ClientSelfServiceLogoutUrl
    /// </summary>
    [DataContract(Name = "selfServiceLogoutUrl")]
    public partial class ClientSelfServiceLogoutUrl : IEquatable<ClientSelfServiceLogoutUrl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSelfServiceLogoutUrl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSelfServiceLogoutUrl()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSelfServiceLogoutUrl" /> class.
        /// </summary>
        /// <param name="logoutToken">LogoutToken can be used to perform logout using AJAX. (required).</param>
        /// <param name="logoutUrl">LogoutURL can be opened in a browser to sign the user out.  format: uri (required).</param>
        public ClientSelfServiceLogoutUrl(string logoutToken = default(string), string logoutUrl = default(string))
        {
            // to ensure "logoutToken" is required (not null)
            if (logoutToken == null) {
                throw new ArgumentNullException("logoutToken is a required property for ClientSelfServiceLogoutUrl and cannot be null");
            }
            this.LogoutToken = logoutToken;
            // to ensure "logoutUrl" is required (not null)
            if (logoutUrl == null) {
                throw new ArgumentNullException("logoutUrl is a required property for ClientSelfServiceLogoutUrl and cannot be null");
            }
            this.LogoutUrl = logoutUrl;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// LogoutToken can be used to perform logout using AJAX.
        /// </summary>
        /// <value>LogoutToken can be used to perform logout using AJAX.</value>
        [DataMember(Name = "logout_token", IsRequired = true, EmitDefaultValue = false)]
        public string LogoutToken { get; set; }

        /// <summary>
        /// LogoutURL can be opened in a browser to sign the user out.  format: uri
        /// </summary>
        /// <value>LogoutURL can be opened in a browser to sign the user out.  format: uri</value>
        [DataMember(Name = "logout_url", IsRequired = true, EmitDefaultValue = false)]
        public string LogoutUrl { get; set; }

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
            sb.Append("class ClientSelfServiceLogoutUrl {\n");
            sb.Append("  LogoutToken: ").Append(LogoutToken).Append("\n");
            sb.Append("  LogoutUrl: ").Append(LogoutUrl).Append("\n");
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
            return this.Equals(input as ClientSelfServiceLogoutUrl);
        }

        /// <summary>
        /// Returns true if ClientSelfServiceLogoutUrl instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSelfServiceLogoutUrl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSelfServiceLogoutUrl input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogoutToken == input.LogoutToken ||
                    (this.LogoutToken != null &&
                    this.LogoutToken.Equals(input.LogoutToken))
                ) && 
                (
                    this.LogoutUrl == input.LogoutUrl ||
                    (this.LogoutUrl != null &&
                    this.LogoutUrl.Equals(input.LogoutUrl))
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
                if (this.LogoutToken != null)
                {
                    hashCode = (hashCode * 59) + this.LogoutToken.GetHashCode();
                }
                if (this.LogoutUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoutUrl.GetHashCode();
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
