/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.130
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
    /// ClientPagination
    /// </summary>
    [DataContract(Name = "pagination")]
    public partial class ClientPagination : IEquatable<ClientPagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPagination" /> class.
        /// </summary>
        /// <param name="page">Pagination Page (default to 1).</param>
        /// <param name="perPage">Items per Page  This is the number of items per page. (default to 250).</param>
        public ClientPagination(long page = 1, long perPage = 250)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Pagination Page
        /// </summary>
        /// <value>Pagination Page</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public long Page { get; set; }

        /// <summary>
        /// Items per Page  This is the number of items per page.
        /// </summary>
        /// <value>Items per Page  This is the number of items per page.</value>
        [DataMember(Name = "per_page", EmitDefaultValue = false)]
        public long PerPage { get; set; }

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
            sb.Append("class ClientPagination {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
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
            return this.Equals(input as ClientPagination);
        }

        /// <summary>
        /// Returns true if ClientPagination instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientPagination input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    this.PerPage.Equals(input.PerPage)
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
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.PerPage.GetHashCode();
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
            // Page (long) minimum
            if (this.Page < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Page, must be a value greater than or equal to 1.", new [] { "Page" });
            }

            // PerPage (long) maximum
            if (this.PerPage > (long)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerPage, must be a value less than or equal to 1000.", new [] { "PerPage" });
            }

            // PerPage (long) minimum
            if (this.PerPage < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerPage, must be a value greater than or equal to 1.", new [] { "PerPage" });
            }

            yield break;
        }
    }

}
