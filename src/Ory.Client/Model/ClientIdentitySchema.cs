/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.1.0-alpha.7
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
    /// Together the name and identity uuid are a unique index constraint. This prevents a user from having schemas with the same name. This also allows schemas to have the same name across the system.
    /// </summary>
    [DataContract(Name = "identitySchema")]
    public partial class ClientIdentitySchema : IEquatable<ClientIdentitySchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentitySchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientIdentitySchema()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentitySchema" /> class.
        /// </summary>
        /// <param name="blobName">The gcs file name  This is a randomly generated name which is used to uniquely identify the file on the blob storage (required).</param>
        /// <param name="blobUrl">The publicly accessible url of the schema (required).</param>
        /// <param name="contentHash">The Content Hash  Contains a hash of the schema&#39;s content..</param>
        /// <param name="id">id (required).</param>
        /// <param name="name">The schema name  This is set by the user and is for them to easily recognise their schema (required).</param>
        /// <param name="schema">The actual Identity JSON Schema.</param>
        public ClientIdentitySchema(string blobName = default(string), string blobUrl = default(string), string contentHash = default(string), string id = default(string), string name = default(string), Object schema = default(Object))
        {
            // to ensure "blobName" is required (not null)
            if (blobName == null) {
                throw new ArgumentNullException("blobName is a required property for ClientIdentitySchema and cannot be null");
            }
            this.BlobName = blobName;
            // to ensure "blobUrl" is required (not null)
            if (blobUrl == null) {
                throw new ArgumentNullException("blobUrl is a required property for ClientIdentitySchema and cannot be null");
            }
            this.BlobUrl = blobUrl;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ClientIdentitySchema and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ClientIdentitySchema and cannot be null");
            }
            this.Name = name;
            this.ContentHash = contentHash;
            this.Schema = schema;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The gcs file name  This is a randomly generated name which is used to uniquely identify the file on the blob storage
        /// </summary>
        /// <value>The gcs file name  This is a randomly generated name which is used to uniquely identify the file on the blob storage</value>
        [DataMember(Name = "blob_name", IsRequired = true, EmitDefaultValue = false)]
        public string BlobName { get; set; }

        /// <summary>
        /// The publicly accessible url of the schema
        /// </summary>
        /// <value>The publicly accessible url of the schema</value>
        [DataMember(Name = "blob_url", IsRequired = true, EmitDefaultValue = false)]
        public string BlobUrl { get; set; }

        /// <summary>
        /// The Content Hash  Contains a hash of the schema&#39;s content.
        /// </summary>
        /// <value>The Content Hash  Contains a hash of the schema&#39;s content.</value>
        [DataMember(Name = "content_hash", EmitDefaultValue = false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// The Schema&#39;s Creation Date
        /// </summary>
        /// <value>The Schema&#39;s Creation Date</value>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The schema name  This is set by the user and is for them to easily recognise their schema
        /// </summary>
        /// <value>The schema name  This is set by the user and is for them to easily recognise their schema</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The actual Identity JSON Schema
        /// </summary>
        /// <value>The actual Identity JSON Schema</value>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public Object Schema { get; set; }

        /// <summary>
        /// Last Time Schema was Updated
        /// </summary>
        /// <value>Last Time Schema was Updated</value>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = false)]
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
            sb.Append("class ClientIdentitySchema {\n");
            sb.Append("  BlobName: ").Append(BlobName).Append("\n");
            sb.Append("  BlobUrl: ").Append(BlobUrl).Append("\n");
            sb.Append("  ContentHash: ").Append(ContentHash).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientIdentitySchema);
        }

        /// <summary>
        /// Returns true if ClientIdentitySchema instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientIdentitySchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientIdentitySchema input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlobName == input.BlobName ||
                    (this.BlobName != null &&
                    this.BlobName.Equals(input.BlobName))
                ) && 
                (
                    this.BlobUrl == input.BlobUrl ||
                    (this.BlobUrl != null &&
                    this.BlobUrl.Equals(input.BlobUrl))
                ) && 
                (
                    this.ContentHash == input.ContentHash ||
                    (this.ContentHash != null &&
                    this.ContentHash.Equals(input.ContentHash))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BlobName != null)
                {
                    hashCode = (hashCode * 59) + this.BlobName.GetHashCode();
                }
                if (this.BlobUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BlobUrl.GetHashCode();
                }
                if (this.ContentHash != null)
                {
                    hashCode = (hashCode * 59) + this.ContentHash.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Schema != null)
                {
                    hashCode = (hashCode * 59) + this.Schema.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
