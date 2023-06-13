/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.35
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
    /// Create JSON Web Key Set Request Body
    /// </summary>
    [DataContract(Name = "createJsonWebKeySet")]
    public partial class ClientCreateJsonWebKeySet : IEquatable<ClientCreateJsonWebKeySet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateJsonWebKeySet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientCreateJsonWebKeySet()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateJsonWebKeySet" /> class.
        /// </summary>
        /// <param name="alg">JSON Web Key Algorithm  The algorithm to be used for creating the key. Supports &#x60;RS256&#x60;, &#x60;ES256&#x60;, &#x60;ES512&#x60;, &#x60;HS512&#x60;, and &#x60;HS256&#x60;. (required).</param>
        /// <param name="kid">JSON Web Key ID  The Key ID of the key to be created. (required).</param>
        /// <param name="use">JSON Web Key Use  The \&quot;use\&quot; (public key use) parameter identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Valid values are \&quot;enc\&quot; and \&quot;sig\&quot;. (required).</param>
        public ClientCreateJsonWebKeySet(string alg = default(string), string kid = default(string), string use = default(string))
        {
            // to ensure "alg" is required (not null)
            if (alg == null) {
                throw new ArgumentNullException("alg is a required property for ClientCreateJsonWebKeySet and cannot be null");
            }
            this.Alg = alg;
            // to ensure "kid" is required (not null)
            if (kid == null) {
                throw new ArgumentNullException("kid is a required property for ClientCreateJsonWebKeySet and cannot be null");
            }
            this.Kid = kid;
            // to ensure "use" is required (not null)
            if (use == null) {
                throw new ArgumentNullException("use is a required property for ClientCreateJsonWebKeySet and cannot be null");
            }
            this.Use = use;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// JSON Web Key Algorithm  The algorithm to be used for creating the key. Supports &#x60;RS256&#x60;, &#x60;ES256&#x60;, &#x60;ES512&#x60;, &#x60;HS512&#x60;, and &#x60;HS256&#x60;.
        /// </summary>
        /// <value>JSON Web Key Algorithm  The algorithm to be used for creating the key. Supports &#x60;RS256&#x60;, &#x60;ES256&#x60;, &#x60;ES512&#x60;, &#x60;HS512&#x60;, and &#x60;HS256&#x60;.</value>
        [DataMember(Name = "alg", IsRequired = true, EmitDefaultValue = false)]
        public string Alg { get; set; }

        /// <summary>
        /// JSON Web Key ID  The Key ID of the key to be created.
        /// </summary>
        /// <value>JSON Web Key ID  The Key ID of the key to be created.</value>
        [DataMember(Name = "kid", IsRequired = true, EmitDefaultValue = false)]
        public string Kid { get; set; }

        /// <summary>
        /// JSON Web Key Use  The \&quot;use\&quot; (public key use) parameter identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Valid values are \&quot;enc\&quot; and \&quot;sig\&quot;.
        /// </summary>
        /// <value>JSON Web Key Use  The \&quot;use\&quot; (public key use) parameter identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Valid values are \&quot;enc\&quot; and \&quot;sig\&quot;.</value>
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
            sb.Append("class ClientCreateJsonWebKeySet {\n");
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
            return this.Equals(input as ClientCreateJsonWebKeySet);
        }

        /// <summary>
        /// Returns true if ClientCreateJsonWebKeySet instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientCreateJsonWebKeySet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientCreateJsonWebKeySet input)
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
