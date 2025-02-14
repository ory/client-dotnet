/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.7
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
    /// Update Login Flow with Password Method
    /// </summary>
    [DataContract(Name = "updateLoginFlowWithPasswordMethod")]
    public partial class ClientUpdateLoginFlowWithPasswordMethod : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowWithPasswordMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientUpdateLoginFlowWithPasswordMethod()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowWithPasswordMethod" /> class.
        /// </summary>
        /// <param name="csrfToken">Sending the anti-csrf token is only required for browser login flows..</param>
        /// <param name="identifier">Identifier is the email or username of the user trying to log in. (required).</param>
        /// <param name="method">Method should be set to \&quot;password\&quot; when logging in using the identifier and password strategy. (required).</param>
        /// <param name="password">The user&#39;s password. (required).</param>
        /// <param name="passwordIdentifier">Identifier is the email or username of the user trying to log in. This field is deprecated!.</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks.</param>
        public ClientUpdateLoginFlowWithPasswordMethod(string csrfToken = default(string), string identifier = default(string), string method = default(string), string password = default(string), string passwordIdentifier = default(string), Object transientPayload = default(Object))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for ClientUpdateLoginFlowWithPasswordMethod and cannot be null");
            }
            this.Identifier = identifier;
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for ClientUpdateLoginFlowWithPasswordMethod and cannot be null");
            }
            this.Method = method;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for ClientUpdateLoginFlowWithPasswordMethod and cannot be null");
            }
            this.Password = password;
            this.CsrfToken = csrfToken;
            this.PasswordIdentifier = passwordIdentifier;
            this.TransientPayload = transientPayload;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Sending the anti-csrf token is only required for browser login flows.
        /// </summary>
        /// <value>Sending the anti-csrf token is only required for browser login flows.</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// Identifier is the email or username of the user trying to log in.
        /// </summary>
        /// <value>Identifier is the email or username of the user trying to log in.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Method should be set to \&quot;password\&quot; when logging in using the identifier and password strategy.
        /// </summary>
        /// <value>Method should be set to \&quot;password\&quot; when logging in using the identifier and password strategy.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// The user&#39;s password.
        /// </summary>
        /// <value>The user&#39;s password.</value>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Identifier is the email or username of the user trying to log in. This field is deprecated!
        /// </summary>
        /// <value>Identifier is the email or username of the user trying to log in. This field is deprecated!</value>
        [DataMember(Name = "password_identifier", EmitDefaultValue = false)]
        public string PasswordIdentifier { get; set; }

        /// <summary>
        /// Transient data to pass along to any webhooks
        /// </summary>
        /// <value>Transient data to pass along to any webhooks</value>
        [DataMember(Name = "transient_payload", EmitDefaultValue = false)]
        public Object TransientPayload { get; set; }

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
            sb.Append("class ClientUpdateLoginFlowWithPasswordMethod {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordIdentifier: ").Append(PasswordIdentifier).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
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
