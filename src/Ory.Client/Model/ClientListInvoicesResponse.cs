/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.13.6
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
    /// ClientListInvoicesResponse
    /// </summary>
    [DataContract(Name = "listInvoicesResponse")]
    public partial class ClientListInvoicesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientListInvoicesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientListInvoicesResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientListInvoicesResponse" /> class.
        /// </summary>
        /// <param name="buckets">buckets (required).</param>
        /// <param name="hasNextPage">hasNextPage (required).</param>
        /// <param name="nextPageToken">nextPageToken (required).</param>
        public ClientListInvoicesResponse(List<ClientBillingPeriodBucket> buckets = default(List<ClientBillingPeriodBucket>), bool hasNextPage = default(bool), string nextPageToken = default(string))
        {
            // to ensure "buckets" is required (not null)
            if (buckets == null)
            {
                throw new ArgumentNullException("buckets is a required property for ClientListInvoicesResponse and cannot be null");
            }
            this.Buckets = buckets;
            this.HasNextPage = hasNextPage;
            // to ensure "nextPageToken" is required (not null)
            if (nextPageToken == null)
            {
                throw new ArgumentNullException("nextPageToken is a required property for ClientListInvoicesResponse and cannot be null");
            }
            this.NextPageToken = nextPageToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Buckets
        /// </summary>
        [DataMember(Name = "buckets", IsRequired = true, EmitDefaultValue = true)]
        public List<ClientBillingPeriodBucket> Buckets { get; set; }

        /// <summary>
        /// Gets or Sets HasNextPage
        /// </summary>
        [DataMember(Name = "has_next_page", IsRequired = true, EmitDefaultValue = true)]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// Gets or Sets NextPageToken
        /// </summary>
        [DataMember(Name = "next_page_token", IsRequired = true, EmitDefaultValue = true)]
        public string NextPageToken { get; set; }

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
            sb.Append("class ClientListInvoicesResponse {\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
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
