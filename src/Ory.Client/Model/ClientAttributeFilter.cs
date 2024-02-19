/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.6.2
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
    /// ClientAttributeFilter
    /// </summary>
    [DataContract(Name = "AttributeFilter")]
    public partial class ClientAttributeFilter : IEquatable<ClientAttributeFilter>, IValidatableObject
    {
        /// <summary>
        /// Defines Condition
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConditionEnum
        {
            /// <summary>
            /// Enum Equals for value: equals
            /// </summary>
            [EnumMember(Value = "equals")]
            Equals = 1,

            /// <summary>
            /// Enum NotEquals for value: not_equals
            /// </summary>
            [EnumMember(Value = "not_equals")]
            NotEquals = 2,

            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 3,

            /// <summary>
            /// Enum NotContains for value: not_contains
            /// </summary>
            [EnumMember(Value = "not_contains")]
            NotContains = 4,

            /// <summary>
            /// Enum Regex for value: regex
            /// </summary>
            [EnumMember(Value = "regex")]
            Regex = 5,

            /// <summary>
            /// Enum NotRegex for value: not_regex
            /// </summary>
            [EnumMember(Value = "not_regex")]
            NotRegex = 6,

            /// <summary>
            /// Enum Set for value: set
            /// </summary>
            [EnumMember(Value = "set")]
            Set = 7,

            /// <summary>
            /// Enum NotSet for value: not_set
            /// </summary>
            [EnumMember(Value = "not_set")]
            NotSet = 8

        }


        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "condition", EmitDefaultValue = false)]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAttributeFilter" /> class.
        /// </summary>
        /// <param name="attribute">attribute.</param>
        /// <param name="condition">condition.</param>
        /// <param name="value">value.</param>
        public ClientAttributeFilter(string attribute = default(string), ConditionEnum? condition = default(ConditionEnum?), string value = default(string))
        {
            this.Attribute = attribute;
            this.Condition = condition;
            this.Value = value;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Attribute
        /// </summary>
        [DataMember(Name = "attribute", EmitDefaultValue = false)]
        public string Attribute { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

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
            sb.Append("class ClientAttributeFilter {\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ClientAttributeFilter);
        }

        /// <summary>
        /// Returns true if ClientAttributeFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAttributeFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAttributeFilter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attribute == input.Attribute ||
                    (this.Attribute != null &&
                    this.Attribute.Equals(input.Attribute))
                ) && 
                (
                    this.Condition == input.Condition ||
                    this.Condition.Equals(input.Condition)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Attribute != null)
                {
                    hashCode = (hashCode * 59) + this.Attribute.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Condition.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
