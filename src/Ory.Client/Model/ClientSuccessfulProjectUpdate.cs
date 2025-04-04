/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.3
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
    /// ClientSuccessfulProjectUpdate
    /// </summary>
    [DataContract(Name = "successfulProjectUpdate")]
    public partial class ClientSuccessfulProjectUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSuccessfulProjectUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSuccessfulProjectUpdate()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSuccessfulProjectUpdate" /> class.
        /// </summary>
        /// <param name="project">project (required).</param>
        /// <param name="warnings">Import Warnings  Not all configuration items can be imported to the Ory Network. For example, setting the port does not make sense because the Ory Network provides the runtime and networking.  This field contains warnings where configuration keys were found but can not be imported. These keys will be ignored by the Ory Network. This field will help you understand why certain configuration keys might not be respected! (required).</param>
        public ClientSuccessfulProjectUpdate(ClientProject project = default(ClientProject), List<ClientWarning> warnings = default(List<ClientWarning>))
        {
            // to ensure "project" is required (not null)
            if (project == null)
            {
                throw new ArgumentNullException("project is a required property for ClientSuccessfulProjectUpdate and cannot be null");
            }
            this.Project = project;
            // to ensure "warnings" is required (not null)
            if (warnings == null)
            {
                throw new ArgumentNullException("warnings is a required property for ClientSuccessfulProjectUpdate and cannot be null");
            }
            this.Warnings = warnings;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", IsRequired = true, EmitDefaultValue = true)]
        public ClientProject Project { get; set; }

        /// <summary>
        /// Import Warnings  Not all configuration items can be imported to the Ory Network. For example, setting the port does not make sense because the Ory Network provides the runtime and networking.  This field contains warnings where configuration keys were found but can not be imported. These keys will be ignored by the Ory Network. This field will help you understand why certain configuration keys might not be respected!
        /// </summary>
        /// <value>Import Warnings  Not all configuration items can be imported to the Ory Network. For example, setting the port does not make sense because the Ory Network provides the runtime and networking.  This field contains warnings where configuration keys were found but can not be imported. These keys will be ignored by the Ory Network. This field will help you understand why certain configuration keys might not be respected!</value>
        [DataMember(Name = "warnings", IsRequired = true, EmitDefaultValue = true)]
        public List<ClientWarning> Warnings { get; set; }

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
            sb.Append("class ClientSuccessfulProjectUpdate {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
