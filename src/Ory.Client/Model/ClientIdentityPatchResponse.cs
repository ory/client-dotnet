/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.6
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
    /// Response for a single identity patch
    /// </summary>
    [DataContract(Name = "identityPatchResponse")]
    public partial class ClientIdentityPatchResponse : IEquatable<ClientIdentityPatchResponse>, IValidatableObject
    {
        /// <summary>
        /// The action for this specific patch create ActionCreate  Create this identity.
        /// </summary>
        /// <value>The action for this specific patch create ActionCreate  Create this identity.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Create for value: create
            /// </summary>
            [EnumMember(Value = "create")]
            Create = 1

        }


        /// <summary>
        /// The action for this specific patch create ActionCreate  Create this identity.
        /// </summary>
        /// <value>The action for this specific patch create ActionCreate  Create this identity.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIdentityPatchResponse" /> class.
        /// </summary>
        /// <param name="action">The action for this specific patch create ActionCreate  Create this identity..</param>
        /// <param name="identity">The identity ID payload of this patch.</param>
        /// <param name="patchId">The ID of this patch response, if an ID was specified in the patch..</param>
        public ClientIdentityPatchResponse(ActionEnum? action = default(ActionEnum?), string identity = default(string), string patchId = default(string))
        {
            this.Action = action;
            this.Identity = identity;
            this.PatchId = patchId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The identity ID payload of this patch
        /// </summary>
        /// <value>The identity ID payload of this patch</value>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public string Identity { get; set; }

        /// <summary>
        /// The ID of this patch response, if an ID was specified in the patch.
        /// </summary>
        /// <value>The ID of this patch response, if an ID was specified in the patch.</value>
        [DataMember(Name = "patch_id", EmitDefaultValue = false)]
        public string PatchId { get; set; }

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
            sb.Append("class ClientIdentityPatchResponse {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  PatchId: ").Append(PatchId).Append("\n");
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
            return this.Equals(input as ClientIdentityPatchResponse);
        }

        /// <summary>
        /// Returns true if ClientIdentityPatchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientIdentityPatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientIdentityPatchResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.PatchId == input.PatchId ||
                    (this.PatchId != null &&
                    this.PatchId.Equals(input.PatchId))
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
                hashCode = (hashCode * 59) + this.Action.GetHashCode();
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }
                if (this.PatchId != null)
                {
                    hashCode = (hashCode * 59) + this.PatchId.GetHashCode();
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
