/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.13.10
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
    /// ClientAcceptOAuth2ConsentRequest
    /// </summary>
    [DataContract(Name = "acceptOAuth2ConsentRequest")]
    public partial class ClientAcceptOAuth2ConsentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAcceptOAuth2ConsentRequest" /> class.
        /// </summary>
        /// <param name="context">context.</param>
        /// <param name="grantAccessTokenAudience">grantAccessTokenAudience.</param>
        /// <param name="grantScope">grantScope.</param>
        /// <param name="handledAt">handledAt.</param>
        /// <param name="remember">Remember, if set to true, tells ORY Hydra to remember this consent authorization and reuse it if the same client asks the same user for the same, or a subset of, scope..</param>
        /// <param name="rememberFor">RememberFor sets how long the consent authorization should be remembered for in seconds. If set to &#x60;0&#x60;, the authorization will be remembered indefinitely..</param>
        /// <param name="session">session.</param>
        public ClientAcceptOAuth2ConsentRequest(Object context = default(Object), List<string> grantAccessTokenAudience = default(List<string>), List<string> grantScope = default(List<string>), DateTime handledAt = default(DateTime), bool remember = default(bool), long rememberFor = default(long), ClientAcceptOAuth2ConsentRequestSession session = default(ClientAcceptOAuth2ConsentRequestSession))
        {
            this.Context = context;
            this.GrantAccessTokenAudience = grantAccessTokenAudience;
            this.GrantScope = grantScope;
            this.HandledAt = handledAt;
            this.Remember = remember;
            this.RememberFor = rememberFor;
            this.Session = session;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public Object Context { get; set; }

        /// <summary>
        /// Gets or Sets GrantAccessTokenAudience
        /// </summary>
        [DataMember(Name = "grant_access_token_audience", EmitDefaultValue = false)]
        public List<string> GrantAccessTokenAudience { get; set; }

        /// <summary>
        /// Gets or Sets GrantScope
        /// </summary>
        [DataMember(Name = "grant_scope", EmitDefaultValue = false)]
        public List<string> GrantScope { get; set; }

        /// <summary>
        /// Gets or Sets HandledAt
        /// </summary>
        [DataMember(Name = "handled_at", EmitDefaultValue = false)]
        public DateTime HandledAt { get; set; }

        /// <summary>
        /// Remember, if set to true, tells ORY Hydra to remember this consent authorization and reuse it if the same client asks the same user for the same, or a subset of, scope.
        /// </summary>
        /// <value>Remember, if set to true, tells ORY Hydra to remember this consent authorization and reuse it if the same client asks the same user for the same, or a subset of, scope.</value>
        [DataMember(Name = "remember", EmitDefaultValue = true)]
        public bool Remember { get; set; }

        /// <summary>
        /// RememberFor sets how long the consent authorization should be remembered for in seconds. If set to &#x60;0&#x60;, the authorization will be remembered indefinitely.
        /// </summary>
        /// <value>RememberFor sets how long the consent authorization should be remembered for in seconds. If set to &#x60;0&#x60;, the authorization will be remembered indefinitely.</value>
        [DataMember(Name = "remember_for", EmitDefaultValue = false)]
        public long RememberFor { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = false)]
        public ClientAcceptOAuth2ConsentRequestSession Session { get; set; }

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
            sb.Append("class ClientAcceptOAuth2ConsentRequest {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  GrantAccessTokenAudience: ").Append(GrantAccessTokenAudience).Append("\n");
            sb.Append("  GrantScope: ").Append(GrantScope).Append("\n");
            sb.Append("  HandledAt: ").Append(HandledAt).Append("\n");
            sb.Append("  Remember: ").Append(Remember).Append("\n");
            sb.Append("  RememberFor: ").Append(RememberFor).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
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
