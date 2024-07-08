/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.13.10
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
    /// VerifiableAddress is an identity&#39;s verifiable address
    /// </summary>
    [DataContract(Name = "verifiableIdentityAddress")]
    public partial class ClientVerifiableIdentityAddress : IValidatableObject
    {
        /// <summary>
        /// The delivery method
        /// </summary>
        /// <value>The delivery method</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViaEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 2
        }


        /// <summary>
        /// The delivery method
        /// </summary>
        /// <value>The delivery method</value>
        /// <example>email</example>
        [DataMember(Name = "via", IsRequired = true, EmitDefaultValue = true)]
        public ViaEnum Via { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientVerifiableIdentityAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientVerifiableIdentityAddress()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientVerifiableIdentityAddress" /> class.
        /// </summary>
        /// <param name="createdAt">When this entry was created.</param>
        /// <param name="id">The ID.</param>
        /// <param name="status">VerifiableAddressStatus must not exceed 16 characters as that is the limitation in the SQL Schema (required).</param>
        /// <param name="updatedAt">When this entry was last updated.</param>
        /// <param name="value">The address value  example foo@user.com (required).</param>
        /// <param name="verified">Indicates if the address has already been verified (required).</param>
        /// <param name="verifiedAt">verifiedAt.</param>
        /// <param name="via">The delivery method (required).</param>
        public ClientVerifiableIdentityAddress(DateTime createdAt = default(DateTime), string id = default(string), string status = default(string), DateTime updatedAt = default(DateTime), string value = default(string), bool verified = default(bool), DateTime verifiedAt = default(DateTime), ViaEnum via = default(ViaEnum))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for ClientVerifiableIdentityAddress and cannot be null");
            }
            this.Status = status;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ClientVerifiableIdentityAddress and cannot be null");
            }
            this.Value = value;
            this.Verified = verified;
            this.Via = via;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.UpdatedAt = updatedAt;
            this.VerifiedAt = verifiedAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// When this entry was created
        /// </summary>
        /// <value>When this entry was created</value>
        /// <example>2014-01-01T23:28:56.782Z</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ID
        /// </summary>
        /// <value>The ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// VerifiableAddressStatus must not exceed 16 characters as that is the limitation in the SQL Schema
        /// </summary>
        /// <value>VerifiableAddressStatus must not exceed 16 characters as that is the limitation in the SQL Schema</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// When this entry was last updated
        /// </summary>
        /// <value>When this entry was last updated</value>
        /// <example>2014-01-01T23:28:56.782Z</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The address value  example foo@user.com
        /// </summary>
        /// <value>The address value  example foo@user.com</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Indicates if the address has already been verified
        /// </summary>
        /// <value>Indicates if the address has already been verified</value>
        /// <example>true</example>
        [DataMember(Name = "verified", IsRequired = true, EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedAt
        /// </summary>
        [DataMember(Name = "verified_at", EmitDefaultValue = false)]
        public DateTime VerifiedAt { get; set; }

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
            sb.Append("class ClientVerifiableIdentityAddress {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  VerifiedAt: ").Append(VerifiedAt).Append("\n");
            sb.Append("  Via: ").Append(Via).Append("\n");
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
