/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.9
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
    /// An [identity](https://www.ory.sh/docs/kratos/concepts/identity-user-model) represents a (human) user in Ory.
    /// </summary>
    [DataContract(Name = "identity")]
    public partial class ClientIdentity : IValidatableObject
    {
        /// <summary>
        /// State is the identity&#39;s state.  This value has currently no effect. active StateActive inactive StateInactive
        /// </summary>
        /// <value>State is the identity&#39;s state.  This value has currently no effect. active StateActive inactive StateInactive</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2
        }


        /// <summary>
        /// State is the identity&#39;s state.  This value has currently no effect. active StateActive inactive StateInactive
        /// </summary>
        /// <value>State is the identity&#39;s state.  This value has currently no effect. active StateActive inactive StateInactive</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientIdentity()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentity" /> class.
        /// </summary>
        /// <param name="createdAt">CreatedAt is a helper struct field for gobuffalo.pop..</param>
        /// <param name="credentials">Credentials represents all credentials that can be used for authenticating this identity..</param>
        /// <param name="id">ID is the identity&#39;s unique identifier.  The Identity ID can not be changed and can not be chosen. This ensures future compatibility and optimization for distributed stores such as CockroachDB. (required).</param>
        /// <param name="metadataAdmin">NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-.</param>
        /// <param name="metadataPublic">NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="recoveryAddresses">RecoveryAddresses contains all the addresses that can be used to recover an identity..</param>
        /// <param name="schemaId">SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. (required).</param>
        /// <param name="schemaUrl">SchemaURL is the URL of the endpoint where the identity&#39;s traits schema can be fetched from.  format: url (required).</param>
        /// <param name="state">State is the identity&#39;s state.  This value has currently no effect. active StateActive inactive StateInactive.</param>
        /// <param name="stateChangedAt">stateChangedAt.</param>
        /// <param name="traits">Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;. (required).</param>
        /// <param name="updatedAt">UpdatedAt is a helper struct field for gobuffalo.pop..</param>
        /// <param name="verifiableAddresses">VerifiableAddresses contains all the addresses that can be verified by the user..</param>
        public ClientIdentity(DateTime createdAt = default(DateTime), Dictionary<string, ClientIdentityCredentials> credentials = default(Dictionary<string, ClientIdentityCredentials>), string id = default(string), Object metadataAdmin = default(Object), Object metadataPublic = default(Object), string organizationId = default(string), List<ClientRecoveryIdentityAddress> recoveryAddresses = default(List<ClientRecoveryIdentityAddress>), string schemaId = default(string), string schemaUrl = default(string), StateEnum? state = default(StateEnum?), DateTime stateChangedAt = default(DateTime), Object traits = default(Object), DateTime updatedAt = default(DateTime), List<ClientVerifiableIdentityAddress> verifiableAddresses = default(List<ClientVerifiableIdentityAddress>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ClientIdentity and cannot be null");
            }
            this.Id = id;
            // to ensure "schemaId" is required (not null)
            if (schemaId == null)
            {
                throw new ArgumentNullException("schemaId is a required property for ClientIdentity and cannot be null");
            }
            this.SchemaId = schemaId;
            // to ensure "schemaUrl" is required (not null)
            if (schemaUrl == null)
            {
                throw new ArgumentNullException("schemaUrl is a required property for ClientIdentity and cannot be null");
            }
            this.SchemaUrl = schemaUrl;
            // to ensure "traits" is required (not null)
            if (traits == null)
            {
                throw new ArgumentNullException("traits is a required property for ClientIdentity and cannot be null");
            }
            this.Traits = traits;
            this.CreatedAt = createdAt;
            this.Credentials = credentials;
            this.MetadataAdmin = metadataAdmin;
            this.MetadataPublic = metadataPublic;
            this.OrganizationId = organizationId;
            this.RecoveryAddresses = recoveryAddresses;
            this.State = state;
            this.StateChangedAt = stateChangedAt;
            this.UpdatedAt = updatedAt;
            this.VerifiableAddresses = verifiableAddresses;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// CreatedAt is a helper struct field for gobuffalo.pop.
        /// </summary>
        /// <value>CreatedAt is a helper struct field for gobuffalo.pop.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Credentials represents all credentials that can be used for authenticating this identity.
        /// </summary>
        /// <value>Credentials represents all credentials that can be used for authenticating this identity.</value>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public Dictionary<string, ClientIdentityCredentials> Credentials { get; set; }

        /// <summary>
        /// ID is the identity&#39;s unique identifier.  The Identity ID can not be changed and can not be chosen. This ensures future compatibility and optimization for distributed stores such as CockroachDB.
        /// </summary>
        /// <value>ID is the identity&#39;s unique identifier.  The Identity ID can not be changed and can not be chosen. This ensures future compatibility and optimization for distributed stores such as CockroachDB.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-
        /// </summary>
        /// <value>NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-</value>
        [DataMember(Name = "metadata_admin", EmitDefaultValue = true)]
        public Object MetadataAdmin { get; set; }

        /// <summary>
        /// NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-
        /// </summary>
        /// <value>NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-</value>
        [DataMember(Name = "metadata_public", EmitDefaultValue = true)]
        public Object MetadataPublic { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name = "organization_id", EmitDefaultValue = true)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// RecoveryAddresses contains all the addresses that can be used to recover an identity.
        /// </summary>
        /// <value>RecoveryAddresses contains all the addresses that can be used to recover an identity.</value>
        [DataMember(Name = "recovery_addresses", EmitDefaultValue = false)]
        public List<ClientRecoveryIdentityAddress> RecoveryAddresses { get; set; }

        /// <summary>
        /// SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits.
        /// </summary>
        /// <value>SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits.</value>
        [DataMember(Name = "schema_id", IsRequired = true, EmitDefaultValue = true)]
        public string SchemaId { get; set; }

        /// <summary>
        /// SchemaURL is the URL of the endpoint where the identity&#39;s traits schema can be fetched from.  format: url
        /// </summary>
        /// <value>SchemaURL is the URL of the endpoint where the identity&#39;s traits schema can be fetched from.  format: url</value>
        [DataMember(Name = "schema_url", IsRequired = true, EmitDefaultValue = true)]
        public string SchemaUrl { get; set; }

        /// <summary>
        /// Gets or Sets StateChangedAt
        /// </summary>
        [DataMember(Name = "state_changed_at", EmitDefaultValue = false)]
        public DateTime StateChangedAt { get; set; }

        /// <summary>
        /// Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;.
        /// </summary>
        /// <value>Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;.</value>
        [DataMember(Name = "traits", IsRequired = true, EmitDefaultValue = true)]
        public Object Traits { get; set; }

        /// <summary>
        /// UpdatedAt is a helper struct field for gobuffalo.pop.
        /// </summary>
        /// <value>UpdatedAt is a helper struct field for gobuffalo.pop.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// VerifiableAddresses contains all the addresses that can be verified by the user.
        /// </summary>
        /// <value>VerifiableAddresses contains all the addresses that can be verified by the user.</value>
        [DataMember(Name = "verifiable_addresses", EmitDefaultValue = false)]
        public List<ClientVerifiableIdentityAddress> VerifiableAddresses { get; set; }

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
            sb.Append("class ClientIdentity {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MetadataAdmin: ").Append(MetadataAdmin).Append("\n");
            sb.Append("  MetadataPublic: ").Append(MetadataPublic).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  RecoveryAddresses: ").Append(RecoveryAddresses).Append("\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  SchemaUrl: ").Append(SchemaUrl).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateChangedAt: ").Append(StateChangedAt).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  VerifiableAddresses: ").Append(VerifiableAddresses).Append("\n");
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
