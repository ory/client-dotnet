/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.14.2
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
    public partial class ClientJsonWebKey : IValidatableObject
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
            if (alg == null)
            {
                throw new ArgumentNullException("alg is a required property for ClientJsonWebKey and cannot be null");
            }
            this.Alg = alg;
            // to ensure "kid" is required (not null)
            if (kid == null)
            {
                throw new ArgumentNullException("kid is a required property for ClientJsonWebKey and cannot be null");
            }
            this.Kid = kid;
            // to ensure "kty" is required (not null)
            if (kty == null)
            {
                throw new ArgumentNullException("kty is a required property for ClientJsonWebKey and cannot be null");
            }
            this.Kty = kty;
            // to ensure "use" is required (not null)
            if (use == null)
            {
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
        /// <example>RS256</example>
        [DataMember(Name = "alg", IsRequired = true, EmitDefaultValue = true)]
        public string Alg { get; set; }

        /// <summary>
        /// Gets or Sets Crv
        /// </summary>
        /// <example>P-256</example>
        [DataMember(Name = "crv", EmitDefaultValue = false)]
        public string Crv { get; set; }

        /// <summary>
        /// Gets or Sets D
        /// </summary>
        /// <example>T_N8I-6He3M8a7X1vWt6TGIx4xB_GP3Mb4SsZSA4v-orvJzzRiQhLlRR81naWYxfQAYt5isDI6_C2L9bdWo4FFPjGQFvNoRX-_sBJyBI_rl-TBgsZYoUlAj3J92WmY2inbA-PwyJfsaIIDceYBC-eX-xiCu6qMqkZi3MwQAFL6bMdPEM0z4JBcwFT3VdiWAIRUuACWQwrXMq672x7fMuaIaHi7XDGgt1ith23CLfaREmJku9PQcchbt_uEY-hqrFY6ntTtS4paWWQj86xLL94S-Tf6v6xkL918PfLSOTq6XCzxvlFwzBJqApnAhbwqLjpPhgUG04EDRrqrSBc5Y1BLevn6Ip5h1AhessBp3wLkQgz_roeckt-ybvzKTjESMuagnpqLvOT7Y9veIug2MwPJZI2VjczRc1vzMs25XrFQ8DpUy-bNdp89TmvAXwctUMiJdgHloJw23Cv03gIUAkDnsTqZmkpbIf-crpgNKFmQP_EDKoe8p_PXZZgfbRri3NoEVGP7Mk6yEu8LjJhClhZaBNjuWw2-KlBfOA3g79mhfBnkInee5KO9mGR50qPk1V-MorUYNTFMZIm0kFE6eYVWFBwJHLKYhHU34DoiK1VP-svZpC2uAMFNA_UJEwM9CQ2b8qe4-5e9aywMvwcuArRkAB5mBIfOaOJao3mfukKAE</example>
        [DataMember(Name = "d", EmitDefaultValue = false)]
        public string D { get; set; }

        /// <summary>
        /// Gets or Sets Dp
        /// </summary>
        /// <example>G4sPXkc6Ya9y8oJW9_ILj4xuppu0lzi_H7VTkS8xj5SdX3coE0oimYwxIi2emTAue0UOa5dpgFGyBJ4c8tQ2VF402XRugKDTP8akYhFo5tAA77Qe_NmtuYZc3C3m3I24G2GvR5sSDxUyAN2zq8Lfn9EUms6rY3Ob8YeiKkTiBj0</example>
        [DataMember(Name = "dp", EmitDefaultValue = false)]
        public string Dp { get; set; }

        /// <summary>
        /// Gets or Sets Dq
        /// </summary>
        /// <example>s9lAH9fggBsoFR8Oac2R_E2gw282rT2kGOAhvIllETE1efrA6huUUvMfBcMpn8lqeW6vzznYY5SSQF7pMdC_agI3nG8Ibp1BUb0JUiraRNqUfLhcQb_d9GF4Dh7e74WbRsobRonujTYN1xCaP6TO61jvWrX-L18txXw494Q_cgk</example>
        [DataMember(Name = "dq", EmitDefaultValue = false)]
        public string Dq { get; set; }

        /// <summary>
        /// Gets or Sets E
        /// </summary>
        /// <example>AQAB</example>
        [DataMember(Name = "e", EmitDefaultValue = false)]
        public string E { get; set; }

        /// <summary>
        /// Gets or Sets K
        /// </summary>
        /// <example>GawgguFyGrWKav7AX4VKUg</example>
        [DataMember(Name = "k", EmitDefaultValue = false)]
        public string K { get; set; }

        /// <summary>
        /// The \&quot;kid\&quot; (key ID) parameter is used to match a specific key.  This is used, for instance, to choose among a set of keys within a JWK Set during key rollover.  The structure of the \&quot;kid\&quot; value is unspecified.  When \&quot;kid\&quot; values are used within a JWK Set, different keys within the JWK Set SHOULD use distinct \&quot;kid\&quot; values.  (One example in which different keys might use the same \&quot;kid\&quot; value is if they have different \&quot;kty\&quot; (key type) values but are considered to be equivalent alternatives by the application using them.)  The \&quot;kid\&quot; value is a case-sensitive string.
        /// </summary>
        /// <value>The \&quot;kid\&quot; (key ID) parameter is used to match a specific key.  This is used, for instance, to choose among a set of keys within a JWK Set during key rollover.  The structure of the \&quot;kid\&quot; value is unspecified.  When \&quot;kid\&quot; values are used within a JWK Set, different keys within the JWK Set SHOULD use distinct \&quot;kid\&quot; values.  (One example in which different keys might use the same \&quot;kid\&quot; value is if they have different \&quot;kty\&quot; (key type) values but are considered to be equivalent alternatives by the application using them.)  The \&quot;kid\&quot; value is a case-sensitive string.</value>
        /// <example>1603dfe0af8f4596</example>
        [DataMember(Name = "kid", IsRequired = true, EmitDefaultValue = true)]
        public string Kid { get; set; }

        /// <summary>
        /// The \&quot;kty\&quot; (key type) parameter identifies the cryptographic algorithm family used with the key, such as \&quot;RSA\&quot; or \&quot;EC\&quot;. \&quot;kty\&quot; values should either be registered in the IANA \&quot;JSON Web Key Types\&quot; registry established by [JWA] or be a value that contains a Collision- Resistant Name.  The \&quot;kty\&quot; value is a case-sensitive string.
        /// </summary>
        /// <value>The \&quot;kty\&quot; (key type) parameter identifies the cryptographic algorithm family used with the key, such as \&quot;RSA\&quot; or \&quot;EC\&quot;. \&quot;kty\&quot; values should either be registered in the IANA \&quot;JSON Web Key Types\&quot; registry established by [JWA] or be a value that contains a Collision- Resistant Name.  The \&quot;kty\&quot; value is a case-sensitive string.</value>
        /// <example>RSA</example>
        [DataMember(Name = "kty", IsRequired = true, EmitDefaultValue = true)]
        public string Kty { get; set; }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        /// <example>vTqrxUyQPl_20aqf5kXHwDZrel-KovIp8s7ewJod2EXHl8tWlRB3_Rem34KwBfqlKQGp1nqah-51H4Jzruqe0cFP58hPEIt6WqrvnmJCXxnNuIB53iX_uUUXXHDHBeaPCSRoNJzNysjoJ30TIUsKBiirhBa7f235PXbKiHducLevV6PcKxJ5cY8zO286qJLBWSPm-OIevwqsIsSIH44Qtm9sioFikhkbLwoqwWORGAY0nl6XvVOlhADdLjBSqSAeT1FPuCDCnXwzCDR8N9IFB_IjdStFkC-rVt2K5BYfPd0c3yFp_vHR15eRd0zJ8XQ7woBC8Vnsac6Et1pKS59pX6256DPWu8UDdEOolKAPgcd_g2NpA76cAaF_jcT80j9KrEzw8Tv0nJBGesuCjPNjGs_KzdkWTUXt23Hn9QJsdc1MZuaW0iqXBepHYfYoqNelzVte117t4BwVp0kUM6we0IqyXClaZgOI8S-WDBw2_Ovdm8e5NmhYAblEVoygcX8Y46oH6bKiaCQfKCFDMcRgChme7AoE1yZZYsPbaG_3IjPrC4LBMHQw8rM9dWjJ8ImjicvZ1pAm0dx-KHCP3y5PVKrxBDf1zSOsBRkOSjB8TPODnJMz6-jd5hTtZxpZPwPoIdCanTZ3ZD6uRBpTmDwtpRGm63UQs1m5FWPwb0T2IF0</example>
        [DataMember(Name = "n", EmitDefaultValue = false)]
        public string N { get; set; }

        /// <summary>
        /// Gets or Sets P
        /// </summary>
        /// <example>6NbkXwDWUhi-eR55Cgbf27FkQDDWIamOaDr0rj1q0f1fFEz1W5A_09YvG09Fiv1AO2-D8Rl8gS1Vkz2i0zCSqnyy8A025XOcRviOMK7nIxE4OH_PEsko8dtIrb3TmE2hUXvCkmzw9EsTF1LQBOGC6iusLTXepIC1x9ukCKFZQvdgtEObQ5kzd9Nhq-cdqmSeMVLoxPLd1blviVT9Vm8-y12CtYpeJHOaIDtVPLlBhJiBoPKWg3vxSm4XxIliNOefqegIlsmTIa3MpS6WWlCK3yHhat0Q-rRxDxdyiVdG_wzJvp0Iw_2wms7pe-PgNPYvUWH9JphWP5K38YqEBiJFXQ</example>
        [DataMember(Name = "p", EmitDefaultValue = false)]
        public string P { get; set; }

        /// <summary>
        /// Gets or Sets Q
        /// </summary>
        /// <example>0A1FmpOWR91_RAWpqreWSavNaZb9nXeKiBo0DQGBz32DbqKqQ8S4aBJmbRhJcctjCLjain-ivut477tAUMmzJwVJDDq2MZFwC9Q-4VYZmFU4HJityQuSzHYe64RjN-E_NQ02TWhG3QGW6roq6c57c99rrUsETwJJiwS8M5p15Miuz53DaOjv-uqqFAFfywN5WkxHbraBcjHtMiQuyQbQqkCFh-oanHkwYNeytsNhTu2mQmwR5DR2roZ2nPiFjC6nsdk-A7E3S3wMzYYFw7jvbWWoYWo9vB40_MY2Y0FYQSqcDzcBIcq_0tnnasf3VW4Fdx6m80RzOb2Fsnln7vKXAQ</example>
        [DataMember(Name = "q", EmitDefaultValue = false)]
        public string Q { get; set; }

        /// <summary>
        /// Gets or Sets Qi
        /// </summary>
        /// <example>GyM_p6JrXySiz1toFgKbWV-JdI3jQ4ypu9rbMWx3rQJBfmt0FoYzgUIZEVFEcOqwemRN81zoDAaa-Bk0KWNGDjJHZDdDmFhW3AN7lI-puxk_mHZGJ11rxyR8O55XLSe3SPmRfKwZI6yU24ZxvQKFYItdldUKGzO6Ia6zTKhAVRU</example>
        [DataMember(Name = "qi", EmitDefaultValue = false)]
        public string Qi { get; set; }

        /// <summary>
        /// Use (\&quot;public key use\&quot;) identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Values are commonly \&quot;sig\&quot; (signature) or \&quot;enc\&quot; (encryption).
        /// </summary>
        /// <value>Use (\&quot;public key use\&quot;) identifies the intended use of the public key. The \&quot;use\&quot; parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Values are commonly \&quot;sig\&quot; (signature) or \&quot;enc\&quot; (encryption).</value>
        /// <example>sig</example>
        [DataMember(Name = "use", IsRequired = true, EmitDefaultValue = true)]
        public string Use { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        /// <example>f83OJ3D2xF1Bg8vub9tLe1gHMzV76e8Tus9uPHvRVEU</example>
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
        /// <example>x_FEzRu9m36HLN_tue659LNpXW6pCyStikYjKIWI5a0</example>
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
