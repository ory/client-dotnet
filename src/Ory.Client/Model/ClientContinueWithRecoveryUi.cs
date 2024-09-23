/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.3
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
    /// Indicates, that the UI flow could be continued by showing a recovery ui
    /// </summary>
    [DataContract(Name = "continueWithRecoveryUi")]
    public partial class ClientContinueWithRecoveryUi : IValidatableObject
    {
        /// <summary>
        /// Action will always be &#x60;show_recovery_ui&#x60; show_recovery_ui ContinueWithActionShowRecoveryUIString
        /// </summary>
        /// <value>Action will always be &#x60;show_recovery_ui&#x60; show_recovery_ui ContinueWithActionShowRecoveryUIString</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum ShowRecoveryUi for value: show_recovery_ui
            /// </summary>
            [EnumMember(Value = "show_recovery_ui")]
            ShowRecoveryUi = 1
        }


        /// <summary>
        /// Action will always be &#x60;show_recovery_ui&#x60; show_recovery_ui ContinueWithActionShowRecoveryUIString
        /// </summary>
        /// <value>Action will always be &#x60;show_recovery_ui&#x60; show_recovery_ui ContinueWithActionShowRecoveryUIString</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWithRecoveryUi" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientContinueWithRecoveryUi()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWithRecoveryUi" /> class.
        /// </summary>
        /// <param name="action">Action will always be &#x60;show_recovery_ui&#x60; show_recovery_ui ContinueWithActionShowRecoveryUIString (required).</param>
        /// <param name="flow">flow (required).</param>
        public ClientContinueWithRecoveryUi(ActionEnum action = default(ActionEnum), ClientContinueWithRecoveryUiFlow flow = default(ClientContinueWithRecoveryUiFlow))
        {
            this.Action = action;
            // to ensure "flow" is required (not null)
            if (flow == null)
            {
                throw new ArgumentNullException("flow is a required property for ClientContinueWithRecoveryUi and cannot be null");
            }
            this.Flow = flow;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name = "flow", IsRequired = true, EmitDefaultValue = true)]
        public ClientContinueWithRecoveryUiFlow Flow { get; set; }

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
            sb.Append("class ClientContinueWithRecoveryUi {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
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
