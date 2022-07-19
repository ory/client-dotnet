/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.1.0-alpha.2
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
    /// ClientProvisionMockSubscriptionPayload
    /// </summary>
    [DataContract(Name = "provisionMockSubscriptionPayload")]
    public partial class ClientProvisionMockSubscriptionPayload : IEquatable<ClientProvisionMockSubscriptionPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProvisionMockSubscriptionPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientProvisionMockSubscriptionPayload()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProvisionMockSubscriptionPayload" /> class.
        /// </summary>
        /// <param name="identityId">identityId (required).</param>
        /// <param name="planOrPrice">planOrPrice (required).</param>
        public ClientProvisionMockSubscriptionPayload(string identityId = default(string), string planOrPrice = default(string))
        {
            // to ensure "identityId" is required (not null)
            if (identityId == null) {
                throw new ArgumentNullException("identityId is a required property for ClientProvisionMockSubscriptionPayload and cannot be null");
            }
            this.IdentityId = identityId;
            // to ensure "planOrPrice" is required (not null)
            if (planOrPrice == null) {
                throw new ArgumentNullException("planOrPrice is a required property for ClientProvisionMockSubscriptionPayload and cannot be null");
            }
            this.PlanOrPrice = planOrPrice;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets IdentityId
        /// </summary>
        [DataMember(Name = "identity_id", IsRequired = true, EmitDefaultValue = false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// Gets or Sets PlanOrPrice
        /// </summary>
        [DataMember(Name = "plan_or_price", IsRequired = true, EmitDefaultValue = false)]
        public string PlanOrPrice { get; set; }

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
            sb.Append("class ClientProvisionMockSubscriptionPayload {\n");
            sb.Append("  IdentityId: ").Append(IdentityId).Append("\n");
            sb.Append("  PlanOrPrice: ").Append(PlanOrPrice).Append("\n");
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
            return this.Equals(input as ClientProvisionMockSubscriptionPayload);
        }

        /// <summary>
        /// Returns true if ClientProvisionMockSubscriptionPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientProvisionMockSubscriptionPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientProvisionMockSubscriptionPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IdentityId == input.IdentityId ||
                    (this.IdentityId != null &&
                    this.IdentityId.Equals(input.IdentityId))
                ) && 
                (
                    this.PlanOrPrice == input.PlanOrPrice ||
                    (this.PlanOrPrice != null &&
                    this.PlanOrPrice.Equals(input.PlanOrPrice))
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
                if (this.IdentityId != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityId.GetHashCode();
                }
                if (this.PlanOrPrice != null)
                {
                    hashCode = (hashCode * 59) + this.PlanOrPrice.GetHashCode();
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
