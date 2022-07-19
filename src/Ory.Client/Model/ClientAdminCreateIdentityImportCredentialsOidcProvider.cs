/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.1.0-alpha.2
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
    /// ClientAdminCreateIdentityImportCredentialsOidcProvider
    /// </summary>
    [DataContract(Name = "adminCreateIdentityImportCredentialsOidcProvider")]
    public partial class ClientAdminCreateIdentityImportCredentialsOidcProvider : IEquatable<ClientAdminCreateIdentityImportCredentialsOidcProvider>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateIdentityImportCredentialsOidcProvider" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientAdminCreateIdentityImportCredentialsOidcProvider()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateIdentityImportCredentialsOidcProvider" /> class.
        /// </summary>
        /// <param name="provider">The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;. (required).</param>
        /// <param name="subject">The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token. (required).</param>
        public ClientAdminCreateIdentityImportCredentialsOidcProvider(string provider = default(string), string subject = default(string))
        {
            // to ensure "provider" is required (not null)
            if (provider == null) {
                throw new ArgumentNullException("provider is a required property for ClientAdminCreateIdentityImportCredentialsOidcProvider and cannot be null");
            }
            this.Provider = provider;
            // to ensure "subject" is required (not null)
            if (subject == null) {
                throw new ArgumentNullException("subject is a required property for ClientAdminCreateIdentityImportCredentialsOidcProvider and cannot be null");
            }
            this.Subject = subject;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;.
        /// </summary>
        /// <value>The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;.</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token.
        /// </summary>
        /// <value>The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token.</value>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

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
            sb.Append("class ClientAdminCreateIdentityImportCredentialsOidcProvider {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as ClientAdminCreateIdentityImportCredentialsOidcProvider);
        }

        /// <summary>
        /// Returns true if ClientAdminCreateIdentityImportCredentialsOidcProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAdminCreateIdentityImportCredentialsOidcProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAdminCreateIdentityImportCredentialsOidcProvider input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
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
