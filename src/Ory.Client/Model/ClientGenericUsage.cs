/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.35
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
    /// ClientGenericUsage
    /// </summary>
    [DataContract(Name = "GenericUsage")]
    public partial class ClientGenericUsage : IEquatable<ClientGenericUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientGenericUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientGenericUsage()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientGenericUsage" /> class.
        /// </summary>
        /// <param name="additionalPrice">AdditionalPrice is the price per-unit exceeding IncludedUsage. A price of 0 means that no other items can be consumed. (required).</param>
        /// <param name="includedUsage">IncludedUsage is the number of included items. (required).</param>
        public ClientGenericUsage(long additionalPrice = default(long), long includedUsage = default(long))
        {
            this.AdditionalPrice = additionalPrice;
            this.IncludedUsage = includedUsage;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// AdditionalPrice is the price per-unit exceeding IncludedUsage. A price of 0 means that no other items can be consumed.
        /// </summary>
        /// <value>AdditionalPrice is the price per-unit exceeding IncludedUsage. A price of 0 means that no other items can be consumed.</value>
        [DataMember(Name = "additional_price", IsRequired = true, EmitDefaultValue = false)]
        public long AdditionalPrice { get; set; }

        /// <summary>
        /// IncludedUsage is the number of included items.
        /// </summary>
        /// <value>IncludedUsage is the number of included items.</value>
        [DataMember(Name = "included_usage", IsRequired = true, EmitDefaultValue = false)]
        public long IncludedUsage { get; set; }

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
            sb.Append("class ClientGenericUsage {\n");
            sb.Append("  AdditionalPrice: ").Append(AdditionalPrice).Append("\n");
            sb.Append("  IncludedUsage: ").Append(IncludedUsage).Append("\n");
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
            return this.Equals(input as ClientGenericUsage);
        }

        /// <summary>
        /// Returns true if ClientGenericUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientGenericUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientGenericUsage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalPrice == input.AdditionalPrice ||
                    this.AdditionalPrice.Equals(input.AdditionalPrice)
                ) && 
                (
                    this.IncludedUsage == input.IncludedUsage ||
                    this.IncludedUsage.Equals(input.IncludedUsage)
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
                hashCode = (hashCode * 59) + this.AdditionalPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludedUsage.GetHashCode();
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
