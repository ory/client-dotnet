/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.6
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
    /// An Identity JSON Schema Container
    /// </summary>
    [DataContract(Name = "identitySchemaContainer")]
    public partial class ClientIdentitySchemaContainer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentitySchemaContainer" /> class.
        /// </summary>
        /// <param name="id">The ID of the Identity JSON Schema.</param>
        /// <param name="schema">The actual Identity JSON Schema.</param>
        public ClientIdentitySchemaContainer(string id = default(string), Object schema = default(Object))
        {
            this.Id = id;
            this.Schema = schema;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The ID of the Identity JSON Schema
        /// </summary>
        /// <value>The ID of the Identity JSON Schema</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The actual Identity JSON Schema
        /// </summary>
        /// <value>The actual Identity JSON Schema</value>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public Object Schema { get; set; }

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
            sb.Append("class ClientIdentitySchemaContainer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
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
