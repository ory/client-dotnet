/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.18
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
    /// PluginConfigUser plugin config user
    /// </summary>
    [DataContract(Name = "PluginConfigUser")]
    public partial class ClientPluginConfigUser : IEquatable<ClientPluginConfigUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPluginConfigUser" /> class.
        /// </summary>
        /// <param name="gID">g ID.</param>
        /// <param name="uID">UID.</param>
        public ClientPluginConfigUser(int gID = default(int), int uID = default(int))
        {
            this.GID = gID;
            this.UID = uID;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// g ID
        /// </summary>
        /// <value>g ID</value>
        [DataMember(Name = "GID", EmitDefaultValue = false)]
        public int GID { get; set; }

        /// <summary>
        /// UID
        /// </summary>
        /// <value>UID</value>
        [DataMember(Name = "UID", EmitDefaultValue = false)]
        public int UID { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class ClientPluginConfigUser {\n");
            sb.Append("  GID: ").Append(GID).Append("\n");
            sb.Append("  UID: ").Append(UID).Append("\n");
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
            return this.Equals(input as ClientPluginConfigUser);
        }

        /// <summary>
        /// Returns true if ClientPluginConfigUser instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientPluginConfigUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientPluginConfigUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GID == input.GID ||
                    this.GID.Equals(input.GID)
                ) && 
                (
                    this.UID == input.UID ||
                    this.UID.Equals(input.UID)
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
                hashCode = hashCode * 59 + this.GID.GetHashCode();
                hashCode = hashCode * 59 + this.UID.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
