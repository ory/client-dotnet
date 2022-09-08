/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.36
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
    /// ClientSubjectSet
    /// </summary>
    [DataContract(Name = "subjectSet")]
    public partial class ClientSubjectSet : IEquatable<ClientSubjectSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubjectSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSubjectSet()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubjectSet" /> class.
        /// </summary>
        /// <param name="_namespace">Namespace of the Subject Set (required).</param>
        /// <param name="_object">Object of the Subject Set (required).</param>
        /// <param name="relation">Relation of the Subject Set (required).</param>
        public ClientSubjectSet(string _namespace = default(string), string _object = default(string), string relation = default(string))
        {
            // to ensure "_namespace" is required (not null)
            if (_namespace == null) {
                throw new ArgumentNullException("_namespace is a required property for ClientSubjectSet and cannot be null");
            }
            this.Namespace = _namespace;
            // to ensure "_object" is required (not null)
            if (_object == null) {
                throw new ArgumentNullException("_object is a required property for ClientSubjectSet and cannot be null");
            }
            this.Object = _object;
            // to ensure "relation" is required (not null)
            if (relation == null) {
                throw new ArgumentNullException("relation is a required property for ClientSubjectSet and cannot be null");
            }
            this.Relation = relation;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Namespace of the Subject Set
        /// </summary>
        /// <value>Namespace of the Subject Set</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Object of the Subject Set
        /// </summary>
        /// <value>Object of the Subject Set</value>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Relation of the Subject Set
        /// </summary>
        /// <value>Relation of the Subject Set</value>
        [DataMember(Name = "relation", IsRequired = true, EmitDefaultValue = false)]
        public string Relation { get; set; }

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
            sb.Append("class ClientSubjectSet {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Relation: ").Append(Relation).Append("\n");
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
            return this.Equals(input as ClientSubjectSet);
        }

        /// <summary>
        /// Returns true if ClientSubjectSet instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSubjectSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSubjectSet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.Relation == input.Relation ||
                    (this.Relation != null &&
                    this.Relation.Equals(input.Relation))
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
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.Relation != null)
                {
                    hashCode = (hashCode * 59) + this.Relation.GetHashCode();
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
