/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.1
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
    /// Update Registration Flow with Profile Method
    /// </summary>
    [DataContract(Name = "updateRegistrationFlowWithProfileMethod")]
    public partial class ClientUpdateRegistrationFlowWithProfileMethod : IValidatableObject
    {
        /// <summary>
        /// Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious
        /// </summary>
        /// <value>Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScreenEnum
        {
            /// <summary>
            /// Enum CredentialSelection for value: credential-selection
            /// </summary>
            [EnumMember(Value = "credential-selection")]
            CredentialSelection = 1,

            /// <summary>
            /// Enum Previous for value: previous
            /// </summary>
            [EnumMember(Value = "previous")]
            Previous = 2
        }


        /// <summary>
        /// Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious
        /// </summary>
        /// <value>Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious</value>
        [DataMember(Name = "screen", EmitDefaultValue = false)]
        public ScreenEnum? Screen { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateRegistrationFlowWithProfileMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientUpdateRegistrationFlowWithProfileMethod()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateRegistrationFlowWithProfileMethod" /> class.
        /// </summary>
        /// <param name="csrfToken">The Anti-CSRF Token  This token is only required when performing browser flows..</param>
        /// <param name="method">Method  Should be set to profile when trying to update a profile. (required).</param>
        /// <param name="screen">Screen requests navigation to a previous screen.  This must be set to credential-selection to go back to the credential selection screen. credential-selection RegistrationScreenCredentialSelection nolint:gosec // not a credential previous RegistrationScreenPrevious.</param>
        /// <param name="traits">Traits  The identity&#39;s traits. (required).</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks.</param>
        public ClientUpdateRegistrationFlowWithProfileMethod(string csrfToken = default(string), string method = default(string), ScreenEnum? screen = default(ScreenEnum?), Object traits = default(Object), Object transientPayload = default(Object))
        {
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for ClientUpdateRegistrationFlowWithProfileMethod and cannot be null");
            }
            this.Method = method;
            // to ensure "traits" is required (not null)
            if (traits == null)
            {
                throw new ArgumentNullException("traits is a required property for ClientUpdateRegistrationFlowWithProfileMethod and cannot be null");
            }
            this.Traits = traits;
            this.CsrfToken = csrfToken;
            this.Screen = screen;
            this.TransientPayload = transientPayload;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Anti-CSRF Token  This token is only required when performing browser flows.
        /// </summary>
        /// <value>The Anti-CSRF Token  This token is only required when performing browser flows.</value>
        [DataMember(Name = "csrf_token", EmitDefaultValue = false)]
        public string CsrfToken { get; set; }

        /// <summary>
        /// Method  Should be set to profile when trying to update a profile.
        /// </summary>
        /// <value>Method  Should be set to profile when trying to update a profile.</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// Traits  The identity&#39;s traits.
        /// </summary>
        /// <value>Traits  The identity&#39;s traits.</value>
        [DataMember(Name = "traits", IsRequired = true, EmitDefaultValue = true)]
        public Object Traits { get; set; }

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
            sb.Append("class ClientUpdateRegistrationFlowWithProfileMethod {\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Screen: ").Append(Screen).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
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
