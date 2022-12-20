/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.3
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
    public partial class ClientSuccessfulProjectUpdate : IEquatable<ClientSuccessfulProjectUpdate>, IValidatableObject
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
            if (project == null) {
                throw new ArgumentNullException("project is a required property for ClientSuccessfulProjectUpdate and cannot be null");
            }
            this.Project = project;
            // to ensure "warnings" is required (not null)
            if (warnings == null) {
                throw new ArgumentNullException("warnings is a required property for ClientSuccessfulProjectUpdate and cannot be null");
            }
            this.Warnings = warnings;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", IsRequired = true, EmitDefaultValue = false)]
        public ClientProject Project { get; set; }

        /// <summary>
        /// Import Warnings  Not all configuration items can be imported to the Ory Network. For example, setting the port does not make sense because the Ory Network provides the runtime and networking.  This field contains warnings where configuration keys were found but can not be imported. These keys will be ignored by the Ory Network. This field will help you understand why certain configuration keys might not be respected!
        /// </summary>
        /// <value>Import Warnings  Not all configuration items can be imported to the Ory Network. For example, setting the port does not make sense because the Ory Network provides the runtime and networking.  This field contains warnings where configuration keys were found but can not be imported. These keys will be ignored by the Ory Network. This field will help you understand why certain configuration keys might not be respected!</value>
        [DataMember(Name = "warnings", IsRequired = true, EmitDefaultValue = false)]
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientSuccessfulProjectUpdate);
        }

        /// <summary>
        /// Returns true if ClientSuccessfulProjectUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSuccessfulProjectUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSuccessfulProjectUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Project != null)
                {
                    hashCode = (hashCode * 59) + this.Project.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
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
