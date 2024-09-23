/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.3
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
    public partial class ClientSubjectSet : IValidatableObject
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
        /// <param name="varNamespace">Namespace of the Subject Set (required).</param>
        /// <param name="varObject">Object of the Subject Set (required).</param>
        /// <param name="relation">Relation of the Subject Set (required).</param>
        public ClientSubjectSet(string varNamespace = default(string), string varObject = default(string), string relation = default(string))
        {
            // to ensure "varNamespace" is required (not null)
            if (varNamespace == null)
            {
                throw new ArgumentNullException("varNamespace is a required property for ClientSubjectSet and cannot be null");
            }
            this.Namespace = varNamespace;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for ClientSubjectSet and cannot be null");
            }
            this.Object = varObject;
            // to ensure "relation" is required (not null)
            if (relation == null)
            {
                throw new ArgumentNullException("relation is a required property for ClientSubjectSet and cannot be null");
            }
            this.Relation = relation;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Namespace of the Subject Set
        /// </summary>
        /// <value>Namespace of the Subject Set</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Object of the Subject Set
        /// </summary>
        /// <value>Object of the Subject Set</value>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Relation of the Subject Set
        /// </summary>
        /// <value>Relation of the Subject Set</value>
        [DataMember(Name = "relation", IsRequired = true, EmitDefaultValue = true)]
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
