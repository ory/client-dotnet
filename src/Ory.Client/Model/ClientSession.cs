/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.6
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
    /// A Session
    /// </summary>
    [DataContract(Name = "session")]
    public partial class ClientSession : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AuthenticatorAssuranceLevel
        /// </summary>
        [DataMember(Name = "authenticator_assurance_level", EmitDefaultValue = false)]
        public ClientAuthenticatorAssuranceLevel? AuthenticatorAssuranceLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSession()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSession" /> class.
        /// </summary>
        /// <param name="active">Active state. If false the session is no longer active..</param>
        /// <param name="authenticatedAt">The Session Authentication Timestamp  When this session was authenticated at. If multi-factor authentication was used this is the time when the last factor was authenticated (e.g. the TOTP code challenge was completed)..</param>
        /// <param name="authenticationMethods">A list of authenticators which were used to authenticate the session..</param>
        /// <param name="authenticatorAssuranceLevel">authenticatorAssuranceLevel.</param>
        /// <param name="devices">Devices has history of all endpoints where the session was used.</param>
        /// <param name="expiresAt">The Session Expiry  When this session expires at..</param>
        /// <param name="id">Session ID (required).</param>
        /// <param name="identity">identity.</param>
        /// <param name="issuedAt">The Session Issuance Timestamp  When this session was issued at. Usually equal or close to &#x60;authenticated_at&#x60;..</param>
        /// <param name="tokenized">Tokenized is the tokenized (e.g. JWT) version of the session.  It is only set when the &#x60;tokenize&#x60; query parameter was set to a valid tokenize template during calls to &#x60;/session/whoami&#x60;..</param>
        public ClientSession(bool active = default(bool), DateTime authenticatedAt = default(DateTime), List<ClientSessionAuthenticationMethod> authenticationMethods = default(List<ClientSessionAuthenticationMethod>), ClientAuthenticatorAssuranceLevel? authenticatorAssuranceLevel = default(ClientAuthenticatorAssuranceLevel?), List<ClientSessionDevice> devices = default(List<ClientSessionDevice>), DateTime expiresAt = default(DateTime), string id = default(string), ClientIdentity identity = default(ClientIdentity), DateTime issuedAt = default(DateTime), string tokenized = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ClientSession and cannot be null");
            }
            this.Id = id;
            this.Active = active;
            this.AuthenticatedAt = authenticatedAt;
            this.AuthenticationMethods = authenticationMethods;
            this.AuthenticatorAssuranceLevel = authenticatorAssuranceLevel;
            this.Devices = devices;
            this.ExpiresAt = expiresAt;
            this.Identity = identity;
            this.IssuedAt = issuedAt;
            this.Tokenized = tokenized;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Active state. If false the session is no longer active.
        /// </summary>
        /// <value>Active state. If false the session is no longer active.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// The Session Authentication Timestamp  When this session was authenticated at. If multi-factor authentication was used this is the time when the last factor was authenticated (e.g. the TOTP code challenge was completed).
        /// </summary>
        /// <value>The Session Authentication Timestamp  When this session was authenticated at. If multi-factor authentication was used this is the time when the last factor was authenticated (e.g. the TOTP code challenge was completed).</value>
        [DataMember(Name = "authenticated_at", EmitDefaultValue = false)]
        public DateTime AuthenticatedAt { get; set; }

        /// <summary>
        /// A list of authenticators which were used to authenticate the session.
        /// </summary>
        /// <value>A list of authenticators which were used to authenticate the session.</value>
        [DataMember(Name = "authentication_methods", EmitDefaultValue = false)]
        public List<ClientSessionAuthenticationMethod> AuthenticationMethods { get; set; }

        /// <summary>
        /// Devices has history of all endpoints where the session was used
        /// </summary>
        /// <value>Devices has history of all endpoints where the session was used</value>
        [DataMember(Name = "devices", EmitDefaultValue = false)]
        public List<ClientSessionDevice> Devices { get; set; }

        /// <summary>
        /// The Session Expiry  When this session expires at.
        /// </summary>
        /// <value>The Session Expiry  When this session expires at.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Session ID
        /// </summary>
        /// <value>Session ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public ClientIdentity Identity { get; set; }

        /// <summary>
        /// The Session Issuance Timestamp  When this session was issued at. Usually equal or close to &#x60;authenticated_at&#x60;.
        /// </summary>
        /// <value>The Session Issuance Timestamp  When this session was issued at. Usually equal or close to &#x60;authenticated_at&#x60;.</value>
        [DataMember(Name = "issued_at", EmitDefaultValue = false)]
        public DateTime IssuedAt { get; set; }

        /// <summary>
        /// Tokenized is the tokenized (e.g. JWT) version of the session.  It is only set when the &#x60;tokenize&#x60; query parameter was set to a valid tokenize template during calls to &#x60;/session/whoami&#x60;.
        /// </summary>
        /// <value>Tokenized is the tokenized (e.g. JWT) version of the session.  It is only set when the &#x60;tokenize&#x60; query parameter was set to a valid tokenize template during calls to &#x60;/session/whoami&#x60;.</value>
        [DataMember(Name = "tokenized", EmitDefaultValue = false)]
        public string Tokenized { get; set; }

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
            sb.Append("class ClientSession {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AuthenticatedAt: ").Append(AuthenticatedAt).Append("\n");
            sb.Append("  AuthenticationMethods: ").Append(AuthenticationMethods).Append("\n");
            sb.Append("  AuthenticatorAssuranceLevel: ").Append(AuthenticatorAssuranceLevel).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  Tokenized: ").Append(Tokenized).Append("\n");
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
