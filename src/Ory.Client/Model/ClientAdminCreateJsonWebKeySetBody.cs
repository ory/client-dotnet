/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.16
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
    /// ClientAdminCreateJsonWebKeySetBody
    /// </summary>
    [DataContract(Name = "adminCreateJsonWebKeySetBody")]
    public partial class ClientAdminCreateJsonWebKeySetBody : IEquatable<ClientAdminCreateJsonWebKeySetBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateJsonWebKeySetBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientAdminCreateJsonWebKeySetBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateJsonWebKeySetBody" /> class.
        /// </summary>
        /// <param name="alg">The algorithm to be used for creating the key. Supports \&quot;RS256\&quot;, \&quot;ES256\&quot;, \&quot;ES512\&quot;, \&quot;HS512\&quot;, and \&quot;HS256\&quot; (required).</param>
        /// <param name="kid">The kid of the key to be created (required).</param>
        /// <param name="use">The \&quot;use\&quot; (public key use) parameter identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Valid values are \&quot;enc\&quot; and \&quot;sig\&quot;. (required).</param>
        public ClientAdminCreateJsonWebKeySetBody(string alg = default(string), string kid = default(string), string use = default(string))
        {
            // to ensure "alg" is required (not null)
            if (alg == null) {
                throw new ArgumentNullException("alg is a required property for ClientAdminCreateJsonWebKeySetBody and cannot be null");
            }
            this.Alg = alg;
            // to ensure "kid" is required (not null)
            if (kid == null) {
                throw new ArgumentNullException("kid is a required property for ClientAdminCreateJsonWebKeySetBody and cannot be null");
            }
            this.Kid = kid;
            // to ensure "use" is required (not null)
            if (use == null) {
                throw new ArgumentNullException("use is a required property for ClientAdminCreateJsonWebKeySetBody and cannot be null");
            }
            this.Use = use;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The algorithm to be used for creating the key. Supports \&quot;RS256\&quot;, \&quot;ES256\&quot;, \&quot;ES512\&quot;, \&quot;HS512\&quot;, and \&quot;HS256\&quot;
        /// </summary>
        /// <value>The algorithm to be used for creating the key. Supports \&quot;RS256\&quot;, \&quot;ES256\&quot;, \&quot;ES512\&quot;, \&quot;HS512\&quot;, and \&quot;HS256\&quot;</value>
        [DataMember(Name = "alg", IsRequired = true, EmitDefaultValue = false)]
        public string Alg { get; set; }

        /// <summary>
        /// The kid of the key to be created
        /// </summary>
        /// <value>The kid of the key to be created</value>
        [DataMember(Name = "kid", IsRequired = true, EmitDefaultValue = false)]
        public string Kid { get; set; }

        /// <summary>
        /// The \&quot;use\&quot; (public key use) parameter identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Valid values are \&quot;enc\&quot; and \&quot;sig\&quot;.
        /// </summary>
        /// <value>The \&quot;use\&quot; (public key use) parameter identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Valid values are \&quot;enc\&quot; and \&quot;sig\&quot;.</value>
        [DataMember(Name = "use", IsRequired = true, EmitDefaultValue = false)]
        public string Use { get; set; }

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
            sb.Append("class ClientAdminCreateJsonWebKeySetBody {\n");
            sb.Append("  Alg: ").Append(Alg).Append("\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  Use: ").Append(Use).Append("\n");
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
            return this.Equals(input as ClientAdminCreateJsonWebKeySetBody);
        }

        /// <summary>
        /// Returns true if ClientAdminCreateJsonWebKeySetBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAdminCreateJsonWebKeySetBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAdminCreateJsonWebKeySetBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Alg == input.Alg ||
                    (this.Alg != null &&
                    this.Alg.Equals(input.Alg))
                ) && 
                (
                    this.Kid == input.Kid ||
                    (this.Kid != null &&
                    this.Kid.Equals(input.Kid))
                ) && 
                (
                    this.Use == input.Use ||
                    (this.Use != null &&
                    this.Use.Equals(input.Use))
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
                if (this.Alg != null)
                {
                    hashCode = (hashCode * 59) + this.Alg.GetHashCode();
                }
                if (this.Kid != null)
                {
                    hashCode = (hashCode * 59) + this.Kid.GetHashCode();
                }
                if (this.Use != null)
                {
                    hashCode = (hashCode * 59) + this.Use.GetHashCode();
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
