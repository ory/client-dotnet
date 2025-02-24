/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.17.1
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
    /// ClientNormalizedProjectRevisionHook
    /// </summary>
    [DataContract(Name = "normalizedProjectRevisionHook")]
    public partial class ClientNormalizedProjectRevisionHook : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProjectRevisionHook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientNormalizedProjectRevisionHook()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProjectRevisionHook" /> class.
        /// </summary>
        /// <param name="configKey">The Hooks Config Key (required).</param>
        /// <param name="hook">The Hook Type (required).</param>
        /// <param name="id">ID of the entry.</param>
        /// <param name="projectRevisionId">The Revision&#39;s ID this schema belongs to.</param>
        /// <param name="webHookConfigAuthApiKeyIn">Whether to send the API Key in the HTTP Header or as a HTTP Cookie.</param>
        /// <param name="webHookConfigAuthApiKeyName">The name of the api key.</param>
        /// <param name="webHookConfigAuthApiKeyValue">The value of the api key.</param>
        /// <param name="webHookConfigAuthBasicAuthPassword">The password to be sent in the HTTP Basic Auth Header.</param>
        /// <param name="webHookConfigAuthBasicAuthUser">The username to be sent in the HTTP Basic Auth Header.</param>
        /// <param name="webHookConfigAuthType">HTTP Auth Method to use for the Web-Hook.</param>
        /// <param name="webHookConfigBody">URI pointing to the JsonNet template used for Web-Hook payload generation. Only used for those HTTP methods, which support HTTP body payloads..</param>
        /// <param name="webHookConfigCanInterrupt">If enabled allows the web hook to interrupt / abort the self-service flow. It only applies to certain flows (registration/verification/login/settings) and requires a valid response format..</param>
        /// <param name="webHookConfigMethod">The HTTP method to use (GET, POST, etc) for the Web-Hook.</param>
        /// <param name="webHookConfigResponseIgnore">Whether to ignore the Web Hook response.</param>
        /// <param name="webHookConfigResponseParse">Whether to parse the Web Hook response.</param>
        /// <param name="webHookConfigUrl">The URL the Web-Hook should call.</param>
        public ClientNormalizedProjectRevisionHook(string configKey = default(string), string hook = default(string), string id = default(string), string projectRevisionId = default(string), string webHookConfigAuthApiKeyIn = default(string), string webHookConfigAuthApiKeyName = default(string), string webHookConfigAuthApiKeyValue = default(string), string webHookConfigAuthBasicAuthPassword = default(string), string webHookConfigAuthBasicAuthUser = default(string), string webHookConfigAuthType = default(string), string webHookConfigBody = default(string), bool webHookConfigCanInterrupt = default(bool), string webHookConfigMethod = default(string), bool webHookConfigResponseIgnore = default(bool), bool webHookConfigResponseParse = default(bool), string webHookConfigUrl = default(string))
        {
            // to ensure "configKey" is required (not null)
            if (configKey == null)
            {
                throw new ArgumentNullException("configKey is a required property for ClientNormalizedProjectRevisionHook and cannot be null");
            }
            this.ConfigKey = configKey;
            // to ensure "hook" is required (not null)
            if (hook == null)
            {
                throw new ArgumentNullException("hook is a required property for ClientNormalizedProjectRevisionHook and cannot be null");
            }
            this.Hook = hook;
            this.Id = id;
            this.ProjectRevisionId = projectRevisionId;
            this.WebHookConfigAuthApiKeyIn = webHookConfigAuthApiKeyIn;
            this.WebHookConfigAuthApiKeyName = webHookConfigAuthApiKeyName;
            this.WebHookConfigAuthApiKeyValue = webHookConfigAuthApiKeyValue;
            this.WebHookConfigAuthBasicAuthPassword = webHookConfigAuthBasicAuthPassword;
            this.WebHookConfigAuthBasicAuthUser = webHookConfigAuthBasicAuthUser;
            this.WebHookConfigAuthType = webHookConfigAuthType;
            this.WebHookConfigBody = webHookConfigBody;
            this.WebHookConfigCanInterrupt = webHookConfigCanInterrupt;
            this.WebHookConfigMethod = webHookConfigMethod;
            this.WebHookConfigResponseIgnore = webHookConfigResponseIgnore;
            this.WebHookConfigResponseParse = webHookConfigResponseParse;
            this.WebHookConfigUrl = webHookConfigUrl;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The Hooks Config Key
        /// </summary>
        /// <value>The Hooks Config Key</value>
        [DataMember(Name = "config_key", IsRequired = true, EmitDefaultValue = true)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// The Project&#39;s Revision Creation Date
        /// </summary>
        /// <value>The Project&#39;s Revision Creation Date</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// The Hook Type
        /// </summary>
        /// <value>The Hook Type</value>
        [DataMember(Name = "hook", IsRequired = true, EmitDefaultValue = true)]
        public string Hook { get; set; }

        /// <summary>
        /// ID of the entry
        /// </summary>
        /// <value>ID of the entry</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The Revision&#39;s ID this schema belongs to
        /// </summary>
        /// <value>The Revision&#39;s ID this schema belongs to</value>
        [DataMember(Name = "project_revision_id", EmitDefaultValue = false)]
        public string ProjectRevisionId { get; set; }

        /// <summary>
        /// Last Time Project&#39;s Revision was Updated
        /// </summary>
        /// <value>Last Time Project&#39;s Revision was Updated</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Whether to send the API Key in the HTTP Header or as a HTTP Cookie
        /// </summary>
        /// <value>Whether to send the API Key in the HTTP Header or as a HTTP Cookie</value>
        /// <example>header</example>
        [DataMember(Name = "web_hook_config_auth_api_key_in", EmitDefaultValue = false)]
        public string WebHookConfigAuthApiKeyIn { get; set; }

        /// <summary>
        /// The name of the api key
        /// </summary>
        /// <value>The name of the api key</value>
        /// <example>X-API-Key</example>
        [DataMember(Name = "web_hook_config_auth_api_key_name", EmitDefaultValue = false)]
        public string WebHookConfigAuthApiKeyName { get; set; }

        /// <summary>
        /// The value of the api key
        /// </summary>
        /// <value>The value of the api key</value>
        /// <example>eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ</example>
        [DataMember(Name = "web_hook_config_auth_api_key_value", EmitDefaultValue = false)]
        public string WebHookConfigAuthApiKeyValue { get; set; }

        /// <summary>
        /// The password to be sent in the HTTP Basic Auth Header
        /// </summary>
        /// <value>The password to be sent in the HTTP Basic Auth Header</value>
        [DataMember(Name = "web_hook_config_auth_basic_auth_password", EmitDefaultValue = false)]
        public string WebHookConfigAuthBasicAuthPassword { get; set; }

        /// <summary>
        /// The username to be sent in the HTTP Basic Auth Header
        /// </summary>
        /// <value>The username to be sent in the HTTP Basic Auth Header</value>
        [DataMember(Name = "web_hook_config_auth_basic_auth_user", EmitDefaultValue = false)]
        public string WebHookConfigAuthBasicAuthUser { get; set; }

        /// <summary>
        /// HTTP Auth Method to use for the Web-Hook
        /// </summary>
        /// <value>HTTP Auth Method to use for the Web-Hook</value>
        [DataMember(Name = "web_hook_config_auth_type", EmitDefaultValue = false)]
        public string WebHookConfigAuthType { get; set; }

        /// <summary>
        /// URI pointing to the JsonNet template used for Web-Hook payload generation. Only used for those HTTP methods, which support HTTP body payloads.
        /// </summary>
        /// <value>URI pointing to the JsonNet template used for Web-Hook payload generation. Only used for those HTTP methods, which support HTTP body payloads.</value>
        /// <example>base64://ZnVuY3Rpb24oY3R4KSB7CiAgaWRlbnRpdHlfaWQ6IGlmIGN0eFsiaWRlbnRpdHkiXSAhPSBudWxsIHRoZW4gY3R4LmlkZW50aXR5LmlkLAp9&#x3D;</example>
        [DataMember(Name = "web_hook_config_body", EmitDefaultValue = false)]
        public string WebHookConfigBody { get; set; }

        /// <summary>
        /// If enabled allows the web hook to interrupt / abort the self-service flow. It only applies to certain flows (registration/verification/login/settings) and requires a valid response format.
        /// </summary>
        /// <value>If enabled allows the web hook to interrupt / abort the self-service flow. It only applies to certain flows (registration/verification/login/settings) and requires a valid response format.</value>
        [DataMember(Name = "web_hook_config_can_interrupt", EmitDefaultValue = true)]
        public bool WebHookConfigCanInterrupt { get; set; }

        /// <summary>
        /// The HTTP method to use (GET, POST, etc) for the Web-Hook
        /// </summary>
        /// <value>The HTTP method to use (GET, POST, etc) for the Web-Hook</value>
        /// <example>POST</example>
        [DataMember(Name = "web_hook_config_method", EmitDefaultValue = false)]
        public string WebHookConfigMethod { get; set; }

        /// <summary>
        /// Whether to ignore the Web Hook response
        /// </summary>
        /// <value>Whether to ignore the Web Hook response</value>
        [DataMember(Name = "web_hook_config_response_ignore", EmitDefaultValue = true)]
        public bool WebHookConfigResponseIgnore { get; set; }

        /// <summary>
        /// Whether to parse the Web Hook response
        /// </summary>
        /// <value>Whether to parse the Web Hook response</value>
        [DataMember(Name = "web_hook_config_response_parse", EmitDefaultValue = true)]
        public bool WebHookConfigResponseParse { get; set; }

        /// <summary>
        /// The URL the Web-Hook should call
        /// </summary>
        /// <value>The URL the Web-Hook should call</value>
        /// <example>https://www.example.org/web-hook-listener</example>
        [DataMember(Name = "web_hook_config_url", EmitDefaultValue = false)]
        public string WebHookConfigUrl { get; set; }

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
            sb.Append("class ClientNormalizedProjectRevisionHook {\n");
            sb.Append("  ConfigKey: ").Append(ConfigKey).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Hook: ").Append(Hook).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProjectRevisionId: ").Append(ProjectRevisionId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  WebHookConfigAuthApiKeyIn: ").Append(WebHookConfigAuthApiKeyIn).Append("\n");
            sb.Append("  WebHookConfigAuthApiKeyName: ").Append(WebHookConfigAuthApiKeyName).Append("\n");
            sb.Append("  WebHookConfigAuthApiKeyValue: ").Append(WebHookConfigAuthApiKeyValue).Append("\n");
            sb.Append("  WebHookConfigAuthBasicAuthPassword: ").Append(WebHookConfigAuthBasicAuthPassword).Append("\n");
            sb.Append("  WebHookConfigAuthBasicAuthUser: ").Append(WebHookConfigAuthBasicAuthUser).Append("\n");
            sb.Append("  WebHookConfigAuthType: ").Append(WebHookConfigAuthType).Append("\n");
            sb.Append("  WebHookConfigBody: ").Append(WebHookConfigBody).Append("\n");
            sb.Append("  WebHookConfigCanInterrupt: ").Append(WebHookConfigCanInterrupt).Append("\n");
            sb.Append("  WebHookConfigMethod: ").Append(WebHookConfigMethod).Append("\n");
            sb.Append("  WebHookConfigResponseIgnore: ").Append(WebHookConfigResponseIgnore).Append("\n");
            sb.Append("  WebHookConfigResponseParse: ").Append(WebHookConfigResponseParse).Append("\n");
            sb.Append("  WebHookConfigUrl: ").Append(WebHookConfigUrl).Append("\n");
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
