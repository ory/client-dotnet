/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.3
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
    /// ClientJsonWebKey
    /// </summary>
    [DataContract(Name = "jsonWebKey")]
    public partial class ClientJsonWebKey : IEquatable<ClientJsonWebKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientJsonWebKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientJsonWebKey()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientJsonWebKey" /> class.
        /// </summary>
        /// <param name="alg">The \&quot;alg\&quot; (algorithm) parameter identifies the algorithm intended for use with the key.  The values used should either be registered in the IANA \&quot;JSON Web Signature and Encryption Algorithms\&quot; registry established by [JWA] or be a value that contains a Collision- Resistant Name. (required).</param>
        /// <param name="crv">crv.</param>
        /// <param name="d">d.</param>
        /// <param name="dp">dp.</param>
        /// <param name="dq">dq.</param>
        /// <param name="e">e.</param>
        /// <param name="k">k.</param>
        /// <param name="kid">The \&quot;kid\&quot; (key ID) parameter is used to match a specific key.  This is used, for instance, to choose among a set of keys within a JWK Set during key rollover.  The structure of the \&quot;kid\&quot; value is unspecified.  When \&quot;kid\&quot; values are used within a JWK Set, different keys within the JWK Set SHOULD use distinct \&quot;kid\&quot; values.  (One example in which different keys might use the same \&quot;kid\&quot; value is if they have different \&quot;kty\&quot; (key type) values but are considered to be equivalent alternatives by the application using them.)  The \&quot;kid\&quot; value is a case-sensitive string. (required).</param>
        /// <param name="kty">The \&quot;kty\&quot; (key type) parameter identifies the cryptographic algorithm family used with the key, such as \&quot;RSA\&quot; or \&quot;EC\&quot;. \&quot;kty\&quot; values should either be registered in the IANA \&quot;JSON Web Key Types\&quot; registry established by [JWA] or be a value that contains a Collision- Resistant Name.  The \&quot;kty\&quot; value is a case-sensitive string. (required).</param>
        /// <param name="n">n.</param>
        /// <param name="p">p.</param>
        /// <param name="q">q.</param>
        /// <param name="qi">qi.</param>
        /// <param name="use">Use (\&quot;public key use\&quot;) identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Values are commonly \&quot;sig\&quot; (signature) or \&quot;enc\&quot; (encryption). (required).</param>
        /// <param name="x">x.</param>
        /// <param name="x5c">The \&quot;x5c\&quot; (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates [RFC5280].  The certificate chain is represented as a JSON array of certificate value strings.  Each string in the array is a base64-encoded (Section 4 of [RFC4648] - - not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value. The PKIX certificate containing the key value MUST be the first certificate..</param>
        /// <param name="y">y.</param>
        public ClientJsonWebKey(string alg = default(string), string crv = default(string), string d = default(string), string dp = default(string), string dq = default(string), string e = default(string), string k = default(string), string kid = default(string), string kty = default(string), string n = default(string), string p = default(string), string q = default(string), string qi = default(string), string use = default(string), string x = default(string), List<string> x5c = default(List<string>), string y = default(string))
        {
            // to ensure "alg" is required (not null)
            if (alg == null) {
                throw new ArgumentNullException("alg is a required property for ClientJsonWebKey and cannot be null");
            }
            this.Alg = alg;
            // to ensure "kid" is required (not null)
            if (kid == null) {
                throw new ArgumentNullException("kid is a required property for ClientJsonWebKey and cannot be null");
            }
            this.Kid = kid;
            // to ensure "kty" is required (not null)
            if (kty == null) {
                throw new ArgumentNullException("kty is a required property for ClientJsonWebKey and cannot be null");
            }
            this.Kty = kty;
            // to ensure "use" is required (not null)
            if (use == null) {
                throw new ArgumentNullException("use is a required property for ClientJsonWebKey and cannot be null");
            }
            this.Use = use;
            this.Crv = crv;
            this.D = d;
            this.Dp = dp;
            this.Dq = dq;
            this.E = e;
            this.K = k;
            this.N = n;
            this.P = p;
            this.Q = q;
            this.Qi = qi;
            this.X = x;
            this.X5c = x5c;
            this.Y = y;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The \&quot;alg\&quot; (algorithm) parameter identifies the algorithm intended for use with the key.  The values used should either be registered in the IANA \&quot;JSON Web Signature and Encryption Algorithms\&quot; registry established by [JWA] or be a value that contains a Collision- Resistant Name.
        /// </summary>
        /// <value>The \&quot;alg\&quot; (algorithm) parameter identifies the algorithm intended for use with the key.  The values used should either be registered in the IANA \&quot;JSON Web Signature and Encryption Algorithms\&quot; registry established by [JWA] or be a value that contains a Collision- Resistant Name.</value>
        [DataMember(Name = "alg", IsRequired = true, EmitDefaultValue = false)]
        public string Alg { get; set; }

        /// <summary>
        /// Gets or Sets Crv
        /// </summary>
        [DataMember(Name = "crv", EmitDefaultValue = false)]
        public string Crv { get; set; }

        /// <summary>
        /// Gets or Sets D
        /// </summary>
        [DataMember(Name = "d", EmitDefaultValue = false)]
        public string D { get; set; }

        /// <summary>
        /// Gets or Sets Dp
        /// </summary>
        [DataMember(Name = "dp", EmitDefaultValue = false)]
        public string Dp { get; set; }

        /// <summary>
        /// Gets or Sets Dq
        /// </summary>
        [DataMember(Name = "dq", EmitDefaultValue = false)]
        public string Dq { get; set; }

        /// <summary>
        /// Gets or Sets E
        /// </summary>
        [DataMember(Name = "e", EmitDefaultValue = false)]
        public string E { get; set; }

        /// <summary>
        /// Gets or Sets K
        /// </summary>
        [DataMember(Name = "k", EmitDefaultValue = false)]
        public string K { get; set; }

        /// <summary>
        /// The \&quot;kid\&quot; (key ID) parameter is used to match a specific key.  This is used, for instance, to choose among a set of keys within a JWK Set during key rollover.  The structure of the \&quot;kid\&quot; value is unspecified.  When \&quot;kid\&quot; values are used within a JWK Set, different keys within the JWK Set SHOULD use distinct \&quot;kid\&quot; values.  (One example in which different keys might use the same \&quot;kid\&quot; value is if they have different \&quot;kty\&quot; (key type) values but are considered to be equivalent alternatives by the application using them.)  The \&quot;kid\&quot; value is a case-sensitive string.
        /// </summary>
        /// <value>The \&quot;kid\&quot; (key ID) parameter is used to match a specific key.  This is used, for instance, to choose among a set of keys within a JWK Set during key rollover.  The structure of the \&quot;kid\&quot; value is unspecified.  When \&quot;kid\&quot; values are used within a JWK Set, different keys within the JWK Set SHOULD use distinct \&quot;kid\&quot; values.  (One example in which different keys might use the same \&quot;kid\&quot; value is if they have different \&quot;kty\&quot; (key type) values but are considered to be equivalent alternatives by the application using them.)  The \&quot;kid\&quot; value is a case-sensitive string.</value>
        [DataMember(Name = "kid", IsRequired = true, EmitDefaultValue = false)]
        public string Kid { get; set; }

        /// <summary>
        /// The \&quot;kty\&quot; (key type) parameter identifies the cryptographic algorithm family used with the key, such as \&quot;RSA\&quot; or \&quot;EC\&quot;. \&quot;kty\&quot; values should either be registered in the IANA \&quot;JSON Web Key Types\&quot; registry established by [JWA] or be a value that contains a Collision- Resistant Name.  The \&quot;kty\&quot; value is a case-sensitive string.
        /// </summary>
        /// <value>The \&quot;kty\&quot; (key type) parameter identifies the cryptographic algorithm family used with the key, such as \&quot;RSA\&quot; or \&quot;EC\&quot;. \&quot;kty\&quot; values should either be registered in the IANA \&quot;JSON Web Key Types\&quot; registry established by [JWA] or be a value that contains a Collision- Resistant Name.  The \&quot;kty\&quot; value is a case-sensitive string.</value>
        [DataMember(Name = "kty", IsRequired = true, EmitDefaultValue = false)]
        public string Kty { get; set; }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name = "n", EmitDefaultValue = false)]
        public string N { get; set; }

        /// <summary>
        /// Gets or Sets P
        /// </summary>
        [DataMember(Name = "p", EmitDefaultValue = false)]
        public string P { get; set; }

        /// <summary>
        /// Gets or Sets Q
        /// </summary>
        [DataMember(Name = "q", EmitDefaultValue = false)]
        public string Q { get; set; }

        /// <summary>
        /// Gets or Sets Qi
        /// </summary>
        [DataMember(Name = "qi", EmitDefaultValue = false)]
        public string Qi { get; set; }

        /// <summary>
        /// Use (\&quot;public key use\&quot;) identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Values are commonly \&quot;sig\&quot; (signature) or \&quot;enc\&quot; (encryption).
        /// </summary>
        /// <value>Use (\&quot;public key use\&quot;) identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Values are commonly \&quot;sig\&quot; (signature) or \&quot;enc\&quot; (encryption).</value>
        [DataMember(Name = "use", IsRequired = true, EmitDefaultValue = false)]
        public string Use { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public string X { get; set; }

        /// <summary>
        /// The \&quot;x5c\&quot; (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates [RFC5280].  The certificate chain is represented as a JSON array of certificate value strings.  Each string in the array is a base64-encoded (Section 4 of [RFC4648] - - not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value. The PKIX certificate containing the key value MUST be the first certificate.
        /// </summary>
        /// <value>The \&quot;x5c\&quot; (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates [RFC5280].  The certificate chain is represented as a JSON array of certificate value strings.  Each string in the array is a base64-encoded (Section 4 of [RFC4648] - - not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value. The PKIX certificate containing the key value MUST be the first certificate.</value>
        [DataMember(Name = "x5c", EmitDefaultValue = false)]
        public List<string> X5c { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public string Y { get; set; }

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
            sb.Append("class ClientJsonWebKey {\n");
            sb.Append("  Alg: ").Append(Alg).Append("\n");
            sb.Append("  Crv: ").Append(Crv).Append("\n");
            sb.Append("  D: ").Append(D).Append("\n");
            sb.Append("  Dp: ").Append(Dp).Append("\n");
            sb.Append("  Dq: ").Append(Dq).Append("\n");
            sb.Append("  E: ").Append(E).Append("\n");
            sb.Append("  K: ").Append(K).Append("\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  Kty: ").Append(Kty).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  P: ").Append(P).Append("\n");
            sb.Append("  Q: ").Append(Q).Append("\n");
            sb.Append("  Qi: ").Append(Qi).Append("\n");
            sb.Append("  Use: ").Append(Use).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  X5c: ").Append(X5c).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(input as ClientJsonWebKey);
        }

        /// <summary>
        /// Returns true if ClientJsonWebKey instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientJsonWebKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientJsonWebKey input)
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
                    this.Crv == input.Crv ||
                    (this.Crv != null &&
                    this.Crv.Equals(input.Crv))
                ) && 
                (
                    this.D == input.D ||
                    (this.D != null &&
                    this.D.Equals(input.D))
                ) && 
                (
                    this.Dp == input.Dp ||
                    (this.Dp != null &&
                    this.Dp.Equals(input.Dp))
                ) && 
                (
                    this.Dq == input.Dq ||
                    (this.Dq != null &&
                    this.Dq.Equals(input.Dq))
                ) && 
                (
                    this.E == input.E ||
                    (this.E != null &&
                    this.E.Equals(input.E))
                ) && 
                (
                    this.K == input.K ||
                    (this.K != null &&
                    this.K.Equals(input.K))
                ) && 
                (
                    this.Kid == input.Kid ||
                    (this.Kid != null &&
                    this.Kid.Equals(input.Kid))
                ) && 
                (
                    this.Kty == input.Kty ||
                    (this.Kty != null &&
                    this.Kty.Equals(input.Kty))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.P == input.P ||
                    (this.P != null &&
                    this.P.Equals(input.P))
                ) && 
                (
                    this.Q == input.Q ||
                    (this.Q != null &&
                    this.Q.Equals(input.Q))
                ) && 
                (
                    this.Qi == input.Qi ||
                    (this.Qi != null &&
                    this.Qi.Equals(input.Qi))
                ) && 
                (
                    this.Use == input.Use ||
                    (this.Use != null &&
                    this.Use.Equals(input.Use))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.X5c == input.X5c ||
                    this.X5c != null &&
                    input.X5c != null &&
                    this.X5c.SequenceEqual(input.X5c)
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
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
                if (this.Crv != null)
                {
                    hashCode = (hashCode * 59) + this.Crv.GetHashCode();
                }
                if (this.D != null)
                {
                    hashCode = (hashCode * 59) + this.D.GetHashCode();
                }
                if (this.Dp != null)
                {
                    hashCode = (hashCode * 59) + this.Dp.GetHashCode();
                }
                if (this.Dq != null)
                {
                    hashCode = (hashCode * 59) + this.Dq.GetHashCode();
                }
                if (this.E != null)
                {
                    hashCode = (hashCode * 59) + this.E.GetHashCode();
                }
                if (this.K != null)
                {
                    hashCode = (hashCode * 59) + this.K.GetHashCode();
                }
                if (this.Kid != null)
                {
                    hashCode = (hashCode * 59) + this.Kid.GetHashCode();
                }
                if (this.Kty != null)
                {
                    hashCode = (hashCode * 59) + this.Kty.GetHashCode();
                }
                if (this.N != null)
                {
                    hashCode = (hashCode * 59) + this.N.GetHashCode();
                }
                if (this.P != null)
                {
                    hashCode = (hashCode * 59) + this.P.GetHashCode();
                }
                if (this.Q != null)
                {
                    hashCode = (hashCode * 59) + this.Q.GetHashCode();
                }
                if (this.Qi != null)
                {
                    hashCode = (hashCode * 59) + this.Qi.GetHashCode();
                }
                if (this.Use != null)
                {
                    hashCode = (hashCode * 59) + this.Use.GetHashCode();
                }
                if (this.X != null)
                {
                    hashCode = (hashCode * 59) + this.X.GetHashCode();
                }
                if (this.X5c != null)
                {
                    hashCode = (hashCode * 59) + this.X5c.GetHashCode();
                }
                if (this.Y != null)
                {
                    hashCode = (hashCode * 59) + this.Y.GetHashCode();
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
