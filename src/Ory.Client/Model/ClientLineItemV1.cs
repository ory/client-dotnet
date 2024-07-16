/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.14.0
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
    /// ClientLineItemV1
    /// </summary>
    [DataContract(Name = "LineItemV1")]
    public partial class ClientLineItemV1 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientLineItemV1" /> class.
        /// </summary>
        /// <param name="amountInCent">amountInCent.</param>
        /// <param name="description">description.</param>
        /// <param name="items">Each line item can have sub-items to create a hierarchy..</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="title">title.</param>
        /// <param name="unitPrice">unitPrice.</param>
        public ClientLineItemV1(long amountInCent = default(long), string description = default(string), List<ClientLineItemV1> items = default(List<ClientLineItemV1>), long quantity = default(long), string title = default(string), string unitPrice = default(string))
        {
            this.AmountInCent = amountInCent;
            this.Description = description;
            this.Items = items;
            this.Quantity = quantity;
            this.Title = title;
            this.UnitPrice = unitPrice;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets AmountInCent
        /// </summary>
        [DataMember(Name = "amount_in_cent", EmitDefaultValue = false)]
        public long AmountInCent { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Each line item can have sub-items to create a hierarchy.
        /// </summary>
        /// <value>Each line item can have sub-items to create a hierarchy.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<ClientLineItemV1> Items { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public long Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name = "unit_price", EmitDefaultValue = false)]
        public string UnitPrice { get; set; }

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
            sb.Append("class ClientLineItemV1 {\n");
            sb.Append("  AmountInCent: ").Append(AmountInCent).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
