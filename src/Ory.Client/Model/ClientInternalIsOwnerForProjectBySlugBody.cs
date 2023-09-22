/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.2.9
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
    /// Is Owner For Project By Slug Request Body
    /// </summary>
    [DataContract(Name = "internalIsOwnerForProjectBySlugBody")]
    public partial class ClientInternalIsOwnerForProjectBySlugBody : IEquatable<ClientInternalIsOwnerForProjectBySlugBody>, IValidatableObject
    {
        /// <summary>
        /// Namespace is the namespace of the subject.
        /// </summary>
        /// <value>Namespace is the namespace of the subject.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NamespaceEnum
        {
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,

            /// <summary>
            /// Enum ApiKey for value:  ApiKey
            /// </summary>
            [EnumMember(Value = " ApiKey")]
            ApiKey = 2

        }


        /// <summary>
        /// Namespace is the namespace of the subject.
        /// </summary>
        /// <value>Namespace is the namespace of the subject.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = false)]
        public NamespaceEnum Namespace { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInternalIsOwnerForProjectBySlugBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientInternalIsOwnerForProjectBySlugBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInternalIsOwnerForProjectBySlugBody" /> class.
        /// </summary>
        /// <param name="_namespace">Namespace is the namespace of the subject. (required).</param>
        /// <param name="projectScope">ProjectScope is the project_id resolved from the API Token..</param>
        /// <param name="projectSlug">ProjectSlug is the project&#39;s slug. (required).</param>
        /// <param name="subject">Subject is the subject acting (user or API key). (required).</param>
        public ClientInternalIsOwnerForProjectBySlugBody(NamespaceEnum _namespace = default(NamespaceEnum), string projectScope = default(string), string projectSlug = default(string), string subject = default(string))
        {
            this.Namespace = _namespace;
            // to ensure "projectSlug" is required (not null)
            if (projectSlug == null) {
                throw new ArgumentNullException("projectSlug is a required property for ClientInternalIsOwnerForProjectBySlugBody and cannot be null");
            }
            this.ProjectSlug = projectSlug;
            // to ensure "subject" is required (not null)
            if (subject == null) {
                throw new ArgumentNullException("subject is a required property for ClientInternalIsOwnerForProjectBySlugBody and cannot be null");
            }
            this.Subject = subject;
            this.ProjectScope = projectScope;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// ProjectScope is the project_id resolved from the API Token.
        /// </summary>
        /// <value>ProjectScope is the project_id resolved from the API Token.</value>
        [DataMember(Name = "project_scope", EmitDefaultValue = false)]
        public string ProjectScope { get; set; }

        /// <summary>
        /// ProjectSlug is the project&#39;s slug.
        /// </summary>
        /// <value>ProjectSlug is the project&#39;s slug.</value>
        [DataMember(Name = "project_slug", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectSlug { get; set; }

        /// <summary>
        /// Subject is the subject acting (user or API key).
        /// </summary>
        /// <value>Subject is the subject acting (user or API key).</value>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

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
            sb.Append("class ClientInternalIsOwnerForProjectBySlugBody {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ProjectScope: ").Append(ProjectScope).Append("\n");
            sb.Append("  ProjectSlug: ").Append(ProjectSlug).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as ClientInternalIsOwnerForProjectBySlugBody);
        }

        /// <summary>
        /// Returns true if ClientInternalIsOwnerForProjectBySlugBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientInternalIsOwnerForProjectBySlugBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientInternalIsOwnerForProjectBySlugBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Namespace == input.Namespace ||
                    this.Namespace.Equals(input.Namespace)
                ) && 
                (
                    this.ProjectScope == input.ProjectScope ||
                    (this.ProjectScope != null &&
                    this.ProjectScope.Equals(input.ProjectScope))
                ) && 
                (
                    this.ProjectSlug == input.ProjectSlug ||
                    (this.ProjectSlug != null &&
                    this.ProjectSlug.Equals(input.ProjectSlug))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                if (this.ProjectScope != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectScope.GetHashCode();
                }
                if (this.ProjectSlug != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectSlug.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
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
