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
    /// ClientNormalizedProjectRevisionIdentitySchema
    /// </summary>
    [DataContract(Name = "normalizedProjectRevisionIdentitySchema")]
    public partial class ClientNormalizedProjectRevisionIdentitySchema : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProjectRevisionIdentitySchema" /> class.
        /// </summary>
        /// <param name="id">The unique ID of this entry..</param>
        /// <param name="identitySchema">identitySchema.</param>
        /// <param name="identitySchemaId">identitySchemaId.</param>
        /// <param name="importId">The imported (named) ID of the Identity Schema referenced in the Ory Kratos config..</param>
        /// <param name="importUrl">The ImportURL can be used to import an Identity Schema from a bse64 encoded string. In the future, this key also support HTTPS and other sources!  If you import an Ory Kratos configuration, this would be akin to the &#x60;identity.schemas.#.url&#x60; key.  The configuration will always return the import URL when you fetch it from the API..</param>
        /// <param name="isDefault">If true sets the default schema for identities  Only one schema can ever be the default schema. If you try to add two schemas with default to true, the request will fail..</param>
        /// <param name="preset">Use a preset instead of a custom identity schema..</param>
        /// <param name="projectRevisionId">The Revision&#39;s ID this schema belongs to.</param>
        public ClientNormalizedProjectRevisionIdentitySchema(string id = default(string), ClientManagedIdentitySchema identitySchema = default(ClientManagedIdentitySchema), string identitySchemaId = default(string), string importId = default(string), string importUrl = default(string), bool isDefault = default(bool), string preset = default(string), string projectRevisionId = default(string))
        {
            this.Id = id;
            this.IdentitySchema = identitySchema;
            this.IdentitySchemaId = identitySchemaId;
            this.ImportId = importId;
            this.ImportUrl = importUrl;
            this.IsDefault = isDefault;
            this.Preset = preset;
            this.ProjectRevisionId = projectRevisionId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

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
        /// The unique ID of this entry.
        /// </summary>
        /// <value>The unique ID of this entry.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IdentitySchema
        /// </summary>
        [DataMember(Name = "identity_schema", EmitDefaultValue = false)]
        public ClientManagedIdentitySchema IdentitySchema { get; set; }

        /// <summary>
        /// Gets or Sets IdentitySchemaId
        /// </summary>
        [DataMember(Name = "identity_schema_id", EmitDefaultValue = true)]
        public string IdentitySchemaId { get; set; }

        /// <summary>
        /// The imported (named) ID of the Identity Schema referenced in the Ory Kratos config.
        /// </summary>
        /// <value>The imported (named) ID of the Identity Schema referenced in the Ory Kratos config.</value>
        [DataMember(Name = "import_id", EmitDefaultValue = false)]
        public string ImportId { get; set; }

        /// <summary>
        /// The ImportURL can be used to import an Identity Schema from a bse64 encoded string. In the future, this key also support HTTPS and other sources!  If you import an Ory Kratos configuration, this would be akin to the &#x60;identity.schemas.#.url&#x60; key.  The configuration will always return the import URL when you fetch it from the API.
        /// </summary>
        /// <value>The ImportURL can be used to import an Identity Schema from a bse64 encoded string. In the future, this key also support HTTPS and other sources!  If you import an Ory Kratos configuration, this would be akin to the &#x60;identity.schemas.#.url&#x60; key.  The configuration will always return the import URL when you fetch it from the API.</value>
        /// <example>base64://ey...</example>
        [DataMember(Name = "import_url", EmitDefaultValue = false)]
        public string ImportUrl { get; set; }

        /// <summary>
        /// If true sets the default schema for identities  Only one schema can ever be the default schema. If you try to add two schemas with default to true, the request will fail.
        /// </summary>
        /// <value>If true sets the default schema for identities  Only one schema can ever be the default schema. If you try to add two schemas with default to true, the request will fail.</value>
        [DataMember(Name = "is_default", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Use a preset instead of a custom identity schema.
        /// </summary>
        /// <value>Use a preset instead of a custom identity schema.</value>
        [DataMember(Name = "preset", EmitDefaultValue = false)]
        public string Preset { get; set; }

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
            sb.Append("class ClientNormalizedProjectRevisionIdentitySchema {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentitySchema: ").Append(IdentitySchema).Append("\n");
            sb.Append("  IdentitySchemaId: ").Append(IdentitySchemaId).Append("\n");
            sb.Append("  ImportId: ").Append(ImportId).Append("\n");
            sb.Append("  ImportUrl: ").Append(ImportUrl).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Preset: ").Append(Preset).Append("\n");
            sb.Append("  ProjectRevisionId: ").Append(ProjectRevisionId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
