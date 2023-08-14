/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.46
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
    /// ClientInternalIsOwnerForProjectBySlugResponse
    /// </summary>
    [DataContract(Name = "internalIsOwnerForProjectBySlugResponse")]
    public partial class ClientInternalIsOwnerForProjectBySlugResponse : IEquatable<ClientInternalIsOwnerForProjectBySlugResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInternalIsOwnerForProjectBySlugResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientInternalIsOwnerForProjectBySlugResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInternalIsOwnerForProjectBySlugResponse" /> class.
        /// </summary>
        /// <param name="projectId">ProjectID is the project&#39;s ID. (required).</param>
        public ClientInternalIsOwnerForProjectBySlugResponse(string projectId = default(string))
        {
            // to ensure "projectId" is required (not null)
            if (projectId == null) {
                throw new ArgumentNullException("projectId is a required property for ClientInternalIsOwnerForProjectBySlugResponse and cannot be null");
            }
            this.ProjectId = projectId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// ProjectID is the project&#39;s ID.
        /// </summary>
        /// <value>ProjectID is the project&#39;s ID.</value>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectId { get; set; }

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
            sb.Append("class ClientInternalIsOwnerForProjectBySlugResponse {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
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
            return this.Equals(input as ClientInternalIsOwnerForProjectBySlugResponse);
        }

        /// <summary>
        /// Returns true if ClientInternalIsOwnerForProjectBySlugResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientInternalIsOwnerForProjectBySlugResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientInternalIsOwnerForProjectBySlugResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
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
