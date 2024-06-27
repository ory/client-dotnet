/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.0
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
    /// A singular authenticator used during authentication / login.
    /// </summary>
    [DataContract(Name = "sessionAuthenticationMethod")]
    public partial class ClientSessionAuthenticationMethod : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Aal
        /// </summary>
        [DataMember(Name = "aal", EmitDefaultValue = false)]
        public ClientAuthenticatorAssuranceLevel? Aal { get; set; }
        /// <summary>
        /// Defines Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum LinkRecovery for value: link_recovery
            /// </summary>
            [EnumMember(Value = "link_recovery")]
            LinkRecovery = 1,

            /// <summary>
            /// Enum CodeRecovery for value: code_recovery
            /// </summary>
            [EnumMember(Value = "code_recovery")]
            CodeRecovery = 2,

            /// <summary>
            /// Enum Password for value: password
            /// </summary>
            [EnumMember(Value = "password")]
            Password = 3,

            /// <summary>
            /// Enum Code for value: code
            /// </summary>
            [EnumMember(Value = "code")]
            Code = 4,

            /// <summary>
            /// Enum Totp for value: totp
            /// </summary>
            [EnumMember(Value = "totp")]
            Totp = 5,

            /// <summary>
            /// Enum Oidc for value: oidc
            /// </summary>
            [EnumMember(Value = "oidc")]
            Oidc = 6,

            /// <summary>
            /// Enum Webauthn for value: webauthn
            /// </summary>
            [EnumMember(Value = "webauthn")]
            Webauthn = 7,

            /// <summary>
            /// Enum LookupSecret for value: lookup_secret
            /// </summary>
            [EnumMember(Value = "lookup_secret")]
            LookupSecret = 8,

            /// <summary>
            /// Enum V06LegacySession for value: v0.6_legacy_session
            /// </summary>
            [EnumMember(Value = "v0.6_legacy_session")]
            V06LegacySession = 9
        }


        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSessionAuthenticationMethod" /> class.
        /// </summary>
        /// <param name="aal">aal.</param>
        /// <param name="completedAt">When the authentication challenge was completed..</param>
        /// <param name="method">method.</param>
        /// <param name="organization">The Organization id used for authentication.</param>
        /// <param name="provider">OIDC or SAML provider id used for authentication.</param>
        public ClientSessionAuthenticationMethod(ClientAuthenticatorAssuranceLevel? aal = default(ClientAuthenticatorAssuranceLevel?), DateTime completedAt = default(DateTime), MethodEnum? method = default(MethodEnum?), string organization = default(string), string provider = default(string))
        {
            this.Aal = aal;
            this.CompletedAt = completedAt;
            this.Method = method;
            this.Organization = organization;
            this.Provider = provider;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// When the authentication challenge was completed.
        /// </summary>
        /// <value>When the authentication challenge was completed.</value>
        [DataMember(Name = "completed_at", EmitDefaultValue = false)]
        public DateTime CompletedAt { get; set; }

        /// <summary>
        /// The Organization id used for authentication
        /// </summary>
        /// <value>The Organization id used for authentication</value>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public string Organization { get; set; }

        /// <summary>
        /// OIDC or SAML provider id used for authentication
        /// </summary>
        /// <value>OIDC or SAML provider id used for authentication</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

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
            sb.Append("class ClientSessionAuthenticationMethod {\n");
            sb.Append("  Aal: ").Append(Aal).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
