/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.2
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
    /// ClientNormalizedProjectRevisionTokenizerTemplate
    /// </summary>
    [DataContract(Name = "normalizedProjectRevisionTokenizerTemplate")]
    public partial class ClientNormalizedProjectRevisionTokenizerTemplate : IEquatable<ClientNormalizedProjectRevisionTokenizerTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProjectRevisionTokenizerTemplate" /> class.
        /// </summary>
        /// <param name="claimsMapperUrl">Claims mapper URL.</param>
        /// <param name="jwksUrl">JSON Web Key URL.</param>
        /// <param name="key">The unique key of the template.</param>
        /// <param name="projectRevisionId">The Revision&#39;s ID this schema belongs to.</param>
        /// <param name="ttl">Token time to live (default to &quot;1m&quot;).</param>
        public ClientNormalizedProjectRevisionTokenizerTemplate(string claimsMapperUrl = default(string), string jwksUrl = default(string), string key = default(string), string projectRevisionId = default(string), string ttl = "1m")
        {
            this.ClaimsMapperUrl = claimsMapperUrl;
            this.JwksUrl = jwksUrl;
            this.Key = key;
            this.ProjectRevisionId = projectRevisionId;
            // use default value if no "ttl" provided
            this.Ttl = ttl ?? "1m";
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Claims mapper URL
        /// </summary>
        /// <value>Claims mapper URL</value>
        [DataMember(Name = "claims_mapper_url", EmitDefaultValue = false)]
        public string ClaimsMapperUrl { get; set; }

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
        /// The revision ID.
        /// </summary>
        /// <value>The revision ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// JSON Web Key URL
        /// </summary>
        /// <value>JSON Web Key URL</value>
        [DataMember(Name = "jwks_url", EmitDefaultValue = false)]
        public string JwksUrl { get; set; }

        /// <summary>
        /// The unique key of the template
        /// </summary>
        /// <value>The unique key of the template</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// The Revision&#39;s ID this schema belongs to
        /// </summary>
        /// <value>The Revision&#39;s ID this schema belongs to</value>
        [DataMember(Name = "project_revision_id", EmitDefaultValue = false)]
        public string ProjectRevisionId { get; set; }

        /// <summary>
        /// Token time to live
        /// </summary>
        /// <value>Token time to live</value>
        [DataMember(Name = "ttl", EmitDefaultValue = false)]
        public string Ttl { get; set; }

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
            sb.Append("class ClientNormalizedProjectRevisionTokenizerTemplate {\n");
            sb.Append("  ClaimsMapperUrl: ").Append(ClaimsMapperUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  JwksUrl: ").Append(JwksUrl).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  ProjectRevisionId: ").Append(ProjectRevisionId).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as ClientNormalizedProjectRevisionTokenizerTemplate);
        }

        /// <summary>
        /// Returns true if ClientNormalizedProjectRevisionTokenizerTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientNormalizedProjectRevisionTokenizerTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientNormalizedProjectRevisionTokenizerTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClaimsMapperUrl == input.ClaimsMapperUrl ||
                    (this.ClaimsMapperUrl != null &&
                    this.ClaimsMapperUrl.Equals(input.ClaimsMapperUrl))
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
                    this.JwksUrl == input.JwksUrl ||
                    (this.JwksUrl != null &&
                    this.JwksUrl.Equals(input.JwksUrl))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.ProjectRevisionId == input.ProjectRevisionId ||
                    (this.ProjectRevisionId != null &&
                    this.ProjectRevisionId.Equals(input.ProjectRevisionId))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))
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
                if (this.ClaimsMapperUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ClaimsMapperUrl.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.JwksUrl != null)
                {
                    hashCode = (hashCode * 59) + this.JwksUrl.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.ProjectRevisionId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectRevisionId.GetHashCode();
                }
                if (this.Ttl != null)
                {
                    hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
            // Ttl (string) pattern
            Regex regexTtl = new Regex(@"^[0-9]+(ns|us|ms|s|m|h)$", RegexOptions.CultureInvariant);
            if (false == regexTtl.Match(this.Ttl).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ttl, must match a pattern of " + regexTtl, new [] { "Ttl" });
            }

            yield break;
        }
    }

}
