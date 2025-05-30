/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.11
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
    /// ClientOAuth2ConsentRequest
    /// </summary>
    [DataContract(Name = "oAuth2ConsentRequest")]
    public partial class ClientOAuth2ConsentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientOAuth2ConsentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientOAuth2ConsentRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientOAuth2ConsentRequest" /> class.
        /// </summary>
        /// <param name="acr">ACR represents the Authentication AuthorizationContext Class Reference value for this authentication session. You can use it to express that, for example, a user authenticated using two factor authentication..</param>
        /// <param name="amr">amr.</param>
        /// <param name="challenge">Challenge is used to retrieve/accept/deny the consent request. (required).</param>
        /// <param name="varClient">varClient.</param>
        /// <param name="consentRequestId">ConsentRequestID is the ID of the consent request..</param>
        /// <param name="context">context.</param>
        /// <param name="loginChallenge">LoginChallenge is the login challenge this consent challenge belongs to. It can be used to associate a login and consent request in the login &amp; consent app..</param>
        /// <param name="loginSessionId">LoginSessionID is the login session ID. If the user-agent reuses a login session (via cookie / remember flag) this ID will remain the same. If the user-agent did not have an existing authentication session (e.g. remember is false) this will be a new random value. This value is used as the \&quot;sid\&quot; parameter in the ID Token and in OIDC Front-/Back- channel logout. It&#39;s value can generally be used to associate consecutive login requests by a certain user..</param>
        /// <param name="oidcContext">oidcContext.</param>
        /// <param name="requestUrl">RequestURL is the original OAuth 2.0 Authorization URL requested by the OAuth 2.0 client. It is the URL which initiates the OAuth 2.0 Authorization Code or OAuth 2.0 Implicit flow. This URL is typically not needed, but might come in handy if you want to deal with additional request parameters..</param>
        /// <param name="requestedAccessTokenAudience">requestedAccessTokenAudience.</param>
        /// <param name="requestedScope">requestedScope.</param>
        /// <param name="skip">Skip, if true, implies that the client has requested the same scopes from the same user previously. If true, you must not ask the user to grant the requested scopes. You must however either allow or deny the consent request using the usual API call..</param>
        /// <param name="subject">Subject is the user ID of the end-user that authenticated. Now, that end user needs to grant or deny the scope requested by the OAuth 2.0 client..</param>
        public ClientOAuth2ConsentRequest(string acr = default(string), List<string> amr = default(List<string>), string challenge = default(string), ClientOAuth2Client varClient = default(ClientOAuth2Client), string consentRequestId = default(string), Object context = default(Object), string loginChallenge = default(string), string loginSessionId = default(string), ClientOAuth2ConsentRequestOpenIDConnectContext oidcContext = default(ClientOAuth2ConsentRequestOpenIDConnectContext), string requestUrl = default(string), List<string> requestedAccessTokenAudience = default(List<string>), List<string> requestedScope = default(List<string>), bool skip = default(bool), string subject = default(string))
        {
            // to ensure "challenge" is required (not null)
            if (challenge == null)
            {
                throw new ArgumentNullException("challenge is a required property for ClientOAuth2ConsentRequest and cannot be null");
            }
            this.Challenge = challenge;
            this.Acr = acr;
            this.Amr = amr;
            this.VarClient = varClient;
            this.ConsentRequestId = consentRequestId;
            this.Context = context;
            this.LoginChallenge = loginChallenge;
            this.LoginSessionId = loginSessionId;
            this.OidcContext = oidcContext;
            this.RequestUrl = requestUrl;
            this.RequestedAccessTokenAudience = requestedAccessTokenAudience;
            this.RequestedScope = requestedScope;
            this.Skip = skip;
            this.Subject = subject;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// ACR represents the Authentication AuthorizationContext Class Reference value for this authentication session. You can use it to express that, for example, a user authenticated using two factor authentication.
        /// </summary>
        /// <value>ACR represents the Authentication AuthorizationContext Class Reference value for this authentication session. You can use it to express that, for example, a user authenticated using two factor authentication.</value>
        [DataMember(Name = "acr", EmitDefaultValue = false)]
        public string Acr { get; set; }

        /// <summary>
        /// Gets or Sets Amr
        /// </summary>
        [DataMember(Name = "amr", EmitDefaultValue = false)]
        public List<string> Amr { get; set; }

        /// <summary>
        /// Challenge is used to retrieve/accept/deny the consent request.
        /// </summary>
        /// <value>Challenge is used to retrieve/accept/deny the consent request.</value>
        [DataMember(Name = "challenge", IsRequired = true, EmitDefaultValue = true)]
        public string Challenge { get; set; }

        /// <summary>
        /// Gets or Sets VarClient
        /// </summary>
        [DataMember(Name = "client", EmitDefaultValue = false)]
        public ClientOAuth2Client VarClient { get; set; }

        /// <summary>
        /// ConsentRequestID is the ID of the consent request.
        /// </summary>
        /// <value>ConsentRequestID is the ID of the consent request.</value>
        [DataMember(Name = "consent_request_id", EmitDefaultValue = false)]
        public string ConsentRequestId { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public Object Context { get; set; }

        /// <summary>
        /// LoginChallenge is the login challenge this consent challenge belongs to. It can be used to associate a login and consent request in the login &amp; consent app.
        /// </summary>
        /// <value>LoginChallenge is the login challenge this consent challenge belongs to. It can be used to associate a login and consent request in the login &amp; consent app.</value>
        [DataMember(Name = "login_challenge", EmitDefaultValue = false)]
        public string LoginChallenge { get; set; }

        /// <summary>
        /// LoginSessionID is the login session ID. If the user-agent reuses a login session (via cookie / remember flag) this ID will remain the same. If the user-agent did not have an existing authentication session (e.g. remember is false) this will be a new random value. This value is used as the \&quot;sid\&quot; parameter in the ID Token and in OIDC Front-/Back- channel logout. It&#39;s value can generally be used to associate consecutive login requests by a certain user.
        /// </summary>
        /// <value>LoginSessionID is the login session ID. If the user-agent reuses a login session (via cookie / remember flag) this ID will remain the same. If the user-agent did not have an existing authentication session (e.g. remember is false) this will be a new random value. This value is used as the \&quot;sid\&quot; parameter in the ID Token and in OIDC Front-/Back- channel logout. It&#39;s value can generally be used to associate consecutive login requests by a certain user.</value>
        [DataMember(Name = "login_session_id", EmitDefaultValue = false)]
        public string LoginSessionId { get; set; }

        /// <summary>
        /// Gets or Sets OidcContext
        /// </summary>
        [DataMember(Name = "oidc_context", EmitDefaultValue = false)]
        public ClientOAuth2ConsentRequestOpenIDConnectContext OidcContext { get; set; }

        /// <summary>
        /// RequestURL is the original OAuth 2.0 Authorization URL requested by the OAuth 2.0 client. It is the URL which initiates the OAuth 2.0 Authorization Code or OAuth 2.0 Implicit flow. This URL is typically not needed, but might come in handy if you want to deal with additional request parameters.
        /// </summary>
        /// <value>RequestURL is the original OAuth 2.0 Authorization URL requested by the OAuth 2.0 client. It is the URL which initiates the OAuth 2.0 Authorization Code or OAuth 2.0 Implicit flow. This URL is typically not needed, but might come in handy if you want to deal with additional request parameters.</value>
        [DataMember(Name = "request_url", EmitDefaultValue = false)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// Gets or Sets RequestedAccessTokenAudience
        /// </summary>
        [DataMember(Name = "requested_access_token_audience", EmitDefaultValue = false)]
        public List<string> RequestedAccessTokenAudience { get; set; }

        /// <summary>
        /// Gets or Sets RequestedScope
        /// </summary>
        [DataMember(Name = "requested_scope", EmitDefaultValue = false)]
        public List<string> RequestedScope { get; set; }

        /// <summary>
        /// Skip, if true, implies that the client has requested the same scopes from the same user previously. If true, you must not ask the user to grant the requested scopes. You must however either allow or deny the consent request using the usual API call.
        /// </summary>
        /// <value>Skip, if true, implies that the client has requested the same scopes from the same user previously. If true, you must not ask the user to grant the requested scopes. You must however either allow or deny the consent request using the usual API call.</value>
        [DataMember(Name = "skip", EmitDefaultValue = true)]
        public bool Skip { get; set; }

        /// <summary>
        /// Subject is the user ID of the end-user that authenticated. Now, that end user needs to grant or deny the scope requested by the OAuth 2.0 client.
        /// </summary>
        /// <value>Subject is the user ID of the end-user that authenticated. Now, that end user needs to grant or deny the scope requested by the OAuth 2.0 client.</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
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
            sb.Append("class ClientOAuth2ConsentRequest {\n");
            sb.Append("  Acr: ").Append(Acr).Append("\n");
            sb.Append("  Amr: ").Append(Amr).Append("\n");
            sb.Append("  Challenge: ").Append(Challenge).Append("\n");
            sb.Append("  VarClient: ").Append(VarClient).Append("\n");
            sb.Append("  ConsentRequestId: ").Append(ConsentRequestId).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  LoginChallenge: ").Append(LoginChallenge).Append("\n");
            sb.Append("  LoginSessionId: ").Append(LoginSessionId).Append("\n");
            sb.Append("  OidcContext: ").Append(OidcContext).Append("\n");
            sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
            sb.Append("  RequestedAccessTokenAudience: ").Append(RequestedAccessTokenAudience).Append("\n");
            sb.Append("  RequestedScope: ").Append(RequestedScope).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
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
