/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.41
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
    /// SubmitSelfServiceRegistrationFlowWithPasswordMethodBody is used to decode the registration form payload when using the password method.
    /// </summary>
    [DataContract(Name = "submitSelfServiceRegistrationFlowWithPasswordMethodBody")]
    public partial class ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody : IEquatable<ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody" /> class.
        /// </summary>
        /// <param name="csrfToken">The CSRF Token.</param>
        /// <param name="method">Method to use  This field must be set to &#x60;password&#x60; when using the password method. (required).</param>
        /// <param name="password">Password to sign the user up with (required).</param>
        /// <param name="traits">The identity&#39;s traits (required).</param>
        public ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody(string csrfToken = default(string), string method = default(string), string password = default(string), Object traits = default(Object))
        {
            // to ensure "method" is required (not null)
            if (method == null) {
                throw new ArgumentNullException("method is a required property for ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody and cannot be null");
            }
            this.Method = method;
            // to ensure "password" is required (not null)
            if (password == null) {
                throw new ArgumentNullException("password is a required property for ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody and cannot be null");
            }
            this.Password = password;
            // to ensure "traits" is required (not null)
            if (traits == null) {
                throw new ArgumentNullException("traits is a required property for ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody and cannot be null");
            }
            this.Traits = traits;
            this.CsrfToken = csrfToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The CSRF Token
        /// </summary>
        /// <value>The CSRF Token</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// Method to use  This field must be set to &#x60;password&#x60; when using the password method.
        /// </summary>
        /// <value>Method to use  This field must be set to &#x60;password&#x60; when using the password method.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Password to sign the user up with
        /// </summary>
        /// <value>Password to sign the user up with</value>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// The identity&#39;s traits
        /// </summary>
        /// <value>The identity&#39;s traits</value>
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
            var sb = new StringBuilder();
            sb.Append("class ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody);
        }

        /// <summary>
        /// Returns true if ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSubmitSelfServiceRegistrationFlowWithPasswordMethodBody input)
        {
            if (input == null)
                return false;

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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                    hashCode = hashCode * 59 + this.CsrfToken.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Traits != null)
                    hashCode = hashCode * 59 + this.Traits.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
